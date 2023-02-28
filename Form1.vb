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

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuper As Decimal = 380D
        Dim decAuto As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(txtGroupSize.Text) Then

            intGroup = Convert.ToInt32(txtGroupSize.Text)

            If intGroup > 0 And intGroup < 20 Then

                If radSuper.Checked Then
                    decRegistration = decSuper
                ElseIf radAuto.Checked Then
                    decRegistration = decAuto
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblCost.Text = decTotalCost.ToString("C")

            Else

                MsgBox("Please enter a positive integer between 1 and 20", , "Invalid Number Error")

            End If

        Else

            MsgBox("Please enter a positive integer between 1 and 20", , "Invalid Entry Error")

        End If
    End Sub
End Class
