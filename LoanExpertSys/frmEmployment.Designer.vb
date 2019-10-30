<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Is the applicant Employed?"
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(60, 77)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(43, 17)
        Me.radYes.TabIndex = 1
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(60, 111)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(39, 17)
        Me.radNo.TabIndex = 2
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(60, 165)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(75, 23)
        Me.btnEvaluate.TabIndex = 3
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'frmEmployment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 220)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.radNo)
        Me.Controls.Add(Me.radYes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmployment"
        Me.Text = "frmEmployment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radYes As System.Windows.Forms.RadioButton
    Friend WithEvents radNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
End Class
