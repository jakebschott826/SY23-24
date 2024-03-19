﻿Public Class ReelControl
    Public Property itemvalue As Integer
    Public Property spintime As Integer = 2000
    Dim rand As New Random
    Public Sub spin()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
    Private Sub Reelcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Interval = spintime
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As Integer
        r = rand.Next(ImageList1.Images.Count)
        PictureBox1.Image = ImageList1.Images(r)
        itemvalue = r
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
End Class
