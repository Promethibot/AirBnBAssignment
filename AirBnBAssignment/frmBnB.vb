Public Class frmBnB

    Const _cdecCostPerNight As Decimal = 79.0
    Dim intNumNights As Integer = 0
    Dim strNumNights As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        If Decimal.TryParse(strNumNights, intNumNights) Then
            lblError.Visible = False
            lblPrice.Text = "$" + (_cdecCostPerNight * intNumNights).ToString("N2")
            btnClear.Enabled = True
        Else
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblError.Visible = False
        lblPrice.Text = ""
        tbxUsIn.Text = ""
        btnClear.Enabled = False
        tbxUsIn.Select()
    End Sub

    Private Sub tbxUsIn_TextChanged(sender As Object, e As EventArgs) Handles tbxUsIn.TextChanged
        If tbxUsIn.TextLength > 0 Then
            btnCost.Enabled = True
            btnClear.Enabled = True
            strNumNights = tbxUsIn.Text
        End If
        If tbxUsIn.TextLength = 0 Then
            btnCost.Enabled = False
        End If
    End Sub

    Private Sub frmBnB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxUsIn.Select()
    End Sub
End Class
