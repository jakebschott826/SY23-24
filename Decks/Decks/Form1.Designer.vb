﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.modellabel = New System.Windows.Forms.Label()
        Me.accelerationlabel = New System.Windows.Forms.Label()
        Me.topsepeedlabel = New System.Windows.Forms.Label()
        Me.weightlabel = New System.Windows.Forms.Label()
        Me.horsepowerlabel = New System.Windows.Forms.Label()
        Me.field1 = New System.Windows.Forms.TextBox()
        Me.field2 = New System.Windows.Forms.TextBox()
        Me.field3 = New System.Windows.Forms.TextBox()
        Me.field4 = New System.Windows.Forms.TextBox()
        Me.field5 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstbutton = New System.Windows.Forms.Button()
        Me.previousbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.lastbutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(396, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'modellabel
        '
        Me.modellabel.AutoSize = True
        Me.modellabel.Location = New System.Drawing.Point(92, 152)
        Me.modellabel.Name = "modellabel"
        Me.modellabel.Size = New System.Drawing.Size(94, 20)
        Me.modellabel.TabIndex = 1
        Me.modellabel.Text = "Make/Model"
        '
        'accelerationlabel
        '
        Me.accelerationlabel.AutoSize = True
        Me.accelerationlabel.Location = New System.Drawing.Point(22, 192)
        Me.accelerationlabel.Name = "accelerationlabel"
        Me.accelerationlabel.Size = New System.Drawing.Size(164, 20)
        Me.accelerationlabel.TabIndex = 2
        Me.accelerationlabel.Text = "Acceleration(0-60MPH)"
        '
        'topsepeedlabel
        '
        Me.topsepeedlabel.AutoSize = True
        Me.topsepeedlabel.Location = New System.Drawing.Point(64, 232)
        Me.topsepeedlabel.Name = "topsepeedlabel"
        Me.topsepeedlabel.Size = New System.Drawing.Size(122, 20)
        Me.topsepeedlabel.TabIndex = 3
        Me.topsepeedlabel.Text = "Top Speed(MPH)"
        '
        'weightlabel
        '
        Me.weightlabel.AutoSize = True
        Me.weightlabel.Location = New System.Drawing.Point(96, 272)
        Me.weightlabel.Name = "weightlabel"
        Me.weightlabel.Size = New System.Drawing.Size(90, 20)
        Me.weightlabel.TabIndex = 4
        Me.weightlabel.Text = "Weight(LBS)"
        '
        'horsepowerlabel
        '
        Me.horsepowerlabel.AutoSize = True
        Me.horsepowerlabel.Location = New System.Drawing.Point(96, 312)
        Me.horsepowerlabel.Name = "horsepowerlabel"
        Me.horsepowerlabel.Size = New System.Drawing.Size(90, 20)
        Me.horsepowerlabel.TabIndex = 5
        Me.horsepowerlabel.Text = "Horsepower"
        '
        'field1
        '
        Me.field1.Location = New System.Drawing.Point(192, 145)
        Me.field1.Name = "field1"
        Me.field1.Size = New System.Drawing.Size(198, 27)
        Me.field1.TabIndex = 6
        '
        'field2
        '
        Me.field2.Location = New System.Drawing.Point(192, 185)
        Me.field2.Name = "field2"
        Me.field2.Size = New System.Drawing.Size(198, 27)
        Me.field2.TabIndex = 7
        '
        'field3
        '
        Me.field3.Location = New System.Drawing.Point(192, 225)
        Me.field3.Name = "field3"
        Me.field3.Size = New System.Drawing.Size(198, 27)
        Me.field3.TabIndex = 8
        '
        'field4
        '
        Me.field4.Location = New System.Drawing.Point(192, 265)
        Me.field4.Name = "field4"
        Me.field4.Size = New System.Drawing.Size(198, 27)
        Me.field4.TabIndex = 9
        '
        'field5
        '
        Me.field5.Location = New System.Drawing.Point(192, 305)
        Me.field5.Name = "field5"
        Me.field5.Size = New System.Drawing.Size(198, 27)
        Me.field5.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.FilesToolStripMenuItem.Text = "files"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NewToolStripMenuItem.Text = "new"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "save"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstbutton
        '
        Me.firstbutton.Location = New System.Drawing.Point(121, 380)
        Me.firstbutton.Name = "firstbutton"
        Me.firstbutton.Size = New System.Drawing.Size(94, 29)
        Me.firstbutton.TabIndex = 12
        Me.firstbutton.Text = "First"
        Me.firstbutton.UseVisualStyleBackColor = True
        '
        'previousbutton
        '
        Me.previousbutton.Location = New System.Drawing.Point(212, 380)
        Me.previousbutton.Name = "previousbutton"
        Me.previousbutton.Size = New System.Drawing.Size(94, 29)
        Me.previousbutton.TabIndex = 13
        Me.previousbutton.Text = "Previous"
        Me.previousbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(304, 380)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 14
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'lastbutton
        '
        Me.lastbutton.Location = New System.Drawing.Point(396, 380)
        Me.lastbutton.Name = "lastbutton"
        Me.lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.lastbutton.TabIndex = 15
        Me.lastbutton.Text = "Last"
        Me.lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.previousbutton)
        Me.Controls.Add(Me.firstbutton)
        Me.Controls.Add(Me.field5)
        Me.Controls.Add(Me.field4)
        Me.Controls.Add(Me.field3)
        Me.Controls.Add(Me.field2)
        Me.Controls.Add(Me.field1)
        Me.Controls.Add(Me.horsepowerlabel)
        Me.Controls.Add(Me.weightlabel)
        Me.Controls.Add(Me.topsepeedlabel)
        Me.Controls.Add(Me.accelerationlabel)
        Me.Controls.Add(Me.modellabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents modellabel As Label
    Friend WithEvents accelerationlabel As Label
    Friend WithEvents topsepeedlabel As Label
    Friend WithEvents weightlabel As Label
    Friend WithEvents horsepowerlabel As Label
    Friend WithEvents field1 As TextBox
    Friend WithEvents field2 As TextBox
    Friend WithEvents field3 As TextBox
    Friend WithEvents field4 As TextBox
    Friend WithEvents field5 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents firstbutton As Button
    Friend WithEvents previousbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents lastbutton As Button
End Class
