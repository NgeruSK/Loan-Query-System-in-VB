Public Class frmIncome

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim objFormEmployment As New frmEmployment()
        Dim objFormReferences As New frmReferences()
        Dim objFormFinal As New frmFinal
        If Me.radHigh.Checked = True Then
            MsgBox("Grant the Loan", MsgBoxStyle.Information, "Recommendation")
            objFormFinal.Show()
        ElseIf Me.radMedium.Checked = True Then
            objFormEmployment.Show()

        Else  'Me.radLow.Checked = True Then
            objFormReferences.Show()

        End If
        Me.Hide()

    End Sub
End Class