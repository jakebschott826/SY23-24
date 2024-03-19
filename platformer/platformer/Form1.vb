Public Class Form2DPlatformer
    Dim movespeed As Integer = 5
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Start()
            Case Keys.Left
                TmrLeft.Start()
            Case Keys.Up
                TmrUp.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles TmrRight.Tick
        PicPlayer.Left += 5
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                TmrRight.Stop()
            Case Keys.Left
                TmrLeft.Stop()
            Case Keys.Up
                TmrUp.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        PicPlayer.Left -= movespeed
    End Sub

    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        PicPlayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timergamelogic.Start()
    End Sub

    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles timerGameLogic.Tick
        If PicPlayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            timerGravity.Stop()
        Else
            If isjumping = False Then
                timerGravity.Start()
            End If
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        TimerGravity.Stop()
                        PicPlayer.Location = New Point(21, 450)
                    End If
                End If
            End If
            If b.Tag = "win" Then
                If PicPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    coinpb.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles timerGravity.Tick
        PicPlayer.Top += movespeed
    End Sub
End Class
