Public Class frmFinal
    'programmed by ngeru SK
    Private Sub btnRunAgain_Click(sender As Object, e As EventArgs) Handles btnRunAgain.Click
        Dim objFormIncome As New frmIncome()
        objFormIncome.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class