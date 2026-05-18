<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pnlSidebar = New Panel()
        LabelNavigasi = New Label()
        btnNavTierList = New Button()
        btnNavManage = New Button()
        btnNavDashboard = New Button()
        pnlMain = New Panel()
        pnlCard3 = New Panel()
        pnlAccent3 = New Panel()
        lblLane = New Label()
        LabelC3 = New Label()
        pnlCard2 = New Panel()
        pnlAccent2 = New Panel()
        lblTotalTier = New Label()
        LabelC2 = New Label()
        pnlCard1 = New Panel()
        pnlAccent1 = New Panel()
        lblTotalHero = New Label()
        LabelC1 = New Label()
        LabelSubtitle = New Label()
        LabelTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlCard3.SuspendLayout()
        pnlCard2.SuspendLayout()
        pnlCard1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(22), CByte(33), CByte(62))
        pnlSidebar.Controls.Add(LabelNavigasi)
        pnlSidebar.Controls.Add(btnNavTierList)
        pnlSidebar.Controls.Add(btnNavManage)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(3, 4, 3, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(251, 747)
        pnlSidebar.TabIndex = 1
        ' 
        ' LabelNavigasi
        ' 
        LabelNavigasi.AutoSize = True
        LabelNavigasi.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        LabelNavigasi.ForeColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        LabelNavigasi.Location = New Point(23, 40)
        LabelNavigasi.Name = "LabelNavigasi"
        LabelNavigasi.Size = New Size(89, 23)
        LabelNavigasi.TabIndex = 0
        LabelNavigasi.Text = "NAVIGASI"
        ' 
        ' btnNavTierList
        ' 
        btnNavTierList.BackColor = Color.Transparent
        btnNavTierList.FlatAppearance.BorderSize = 0
        btnNavTierList.FlatStyle = FlatStyle.Flat
        btnNavTierList.Font = New Font("Segoe UI", 10.0F)
        btnNavTierList.ForeColor = Color.Gainsboro
        btnNavTierList.Location = New Point(0, 227)
        btnNavTierList.Margin = New Padding(3, 4, 3, 4)
        btnNavTierList.Name = "btnNavTierList"
        btnNavTierList.Padding = New Padding(23, 0, 0, 0)
        btnNavTierList.Size = New Size(251, 60)
        btnNavTierList.TabIndex = 1
        btnNavTierList.Text = "Tier List View"
        btnNavTierList.TextAlign = ContentAlignment.MiddleLeft
        btnNavTierList.UseVisualStyleBackColor = False
        ' 
        ' btnNavManage
        ' 
        btnNavManage.BackColor = Color.Transparent
        btnNavManage.FlatAppearance.BorderSize = 0
        btnNavManage.FlatStyle = FlatStyle.Flat
        btnNavManage.Font = New Font("Segoe UI", 10.0F)
        btnNavManage.ForeColor = Color.Gainsboro
        btnNavManage.Location = New Point(0, 167)
        btnNavManage.Margin = New Padding(3, 4, 3, 4)
        btnNavManage.Name = "btnNavManage"
        btnNavManage.Padding = New Padding(23, 0, 0, 0)
        btnNavManage.Size = New Size(251, 60)
        btnNavManage.TabIndex = 2
        btnNavManage.Text = "Manage Hero"
        btnNavManage.TextAlign = ContentAlignment.MiddleLeft
        btnNavManage.UseVisualStyleBackColor = False
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnNavDashboard.ForeColor = Color.White
        btnNavDashboard.Location = New Point(0, 107)
        btnNavDashboard.Margin = New Padding(3, 4, 3, 4)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Padding = New Padding(23, 0, 0, 0)
        btnNavDashboard.Size = New Size(251, 60)
        btnNavDashboard.TabIndex = 3
        btnNavDashboard.Text = "Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        pnlMain.Controls.Add(pnlCard3)
        pnlMain.Controls.Add(pnlCard2)
        pnlMain.Controls.Add(pnlCard1)
        pnlMain.Controls.Add(LabelSubtitle)
        pnlMain.Controls.Add(LabelTitle)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(251, 0)
        pnlMain.Margin = New Padding(3, 4, 3, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(835, 747)
        pnlMain.TabIndex = 0
        ' 
        ' pnlCard3
        ' 
        pnlCard3.BackColor = Color.FromArgb(CByte(15), CByte(52), CByte(96))
        pnlCard3.Controls.Add(pnlAccent3)
        pnlCard3.Controls.Add(lblLane)
        pnlCard3.Controls.Add(LabelC3)
        pnlCard3.Location = New Point(509, 213)
        pnlCard3.Margin = New Padding(3, 4, 3, 4)
        pnlCard3.Name = "pnlCard3"
        pnlCard3.Size = New Size(206, 133)
        pnlCard3.TabIndex = 0
        ' 
        ' pnlAccent3
        ' 
        pnlAccent3.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        pnlAccent3.Dock = DockStyle.Left
        pnlAccent3.Location = New Point(0, 0)
        pnlAccent3.Margin = New Padding(3, 4, 3, 4)
        pnlAccent3.Name = "pnlAccent3"
        pnlAccent3.Size = New Size(6, 133)
        pnlAccent3.TabIndex = 0
        ' 
        ' lblLane
        ' 
        lblLane.AutoSize = True
        lblLane.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblLane.ForeColor = Color.White
        lblLane.Location = New Point(23, 20)
        lblLane.Name = "lblLane"
        lblLane.Size = New Size(46, 54)
        lblLane.TabIndex = 1
        lblLane.Text = "5"
        ' 
        ' LabelC3
        ' 
        LabelC3.AutoSize = True
        LabelC3.Font = New Font("Segoe UI", 10.0F)
        LabelC3.ForeColor = Color.DarkGray
        LabelC3.Location = New Point(27, 87)
        LabelC3.Name = "LabelC3"
        LabelC3.Size = New Size(91, 23)
        LabelC3.TabIndex = 2
        LabelC3.Text = "Lane Roles"
        ' 
        ' pnlCard2
        ' 
        pnlCard2.BackColor = Color.FromArgb(CByte(15), CByte(52), CByte(96))
        pnlCard2.Controls.Add(pnlAccent2)
        pnlCard2.Controls.Add(lblTotalTier)
        pnlCard2.Controls.Add(LabelC2)
        pnlCard2.Location = New Point(280, 213)
        pnlCard2.Margin = New Padding(3, 4, 3, 4)
        pnlCard2.Name = "pnlCard2"
        pnlCard2.Size = New Size(206, 133)
        pnlCard2.TabIndex = 1
        ' 
        ' pnlAccent2
        ' 
        pnlAccent2.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        pnlAccent2.Dock = DockStyle.Left
        pnlAccent2.Location = New Point(0, 0)
        pnlAccent2.Margin = New Padding(3, 4, 3, 4)
        pnlAccent2.Name = "pnlAccent2"
        pnlAccent2.Size = New Size(6, 133)
        pnlAccent2.TabIndex = 0
        ' 
        ' lblTotalTier
        ' 
        lblTotalTier.AutoSize = True
        lblTotalTier.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblTotalTier.ForeColor = Color.White
        lblTotalTier.Location = New Point(23, 20)
        lblTotalTier.Name = "lblTotalTier"
        lblTotalTier.Size = New Size(46, 54)
        lblTotalTier.TabIndex = 1
        lblTotalTier.Text = "0"
        ' 
        ' LabelC2
        ' 
        LabelC2.AutoSize = True
        LabelC2.Font = New Font("Segoe UI", 10.0F)
        LabelC2.ForeColor = Color.DarkGray
        LabelC2.Location = New Point(27, 87)
        LabelC2.Name = "LabelC2"
        LabelC2.Size = New Size(162, 23)
        LabelC2.TabIndex = 2
        LabelC2.Text = "Hero dalam Tier List"
        ' 
        ' pnlCard1
        ' 
        pnlCard1.BackColor = Color.FromArgb(CByte(15), CByte(52), CByte(96))
        pnlCard1.Controls.Add(pnlAccent1)
        pnlCard1.Controls.Add(lblTotalHero)
        pnlCard1.Controls.Add(LabelC1)
        pnlCard1.Location = New Point(51, 213)
        pnlCard1.Margin = New Padding(3, 4, 3, 4)
        pnlCard1.Name = "pnlCard1"
        pnlCard1.Size = New Size(206, 133)
        pnlCard1.TabIndex = 2
        ' 
        ' pnlAccent1
        ' 
        pnlAccent1.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        pnlAccent1.Dock = DockStyle.Left
        pnlAccent1.Location = New Point(0, 0)
        pnlAccent1.Margin = New Padding(3, 4, 3, 4)
        pnlAccent1.Name = "pnlAccent1"
        pnlAccent1.Size = New Size(6, 133)
        pnlAccent1.TabIndex = 0
        ' 
        ' lblTotalHero
        ' 
        lblTotalHero.AutoSize = True
        lblTotalHero.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        lblTotalHero.ForeColor = Color.White
        lblTotalHero.Location = New Point(23, 20)
        lblTotalHero.Name = "lblTotalHero"
        lblTotalHero.Size = New Size(46, 54)
        lblTotalHero.TabIndex = 1
        lblTotalHero.Text = "0"
        ' 
        ' LabelC1
        ' 
        LabelC1.AutoSize = True
        LabelC1.Font = New Font("Segoe UI", 10.0F)
        LabelC1.ForeColor = Color.DarkGray
        LabelC1.Location = New Point(27, 87)
        LabelC1.Name = "LabelC1"
        LabelC1.Size = New Size(164, 23)
        LabelC1.TabIndex = 2
        LabelC1.Text = "Total Hero Database"
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Font = New Font("Segoe UI", 12.0F)
        LabelSubtitle.ForeColor = Color.DarkGray
        LabelSubtitle.Location = New Point(51, 120)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(468, 28)
        LabelSubtitle.TabIndex = 3
        LabelSubtitle.Text = "Advanced hero meta management and visualization."
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        LabelTitle.Location = New Point(46, 53)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(477, 54)
        LabelTitle.TabIndex = 4
        LabelTitle.Text = "MLBB TIER LIST SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1086, 747)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard System"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlCard3.ResumeLayout(False)
        pnlCard3.PerformLayout()
        pnlCard2.ResumeLayout(False)
        pnlCard2.PerformLayout()
        pnlCard1.ResumeLayout(False)
        pnlCard1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents LabelNavigasi As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavManage As Button
    Friend WithEvents btnNavTierList As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblTotalHero As Label
    Friend WithEvents LabelC1 As Label
    Friend WithEvents pnlAccent1 As Panel
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblTotalTier As Label
    Friend WithEvents LabelC2 As Label
    Friend WithEvents pnlAccent2 As Panel
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblLane As Label
    Friend WithEvents LabelC3 As Label
    Friend WithEvents pnlAccent3 As Panel
End Class