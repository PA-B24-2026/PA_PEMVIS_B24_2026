Imports System.IO
Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Module DataModule

    Public Sub LoadDataSatuLane(namaLane As String, lv As ListView, imageListHero As ImageList)
        Try
            ConnectionModule.OpenConnection()
            lv.Items.Clear()
            lv.LargeImageList = imageListHero

            Dim query As String =
                "SELECT h.id_hero, h.nama_hero, h.gambar, t.grade_tier " &
                "FROM tb_hero h JOIN tb_tierlist t ON h.id_hero = t.id_hero " &
                "WHERE t.lane = @lane"

            Dim cmd = ConnectionModule.CreateCommand(query)
            cmd.Parameters.AddWithValue("@lane", namaLane)

            Dim localReader As MySqlDataReader = cmd.ExecuteReader()
            While localReader.Read()
                Dim id As Integer = localReader("id_hero")
                Dim nama As String = localReader("nama_hero").ToString()
                Dim path As String = localReader("gambar").ToString()
                Dim tier As String = localReader("grade_tier").ToString()

                If Not imageListHero.Images.ContainsKey(id.ToString()) Then
                    If File.Exists(path) Then
                        imageListHero.Images.Add(id.ToString(), Image.FromFile(path))
                    Else
                        imageListHero.Images.Add(id.ToString(), New Bitmap(80, 80))
                    End If
                End If

                Dim item As New ListViewItem(nama)
                item.ImageKey = id.ToString()
                item.Tag = id

                Select Case tier
                    Case "S" : item.Group = lv.Groups("grpS")
                    Case "A" : item.Group = lv.Groups("grpA")
                    Case "B" : item.Group = lv.Groups("grpB")
                    Case "C" : item.Group = lv.Groups("grpC")
                End Select

                lv.Items.Add(item)
            End While
            localReader.Close()

        Catch ex As Exception
            MsgBox("Gagal memuat data " & namaLane & ": " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Sub

    Public Class HeroDetail
        Public Property IdHero As Integer
        Public Property NamaHero As String
        Public Property Lane As String
        Public Property GradeTier As String
        Public Property Gambar As String
        Public Property Role As String
        Public Property Counter As String
        Public Property Sinergi As String
    End Class

    Public Function GetDetailHero(idHero As Integer) As HeroDetail
        Dim hasil As HeroDetail = Nothing
        Try
            ConnectionModule.OpenConnection()
            Dim query As String =
                "SELECT h.*, t.lane, t.grade_tier FROM tb_hero h " &
                "JOIN tb_tierlist t ON h.id_hero = t.id_hero WHERE h.id_hero = @id"

            Dim cmd = ConnectionModule.CreateCommand(query)
            cmd.Parameters.AddWithValue("@id", idHero)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                hasil = New HeroDetail With {
                    .IdHero = idHero,
                    .NamaHero = reader("nama_hero").ToString(),
                    .Lane = reader("lane").ToString(),
                    .GradeTier = reader("grade_tier").ToString(),
                    .Gambar = reader("gambar").ToString(),
                    .Role = reader("role").ToString(),
                    .Counter = reader("counter").ToString(),
                    .Sinergi = reader("sinergi").ToString()
                }
            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("Gagal mengambil detail hero: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ConnectionModule.CloseConnection()
        End Try
        Return hasil
    End Function


    Public Function TambahHero(nama As String, lane As String, tier As String,
                                role As String, counter As String, sinergi As String,
                                pathGambar As String) As Boolean
        Try
            ConnectionModule.OpenConnection()

            Dim qHero As String =
                "INSERT INTO tb_hero (nama_hero, role, counter, sinergi, gambar) " &
                "VALUES (@nama, @role, @counter, @sinergi, @gambar)"
            Dim cmdHero = ConnectionModule.CreateCommand(qHero)
            cmdHero.Parameters.AddWithValue("@nama", nama)
            cmdHero.Parameters.AddWithValue("@role", role)
            cmdHero.Parameters.AddWithValue("@counter", counter)
            cmdHero.Parameters.AddWithValue("@sinergi", sinergi)
            cmdHero.Parameters.AddWithValue("@gambar", pathGambar.Replace("\", "\\"))
            cmdHero.ExecuteNonQuery()

            Dim idBaru As Integer = CInt(cmdHero.LastInsertedId)

            Dim qTier As String =
                "INSERT INTO tb_tierlist (id_hero, lane, grade_tier) VALUES (@id_hero, @lane, @tier)"
            Dim cmdTier = ConnectionModule.CreateCommand(qTier)
            cmdTier.Parameters.AddWithValue("@id_hero", idBaru)
            cmdTier.Parameters.AddWithValue("@lane", lane)
            cmdTier.Parameters.AddWithValue("@tier", tier)
            cmdTier.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox("Gagal menambah data: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function


    Public Function UpdateHero(idHero As Integer, nama As String, lane As String, tier As String,
                                role As String, counter As String, sinergi As String,
                                pathGambar As String) As Boolean
        Try
            ConnectionModule.OpenConnection()

            Dim qHero As String =
                "UPDATE tb_hero SET nama_hero=@nama, role=@role, counter=@counter, " &
                "sinergi=@sinergi, gambar=@gambar WHERE id_hero=@id"
            Dim cmdHero = ConnectionModule.CreateCommand(qHero)
            cmdHero.Parameters.AddWithValue("@nama", nama)
            cmdHero.Parameters.AddWithValue("@role", role)
            cmdHero.Parameters.AddWithValue("@counter", counter)
            cmdHero.Parameters.AddWithValue("@sinergi", sinergi)
            cmdHero.Parameters.AddWithValue("@gambar", pathGambar.Replace("\", "\\"))
            cmdHero.Parameters.AddWithValue("@id", idHero)
            cmdHero.ExecuteNonQuery()

            Dim qTier As String =
                "UPDATE tb_tierlist SET lane=@lane, grade_tier=@tier WHERE id_hero=@id"
            Dim cmdTier = ConnectionModule.CreateCommand(qTier)
            cmdTier.Parameters.AddWithValue("@lane", lane)
            cmdTier.Parameters.AddWithValue("@tier", tier)
            cmdTier.Parameters.AddWithValue("@id", idHero)
            cmdTier.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox("Gagal mengupdate data: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function

    Public Function HapusHero(idHero As Integer) As Boolean
        Try
            ConnectionModule.OpenConnection()

            Dim cmdTier = ConnectionModule.CreateCommand("DELETE FROM tb_tierlist WHERE id_hero=@id")
            cmdTier.Parameters.AddWithValue("@id", idHero)
            cmdTier.ExecuteNonQuery()

            Dim cmdHero = ConnectionModule.CreateCommand("DELETE FROM tb_hero WHERE id_hero=@id")
            cmdHero.Parameters.AddWithValue("@id", idHero)
            cmdHero.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MsgBox("Gagal menghapus data: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        Finally
            ConnectionModule.CloseConnection()
        End Try
    End Function

End Module