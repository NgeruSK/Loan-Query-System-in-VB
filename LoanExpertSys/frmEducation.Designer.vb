<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEducation
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
        Me.radHigh = New System.Windows.Forms.RadioButton()
        Me.radLow = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Is the applicant’s level of education "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "characterized as high or low? "
        '
        'radHigh
        '
        Me.radHigh.AutoSize = True
        Me.radHigh.Location = New System.Drawing.Point(40, 83)
        Me.radHigh.Name = "radHigh"
        Me.radHigh.Size = New System.Drawing.Size(47, 17)
        Me.radHigh.TabIndex = 2
        Me.radHigh.TabStop = True
        Me.radHigh.Text = "High"
        Me.radHigh.UseVisualStyleBackColor = True
        '
        'radLow
        '
        Me.radLow.AutoSize = True
        Me.radLow.Location = New System.Drawing.Point(40, 116)
        Me.radLow.Name = "radLow"
        Me.radLow.Size = New System.Drawing.Size(45, 17)
        Me.radLow.TabIndex = 3
        Me.radLow.TabStop = True
        Me.radLow.Text = "Low"
        Me.radLow.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Evaluate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEducation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 211)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.radLow)
        Me.Controls.Add(Me.radHigh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEducation"
        Me.Text = "frmEducation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radHigh As System.Windows.Forms.RadioButton
    Friend WithEvents radLow As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
