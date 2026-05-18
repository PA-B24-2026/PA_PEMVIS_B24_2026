Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module DataModule
    Public connectionString As String = "Server=localhost;Database=dbml;Uid=root;Pwd=;"
    Public conn As New MySqlConnection(connectionString)

    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Public Function CreateCommand(query As String) As MySqlCommand
        Return New MySqlCommand(query, conn)
    End Function

    ' --- FUNGSI TAMBAH HERO ---
    Public Function TambahDataHero(nama As String, role As String, deskripsi As String, gambar As String) As Integer
        Try
            OpenConnection()
            Dim qHero = "INSERT INTO tb_hero (nama_hero, role, deskripsi, gambar) VALUES (@nama, @role, @desc, @img); SELECT LAST_INSERT_ID();"
            Dim cmdH = CreateCommand(qHero)
            cmdH.Parameters.AddWithValue("@nama", nama)
            cmdH.Parameters.AddWithValue("@role", role)
            cmdH.Parameters.AddWithValue("@desc", deskripsi)
            cmdH.Parameters.AddWithValue("@img", gambar)
            Return Convert.ToInt32(cmdH.ExecuteScalar())
        Catch ex As Exception
            MsgBox("Error Insert Hero: " & ex.Message, MsgBoxStyle.Critical)
            Return -1
        Finally
            CloseConnection()
        End Try
    End Function

    ' --- FUNGSI TAMBAH TIER LIST ---
    Public Function TambahDataTierList(id_hero As Integer, lane As String, tier As String) As Boolean
        Try
            OpenConnection()
            Dim qTier = "INSERT INTO tb_tierlist (id_hero, lane, grade_tier) VALUES (@id, @lane, @tier)"
            Dim cmdT = CreateCommand(qTier)
            cmdT.Parameters.AddWithValue("@id", id_hero)
            cmdT.Parameters.AddWithValue("@lane", lane)
            cmdT.Parameters.AddWithValue("@tier", tier)
            cmdT.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error Insert Tier: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' --- FUNGSI UPDATE HERO & TIER LIST ---
    Public Function UpdateHero(id As Integer, nama As String, lane As String, tier As String, role As String, deskripsi As String, gambar As String) As Boolean
        Try
            OpenConnection()
            Dim qUpdate = "UPDATE tb_hero SET nama_hero=@nama, role=@role, deskripsi=@desc, gambar=@img WHERE id_hero=@id"
            Dim cmd = CreateCommand(qUpdate)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@role", role)
            cmd.Parameters.AddWithValue("@desc", deskripsi)
            cmd.Parameters.AddWithValue("@img", gambar)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()

            Dim qUpdateTier = "UPDATE tb_tierlist SET lane=@lane, grade_tier=@tier WHERE id_hero=@id"
            Dim cmdT = CreateCommand(qUpdateTier)
            cmdT.Parameters.AddWithValue("@lane", lane)
            cmdT.Parameters.AddWithValue("@tier", tier)
            cmdT.Parameters.AddWithValue("@id", id)
            cmdT.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error Update: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' --- FUNGSI HAPUS HERO & RELASI TIER LIST ---
    Public Function HapusHero(id As Integer) As Boolean
        Try
            OpenConnection()
            Dim qHapus = "DELETE FROM tb_hero WHERE id_hero=@id"
            Dim cmd = CreateCommand(qHapus)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("Error Hapus: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    ' --- MENGAMBIL DATA GABUNGAN UNTUK DATAGRIDVIEW ---
    Public Function GetAllHero() As DataTable
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Dim query = "SELECT t.id_tier, h.id_hero, h.nama_hero, h.role, h.deskripsi, h.gambar, t.lane, t.grade_tier " &
                        "FROM tb_tierlist t " &
                        "INNER JOIN tb_hero h ON t.id_hero = h.id_hero"
            Dim adapter As New MySqlDataAdapter(query, conn)
            adapter.Fill(dt)
        Catch ex As Exception
            MsgBox("Error Load Data Tier: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function

    ' --- MEMUAT DATA KE LISTVIEW TIER LIST ---
    Public Sub LoadDataSatuLane(lane As String, lv As ListView, imgList As ImageList)
        Try
            OpenConnection()
            Dim query = "SELECT h.id_hero, h.nama_hero, h.gambar, t.grade_tier FROM tb_hero h JOIN tb_tierlist t ON h.id_hero = t.id_hero WHERE t.lane = @lane"
            Dim cmd = CreateCommand(query)
            cmd.Parameters.AddWithValue("@lane", lane)
            Dim reader = cmd.ExecuteReader()

            While reader.Read()
                Dim id = reader("id_hero").ToString()
                Dim nama = reader("nama_hero").ToString()
                Dim gambar = reader("gambar").ToString()
                Dim tier = reader("grade_tier").ToString()

                Dim imgPath = Path.Combine(Application.StartupPath, "Images", gambar)
                If File.Exists(imgPath) Then
                    If Not imgList.Images.ContainsKey(id) Then
                        imgList.Images.Add(id, Image.FromFile(imgPath))
                    End If
                End If

                Dim lvi As New ListViewItem(nama)
                lvi.ImageKey = id
                lvi.Tag = id

                For Each group As ListViewGroup In lv.Groups
                    If group.Header = "Tier " & tier Or group.Name = tier Then
                        lvi.Group = group
                        Exit For
                    End If
                Next
                lv.Items.Add(lvi)
            End While
            reader.Close()
        Catch ex As Exception
            MsgBox("Error Load Lane: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Function GetDetailHero(id As Integer) As (Nama As String, Role As String, Deskripsi As String)
        Dim res = ("", "", "")
        Try
            OpenConnection()
            Dim cmd = CreateCommand("SELECT nama_hero, role, deskripsi FROM tb_hero WHERE id_hero=@id")
            cmd.Parameters.AddWithValue("@id", id)
            Dim r = cmd.ExecuteReader()
            If r.Read() Then
                res = (r("nama_hero").ToString(), r("role").ToString(), r("deskripsi").ToString())
            End If
            r.Close()
        Catch ex As Exception
        Finally
            CloseConnection()
        End Try
        Return res
    End Function
End Module