Public Class frmReferences

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim objFormFinal As New frmFinal
        If Me.radGood.Checked = True Then
            MsgBox("Investigate Further", MsgBoxStyle.Information, "Recommendation")
        Else
            MsgBox("Refuse the Loan", MsgBoxStyle.Information, "Recommendation")
        End If
        objFormFinal.Show()
        Me.Hide()

    End Sub
End Class