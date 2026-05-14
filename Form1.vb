Public Class Form1
    Private Sub btnTierList_Click(sender As Object, e As EventArgs) Handles btnTierList.Click
        Dim f As New FormTierList()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        Dim f As New FormInput()
        Me.Hide()
        f.ShowDialog()
        Me.Show()
    End Sub
End Class