<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReferences
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radGood = New System.Windows.Forms.RadioButton()
        Me.radBad = New System.Windows.Forms.RadioButton()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Would the applicant's "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "references be characterized as "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "good or bad?"
        '
        'radGood
        '
        Me.radGood.AutoSize = True
        Me.radGood.Location = New System.Drawing.Point(57, 138)
        Me.radGood.Name = "radGood"
        Me.radGood.Size = New System.Drawing.Size(51, 17)
        Me.radGood.TabIndex = 3
        Me.radGood.TabStop = True
        Me.radGood.Text = "Good"
        Me.radGood.UseVisualStyleBackColor = True
        '
        'radBad
        '
        Me.radBad.AutoSize = True
        Me.radBad.Location = New System.Drawing.Point(57, 177)
        Me.radBad.Name = "radBad"
        Me.radBad.Size = New System.Drawing.Size(44, 17)
        Me.radBad.TabIndex = 4
        Me.radBad.TabStop = True
        Me.radBad.Text = "Bad"
        Me.radBad.UseVisualStyleBackColor = True
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(57, 226)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(75, 23)
        Me.btnEvaluate.TabIndex = 5
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'frmReferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.radBad)
        Me.Controls.Add(Me.radGood)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReferences"
        Me.Text = "frmReferences"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radGood As System.Windows.Forms.RadioButton
    Friend WithEvents radBad As System.Windows.Forms.RadioButton
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
End Class
