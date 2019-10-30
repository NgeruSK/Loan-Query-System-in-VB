Public Class frmEmployment

    Private Sub frmEmployment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim objFormEducation As New frmEducation()
        If Me.radYes.Checked = True Then
            strEmployed = "Yes"
            strUnemployed = "No"
        Else
            strEmployed = "No"
            strUnemployed = "Yes"
        End If
        objFormEducation.Show()
        Me.Hide()

    End Sub
End Class