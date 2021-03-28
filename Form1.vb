Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim principal As Integer
        Dim period As Integer
        Dim interestRate As Decimal
        Dim finalValue As Decimal

        principal = txtPrincipalValue.Text
        period = txtPeriod.Text
        interestRate = txtInterestRate.Text

        finalValue = principal * ((1 + (interestRate / 100)) ^ period)

        lblFinalValueAns.Text = finalValue

        Dim myFormat As String = "$#,##0.00"

        lblFinalValueAns.Text = Format(finalValue, myFormat)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
