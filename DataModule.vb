Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Module DataModule
    ' Mengatur ListView agar membentuk baris-baris (Group) berdasarkan Tier
    Public Sub LoadDataSatuLane(namaLane As String, lv As ListView, imageListHero As ImageList)
        Try
            ConnectionModule.OpenConnection()
            lv.Items.Clear()
            lv.LargeImageList = imageListHero

            ' Setup Tampilan Tabel per Tier (ListView Group)
            lv.Groups.Clear()
            lv.Groups.Add(New ListViewGroup("S", "TIER S"))
            lv.Groups.Add(New ListViewGroup("A", "TIER A"))
            lv.Groups.Add(New ListViewGroup("B", "TIER B"))
            lv.Groups.Add(New ListViewGroup("C", "TIER C"))
            lv.ShowGroups = True

            Dim query As String = "SELECT h.id_hero, h.nama_hero, h.gambar, t.grade_tier " &
                                 "FROM tb_hero h JOIN tb_tierlist t ON h.id_hero = t.id_hero " &
                                 "WHERE t.lane = @lane ORDER BY t.grade_tier ASC"
            Dim cmd = ConnectionModule.CreateCommand(query)
            cmd.Parameters.AddWithValue("@lane", namaLane)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim id = dr("id_hero").ToString()
                Dim nama = dr("nama_hero").ToString()
                Dim imgName = dr("gambar").ToString()
                Dim tier = dr("grade_tier").ToString()
                Dim pathImg = Path.Combine(Application.StartupPath, "Images", imgName)

                If Not imageListHero.Images.ContainsKey(id) Then
                    If File.Exists(pathImg) Then
                        imageListHero.Images.Add(id, Image.FromFile(pathImg))
                    Else
                        imageListHero.Images.Add(id, New Bitmap(80, 80)) ' Jika gambar tidak ada
                    End If
                End If

                Dim item As New ListViewItem(nama, id) ' Tampilkan gambar dan nama hero
                item.Tag = id

                ' Masukkan hero ke dalam baris Tier yang sesuai
                For Each grp As ListViewGroup In lv.Groups
                    If grp.Name = tier Then
                        item.Group = grp
                        Exit For
                    End If
                Next

                lv.Items.Add(item)
            End While
            dr.Close()
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Sub

    Public Function GetAllHero() As DataTable
        Dim dt As New DataTable()
        Try
            ConnectionModule.OpenConnection()
            Dim query = "SELECT h.id_hero, h.nama_hero, h.role, t.lane, t.grade_tier, h.deskripsi FROM tb_hero h JOIN tb_tierlist t ON h.id_hero = t.id_hero"
            Dim cmd = ConnectionModule.CreateCommand(query)
            Dim adp As New MySqlDataAdapter(cmd)
            adp.Fill(dt)
        Finally
            ConnectionModule.CloseConnection()
        End Try
        Return dt
    End Function

    Public Function GetDetailHero(id As Integer) As (Nama As String, Role As String, Deskripsi As String)
        Dim hasil = ("", "", "")
        Try
            ConnectionModule.OpenConnection()
            Dim cmd = ConnectionModule.CreateCommand("SELECT * FROM tb_hero WHERE id_hero=@id")
            cmd.Parameters.AddWithValue("@id", id)
            Dim dr = cmd.ExecuteReader()
            If dr.Read() Then
                hasil = (dr("nama_hero").ToString(), dr("role").ToString(), dr("deskripsi").ToString())
            End If
            dr.Close()
        Finally
            ConnectionModule.CloseConnection()
        End Try
        Return hasil
    End Function

    Public Function TambahHero(nama As String, lane As String, tier As String, role As String, deskripsi As String, gambar As String) As Boolean
        Try
            ConnectionModule.OpenConnection()
            ' Insert ke tb_hero
            Dim qHero = "INSERT INTO tb_hero (nama_hero, role, deskripsi, gambar) VALUES (@nama, @role, @desc, @img); SELECT LAST_INSERT_ID();"
            Dim cmdH = ConnectionModule.CreateCommand(qHero)
            cmdH.Parameters.AddWithValue("@nama", nama)
            cmdH.Parameters.AddWithValue("@role", role)
            cmdH.Parameters.AddWithValue("@desc", deskripsi)
            cmdH.Parameters.AddWithValue("@img", gambar)

            Dim newId = Convert.ToInt32(cmdH.ExecuteScalar())

            ' Insert ke tb_tierlist
            Dim qTier = "INSERT INTO tb_tierlist (id_hero, lane, grade_tier) VALUES (@id, @lane, @tier)"
            Dim cmdT = ConnectionModule.CreateCommand(qTier)
            cmdT.Parameters.AddWithValue("@id", newId)
            cmdT.Parameters.AddWithValue("@lane", lane)
            cmdT.Parameters.AddWithValue("@tier", tier)
            cmdT.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function

    Public Function HapusHero(id As Integer) As Boolean
        Try
            ConnectionModule.OpenConnection()
            ' Karena di SQL pakai ON DELETE CASCADE, cukup hapus data di tb_hero saja. Tierlist otomatis terhapus.
            Dim cmd = ConnectionModule.CreateCommand("DELETE FROM tb_hero WHERE id_hero=@id")
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
            Return True
        Catch
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function

    Public Function UpdateHero(id As Integer, nama As String, lane As String, tier As String, role As String, deskripsi As String, gambar As String) As Boolean
        Try
            ConnectionModule.OpenConnection()
            ' Update tabel tb_hero
            Dim qHero = "UPDATE tb_hero SET nama_hero=@nama, role=@role, deskripsi=@desc, gambar=@img WHERE id_hero=@id"
            Dim cmdH = ConnectionModule.CreateCommand(qHero)
            cmdH.Parameters.AddWithValue("@nama", nama)
            cmdH.Parameters.AddWithValue("@role", role)
            cmdH.Parameters.AddWithValue("@desc", deskripsi)
            cmdH.Parameters.AddWithValue("@img", gambar)
            cmdH.Parameters.AddWithValue("@id", id)
            cmdH.ExecuteNonQuery()

            ' Update tabel tb_tierlist
            Dim qTier = "UPDATE tb_tierlist SET lane=@lane, grade_tier=@tier WHERE id_hero=@id"
            Dim cmdT = ConnectionModule.CreateCommand(qTier)
            cmdT.Parameters.AddWithValue("@lane", lane)
            cmdT.Parameters.AddWithValue("@tier", tier)
            cmdT.Parameters.AddWithValue("@id", id)
            cmdT.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            MsgBox("Gagal Update: " & ex.Message)
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function

End Module