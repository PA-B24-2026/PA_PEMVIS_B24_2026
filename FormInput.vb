Imports System.IO

Public Class FormInput
    Dim pathGambarGlobal As String = ""
    Dim idHeroTerpilih As Integer = 0

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbLane.Items.AddRange({"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"})
        cbTier.Items.AddRange({"S", "A", "B", "C"})
        RefreshData()
    End Sub

    ' --- LOGIKA CLBHERO (Hanya boleh pilih 1 nama hero) ---
    Private Sub clbHero_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbHero.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To clbHero.Items.Count - 1
                If i <> e.Index Then clbHero.SetItemChecked(i, False)
            Next
        End If
    End Sub

    ' --- LOGIKA BUTANG TAMBAH (DATA BARU) ---
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Validasi: Pastikan ada 1 hero yang dicentang di clbHero
        If clbHero.CheckedItems.Count = 0 Or cbLane.Text = "" Or pathGambarGlobal = "" Then
            MsgBox("Mohon pilih Nama Hero dari senarai, Lane, dan Pilih Gambar!")
            Exit Sub
        End If

        ' Mengambil nama hero dari item yang dicentang pada clbHero
        Dim namaHeroPilihan As String = clbHero.CheckedItems(0).ToString()
        Dim namaFileDb As String = Path.GetFileName(pathGambarGlobal)

        If DataModule.TambahHero(namaHeroPilihan, cbLane.Text, cbTier.Text, GetRoles(), txtDeskripsi.Text, namaFileDb) Then
            MsgBox("Hero Baru Berjaya Ditambahkan!")
            RefreshData()
            BersihkanForm()
        End If
    End Sub

    ' --- LOGIKA BUTANG EDIT (SIMPAN PERUBAHAN) ---
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idHeroTerpilih = 0 Then
            MsgBox("Sila pilih hero dari jadual yang ingin diedit!")
            Exit Sub
        End If

        If clbHero.CheckedItems.Count = 0 Then
            MsgBox("Mohon pilih Nama Hero dari senarai!")
            Exit Sub
        End If

        Dim namaHeroPilihan As String = clbHero.CheckedItems(0).ToString()
        Dim namaFileDb As String = Path.GetFileName(pathGambarGlobal)

        If DataModule.UpdateHero(idHeroTerpilih, namaHeroPilihan, cbLane.Text, cbTier.Text, GetRoles(), txtDeskripsi.Text, namaFileDb) Then
            MsgBox("Data Hero Berjaya Diperbarui!")
            RefreshData()
            BersihkanForm()
        End If
    End Sub

    ' --- LOGIKA SEMASA JADUAL DIKLIK (MENGISI FORM INPUT) ---
    Private Sub dgvHero_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHero.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvHero.Rows(e.RowIndex)
            idHeroTerpilih = Val(row.Cells("id_hero").Value)

            ' Mencari nama hero di clbHero dan mencentangnya secara automatik
            Dim namaHeroDB As String = row.Cells("nama_hero").Value.ToString()
            For i As Integer = 0 To clbHero.Items.Count - 1
                If clbHero.Items(i).ToString() = namaHeroDB Then
                    clbHero.SetItemChecked(i, True)
                Else
                    clbHero.SetItemChecked(i, False)
                End If
            Next

            cbLane.Text = row.Cells("lane").Value.ToString()
            cbTier.Text = row.Cells("grade_tier").Value.ToString()
            txtDeskripsi.Text = row.Cells("deskripsi").Value.ToString()

            ' Set Checkbox Role
            Dim roles = row.Cells("role").Value.ToString()
            cbAssasin.Checked = roles.Contains("Assasin")
            cbTank.Checked = roles.Contains("Tank")
            cbMarksman.Checked = roles.Contains("Marksman")
            cbSupport.Checked = roles.Contains("Support")
            cbFighter.Checked = roles.Contains("Fighter")
            cbMage.Checked = roles.Contains("Mage")

            ' Load Gambar Preview
            Dim imgName = row.Cells("gambar").Value.ToString()
            pathGambarGlobal = Path.Combine(Application.StartupPath, "Images", imgName)
            If File.Exists(pathGambarGlobal) Then
                picHero.Image = Image.FromFile(pathGambarGlobal)
            End If
        End If
    End Sub

    ' --- LOGIKA BUTANG BROWSE GAMBAR ---
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Images|*.png;*.jpg;*.jpeg"
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim folder = Path.Combine(Application.StartupPath, "Images")
            If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)

            pathGambarGlobal = Path.Combine(folder, Path.GetFileName(ofd.FileName))
            If Not File.Exists(pathGambarGlobal) Then File.Copy(ofd.FileName, pathGambarGlobal)
            picHero.ImageLocation = pathGambarGlobal
        End If
    End Sub

    ' --- BUTANG HAPUS ---
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idHeroTerpilih <> 0 AndAlso MsgBox("Adakah anda pasti ingin memadam data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If DataModule.HapusHero(idHeroTerpilih) Then
                RefreshData()
                BersihkanForm()
            End If
        End If
    End Sub

    ' --- FUNGSI SOKONGAN ---
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
        ' Buangkan semua centang di clbHero
        For i As Integer = 0 To clbHero.Items.Count - 1
            clbHero.SetItemChecked(i, False)
        Next

        txtDeskripsi.Clear()
        cbLane.SelectedIndex = -1
        cbTier.SelectedIndex = -1
        picHero.Image = Nothing
        pathGambarGlobal = ""
        idHeroTerpilih = 0

        ' Uncheck semua role
        cbAssasin.Checked = False : cbTank.Checked = False : cbMarksman.Checked = False
        cbSupport.Checked = False : cbFighter.Checked = False : cbMage.Checked = False
    End Sub
End Class