Imports System.IO

Public Class Form1

    Dim pathGambar As String = ""
    Dim idHeroTerpilih As Integer = 0
    Dim imageListHero As New ImageList()

    Private ReadOnly Property AllRoleCheckBoxes As IEnumerable(Of CheckBox)
        Get
            Return {cbAssasin, cbFighter, cbMarksman, cbTank, cbSupport, cbMage}
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageListHero.ImageSize = New Size(80, 80)

        Dim pathLingkaran As New System.Drawing.Drawing2D.GraphicsPath()
        pathLingkaran.AddEllipse(0, 0, gambar.Width, gambar.Height)
        gambar.Region = New Region(pathLingkaran)

        For Each lv As ListView In {ListJung, ListRoam, ListExp, ListGold, ListMid}
            lv.View = View.LargeIcon
        Next

        If cbLane.Items.Count = 0 Then
            cbLane.Items.AddRange(New String() {"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"})
        End If
        If cbTier.Items.Count = 0 Then
            cbTier.Items.AddRange(New String() {"S", "A", "B", "C"})
        End If

        LoadSemuaData()
    End Sub


    Private Sub LoadSemuaData()
        DataModule.LoadDataSatuLane("Jungle", ListJung, imageListHero)
        DataModule.LoadDataSatuLane("Roam", ListRoam, imageListHero)
        DataModule.LoadDataSatuLane("ExpLane", ListExp, imageListHero)
        DataModule.LoadDataSatuLane("GoldLane", ListGold, imageListHero)
        DataModule.LoadDataSatuLane("MidLane", ListMid, imageListHero)
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListJung.SelectedIndexChanged, ListRoam.SelectedIndexChanged,
                ListExp.SelectedIndexChanged, ListGold.SelectedIndexChanged,
                ListMid.SelectedIndexChanged

        Dim lv As ListView = CType(sender, ListView)
        If lv.SelectedItems.Count > 0 Then
            idHeroTerpilih = Convert.ToInt32(lv.SelectedItems(0).Tag)
            TampilkanDetailHero(idHeroTerpilih)
        End If
    End Sub

    Private Sub TampilkanDetailHero(id As Integer)
        Dim hero = DataModule.GetDetailHero(id)
        If hero Is Nothing Then Return

        txtNama.Text = hero.NamaHero
        cbLane.Text = hero.Lane
        cbTier.Text = hero.GradeTier

        pathGambar = hero.Gambar
        If File.Exists(pathGambar) Then
            gambar.ImageLocation = pathGambar
            gambar.SizeMode = PictureBoxSizeMode.Zoom
        Else
            gambar.Image = Nothing
        End If

        cbAssasin.Checked = hero.Role.Contains("Assasin")
        cbFighter.Checked = hero.Role.Contains("Fighter")
        cbMarksman.Checked = hero.Role.Contains("Marksman")
        cbTank.Checked = hero.Role.Contains("Tank")
        cbSupport.Checked = hero.Role.Contains("Support")
        cbMage.Checked = hero.Role.Contains("Mage")

        For i As Integer = 0 To clbCounter.Items.Count - 1
            clbCounter.SetItemChecked(i, hero.Counter.Contains(clbCounter.Items(i).ToString()))
        Next
        For i As Integer = 0 To clbSinergis.Items.Count - 1
            clbSinergis.SetItemChecked(i, hero.Sinergi.Contains(clbSinergis.Items(i).ToString()))
        Next
    End Sub


    Private Sub Role_CheckedChanged(sender As Object, e As EventArgs) _
        Handles cbAssasin.CheckedChanged, cbFighter.CheckedChanged, cbMarksman.CheckedChanged,
                cbTank.CheckedChanged, cbSupport.CheckedChanged, cbMage.CheckedChanged

        ValidationModule.ValidasiMaxRole(AllRoleCheckBoxes, CType(sender, CheckBox))
    End Sub

    Private Sub clbCounter_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbCounter.ItemCheck
        ValidationModule.ValidasiMaxCheckedListBox(e, clbCounter, "Hero Counter", 3)
    End Sub

    Private Sub clbSinergis_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbSinergis.ItemCheck
        ValidationModule.ValidasiMaxCheckedListBox(e, clbSinergis, "Hero Sinergi", 3)
    End Sub

    Private Sub txtCariCounter_TextChanged(sender As Object, e As EventArgs) Handles txtCariCounter.TextChanged
        ScrollCheckedListBox(clbCounter, txtCariCounter.Text)
    End Sub

    Private Sub txtCariSinergis_TextChanged(sender As Object, e As EventArgs) Handles txtCariSinergis.TextChanged
        ScrollCheckedListBox(clbSinergis, txtCariSinergis.Text)
    End Sub

    Private Sub ScrollCheckedListBox(clb As CheckedListBox, keyword As String)
        If String.IsNullOrWhiteSpace(keyword) Then Return
        For i As Integer = 0 To clb.Items.Count - 1
            If clb.Items(i).ToString().ToLower().Contains(keyword.ToLower()) Then
                clb.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Function GetRoleString() As String
        Dim roles As New List(Of String)
        If cbAssasin.Checked Then roles.Add("Assasin")
        If cbFighter.Checked Then roles.Add("Fighter")
        If cbMarksman.Checked Then roles.Add("Marksman")
        If cbTank.Checked Then roles.Add("Tank")
        If cbSupport.Checked Then roles.Add("Support")
        If cbMage.Checked Then roles.Add("Mage")
        Return String.Join(", ", roles)
    End Function

    Private Function GetCLBString(clb As CheckedListBox) As String
        Dim listStr As New List(Of String)
        For Each item In clb.CheckedItems
            listStr.Add(item.ToString())
        Next
        Return String.Join(", ", listStr)
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp"
        If openFile.ShowDialog() = DialogResult.OK Then
            pathGambar = openFile.FileName
            gambar.ImageLocation = pathGambar
            gambar.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidationModule.ValidasiTambah(txtNama.Text, cbLane.Text, pathGambar) Then Return

        Dim berhasil = DataModule.TambahHero(
            txtNama.Text, cbLane.Text, cbTier.Text,
            GetRoleString(), GetCLBString(clbCounter), GetCLBString(clbSinergis),
            pathGambar)

        If berhasil Then
            MsgBox("Data hero berhasil ditambahkan!", MsgBoxStyle.Information)
            BersihkanForm()
            LoadSemuaData()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not ValidationModule.ValidasiHeroTerpilih(idHeroTerpilih, "Update") Then Return

        Dim berhasil = DataModule.UpdateHero(
            idHeroTerpilih, txtNama.Text, cbLane.Text, cbTier.Text,
            GetRoleString(), GetCLBString(clbCounter), GetCLBString(clbSinergis),
            pathGambar)

        If berhasil Then
            MsgBox("Data berhasil diperbarui!", MsgBoxStyle.Information)
            LoadSemuaData()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not ValidationModule.ValidasiHeroTerpilih(idHeroTerpilih, "Hapus") Then Return
        If Not ValidationModule.KonfirmasiHapus(txtNama.Text) Then Return

        Dim berhasil = DataModule.HapusHero(idHeroTerpilih)
        If berhasil Then
            MsgBox("Data hero berhasil dihapus!", MsgBoxStyle.Information)
            BersihkanForm()
            LoadSemuaData()
        End If
    End Sub

    Private Sub BersihkanForm()
        txtNama.Clear()
        cbLane.SelectedIndex = -1
        cbTier.SelectedIndex = -1
        gambar.Image = Nothing
        pathGambar = ""
        idHeroTerpilih = 0

        For Each chk As CheckBox In AllRoleCheckBoxes
            chk.Checked = False
        Next

        For i As Integer = 0 To clbCounter.Items.Count - 1
            clbCounter.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To clbSinergis.Items.Count - 1
            clbSinergis.SetItemChecked(i, False)
        Next
    End Sub

End Class