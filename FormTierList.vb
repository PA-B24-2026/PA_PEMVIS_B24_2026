Imports System.Drawing.Printing
Imports System.IO

Public Class FormTierList
    Dim imgList As New ImageList()
    Private WithEvents printDoc As New PrintDocument()

    ' Variabel Paginasi untuk mencegah terpotong saat berganti halaman
    Private cetakLaneIdx As Integer = 0
    Private cetakTierIdx As Integer = 0
    Private cetakHeroIdx As Integer = 0

    Private Sub FormTierList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imgList.ImageSize = New Size(70, 70)
        imgList.ColorDepth = ColorDepth.Depth32Bit
        MuatSemuaData()
    End Sub

    Private Sub MuatSemuaData()
        Dim listViews = {lvJungle, lvRoam, lvExp, lvGold, lvMid}
        For Each lv In listViews
            lv.Clear()
            lv.Groups.Clear()
            lv.Groups.Add(New ListViewGroup("S", "Tier S"))
            lv.Groups.Add(New ListViewGroup("A", "Tier A"))
            lv.Groups.Add(New ListViewGroup("B", "Tier B"))
            lv.Groups.Add(New ListViewGroup("C", "Tier C"))
            lv.ShowGroups = True
            lv.View = View.LargeIcon
            lv.LargeImageList = imgList
        Next

        DataModule.LoadDataSatuLane("Jungle", lvJungle, imgList)
        DataModule.LoadDataSatuLane("Roam", lvRoam, imgList)
        DataModule.LoadDataSatuLane("ExpLane", lvExp, imgList)
        DataModule.LoadDataSatuLane("GoldLane", lvGold, imgList)
        DataModule.LoadDataSatuLane("MidLane", lvMid, imgList)
    End Sub

    Private Sub btnKosongkan_Click(sender As Object, e As EventArgs) Handles btnKosongkan.Click
        lvJungle.Items.Clear()
        lvRoam.Items.Clear()
        lvExp.Items.Clear()
        lvGold.Items.Clear()
        lvMid.Items.Clear()
    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        MuatSemuaData()
        MsgBox("Data dimuat kembali.", MsgBoxStyle.Information)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Reset index paginasi ke 0 sebelum mulai mencetak
        cetakLaneIdx = 0
        cetakTierIdx = 0
        cetakHeroIdx = 0

        Dim printDlg As New PrintDialog()
        printDlg.Document = printDoc

        If printDlg.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
    End Sub

    ' --- LOGIKA CETAK VEKTOR & PAGINASI ANTI TERPOTONG ---
    Private Sub printDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim g As Graphics = e.Graphics

        ' Meningkatkan kualiti rendering teks & bentuk
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim fontJudul As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim fontLane As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim fontTier As New Font("Segoe UI", 11, FontStyle.Bold)
        Dim fontHero As New Font("Segoe UI", 8, FontStyle.Regular)

        Dim posX As Integer = e.MarginBounds.Left
        Dim posY As Integer = e.MarginBounds.Top

        ' Cetak Header Hanya di Halaman Pertama
        If cetakLaneIdx = 0 AndAlso cetakTierIdx = 0 AndAlso cetakHeroIdx = 0 Then
            g.DrawString("MOBILE LEGENDS HERO META TIER LIST", fontJudul, Brushes.Black, posX, posY)
            posY += 35
            g.DrawLine(Pens.Black, posX, posY, e.MarginBounds.Right, posY)
            posY += 20
        End If

        Dim lanes() As String = {"Jungle", "Roam", "ExpLane", "GoldLane", "MidLane"}
        Dim tiers() As String = {"S", "A", "B", "C"}
        Dim dtTierList As DataTable = DataModule.GetAllHero()

        While cetakLaneIdx < lanes.Length
            Dim currentLane As String = lanes(cetakLaneIdx)

            ' Cetak Nama Lane
            If cetakTierIdx = 0 AndAlso cetakHeroIdx = 0 Then
                If posY + 40 > e.MarginBounds.Bottom Then e.HasMorePages = True : Exit Sub

                g.DrawString("LANE: " & currentLane.ToUpper(), fontLane, Brushes.DarkBlue, posX, posY)
                posY += 25
                g.DrawLine(Pens.Gray, posX, posY, e.MarginBounds.Right, posY)
                posY += 10
            End If

            ' Cetak Tingkatan Tier S, A, B, C
            While cetakTierIdx < tiers.Length
                Dim currentTier As String = tiers(cetakTierIdx)
                Dim rows() As DataRow = dtTierList.Select($"lane = '{currentLane}' AND grade_tier = '{currentTier}'")

                ' Cetak Kotak Label Tier
                If cetakHeroIdx = 0 Then
                    If posY + 55 > e.MarginBounds.Bottom Then e.HasMorePages = True : Exit Sub

                    Dim warnaTier As Brush = Brushes.WhiteSmoke
                    If currentTier = "S" Then warnaTier = New SolidBrush(Color.FromArgb(231, 76, 60))
                    If currentTier = "A" Then warnaTier = New SolidBrush(Color.FromArgb(230, 126, 34))
                    If currentTier = "B" Then warnaTier = New SolidBrush(Color.FromArgb(241, 196, 15))
                    If currentTier = "C" Then warnaTier = New SolidBrush(Color.FromArgb(46, 204, 113))

                    g.FillRectangle(warnaTier, posX, posY, 26, 26)
                    g.DrawString(currentTier, fontTier, Brushes.White, posX + 6, posY + 3)
                End If

                Dim drawX As Integer = posX + 38

                ' Jika Tidak Ada Hero
                If rows.Length = 0 Then
                    If cetakHeroIdx = 0 Then
                        g.DrawString("- Tidak ada hero di tier ini -", fontHero, Brushes.Gray, drawX, posY + 6)
                    End If
                Else
                    ' Cetak Gambar Hero
                    While cetakHeroIdx < rows.Length
                        If drawX + 55 > e.MarginBounds.Right Then
                            drawX = posX + 38
                            posY += 55
                            If posY + 55 > e.MarginBounds.Bottom Then
                                e.HasMorePages = True
                                Exit Sub
                            End If
                        End If

                        Dim row = rows(cetakHeroIdx)
                        Dim fileGambar As String = row("gambar").ToString()
                        Dim pathFileImg As String = Path.Combine(Application.StartupPath, "Images", fileGambar)

                        ' -------------------------------------------------------------
                        ' FIX GAMBAR TERPOTONG: Paksa ubah saiz di memori menggunakan Bitmap
                        ' -------------------------------------------------------------
                        If File.Exists(pathFileImg) Then
                            Try
                                Using img As Image = Image.FromFile(pathFileImg)
                                    ' Membuat bitmap baru berukuran mutlak 35x35 (membuang metadata DPI)
                                    Using bmpResized As New Bitmap(img, New Size(35, 35))
                                        g.DrawImage(bmpResized, drawX, posY)
                                    End Using
                                End Using
                            Catch
                                g.DrawRectangle(Pens.Black, drawX, posY, 35, 35)
                            End Try
                        Else
                            g.DrawRectangle(Pens.Black, drawX, posY, 35, 35)
                        End If

                        Dim n As String = row("nama_hero").ToString()
                        If n.Length > 8 Then n = n.Substring(0, 6) & ".."
                        g.DrawString(n, fontHero, Brushes.Black, drawX, posY + 38)

                        drawX += 50
                        cetakHeroIdx += 1
                    End While
                End If

                posY += 55
                cetakHeroIdx = 0
                cetakTierIdx += 1
            End While

            posY += 15
            cetakTierIdx = 0
            cetakLaneIdx += 1
        End While

        e.HasMorePages = False ' Proses pencetakan siap
    End Sub

    Private Sub ListView_Click(sender As Object, e As EventArgs) Handles lvJungle.Click, lvRoam.Click, lvExp.Click, lvGold.Click, lvMid.Click
        Dim lv = DirectCast(sender, ListView)
        If lv.SelectedItems.Count > 0 Then
            Dim id = CInt(lv.SelectedItems(0).Tag)
            Dim detail = DataModule.GetDetailHero(id)
            MsgBox($"NAMA HERO: {detail.Nama}{vbCrLf}ROLE: {detail.Role}{vbCrLf}DESKRIPSI: {detail.Deskripsi}", MsgBoxStyle.Information, "Detail")
        End If
    End Sub
End Class