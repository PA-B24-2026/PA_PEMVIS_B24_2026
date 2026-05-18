Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Muat statistik saat dashboard dibuka
        LoadDashboardStats()
    End Sub

    ' Fungsi untuk mengupdate angka di Stat Cards dari Database
    Public Sub LoadDashboardStats()
        Try
            DataModule.OpenConnection()

            ' Hitung Total Hero di tb_hero
            Dim cmdHero = DataModule.CreateCommand("SELECT COUNT(*) FROM tb_hero")
            Dim countHero = Convert.ToInt32(cmdHero.ExecuteScalar())
            lblTotalHero.Text = countHero.ToString()

            ' Hitung Total Hero yang masuk Tier List
            Dim cmdTier = DataModule.CreateCommand("SELECT COUNT(*) FROM tb_tierlist")
            Dim countTier = Convert.ToInt32(cmdTier.ExecuteScalar())
            lblTotalTier.Text = countTier.ToString()

        Catch ex As Exception
            ' Jika gagal connect database, set jadi 0
            lblTotalHero.Text = "0"
            lblTotalTier.Text = "0"
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    ' --- TOMBOL NAVIGASI SIDEBAR ---

    Private Sub btnNavManage_Click(sender As Object, e As EventArgs) Handles btnNavManage.Click
        Dim f As New FormInput()
        Me.Hide()
        f.ShowDialog()

        ' Refresh statistik dashboard setelah user kembali dari menu kelola data (barangkali ada data baru)
        LoadDashboardStats()
        Me.Show()
    End Sub

    Private Sub btnNavTierList_Click(sender As Object, e As EventArgs) Handles btnNavTierList.Click
        Dim f As New FormTierList()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    ' Tombol Dashboard (Hanya memberi tahu bahwa user sedang di halaman ini)
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        LoadDashboardStats()
    End Sub

End Class