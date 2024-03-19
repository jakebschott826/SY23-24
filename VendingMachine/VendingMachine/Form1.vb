Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertnickel()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdime()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdollar()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_CoinReturnEvent(d As Integer, q As Integer, n As Integer, di As Integer) Handles cs.CoinReturnEvent
        If q > 0 Then
            quarterpicturebox.Visible = True
        Else
            quarterpicturebox.Visible = False
        End If
        If d > 0 Then
            dollarpicturebox.Visible = True
        Else
            dollarpicturebox.Visible = False
        End If
        If di > 0 Then
            dimepicturebox.Visible = True
        Else
            dimepicturebox.Visible = False
        End If
        If n > 0 Then
            nickelpicturebox.Visible = True
        Else
            nickelpicturebox.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDtextbox.Text
            Case ProductControl1.productID
                cs.buy(ProductControl1)
            Case ProductControl2.productID
                cs.buy(ProductControl2)
            Case ProductControl3.productID
                cs.buy(ProductControl3)
            Case ProductControl4.productID
                cs.buy(ProductControl4)
            Case ProductControl5.productID
                cs.buy(ProductControl5)
            Case ProductControl6.productID
                cs.buy(ProductControl6)
            Case ProductControl7.productID
                cs.buy(ProductControl7)
            Case ProductControl8.productID
                cs.buy(ProductControl8)
            Case ProductControl9.productID
                cs.buy(ProductControl9)
            Case ProductControl10.productID
                cs.buy(ProductControl10)
            Case ProductControl11.productID
                cs.buy(ProductControl11)
            Case ProductControl12.productID
                cs.buy(ProductControl12)
            Case ProductControl13.productID
                cs.buy(ProductControl13)
            Case ProductControl14.productID
                cs.buy(ProductControl14)
            Case ProductControl15.productID
                cs.buy(ProductControl15)
            Case ProductControl16.productID
                cs.buy(ProductControl16)
        End Select
        Label1.Text = cs.total.ToString("c2")
    End Sub

    Private Sub ProductControl1_dispense(i As Image) Handles ProductControl1.dispense, ProductControl2.dispense, ProductControl3.dispense, ProductControl4.dispense, ProductControl5.dispense, ProductControl6.dispense, ProductControl7.dispense, ProductControl8.dispense, ProductControl9.dispense, ProductControl10.dispense, ProductControl11.dispense, ProductControl12.dispense, ProductControl13.dispense, ProductControl14.dispense, ProductControl15.dispense, ProductControl16.dispense
        productpicturebox.Image = i
    End Sub
End Class
