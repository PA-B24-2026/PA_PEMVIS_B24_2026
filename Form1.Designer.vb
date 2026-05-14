<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTierList = New System.Windows.Forms.Button()
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnTierList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInputData, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill ' Mengisi seluruh layar
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(384, 261)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnTierList
        '
        Me.btnTierList.Anchor = System.Windows.Forms.AnchorStyles.None ' Tetap di tengah kotak
        Me.btnTierList.Location = New System.Drawing.Point(117, 35)
        Me.btnTierList.Name = "btnTierList"
        Me.btnTierList.Size = New System.Drawing.Size(150, 60)
        Me.btnTierList.TabIndex = 0
        Me.btnTierList.Text = "LIHAT TIER LIST"
        Me.btnTierList.UseVisualStyleBackColor = True
        '
        'btnInputData
        '
        Me.btnInputData.Anchor = System.Windows.Forms.AnchorStyles.None ' Tetap di tengah kotak
        Me.btnInputData.Location = New System.Drawing.Point(117, 165)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Size = New System.Drawing.Size(150, 60)
        Me.btnInputData.TabIndex = 1
        Me.btnInputData.Text = "MANAGE HERO"
        Me.btnInputData.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 261)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Landing Page"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnTierList As Button
    Friend WithEvents btnInputData As Button
End Class