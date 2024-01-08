<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.redbutton = New System.Windows.Forms.Button()
        Me.bluebutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'redbutton
        '
        Me.redbutton.Location = New System.Drawing.Point(185, 57)
        Me.redbutton.Name = "redbutton"
        Me.redbutton.Size = New System.Drawing.Size(94, 29)
        Me.redbutton.TabIndex = 0
        Me.redbutton.Text = "red"
        Me.redbutton.UseVisualStyleBackColor = True
        '
        'bluebutton
        '
        Me.bluebutton.Location = New System.Drawing.Point(248, 127)
        Me.bluebutton.Name = "bluebutton"
        Me.bluebutton.Size = New System.Drawing.Size(94, 29)
        Me.bluebutton.TabIndex = 1
        Me.bluebutton.Text = "blue"
        Me.bluebutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bluebutton)
        Me.Controls.Add(Me.redbutton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents redbutton As Button
    Friend WithEvents bluebutton As Button
End Class
