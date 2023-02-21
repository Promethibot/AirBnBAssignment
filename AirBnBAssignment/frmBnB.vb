Public Class frmBnB

    Const _cdecNightlyCost As Decimal = 79.0
    Dim nightsTotal As Decimal = 0.00

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        If Decimal.TryParse(tbxUsIn.Text, nightsTotal) Then
            lblError.Visible = False
            lblPrice.Text = "$" + (_cdecNightlyCost * nightsTotal).ToString("N2")
            btnClear.Enabled = true
        Else
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblError.Visible = False
        lblPrice.Text = ""
        tbxUsIn.Text = ""
        btnClear.Enabled = False
    End Sub

    Private Sub tbxUsIn_TextChanged(sender As Object, e As EventArgs) Handles tbxUsIn.TextChanged
        If tbxUsIn.TextLength > 0 Then
            btnCost.Enabled = True
            btnClear.Enabled = True
        End If
        If tbxUsIn.TextLength = 0 Then
            btnCost.Enabled = False
        End If
    End Sub
End Class
