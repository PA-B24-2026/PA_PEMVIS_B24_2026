Imports System.IO

Public Class FormInput
    Dim pathGambarGlobal As String = ""
    Dim idHeroTerpilih As Integer = 0

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbLane.Items.AddRange({"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"})
        cbTier.Items.AddRange({"S", "A", "B", "C"})
        errProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        RefreshData()
    End Sub

    Private Function ValidasiInput() As Boolean
        errProvider.Clear()
        Dim isValid As Boolean = True

        ' Sekarang memvalidasi ComboBox cbHero
        If cbHero.SelectedIndex = -1 Or cbHero.Text = "" Then
            errProvider.SetError(cbHero, "Sila pilih nama Hero dari senarai dropdown!")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(cbLane.Text) Then
            errProvider.SetError(cbLane, "Sila tentukan Lane!")
            isValid = False
        End If
        If String.IsNullOrWhiteSpace(cbTier.Text) Then
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

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then Exit Sub

        ' Mengambil nama hero dari ComboBox cbHero
        Dim namaHeroPilihan As String = cbHero.Text
        Dim namaFileDb As String = Path.GetFileName(pathGambarGlobal)
        Dim idHeroBaru As Integer = DataModule.TambahDataHero(namaHeroPilihan, GetRoles(), txtDeskripsi.Text, namaFileDb)

        If idHeroBaru > 0 Then
            If DataModule.TambahDataTierList(idHeroBaru, cbLane.Text, cbTier.Text) Then
                MsgBox("Data Tier List Baru Berjaya Disimpan!", MsgBoxStyle.Information)
                RefreshData()
                BersihkanForm()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idHeroTerpilih = 0 Then MsgBox("Sila pilih data dari jadual di sebelah kanan terlebih dahulu!", MsgBoxStyle.Critical) : Exit Sub
        If Not ValidasiInput() Then Exit Sub

        Dim namaHeroPilihan As String = cbHero.Text
        Dim namaFileDb As String = Path.GetFileName(pathGambarGlobal)

        If DataModule.UpdateHero(idHeroTerpilih, namaHeroPilihan, cbLane.Text, cbTier.Text, GetRoles(), txtDeskripsi.Text, namaFileDb) Then
            MsgBox("Data Berjaya Dikemas Kini!", MsgBoxStyle.Information)
            RefreshData()
            BersihkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idHeroTerpilih <> 0 AndAlso MsgBox("Adakah anda pasti ingin memadam data ini?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            If DataModule.HapusHero(idHeroTerpilih) Then
                RefreshData()
                BersihkanForm()
            End If
        End If
    End Sub

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

            ' Isi ComboBox cbHero otomatis saat tabel diklik
            cbHero.Text = row.Cells("nama_hero").Value.ToString()
            cbLane.Text = row.Cells("lane").Value.ToString()
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
        cbHero.SelectedIndex = -1 ' Reset Dropdown Hero
        txtDeskripsi.Clear()
        cbLane.SelectedIndex = -1
        cbTier.SelectedIndex = -1
        If picHero.Image IsNot Nothing Then picHero.Image.Dispose()
        picHero.Image = Nothing
        pathGambarGlobal = ""
        idHeroTerpilih = 0
        cbAssasin.Checked = False : cbTank.Checked = False : cbMarksman.Checked = False
        cbSupport.Checked = False : cbFighter.Checked = False : cbMage.Checked = False
    End Sub
End Class