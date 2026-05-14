<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTierList
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
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(600, 450)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lvJungle)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(592, 417)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Jungle"
        ' 
        ' lvJungle
        ' 
        lvJungle.Dock = DockStyle.Fill
        lvJungle.Location = New Point(0, 0)
        lvJungle.Name = "lvJungle"
        lvJungle.Size = New Size(592, 417)
        lvJungle.TabIndex = 0
        lvJungle.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lvRoam)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(592, 417)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Roam"
        ' 
        ' lvRoam
        ' 
        lvRoam.Dock = DockStyle.Fill
        lvRoam.Location = New Point(0, 0)
        lvRoam.Name = "lvRoam"
        lvRoam.Size = New Size(592, 417)
        lvRoam.TabIndex = 0
        lvRoam.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(lvExp)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(592, 417)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Exp Lane"
        ' 
        ' lvExp
        ' 
        lvExp.Dock = DockStyle.Fill
        lvExp.Location = New Point(0, 0)
        lvExp.Name = "lvExp"
        lvExp.Size = New Size(592, 417)
        lvExp.TabIndex = 0
        lvExp.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(lvGold)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(592, 417)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Gold Lane"
        ' 
        ' lvGold
        ' 
        lvGold.Dock = DockStyle.Fill
        lvGold.Location = New Point(0, 0)
        lvGold.Name = "lvGold"
        lvGold.Size = New Size(592, 417)
        lvGold.TabIndex = 0
        lvGold.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(lvMid)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(592, 417)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Mid Lane"
        ' 
        ' lvMid
        ' 
        lvMid.Dock = DockStyle.Fill
        lvMid.Location = New Point(0, 0)
        lvMid.Name = "lvMid"
        lvMid.Size = New Size(592, 417)
        lvMid.TabIndex = 0
        lvMid.UseCompatibleStateImageBehavior = False
        ' 
        ' FormTierList
        ' 
        ClientSize = New Size(600, 450)
        Controls.Add(TabControl1)
        Name = "FormTierList"
        Text = "Tier List Heroes"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

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