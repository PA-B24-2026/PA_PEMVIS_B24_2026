Imports System.IO

Public Class FormInput
    Dim pathGambarGlobal As String = ""
    Dim idHeroTerpilih As Integer = 0
    Dim idTierTerpilih As Integer = 0

    ' Dictionary untuk menyimpan daftar hero berdasarkan Lane
    Dim mapHeroLane As New Dictionary(Of String, List(Of String))

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Muat Database Hero berdasarkan Lane
        SetupDaftarHero()

        ' 2. Isi ComboBox Lane
        cbLane.Items.AddRange({"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"})
        cbTier.Items.AddRange({"S", "A", "B", "C"})
        errProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        RefreshData()
    End Sub

    ' =========================================================
    ' PENGATURAN FILTER HERO BERDASARKAN LANE
    ' =========================================================
    Private Sub SetupDaftarHero()
        ' Daftar Hero Jungle
        mapHeroLane.Add("Jungle", New List(Of String) From {"Aamon", "Akai", "Aldous", "Alpha", "Alucard", "Balmond", "Bane", "Barats", "Baxia", "Benedetta", "Chou", "Cyclops", "Dyroth", "Fanny", "Fredrinn", "Freya", "Gusion", "Hanzo", "Harley", "Helcurt", "Jawhead", "Julian", "Karina", "Lancelot", "Leomord", "Ling", "Martis", "Nolan", "Paquito", "Popol Kupa", "Roger", "Saber", "Sun", "Thamuz", "X.Borg", "Yi Sun-Shin", "Yin", "Zilong"})

        ' Daftar Hero Roam
        mapHeroLane.Add("Roam", New List(Of String) From {"Akai", "Angela", "Atlas", "Belerick", "Carmilla", "Chou", "Diggie", "Estes", "Faramis", "Floryn", "Franco", "Gatotkaca", "Gloo", "Grock", "Hylos", "Jawhead", "Johnson", "Kadita", "Kaja", "Khufra", "Lolita", "Mathilda", "Minotaur", "Minsitthar", "Nana", "Natalia", "Rafaela", "Ruby", "Tigreal", "Valir"})

        ' Daftar Hero Exp Lane
        mapHeroLane.Add("ExpLane", New List(Of String) From {"Aldous", "Alpha", "Argus", "Arlott", "Badang", "Balmond", "Bane", "Barats", "Benedetta", "Chou", "Dyroth", "Esmeralda", "Freya", "Gatotkaca", "Gloo", "Guinevere", "Hilda", "Jawhead", "Julian", "Khaleed", "Lapu-Lapu", "Leomord", "Martis", "Masha", "Minsitthar", "Paquito", "Phoveus", "Ruby", "Silvanna", "Sun", "Terizla", "Thamuz", "Uranus", "X.Borg", "Yin", "Yu Zhong", "Zilong"})

        ' Daftar Hero Gold Lane
        mapHeroLane.Add("GoldLane", New List(Of String) From {"Beatrix", "Brody", "Bruno", "Claude", "Clint", "Granger", "Hanabi", "Irithel", "Ixia", "Karrie", "Kimmy", "Layla", "Lesley", "Melissa", "Miya", "Moskov", "Natan", "Popol Kupa", "Roger", "Wanwan"})

        ' Daftar Hero Mid Lane
        mapHeroLane.Add("MidLane", New List(Of String) From {"Alice", "Aurora", "Cecilion", "Chang'e", "Cyclops", "Eudora", "Faramis", "Gord", "Harith", "Harley", "Kadita", "Kagura", "Kimmy", "Lunox", "Luo Yi", "Lylia", "Nana", "Novaria", "Odette", "Pharsa", "Valentina", "Vale", "Valir", "Vexana", "Yve", "Zhask"})
    End Sub

    ' Event: Jika Lane diubah, filter hero yang tampil di cbHero
    Private Sub cbLane_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLane.SelectedIndexChanged
        If cbLane.SelectedIndex <> -1 Then
            Dim lanePilihan = cbLane.Text
            cbHero.Items.Clear()

            If mapHeroLane.ContainsKey(lanePilihan) Then
                ' Urutkan nama hero sesuai abjad A-Z agar rapi
                Dim listHero = mapHeroLane(lanePilihan).ToList()
                listHero.Sort()
                cbHero.Items.AddRange(listHero.ToArray())
            End If
        End If
    End Sub

    ' =========================================================
    ' VALIDASI ROLE (MAKSIMAL 2) MENGGUNAKAN VALIDATION MODULE
    ' =========================================================
    Private Sub RoleCheckbox_Click(sender As Object, e As EventArgs) Handles cbAssasin.Click, cbTank.Click, cbMarksman.Click, cbFighter.Click, cbMage.Click, cbSupport.Click
        Dim chkBaru = DirectCast(sender, CheckBox)
        Dim semuaCheckbox = {cbAssasin, cbTank, cbMarksman, cbFighter, cbMage, cbSupport}

        ' Memanggil fungsi dari ValidationModule milik Anda
        ValidationModule.ValidasiMaxRole(semuaCheckbox, chkBaru)
    End Sub

    ' =========================================================
    ' FUNGSI VALIDASI UMUM & CEK DUPLIKAT
    ' =========================================================
    Private Function CekDuplikat(namaHero As String, lane As String, idAbaikan As Integer) As Boolean
        For Each row As DataGridViewRow In dgvHero.Rows
            If row.Cells("nama_hero").Value IsNot Nothing Then
                Dim rowId As Integer = Val(row.Cells("id_hero").Value)
                Dim rowNama As String = row.Cells("nama_hero").Value.ToString()
                Dim rowLane As String = row.Cells("lane").Value.ToString()

                If rowId <> idAbaikan Then
                    If rowNama.ToLower() = namaHero.ToLower() AndAlso rowLane.ToLower() = lane.ToLower() Then
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function

    Private Function ValidasiInput() As Boolean
        errProvider.Clear()
        Dim isValid As Boolean = True

        If cbLane.SelectedIndex = -1 Then
            errProvider.SetError(cbLane, "Sila pilih Lane terlebih dahulu!")
            isValid = False
        End If
        If cbHero.SelectedIndex = -1 Or cbHero.Text = "" Then
            errProvider.SetError(cbHero, "Sila pilih nama Hero dari senarai!")
            isValid = False
        End If
        If cbTier.SelectedIndex = -1 Then
            errProvider.SetError(cbTier, "Sila tentukan Tier Meta!")
            isValid = False
        End If
        If pathGambarGlobal = "" Then
            errProvider.SetError(btnBrowse, "Sila muat naik gambar hero!")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(txtDeskripsi.Text) Then
            errProvider.SetError(txtDeskripsi, "Deskripsi analisis meta tidak boleh kosong!")
            isValid = False
        End If
        If GetRoles() = "" Then
            errProvider.SetError(gbRole, "Sila pilih sekurang-kurangnya satu role!")
            isValid = False
        End If

        Return isValid
    End Function

    ' =========================================================
    ' TOMBOL CRUD & BERSIHKAN
    ' =========================================================

    ' =========================================================
    ' TOMBOL SIMPAN (DENGAN LOGIKA REUSE ID_HERO LAMA)
    ' =========================================================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        Dim namaHeroPilihan As String = cbHero.Text

        ' 1. Cek apakah hero sudah ada di lane ini (Validasi Duplikat dari ValidationModule)
        If ValidationModule.CekDuplikatTier(dgvHero, namaHeroPilihan, cbLane.Text, 0) Then
            MsgBox($"Hero '{namaHeroPilihan}' sudah didaftarkan pada lane '{cbLane.Text}'!", MsgBoxStyle.Exclamation, "Ralat Duplikat")
            Exit Sub
        End If

        Dim namaFileDb As String = Path.GetFileName(pathGambarGlobal)
        Dim idHeroDipakai As Integer = 0

        ' 2. CEK LANGSUNG KE DATABASE: Apakah hero ini sudah ada di tabel tb_hero?
        Try
            DataModule.OpenConnection()
            Dim cmdCek = DataModule.CreateCommand("SELECT id_hero FROM tb_hero WHERE nama_hero = @nama")
            cmdCek.Parameters.AddWithValue("@nama", namaHeroPilihan)
            Dim result = cmdCek.ExecuteScalar()

            ' Jika query mengembalikan data (hero ditemukan), simpan ID-nya
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                idHeroDipakai = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            MsgBox("Error Cek Database Hero: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            DataModule.CloseConnection()
        End Try

        ' 3. TENTUKAN ID_HERO: Gunakan yang lama, atau buat baru jika belum ada
        If idHeroDipakai = 0 Then
            ' Hero belum ada di tb_hero, panggil fungsi insert dan ambil ID barunya
            idHeroDipakai = DataModule.TambahDataHero(namaHeroPilihan, GetRoles(), txtDeskripsi.Text, namaFileDb)
        Else
            ' Hero sudah ada di tb_hero, kita update data role, gambar, & deskripsinya agar menggunakan versi terbaru
            Try
                DataModule.OpenConnection()
                Dim cmdUpdateHero = DataModule.CreateCommand("UPDATE tb_hero SET role=@role, deskripsi=@desc, gambar=@img WHERE id_hero=@id")
                cmdUpdateHero.Parameters.AddWithValue("@role", GetRoles())
                cmdUpdateHero.Parameters.AddWithValue("@desc", txtDeskripsi.Text)
                cmdUpdateHero.Parameters.AddWithValue("@img", namaFileDb)
                cmdUpdateHero.Parameters.AddWithValue("@id", idHeroDipakai)
                cmdUpdateHero.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                DataModule.CloseConnection()
            End Try
        End If

        ' 4. SIMPAN KE TIER LIST (Menggunakan id_hero yang benar dari tb_hero)
        If idHeroDipakai > 0 Then
            If DataModule.TambahDataTierList(idHeroDipakai, cbLane.Text, cbTier.Text) Then
                MsgBox("Data Tier List Baru Berjaya Disimpan!", MsgBoxStyle.Information)
                RefreshData()
                BersihkanForm()
            End If
        End If
    End Sub

    ' =========================================================
    ' TOMBOL UPDATE (BERDASARKAN ID_TIER BUKAN ID_HERO)
    ' =========================================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idTierTerpilih = 0 Then MsgBox("Sila pilih data dari jadual terlebih dahulu!", MsgBoxStyle.Critical) : Exit Sub
        If Not ValidasiInput() Then Exit Sub

        Dim namaHeroPilihan As String = cbHero.Text
        If ValidationModule.CekDuplikatTier(dgvHero, namaHeroPilihan, cbLane.Text, idHeroTerpilih) Then
            MsgBox($"Hero '{namaHeroPilihan}' sudah wujud pada lane '{cbLane.Text}'.", MsgBoxStyle.Exclamation, "Ralat Duplikat")
            Exit Sub
        End If

        Try
            DataModule.OpenConnection()

            ' Update tabel utama tb_hero
            Dim cmdHero = DataModule.CreateCommand("UPDATE tb_hero SET role=@role, deskripsi=@desc, gambar=@img WHERE id_hero=@id_hero")
            cmdHero.Parameters.AddWithValue("@role", GetRoles())
            cmdHero.Parameters.AddWithValue("@desc", txtDeskripsi.Text)
            cmdHero.Parameters.AddWithValue("@img", Path.GetFileName(pathGambarGlobal))
            cmdHero.Parameters.AddWithValue("@id_hero", idHeroTerpilih)
            cmdHero.ExecuteNonQuery()

            ' Update HANYA lane tersebut di tb_tierlist menggunakan ID_TIER (Mencegah lane lain ikut berubah)
            Dim cmdTier = DataModule.CreateCommand("UPDATE tb_tierlist SET lane=@lane, grade_tier=@tier WHERE id_tier=@id_tier")
            cmdTier.Parameters.AddWithValue("@lane", cbLane.Text)
            cmdTier.Parameters.AddWithValue("@tier", cbTier.Text)
            cmdTier.Parameters.AddWithValue("@id_tier", idTierTerpilih)
            cmdTier.ExecuteNonQuery()

            MsgBox("Data Berjaya Dikemas Kini!", MsgBoxStyle.Information)
            RefreshData()
            BersihkanForm()
        Catch ex As Exception
            MsgBox("Error Update: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    ' =========================================================
    ' TOMBOL HAPUS (MENGHAPUS TIERLIST SECARA AMAN)
    ' =========================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idTierTerpilih <> 0 AndAlso MsgBox("Adakah anda pasti ingin memadam data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                DataModule.OpenConnection()

                ' Hapus hanya status TierList pada lane yang dipilih
                Dim cmdHapus = DataModule.CreateCommand("DELETE FROM tb_tierlist WHERE id_tier=@id_tier")
                cmdHapus.Parameters.AddWithValue("@id_tier", idTierTerpilih)
                cmdHapus.ExecuteNonQuery()

                ' Cek apakah hero tersebut masih ada di Lane lain. Jika kosong (tidak terpakai sama sekali), hapus hero secara total
                Dim cmdCek = DataModule.CreateCommand("SELECT COUNT(*) FROM tb_tierlist WHERE id_hero=@id_hero")
                cmdCek.Parameters.AddWithValue("@id_hero", idHeroTerpilih)
                Dim sisaLane = Convert.ToInt32(cmdCek.ExecuteScalar())

                If sisaLane = 0 Then
                    Dim cmdHapusTotal = DataModule.CreateCommand("DELETE FROM tb_hero WHERE id_hero=@id_hero")
                    cmdHapusTotal.Parameters.AddWithValue("@id_hero", idHeroTerpilih)
                    cmdHapusTotal.ExecuteNonQuery()
                End If

                RefreshData()
                BersihkanForm()
            Catch ex As Exception
                MsgBox("Error Hapus: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                DataModule.CloseConnection()
            End Try
        End If
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    ' =========================================================
    ' LAIN-LAIN (GAMBAR, KLIK TABEL, PROTEKSI)
    ' =========================================================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.png;*.jpg;*.jpeg"
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim folder = Path.Combine(Application.StartupPath, "Images")
            If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
            pathGambarGlobal = Path.Combine(folder, Path.GetFileName(ofd.FileName))
            If Not File.Exists(pathGambarGlobal) Then File.Copy(ofd.FileName, pathGambarGlobal)
            picHero.ImageLocation = pathGambarGlobal
            errProvider.SetError(btnBrowse, "")
        End If
    End Sub

    Private Sub dgvHero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHero.CellClick
        errProvider.Clear()
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHero.Rows(e.RowIndex)
            idHeroTerpilih = Val(row.Cells("id_hero").Value)
            idTierTerpilih = Val(row.Cells("id_tier").Value) ' <-- AMBIL ID TIER

            cbLane.Text = row.Cells("lane").Value.ToString()
            cbHero.Text = row.Cells("nama_hero").Value.ToString()
            cbTier.Text = row.Cells("grade_tier").Value.ToString()
            txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()

            Dim roles = row.Cells("role").Value.ToString()
            cbAssasin.Checked = roles.Contains("Assasin")
            cbTank.Checked = roles.Contains("Tank")
            cbMarksman.Checked = roles.Contains("Marksman")
            cbSupport.Checked = roles.Contains("Support")
            cbFighter.Checked = roles.Contains("Fighter")
            cbMage.Checked = roles.Contains("Mage")

            Dim imgName = row.Cells("gambar").Value.ToString()
            pathGambarGlobal = Path.Combine(Application.StartupPath, "Images", imgName)
            If File.Exists(pathGambarGlobal) Then picHero.Image = Image.FromFile(pathGambarGlobal)
        End If
    End Sub

    Private Function GetRoles() As String
        Dim r As New List(Of String)
        If cbAssasin.Checked Then r.Add("Assasin")
        If cbTank.Checked Then r.Add("Tank")
        If cbMarksman.Checked Then r.Add("Marksman")
        If cbSupport.Checked Then r.Add("Support")
        If cbFighter.Checked Then r.Add("Fighter")
        If cbMage.Checked Then r.Add("Mage")
        Return String.Join(", ", r)
    End Function

    Sub RefreshData()
        dgvHero.DataSource = DataModule.GetAllHero()
    End Sub

    Sub BersihkanForm()
        errProvider.Clear()
        cbLane.SelectedIndex = -1
        cbHero.Items.Clear() ' Bersihkan senarai hero kerana lane kosong
        txtDeskripsi.Clear()
        cbTier.SelectedIndex = -1
        If picHero.Image IsNot Nothing Then picHero.Image.Dispose()
        picHero.Image = Nothing
        pathGambarGlobal = ""
        idHeroTerpilih = 0
        cbAssasin.Checked = False : cbTank.Checked = False : cbMarksman.Checked = False
        cbSupport.Checked = False : cbFighter.Checked = False : cbMage.Checked = False
        dgvHero.ClearSelection()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_SYSCOMMAND As Integer = &H112
        Const SC_MOVE As Integer = &HF010

        ' Jika ada perintah sistem untuk menggeser (move) form
        If m.Msg = WM_SYSCOMMAND Then
            Dim command As Integer = m.WParam.ToInt32() And &HFFF0
            If command = SC_MOVE Then
                Return ' Abaikan perintah geser, form akan diam di tempat
            End If
        End If

        ' Lanjutkan pesan sistem lainnya (seperti klik tombol close, dll)
        MyBase.WndProc(m)
    End Sub

End Class