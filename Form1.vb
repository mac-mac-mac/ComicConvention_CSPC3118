Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCost.Text = ""
        txtGroupSize.Clear()
        txtGroupSize.Focus()
        radSuper.Checked = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCost.Text = ""
        txtGroupSize.Clear()
        txtGroupSize.Focus()
        radSuper.Checked = True
    End Sub
End Class
