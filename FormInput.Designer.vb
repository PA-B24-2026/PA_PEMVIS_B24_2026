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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.lblHero = New System.Windows.Forms.Label()
        Me.cbHero = New System.Windows.Forms.ComboBox()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.cbLane = New System.Windows.Forms.ComboBox()
        Me.lblTier = New System.Windows.Forms.Label()
        Me.cbTier = New System.Windows.Forms.ComboBox()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.lblGambar = New System.Windows.Forms.Label()
        Me.picHero = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.gbRole = New System.Windows.Forms.GroupBox()
        Me.cbSupport = New System.Windows.Forms.CheckBox()
        Me.cbMage = New System.Windows.Forms.CheckBox()
        Me.cbFighter = New System.Windows.Forms.CheckBox()
        Me.cbMarksman = New System.Windows.Forms.CheckBox()
        Me.cbTank = New System.Windows.Forms.CheckBox()
        Me.cbAssasin = New System.Windows.Forms.CheckBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.pnlKanan = New System.Windows.Forms.Panel()
        Me.pnlKananHeader = New System.Windows.Forms.Panel()
        Me.lblDaftar = New System.Windows.Forms.Label()
        Me.dgvHero = New System.Windows.Forms.DataGridView()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.pnlInput.SuspendLayout()
        Me.gbRole.SuspendLayout()
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKanan.SuspendLayout()
        Me.pnlKananHeader.SuspendLayout()
        CType(Me.dgvHero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(30, 41, 59)
        Me.pnlInput.Controls.Add(Me.LabelJudul)
        Me.pnlInput.Controls.Add(Me.lblHero)
        Me.pnlInput.Controls.Add(Me.cbHero)
        Me.pnlInput.Controls.Add(Me.lblLane)
        Me.pnlInput.Controls.Add(Me.cbLane)
        Me.pnlInput.Controls.Add(Me.lblTier)
        Me.pnlInput.Controls.Add(Me.cbTier)
        Me.pnlInput.Controls.Add(Me.lblDeskripsi)
        Me.pnlInput.Controls.Add(Me.txtDeskripsi)
        Me.pnlInput.Controls.Add(Me.lblGambar)
        Me.pnlInput.Controls.Add(Me.picHero)
        Me.pnlInput.Controls.Add(Me.btnBrowse)
        Me.pnlInput.Controls.Add(Me.gbRole)
        Me.pnlInput.Controls.Add(Me.btnTambah)
        Me.pnlInput.Controls.Add(Me.btnEdit)
        Me.pnlInput.Controls.Add(Me.btnHapus)
        Me.pnlInput.Controls.Add(Me.btnBersihkan)
        Me.pnlInput.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlInput.Location = New System.Drawing.Point(0, 0)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(350, 580)
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelJudul.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.LabelJudul.Location = New System.Drawing.Point(21, 25)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(147, 21)
        Me.LabelJudul.Text = "INPUT DATA TIER"
        '
        'lblHero
        '
        Me.lblHero.AutoSize = True
        Me.lblHero.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblHero.ForeColor = System.Drawing.Color.DarkGray
        Me.lblHero.Location = New System.Drawing.Point(22, 60)
        Me.lblHero.Text = "PILIH HERO"
        '
        'cbHero
        '
        Me.cbHero.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cbHero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHero.ForeColor = System.Drawing.Color.White
        Me.cbHero.Location = New System.Drawing.Point(25, 78)
        Me.cbHero.Size = New System.Drawing.Size(300, 23)
        Me.cbHero.Items.AddRange(New Object() {"Aamon", "Akai", "Aldous", "Alice", "Alpha", "Alucard", "Angela", "Argus", "Arlott", "Atlas", "Aulus", "Aurora", "Badang", "Balmond", "Bane", "Barats", "Baxia", "Beatrix", "Belerick", "Benedetta", "Brody", "Bruno", "Carmilla", "Cecilion", "Chang'e", "Chou", "Claude", "Clint", "Cyclops", "Diggie", "Dyroth", "Esmeralda", "Estes", "Eudora", "Fanny", "Faramis", "Floryn", "Franco", "Fredrinn", "Freya", "Gatotkaca", "Gloo", "Gord", "Granger", "Gusion", "Hanabi", "Hanzo", "Harith", "Harley", "Helcurt", "Hilda", "Hylos", "Irithel", "Ixia", "Jawhead", "Johnson", "Kadita", "Kagura", "Kaja", "Karina", "Karrie", "Khaleed", "Khufra", "Kimmy", "Lancelot", "Lapu-Lapu", "Layla", "Leomord", "Lesley", "Ling", "Lolita", "Lunox", "Luo Yi", "Lyria", "Martis", "Masha", "Mathilda", "Minotaur", "Minsitthar", "Miya", "Moskov", "Nana", "Natalia", "Natan", "Nolan", "Odette", "Paquito", "Pharsa", "Phoveus", "Popol Kupa", "Rafaela", "Roger", "Ruby", "Saber", "Selena", "Silvanna", "Sun", "Terizla", "Thamuz", "Tigreal", "Valir", "Vale", "Vexana", "Wanwan", "X.Borg", "Yavier", "Yi Sun-Shin", "Yve", "Yu Zhong", "Zilong"})
        '
        'lblLane & lblTier
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLane.ForeColor = System.Drawing.Color.DarkGray
        Me.lblLane.Location = New System.Drawing.Point(22, 115)
        Me.lblLane.Text = "LANE"

        Me.lblTier.AutoSize = True
        Me.lblTier.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTier.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTier.Location = New System.Drawing.Point(177, 115)
        Me.lblTier.Text = "TIER"
        '
        'cbLane & cbTier
        '
        Me.cbLane.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cbLane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLane.ForeColor = System.Drawing.Color.White
        Me.cbLane.Location = New System.Drawing.Point(25, 133)
        Me.cbLane.Size = New System.Drawing.Size(145, 23)

        Me.cbTier.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.cbTier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTier.ForeColor = System.Drawing.Color.White
        Me.cbTier.Location = New System.Drawing.Point(180, 133)
        Me.cbTier.Size = New System.Drawing.Size(145, 23)
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.AutoSize = True
        Me.lblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblDeskripsi.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDeskripsi.Location = New System.Drawing.Point(22, 170)
        Me.lblDeskripsi.Text = "DESKRIPSI HERO"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.txtDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeskripsi.ForeColor = System.Drawing.Color.White
        Me.txtDeskripsi.Location = New System.Drawing.Point(25, 188)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Size = New System.Drawing.Size(300, 60)
        '
        'lblGambar
        '
        Me.lblGambar.AutoSize = True
        Me.lblGambar.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblGambar.ForeColor = System.Drawing.Color.DarkGray
        Me.lblGambar.Location = New System.Drawing.Point(22, 260)
        Me.lblGambar.Text = "PREVIEW GAMBAR"
        '
        'picHero
        '
        Me.picHero.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.picHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHero.Location = New System.Drawing.Point(25, 278)
        Me.picHero.Size = New System.Drawing.Size(300, 80)
        Me.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(25, 365)
        Me.btnBrowse.Size = New System.Drawing.Size(120, 25)
        Me.btnBrowse.Text = "Browse Gambar"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'gbRole
        '
        Me.gbRole.ForeColor = System.Drawing.Color.DarkGray
        Me.gbRole.Controls.Add(Me.cbSupport)
        Me.gbRole.Controls.Add(Me.cbMage)
        Me.gbRole.Controls.Add(Me.cbFighter)
        Me.gbRole.Controls.Add(Me.cbMarksman)
        Me.gbRole.Controls.Add(Me.cbTank)
        Me.gbRole.Controls.Add(Me.cbAssasin)
        Me.gbRole.Location = New System.Drawing.Point(25, 400)
        Me.gbRole.Size = New System.Drawing.Size(300, 75)
        Me.gbRole.Text = "ROLE HERO"
        '
        'Checkboxes
        '
        Me.cbFighter.Location = New System.Drawing.Point(15, 20) : Me.cbFighter.Text = "Fighter" : Me.cbFighter.ForeColor = System.Drawing.Color.White : Me.cbFighter.AutoSize = True
        Me.cbAssasin.Location = New System.Drawing.Point(100, 20) : Me.cbAssasin.Text = "Assasin" : Me.cbAssasin.ForeColor = System.Drawing.Color.White : Me.cbAssasin.AutoSize = True
        Me.cbMarksman.Location = New System.Drawing.Point(190, 20) : Me.cbMarksman.Text = "Marksman" : Me.cbMarksman.ForeColor = System.Drawing.Color.White : Me.cbMarksman.AutoSize = True
        Me.cbTank.Location = New System.Drawing.Point(15, 45) : Me.cbTank.Text = "Tank" : Me.cbTank.ForeColor = System.Drawing.Color.White : Me.cbTank.AutoSize = True
        Me.cbMage.Location = New System.Drawing.Point(100, 45) : Me.cbMage.Text = "Mage" : Me.cbMage.ForeColor = System.Drawing.Color.White : Me.cbMage.AutoSize = True
        Me.cbSupport.Location = New System.Drawing.Point(190, 45) : Me.cbSupport.Text = "Support" : Me.cbSupport.ForeColor = System.Drawing.Color.White : Me.cbSupport.AutoSize = True
        '
        'Tombol Aksi (Kini 4 Butang sebaris - Lebar masing-masing 72px)
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(46, 204, 113)
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnTambah.ForeColor = System.Drawing.Color.Black
        Me.btnTambah.Location = New System.Drawing.Point(25, 500)
        Me.btnTambah.Size = New System.Drawing.Size(72, 35)
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = False

        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(101, 500)
        Me.btnEdit.Size = New System.Drawing.Size(72, 35)
        Me.btnEdit.Text = "Update"
        Me.btnEdit.UseVisualStyleBackColor = False

        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(177, 500)
        Me.btnHapus.Size = New System.Drawing.Size(72, 35)
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False

        Me.btnBersihkan.BackColor = System.Drawing.Color.FromArgb(149, 165, 166) ' Gray/Silver color for Clear
        Me.btnBersihkan.FlatAppearance.BorderSize = 0
        Me.btnBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBersihkan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBersihkan.ForeColor = System.Drawing.Color.White
        Me.btnBersihkan.Location = New System.Drawing.Point(253, 500)
        Me.btnBersihkan.Size = New System.Drawing.Size(72, 35)
        Me.btnBersihkan.Text = "Clear"
        Me.btnBersihkan.UseVisualStyleBackColor = False
        '
        'pnlKanan
        '
        Me.pnlKanan.Controls.Add(Me.dgvHero)
        Me.pnlKanan.Controls.Add(Me.pnlKananHeader)
        Me.pnlKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKanan.Location = New System.Drawing.Point(350, 0)
        Me.pnlKanan.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlKanan.Size = New System.Drawing.Size(650, 580)
        '
        'pnlKananHeader
        '
        Me.pnlKananHeader.BackColor = System.Drawing.Color.FromArgb(22, 33, 62)
        Me.pnlKananHeader.Controls.Add(Me.lblDaftar)
        Me.pnlKananHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKananHeader.Location = New System.Drawing.Point(20, 20)
        Me.pnlKananHeader.Size = New System.Drawing.Size(610, 40)
        '
        'lblDaftar
        '
        Me.lblDaftar.AutoSize = True
        Me.lblDaftar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDaftar.ForeColor = System.Drawing.Color.White
        Me.lblDaftar.Location = New System.Drawing.Point(15, 10)
        Me.lblDaftar.Text = "DAFTAR TIER LIST"
        '
        'dgvHero
        '
        Me.dgvHero.AllowUserToAddRows = False
        Me.dgvHero.AllowUserToDeleteRows = False
        Me.dgvHero.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.dgvHero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False
        Me.dgvHero.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHero.GridColor = System.Drawing.Color.FromArgb(51, 65, 85)
        Me.dgvHero.Location = New System.Drawing.Point(20, 60)
        Me.dgvHero.ReadOnly = True
        Me.dgvHero.Size = New System.Drawing.Size(610, 500)
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'FormInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.ClientSize = New System.Drawing.Size(1000, 580)
        Me.Controls.Add(Me.pnlKanan)
        Me.Controls.Add(Me.pnlInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Tier List"
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.gbRole.ResumeLayout(False)
        Me.gbRole.PerformLayout()
        CType(Me.picHero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKananHeader.ResumeLayout(False)
        Me.pnlKananHeader.PerformLayout()
        Me.pnlKanan.ResumeLayout(False)
        CType(Me.dgvHero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents pnlKanan As Panel
    Friend WithEvents pnlKananHeader As Panel
    Friend WithEvents lblDaftar As Label
    Friend WithEvents dgvHero As DataGridView
    Friend WithEvents errProvider As ErrorProvider
End Class