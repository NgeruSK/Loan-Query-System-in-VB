Public Class frmEducation

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objFormFinal As New frmFinal()

        If strEmployed = "Yes" Then
            If Me.radHigh.Checked = True Then
                MsgBox("Grant the loan", MsgBoxStyle.Information, "Recommendation")
            Else
                MsgBox("Investigate Further", MsgBoxStyle.Information, "Recommendation")
            End If
        Else 'handles unemployment
            If Me.radHigh.Checked = True Then
                MsgBox("Investigate Further", MsgBoxStyle.Information, "Recommendation")
            Else
                MsgBox("Refuse the loan", MsgBoxStyle.Information, "Recommendation")
            End If

        End If
        objFormFinal.Show()
        Me.Hide()

    End Sub
End Class