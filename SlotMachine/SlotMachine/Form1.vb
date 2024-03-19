Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl4.spin()
        ReelControl5.spin()
        ReelControl6.spin()
        Timer1.Enabled = True
        cs.spenddollar()
        Label4.Text = cs.total.ToString("c2")
        cs.spendquarter()
        Label4.Text = cs.total.ToString("c2")
        cs.spenddime()
        Label4.Text = cs.total.ToString("c2")
        cs.spendnickel()
        Label4.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = ReelControl4.itemvalue
        Label2.Text = ReelControl5.itemvalue
        Label3.Text = ReelControl6.itemvalue
        Timer1.Enabled = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        Label4.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdime()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertnickel()
        Label4.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.coinreturn()
        Label4.Text = cs.total.ToString("c2")
    End Sub
End Class
