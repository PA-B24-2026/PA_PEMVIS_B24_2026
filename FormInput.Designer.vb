<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInput))
        pnlInput = New Panel()
        LabelJudul = New Label()
        lblHero = New Label()
        cbHero = New ComboBox()
        lblLane = New Label()
        cbLane = New ComboBox()
        lblTier = New Label()
        cbTier = New ComboBox()
        lblDeskripsi = New Label()
        txtDeskripsi = New TextBox()
        lblGambar = New Label()
        picHero = New PictureBox()
        btnBrowse = New Button()
        gbRole = New GroupBox()
        cbSupport = New CheckBox()
        cbMage = New CheckBox()
        cbFighter = New CheckBox()
        cbMarksman = New CheckBox()
        cbTank = New CheckBox()
        cbAssasin = New CheckBox()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        pnlKanan = New Panel()
        dgvHero = New DataGridView()
        pnlKananHeader = New Panel()
        lblDaftar = New Label()
        errProvider = New ErrorProvider(components)
        pnlInput.SuspendLayout()
        CType(picHero, ComponentModel.ISupportInitialize).BeginInit()
        gbRole.SuspendLayout()
        pnlKanan.SuspendLayout()
        CType(dgvHero, ComponentModel.ISupportInitialize).BeginInit()
        pnlKananHeader.SuspendLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        pnlInput.Controls.Add(LabelJudul)
        pnlInput.Controls.Add(lblHero)
        pnlInput.Controls.Add(cbHero)
        pnlInput.Controls.Add(lblLane)
        pnlInput.Controls.Add(cbLane)
        pnlInput.Controls.Add(lblTier)
        pnlInput.Controls.Add(cbTier)
        pnlInput.Controls.Add(lblDeskripsi)
        pnlInput.Controls.Add(txtDeskripsi)
        pnlInput.Controls.Add(lblGambar)
        pnlInput.Controls.Add(picHero)
        pnlInput.Controls.Add(btnBrowse)
        pnlInput.Controls.Add(gbRole)
        pnlInput.Controls.Add(btnTambah)
        pnlInput.Controls.Add(btnEdit)
        pnlInput.Controls.Add(btnHapus)
        pnlInput.Dock = DockStyle.Left
        pnlInput.Location = New Point(0, 0)
        pnlInput.Margin = New Padding(3, 4, 3, 4)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(400, 773)
        pnlInput.TabIndex = 0
        ' 
        ' LabelJudul
        ' 
        LabelJudul.AutoSize = True
        LabelJudul.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        LabelJudul.ForeColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        LabelJudul.Location = New Point(24, 33)
        LabelJudul.Name = "LabelJudul"
        LabelJudul.Size = New Size(224, 28)
        LabelJudul.TabIndex = 0
        LabelJudul.Text = "INPUT DATA TIER LIST"
        ' 
        ' lblHero
        ' 
        lblHero.AutoSize = True
        lblHero.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblHero.ForeColor = Color.DarkGray
        lblHero.Location = New Point(25, 80)
        lblHero.Name = "lblHero"
        lblHero.Size = New Size(86, 19)
        lblHero.TabIndex = 1
        lblHero.Text = "PILIH HERO"
        ' 
        ' cbHero
        ' 
        cbHero.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        cbHero.DropDownStyle = ComboBoxStyle.DropDownList
        cbHero.FlatStyle = FlatStyle.Flat
        cbHero.ForeColor = Color.White
        cbHero.Items.AddRange(New Object() {"Aamon", "Akai", "Aldous", "Alice", "Alpha", "Alucard", "Angela", "Argus", "Arlott", "Atlas", "Aulus", "Aurora", "Badang", "Balmond", "Bane", "Barats", "Baxia", "Beatrix", "Belerick", "Benedetta", "Brody", "Bruno", "Carmilla", "Cecilion", "Chang'e", "Chou", "Claude", "Clint", "Cyclops", "Diggie", "Dyroth", "Esmeralda", "Estes", "Eudora", "Fanny", "Faramis", "Floryn", "Franco", "Fredrinn", "Freya", "Gatotkaca", "Gloo", "Gord", "Granger", "Gusion", "Hanabi", "Hanzo", "Harith", "Harley", "Helcurt", "Hilda", "Hylos", "Irithel", "Ixia", "Jawhead", "Johnson", "Kadita", "Kagura", "Kaja", "Karina", "Karrie", "Khaleed", "Khufra", "Kimmy", "Lancelot", "Lapu-Lapu", "Layla", "Leomord", "Lesley", "Ling", "Lolita", "Lunox", "Luo Yi", "Lyria", "Martis", "Masha", "Mathilda", "Minotaur", "Minsitthar", "Miya", "Moskov", "Nana", "Natalia", "Natan", "Nolan", "Odette", "Paquito", "Pharsa", "Phoveus", "Popol Kupa", "Rafaela", "Roger", "Ruby", "Saber", "Selena", "Silvanna", "Sun", "Terizla", "Thamuz", "Tigreal", "Valir", "Vale", "Vexana", "Wanwan", "X.Borg", "Yavier", "Yi Sun-Shin", "Yve", "Yu Zhong", "Zilong"})
        cbHero.Location = New Point(29, 104)
        cbHero.Margin = New Padding(3, 4, 3, 4)
        cbHero.Name = "cbHero"
        cbHero.Size = New Size(342, 28)
        cbHero.TabIndex = 2
        ' 
        ' lblLane
        ' 
        lblLane.AutoSize = True
        lblLane.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblLane.ForeColor = Color.DarkGray
        lblLane.Location = New Point(25, 153)
        lblLane.Name = "lblLane"
        lblLane.Size = New Size(44, 19)
        lblLane.TabIndex = 3
        lblLane.Text = "LANE"
        ' 
        ' cbLane
        ' 
        cbLane.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        cbLane.DropDownStyle = ComboBoxStyle.DropDownList
        cbLane.FlatStyle = FlatStyle.Flat
        cbLane.ForeColor = Color.White
        cbLane.Location = New Point(29, 177)
        cbLane.Margin = New Padding(3, 4, 3, 4)
        cbLane.Name = "cbLane"
        cbLane.Size = New Size(165, 28)
        cbLane.TabIndex = 4
        ' 
        ' lblTier
        ' 
        lblTier.AutoSize = True
        lblTier.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblTier.ForeColor = Color.DarkGray
        lblTier.Location = New Point(202, 153)
        lblTier.Name = "lblTier"
        lblTier.Size = New Size(37, 19)
        lblTier.TabIndex = 5
        lblTier.Text = "TIER"
        ' 
        ' cbTier
        ' 
        cbTier.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        cbTier.DropDownStyle = ComboBoxStyle.DropDownList
        cbTier.FlatStyle = FlatStyle.Flat
        cbTier.ForeColor = Color.White
        cbTier.Location = New Point(206, 177)
        cbTier.Margin = New Padding(3, 4, 3, 4)
        cbTier.Name = "cbTier"
        cbTier.Size = New Size(165, 28)
        cbTier.TabIndex = 6
        ' 
        ' lblDeskripsi
        ' 
        lblDeskripsi.AutoSize = True
        lblDeskripsi.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblDeskripsi.ForeColor = Color.DarkGray
        lblDeskripsi.Location = New Point(25, 227)
        lblDeskripsi.Name = "lblDeskripsi"
        lblDeskripsi.Size = New Size(119, 19)
        lblDeskripsi.TabIndex = 7
        lblDeskripsi.Text = "DESKRIPSI HERO"
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.ForeColor = Color.White
        txtDeskripsi.Location = New Point(29, 251)
        txtDeskripsi.Margin = New Padding(3, 4, 3, 4)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(343, 79)
        txtDeskripsi.TabIndex = 8
        ' 
        ' lblGambar
        ' 
        lblGambar.AutoSize = True
        lblGambar.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblGambar.ForeColor = Color.DarkGray
        lblGambar.Location = New Point(130, 478)
        lblGambar.Name = "lblGambar"
        lblGambar.Size = New Size(133, 19)
        lblGambar.TabIndex = 9
        lblGambar.Text = "PREVIEW GAMBAR"
        ' 
        ' picHero
        ' 
        picHero.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        picHero.BorderStyle = BorderStyle.FixedSingle
        picHero.Location = New Point(142, 504)
        picHero.Margin = New Padding(3, 4, 3, 4)
        picHero.Name = "picHero"
        picHero.Size = New Size(109, 106)
        picHero.SizeMode = PictureBoxSizeMode.Zoom
        picHero.TabIndex = 10
        picHero.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 8.0F)
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(128, 618)
        btnBrowse.Margin = New Padding(3, 4, 3, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(137, 33)
        btnBrowse.TabIndex = 11
        btnBrowse.Text = "Browse Gambar"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' gbRole
        ' 
        gbRole.Controls.Add(cbSupport)
        gbRole.Controls.Add(cbMage)
        gbRole.Controls.Add(cbFighter)
        gbRole.Controls.Add(cbMarksman)
        gbRole.Controls.Add(cbTank)
        gbRole.Controls.Add(cbAssasin)
        gbRole.ForeColor = Color.DarkGray
        gbRole.Location = New Point(29, 353)
        gbRole.Margin = New Padding(3, 4, 3, 4)
        gbRole.Name = "gbRole"
        gbRole.Padding = New Padding(3, 4, 3, 4)
        gbRole.Size = New Size(343, 100)
        gbRole.TabIndex = 12
        gbRole.TabStop = False
        gbRole.Text = "ROLE HERO"
        ' 
        ' cbSupport
        ' 
        cbSupport.AutoSize = True
        cbSupport.ForeColor = Color.White
        cbSupport.Location = New Point(217, 60)
        cbSupport.Margin = New Padding(3, 4, 3, 4)
        cbSupport.Name = "cbSupport"
        cbSupport.Size = New Size(84, 24)
        cbSupport.TabIndex = 0
        cbSupport.Text = "Support"
        ' 
        ' cbMage
        ' 
        cbMage.AutoSize = True
        cbMage.ForeColor = Color.White
        cbMage.Location = New Point(114, 60)
        cbMage.Margin = New Padding(3, 4, 3, 4)
        cbMage.Name = "cbMage"
        cbMage.Size = New Size(69, 24)
        cbMage.TabIndex = 1
        cbMage.Text = "Mage"
        ' 
        ' cbFighter
        ' 
        cbFighter.AutoSize = True
        cbFighter.ForeColor = Color.White
        cbFighter.Location = New Point(17, 27)
        cbFighter.Margin = New Padding(3, 4, 3, 4)
        cbFighter.Name = "cbFighter"
        cbFighter.Size = New Size(77, 24)
        cbFighter.TabIndex = 2
        cbFighter.Text = "Fighter"
        ' 
        ' cbMarksman
        ' 
        cbMarksman.AutoSize = True
        cbMarksman.ForeColor = Color.White
        cbMarksman.Location = New Point(217, 27)
        cbMarksman.Margin = New Padding(3, 4, 3, 4)
        cbMarksman.Name = "cbMarksman"
        cbMarksman.Size = New Size(99, 24)
        cbMarksman.TabIndex = 3
        cbMarksman.Text = "Marksman"
        ' 
        ' cbTank
        ' 
        cbTank.AutoSize = True
        cbTank.ForeColor = Color.White
        cbTank.Location = New Point(17, 60)
        cbTank.Margin = New Padding(3, 4, 3, 4)
        cbTank.Name = "cbTank"
        cbTank.Size = New Size(60, 24)
        cbTank.TabIndex = 4
        cbTank.Text = "Tank"
        ' 
        ' cbAssasin
        ' 
        cbAssasin.AutoSize = True
        cbAssasin.ForeColor = Color.White
        cbAssasin.Location = New Point(114, 27)
        cbAssasin.Margin = New Padding(3, 4, 3, 4)
        cbAssasin.Name = "cbAssasin"
        cbAssasin.Size = New Size(79, 24)
        cbAssasin.TabIndex = 5
        cbAssasin.Text = "Assasin"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnTambah.ForeColor = Color.Black
        btnTambah.Location = New Point(29, 677)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(109, 47)
        btnTambah.TabIndex = 13
        btnTambah.Text = "Simpan"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(145, 677)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(109, 47)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Update"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(263, 677)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(109, 47)
        btnHapus.TabIndex = 15
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' pnlKanan
        ' 
        pnlKanan.Controls.Add(dgvHero)
        pnlKanan.Controls.Add(pnlKananHeader)
        pnlKanan.Dock = DockStyle.Fill
        pnlKanan.Location = New Point(400, 0)
        pnlKanan.Margin = New Padding(3, 4, 3, 4)
        pnlKanan.Name = "pnlKanan"
        pnlKanan.Padding = New Padding(23, 27, 23, 27)
        pnlKanan.Size = New Size(743, 773)
        pnlKanan.TabIndex = 0
        ' 
        ' dgvHero
        ' 
        dgvHero.AllowUserToAddRows = False
        dgvHero.AllowUserToDeleteRows = False
        dgvHero.BackgroundColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        dgvHero.BorderStyle = BorderStyle.None
        dgvHero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvHero.DefaultCellStyle = DataGridViewCellStyle1
        dgvHero.Dock = DockStyle.Fill
        dgvHero.GridColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        dgvHero.Location = New Point(23, 80)
        dgvHero.Margin = New Padding(3, 4, 3, 4)
        dgvHero.Name = "dgvHero"
        dgvHero.ReadOnly = True
        dgvHero.RowHeadersWidth = 51
        dgvHero.Size = New Size(697, 666)
        dgvHero.TabIndex = 0
        ' 
        ' pnlKananHeader
        ' 
        pnlKananHeader.BackColor = Color.FromArgb(CByte(22), CByte(33), CByte(62))
        pnlKananHeader.Controls.Add(lblDaftar)
        pnlKananHeader.Dock = DockStyle.Top
        pnlKananHeader.Location = New Point(23, 27)
        pnlKananHeader.Margin = New Padding(3, 4, 3, 4)
        pnlKananHeader.Name = "pnlKananHeader"
        pnlKananHeader.Size = New Size(697, 53)
        pnlKananHeader.TabIndex = 1
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblDaftar.ForeColor = Color.White
        lblDaftar.Location = New Point(17, 13)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(155, 23)
        lblDaftar.TabIndex = 0
        lblDaftar.Text = "DAFTAR TIER LIST"
        ' 
        ' errProvider
        ' 
        errProvider.ContainerControl = Me
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        ClientSize = New Size(1143, 773)
        Controls.Add(pnlKanan)
        Controls.Add(pnlInput)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormInput"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Tier List"
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(picHero, ComponentModel.ISupportInitialize).EndInit()
        gbRole.ResumeLayout(False)
        gbRole.PerformLayout()
        pnlKanan.ResumeLayout(False)
        CType(dgvHero, ComponentModel.ISupportInitialize).EndInit()
        pnlKananHeader.ResumeLayout(False)
        pnlKananHeader.PerformLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlInput As Panel
    Friend WithEvents LabelJudul As Label
    Friend WithEvents lblHero As Label
    Friend WithEvents cbHero As ComboBox
    Friend WithEvents lblLane As Label
    Friend WithEvents lblTier As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents lblGambar As Label
    Friend WithEvents cbLane As ComboBox
    Friend WithEvents cbTier As ComboBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents picHero As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents gbRole As GroupBox
    Friend WithEvents cbSupport As CheckBox
    Friend WithEvents cbMage As CheckBox
    Friend WithEvents cbFighter As CheckBox
    Friend WithEvents cbMarksman As CheckBox
    Friend WithEvents cbTank As CheckBox
    Friend WithEvents cbAssasin As CheckBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents pnlKanan As Panel
    Friend WithEvents pnlKananHeader As Panel
    Friend WithEvents lblDaftar As Label
    Friend WithEvents dgvHero As DataGridView
    Friend WithEvents errProvider As ErrorProvider
End Class