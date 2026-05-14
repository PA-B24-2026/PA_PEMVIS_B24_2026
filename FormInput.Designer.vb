<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlInput = New Panel()
        btnEdit = New Button()
        gbRole = New GroupBox()
        cbMage = New CheckBox()
        cbSupport = New CheckBox()
        cbTank = New CheckBox()
        cbFighter = New CheckBox()
        cbMarksman = New CheckBox()
        cbAssasin = New CheckBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtDeskripsi = New TextBox()
        cbLane = New ComboBox()
        cbTier = New ComboBox()
        clbHero = New CheckedListBox()
        picHero = New PictureBox()
        btnBrowse = New Button()
        btnTambah = New Button()
        btnHapus = New Button()
        chkAssasin = New CheckBox()
        chkFighter = New CheckBox()
        OpenFileDialog1 = New OpenFileDialog()
        dgvHero = New DataGridView()
        pnlInput.SuspendLayout()
        gbRole.SuspendLayout()
        CType(picHero, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvHero, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlInput
        ' 
        pnlInput.AutoSize = True
        pnlInput.Controls.Add(btnEdit)
        pnlInput.Controls.Add(gbRole)
        pnlInput.Controls.Add(Label4)
        pnlInput.Controls.Add(Label3)
        pnlInput.Controls.Add(Label2)
        pnlInput.Controls.Add(Label1)
        pnlInput.Controls.Add(txtDeskripsi)
        pnlInput.Controls.Add(cbLane)
        pnlInput.Controls.Add(cbTier)
        pnlInput.Controls.Add(clbHero)
        pnlInput.Controls.Add(picHero)
        pnlInput.Controls.Add(btnBrowse)
        pnlInput.Controls.Add(btnTambah)
        pnlInput.Controls.Add(btnHapus)
        pnlInput.Dock = DockStyle.Top
        pnlInput.Location = New Point(0, 0)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(800, 234)
        pnlInput.TabIndex = 1
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEdit.AutoSize = True
        btnEdit.Location = New Point(551, 201)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 30)
        btnEdit.TabIndex = 16
        btnEdit.Text = "Edit"
        ' 
        ' gbRole
        ' 
        gbRole.Anchor = AnchorStyles.Top
        gbRole.Controls.Add(cbMage)
        gbRole.Controls.Add(cbSupport)
        gbRole.Controls.Add(cbTank)
        gbRole.Controls.Add(cbFighter)
        gbRole.Controls.Add(cbMarksman)
        gbRole.Controls.Add(cbAssasin)
        gbRole.Location = New Point(548, 31)
        gbRole.Name = "gbRole"
        gbRole.Size = New Size(240, 162)
        gbRole.TabIndex = 15
        gbRole.TabStop = False
        gbRole.Text = "Role"
        ' 
        ' cbMage
        ' 
        cbMage.AutoSize = True
        cbMage.Location = New Point(139, 112)
        cbMage.Name = "cbMage"
        cbMage.Size = New Size(69, 24)
        cbMage.TabIndex = 5
        cbMage.Text = "Mage"
        cbMage.UseVisualStyleBackColor = True
        ' 
        ' cbSupport
        ' 
        cbSupport.AutoSize = True
        cbSupport.Location = New Point(139, 68)
        cbSupport.Name = "cbSupport"
        cbSupport.Size = New Size(84, 24)
        cbSupport.TabIndex = 4
        cbSupport.Text = "Support"
        cbSupport.UseVisualStyleBackColor = True
        ' 
        ' cbTank
        ' 
        cbTank.AutoSize = True
        cbTank.Location = New Point(139, 29)
        cbTank.Name = "cbTank"
        cbTank.Size = New Size(60, 24)
        cbTank.TabIndex = 3
        cbTank.Text = "Tank"
        cbTank.UseVisualStyleBackColor = True
        ' 
        ' cbFighter
        ' 
        cbFighter.AutoSize = True
        cbFighter.Location = New Point(20, 112)
        cbFighter.Name = "cbFighter"
        cbFighter.Size = New Size(77, 24)
        cbFighter.TabIndex = 2
        cbFighter.Text = "Fighter"
        cbFighter.UseVisualStyleBackColor = True
        ' 
        ' cbMarksman
        ' 
        cbMarksman.AutoSize = True
        cbMarksman.Location = New Point(20, 68)
        cbMarksman.Name = "cbMarksman"
        cbMarksman.Size = New Size(99, 24)
        cbMarksman.TabIndex = 1
        cbMarksman.Text = "Marksman"
        cbMarksman.UseVisualStyleBackColor = True
        ' 
        ' cbAssasin
        ' 
        cbAssasin.AutoSize = True
        cbAssasin.Location = New Point(20, 29)
        cbAssasin.Name = "cbAssasin"
        cbAssasin.Size = New Size(79, 24)
        cbAssasin.TabIndex = 0
        cbAssasin.Text = "Assasin"
        cbAssasin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Location = New Point(254, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 12
        Label4.Text = "Tier"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Location = New Point(127, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 20)
        Label3.TabIndex = 11
        Label3.Text = "Lane"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Location = New Point(127, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 10
        Label2.Text = "Deskripsi Hero"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.Location = New Point(18, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 23)
        Label1.TabIndex = 0
        Label1.Text = "Profil Hero"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.Anchor = AnchorStyles.Top
        txtDeskripsi.Location = New Point(127, 45)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(248, 52)
        txtDeskripsi.TabIndex = 1
        ' 
        ' cbLane
        ' 
        cbLane.Anchor = AnchorStyles.Top
        cbLane.Location = New Point(127, 139)
        cbLane.Name = "cbLane"
        cbLane.Size = New Size(121, 28)
        cbLane.TabIndex = 2
        ' 
        ' cbTier
        ' 
        cbTier.Anchor = AnchorStyles.Top
        cbTier.Location = New Point(254, 139)
        cbTier.Name = "cbTier"
        cbTier.Size = New Size(121, 28)
        cbTier.TabIndex = 3
        ' 
        ' clbHero
        ' 
        clbHero.Anchor = AnchorStyles.Top
        clbHero.FormattingEnabled = True
        clbHero.Items.AddRange(New Object() {"Aamon", "Akai", "Aldous", "Alice", "Alpha", "Alucard", "Angela", "Argus", "Arlott", "Atlas", "Aurora", "Badang", "Balmond", "Bane", "Barats", "Baxia", "Beatrix", "Belerick", "Benedetta", "Brody", "Bruno", "Carmilla", "Cecilion", "Chang'e", "Chip", "Chou", "Cici", "Claude", "Clint", "Cyclops", "Diggie", "Dyroth", "Esmeralda", "Estes", "Eudora", "Faramis", "Fanny", "Franco", "Fredrinn", "Freya", "Gatotkaca", "Gloo", "Gord", "Granger", "Grock", "Guinevere", "Gusion", "Hanabi", "Hanzo", "Harley", "Harith", "Hayabusa", "Helcurt", "Hilda", "Hylos", "Irithel", "Ixia", "Jawhead", "Johnson", "Joy", "Julian", "Kadita", "Kagura", "Kaja", "Karrie", "Karina", "Khaleed", "Khufra", "Kimmy", "Lancelot", "Lapu-Lapu", "Layla", "Leomord", "Lesley", "Ling", "Lolita", "Lunox", "Luo Yi", "Lylia", "Martis", "Masha", "Mathilda", "Melissa", "Minotaur", "Minsitthar", "Miya", "Moskov", "Nana", "Natalia", "Nathan", "Nolan", "Novaria", "Odette", "Paquito", "Pharsa", "Phoveus", "Popol & Kupa", "Rafaela", "Roger", "Ruby", "Saber", "Selena", "Silvanna", "Sun", "Terizla", "Thamuz", "Tigreal", "Uranus", "Vale", "Valentina", "Valir", "Vexana", "Wanwan", "Xavier", "X.Borg", "Yi Sun-shin", "Yin", "Yu Zhong", "Yve", "Zhask", "Zhuxin"})
        clbHero.Location = New Point(386, 31)
        clbHero.Name = "clbHero"
        clbHero.Size = New Size(150, 158)
        clbHero.TabIndex = 4
        ' 
        ' picHero
        ' 
        picHero.Anchor = AnchorStyles.Top
        picHero.BorderStyle = BorderStyle.FixedSingle
        picHero.Location = New Point(12, 45)
        picHero.Name = "picHero"
        picHero.Size = New Size(100, 122)
        picHero.SizeMode = PictureBoxSizeMode.StretchImage
        picHero.TabIndex = 6
        picHero.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Anchor = AnchorStyles.Top
        btnBrowse.Location = New Point(26, 173)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 26)
        btnBrowse.TabIndex = 7
        btnBrowse.Text = "Browse"
        ' 
        ' btnTambah
        ' 
        btnTambah.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnTambah.AutoSize = True
        btnTambah.Location = New Point(632, 201)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 30)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnHapus.AutoSize = True
        btnHapus.Location = New Point(713, 201)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 30)
        btnHapus.TabIndex = 9
        btnHapus.Text = "Hapus"
        ' 
        ' chkAssasin
        ' 
        chkAssasin.Location = New Point(0, 0)
        chkAssasin.Name = "chkAssasin"
        chkAssasin.Size = New Size(104, 24)
        chkAssasin.TabIndex = 0
        ' 
        ' chkFighter
        ' 
        chkFighter.Location = New Point(0, 0)
        chkFighter.Name = "chkFighter"
        chkFighter.Size = New Size(104, 24)
        chkFighter.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' dgvHero
        ' 
        dgvHero.AllowUserToOrderColumns = True
        dgvHero.AllowUserToResizeRows = False
        dgvHero.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHero.BackgroundColor = SystemColors.Control
        dgvHero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHero.Location = New Point(0, 232)
        dgvHero.MultiSelect = False
        dgvHero.Name = "dgvHero"
        dgvHero.RowHeadersVisible = False
        dgvHero.RowHeadersWidth = 51
        dgvHero.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHero.Size = New Size(800, 368)
        dgvHero.TabIndex = 2
        ' 
        ' FormInput
        ' 
        ClientSize = New Size(800, 600)
        Controls.Add(pnlInput)
        Controls.Add(dgvHero)
        Name = "FormInput"
        Text = "Hero Management"
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        gbRole.ResumeLayout(False)
        gbRole.PerformLayout()
        CType(picHero, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvHero, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlInput As Panel
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents cbLane As ComboBox
    Friend WithEvents cbTier As ComboBox
    Friend WithEvents picHero As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents clbHero As CheckedListBox
    Friend WithEvents chkAssasin As CheckBox
    Friend WithEvents chkFighter As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbRole As GroupBox
    Friend WithEvents cbMage As CheckBox
    Friend WithEvents cbSupport As CheckBox
    Friend WithEvents cbTank As CheckBox
    Friend WithEvents cbFighter As CheckBox
    Friend WithEvents cbMarksman As CheckBox
    Friend WithEvents cbAssasin As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgvHero As DataGridView
    Friend WithEvents btnEdit As Button
    ' ... sisanya bisa ditambahkan di Designer View VS
End Class