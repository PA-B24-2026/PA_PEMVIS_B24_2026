Public Class FormTierList
    Dim imgList As New ImageList()

    Private Sub FormTierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imgList.ImageSize = New Size(70, 70) ' Ukuran gambar diatur di sini
        imgList.ColorDepth = ColorDepth.Depth32Bit

        DataModule.LoadDataSatuLane("Jungle", lvJungle, imgList)
        DataModule.LoadDataSatuLane("Roam", lvRoam, imgList)
        DataModule.LoadDataSatuLane("ExpLane", lvExp, imgList)
        DataModule.LoadDataSatuLane("GoldLane", lvGold, imgList)
        DataModule.LoadDataSatuLane("MidLane", lvMid, imgList)
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles lvJungle.Click, lvRoam.Click, lvExp.Click, lvGold.Click, lvMid.Click
        Dim lv = DirectCast(sender, ListView)
        If lv.SelectedItems.Count > 0 Then
            Dim id = CInt(lv.SelectedItems(0).Tag)
            Dim detail = DataModule.GetDetailHero(id)

            Dim info = $"NAMA HERO: {detail.Nama}{vbCrLf}" &
                       $"ROLE: {detail.Role}{vbCrLf}" &
                       $"DESKRIPSI: {detail.Deskripsi}"
            MsgBox(info, MsgBoxStyle.Information, "Detail Hero")
        End If
    End Sub
End Class