Public Class Main

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim objFormIncome As New frmIncome()
        objFormIncome.Show()
        Me.Hide()
    End Sub
End Class
