Public Class UserControl1
    Public Property speed As Integer = 10
    Public Property interval As Integer = 100
    Public Property sprite As PictureBox
    Dim xdir As Integer = 1
    Dim ydir As Integer = 0
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = interval
        Timer1.Enabled = True
        If Not sprite Is Nothing Then
            sprite.Left = me.Left
            sprite.Top = Me.Top
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not sprite Is Nothing Then
            sprite.Left += xdir * speed
            sprite.Top += ydir * speed
            If sprite.Left > Me.Left + Me.Width = xdir = 1 Then
                xdir = 0
                ydir = 1
            End If
            If sprite.Left < Me.Left And xdir = -1 Then
                xdir = 0
                ydir = -1
            End If
            If sprite.Top > Me.Top + Me.Height = ydir = 1 Then
                ydir = 0
                xdir = -1
            End If
            If sprite.Top < Me.Top And ydir = -1 Then
                ydir = 0
                xdir = 1
            End If
        End If
    End Sub
End Class
