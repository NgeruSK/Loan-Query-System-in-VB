<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncome
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
        Me.radHigh = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLow = New System.Windows.Forms.RadioButton()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Would the applicant's income be "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "classified as High, Medium "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "or Low?"
        '
        'radHigh
        '
        Me.radHigh.AutoSize = True
        Me.radHigh.Location = New System.Drawing.Point(72, 128)
        Me.radHigh.Name = "radHigh"
        Me.radHigh.Size = New System.Drawing.Size(47, 17)
        Me.radHigh.TabIndex = 3
        Me.radHigh.TabStop = True
        Me.radHigh.Text = "High"
        Me.radHigh.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(72, 163)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 4
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLow
        '
        Me.radLow.AutoSize = True
        Me.radLow.Location = New System.Drawing.Point(72, 199)
        Me.radLow.Name = "radLow"
        Me.radLow.Size = New System.Drawing.Size(45, 17)
        Me.radLow.TabIndex = 5
        Me.radLow.TabStop = True
        Me.radLow.Text = "Low"
        Me.radLow.UseVisualStyleBackColor = True
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(72, 226)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(84, 23)
        Me.btnEvaluate.TabIndex = 6
        Me.btnEvaluate.Text = "Evaluate"
        Me.btnEvaluate.UseVisualStyleBackColor = True
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Controls.Add(Me.radLow)
        Me.Controls.Add(Me.radMedium)
        Me.Controls.Add(Me.radHigh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIncome"
        Me.Text = "frmIncome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radHigh As System.Windows.Forms.RadioButton
    Friend WithEvents radMedium As System.Windows.Forms.RadioButton
    Friend WithEvents radLow As System.Windows.Forms.RadioButton
    Friend WithEvents btnEvaluate As System.Windows.Forms.Button
End Class
