<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTierList
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then components.Dispose()
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTierList))
        PanelAtas = New Panel()
        btnLoadData = New Button()
        btnKosongkan = New Button()
        btnPrint = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        lvJungle = New ListView()
        TabPage2 = New TabPage()
        lvRoam = New ListView()
        TabPage3 = New TabPage()
        lvExp = New ListView()
        TabPage4 = New TabPage()
        lvGold = New ListView()
        TabPage5 = New TabPage()
        lvMid = New ListView()
        PanelAtas.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelAtas
        ' 
        PanelAtas.BackColor = Color.FromArgb(CByte(22), CByte(33), CByte(62))
        PanelAtas.Controls.Add(btnLoadData)
        PanelAtas.Controls.Add(btnKosongkan)
        PanelAtas.Controls.Add(btnPrint)
        PanelAtas.Dock = DockStyle.Top
        PanelAtas.Location = New Point(0, 0)
        PanelAtas.Margin = New Padding(3, 4, 3, 4)
        PanelAtas.Name = "PanelAtas"
        PanelAtas.Size = New Size(971, 67)
        PanelAtas.TabIndex = 1
        ' 
        ' btnLoadData
        ' 
        btnLoadData.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnLoadData.FlatAppearance.BorderSize = 0
        btnLoadData.FlatStyle = FlatStyle.Flat
        btnLoadData.ForeColor = Color.Black
        btnLoadData.Location = New Point(314, 13)
        btnLoadData.Margin = New Padding(3, 4, 3, 4)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(114, 40)
        btnLoadData.TabIndex = 0
        btnLoadData.Text = "Load Data"
        btnLoadData.UseVisualStyleBackColor = False
        ' 
        ' btnKosongkan
        ' 
        btnKosongkan.BackColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnKosongkan.FlatAppearance.BorderSize = 0
        btnKosongkan.FlatStyle = FlatStyle.Flat
        btnKosongkan.ForeColor = Color.White
        btnKosongkan.Location = New Point(189, 13)
        btnKosongkan.Margin = New Padding(3, 4, 3, 4)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(114, 40)
        btnKosongkan.TabIndex = 1
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(14, 13)
        btnPrint.Margin = New Padding(3, 4, 3, 4)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(160, 40)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Cetak / Save PDF"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 67)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(971, 733)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        TabPage1.Controls.Add(lvJungle)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(963, 700)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Jungle"
        ' 
        ' lvJungle
        ' 
        lvJungle.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        lvJungle.BorderStyle = BorderStyle.None
        lvJungle.Dock = DockStyle.Fill
        lvJungle.ForeColor = Color.White
        lvJungle.Location = New Point(0, 0)
        lvJungle.Margin = New Padding(3, 4, 3, 4)
        lvJungle.Name = "lvJungle"
        lvJungle.Size = New Size(963, 700)
        lvJungle.TabIndex = 0
        lvJungle.Tag = ""
        lvJungle.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        TabPage2.Controls.Add(lvRoam)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(963, 700)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Roam"
        ' 
        ' lvRoam
        ' 
        lvRoam.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        lvRoam.BorderStyle = BorderStyle.None
        lvRoam.Dock = DockStyle.Fill
        lvRoam.ForeColor = Color.White
        lvRoam.Location = New Point(0, 0)
        lvRoam.Margin = New Padding(3, 4, 3, 4)
        lvRoam.Name = "lvRoam"
        lvRoam.Size = New Size(963, 700)
        lvRoam.TabIndex = 0
        lvRoam.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        TabPage3.Controls.Add(lvExp)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(963, 700)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Exp Lane"
        ' 
        ' lvExp
        ' 
        lvExp.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        lvExp.BorderStyle = BorderStyle.None
        lvExp.Dock = DockStyle.Fill
        lvExp.ForeColor = Color.White
        lvExp.Location = New Point(0, 0)
        lvExp.Margin = New Padding(3, 4, 3, 4)
        lvExp.Name = "lvExp"
        lvExp.Size = New Size(963, 700)
        lvExp.TabIndex = 0
        lvExp.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        TabPage4.Controls.Add(lvGold)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Margin = New Padding(3, 4, 3, 4)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(963, 700)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Gold Lane"
        ' 
        ' lvGold
        ' 
        lvGold.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        lvGold.BorderStyle = BorderStyle.None
        lvGold.Dock = DockStyle.Fill
        lvGold.ForeColor = Color.White
        lvGold.Location = New Point(0, 0)
        lvGold.Margin = New Padding(3, 4, 3, 4)
        lvGold.Name = "lvGold"
        lvGold.Size = New Size(963, 700)
        lvGold.TabIndex = 0
        lvGold.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage5
        ' 
        TabPage5.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        TabPage5.Controls.Add(lvMid)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Margin = New Padding(3, 4, 3, 4)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(963, 700)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Mid Lane"
        ' 
        ' lvMid
        ' 
        lvMid.BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        lvMid.BorderStyle = BorderStyle.None
        lvMid.Dock = DockStyle.Fill
        lvMid.ForeColor = Color.White
        lvMid.Location = New Point(0, 0)
        lvMid.Margin = New Padding(3, 4, 3, 4)
        lvMid.Name = "lvMid"
        lvMid.Size = New Size(963, 700)
        lvMid.TabIndex = 0
        lvMid.UseCompatibleStateImageBehavior = False
        ' 
        ' FormTierList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
        ClientSize = New Size(971, 800)
        Controls.Add(TabControl1)
        Controls.Add(PanelAtas)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormTierList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tier List Meta Viewer"
        PanelAtas.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelAtas As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents btnLoadData As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lvJungle As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lvRoam As ListView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lvExp As ListView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lvGold As ListView
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents lvMid As ListView
End Class