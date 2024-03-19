Public Class ProductControl
    Public Property productname As String
    Public Property productID As String
    Public Property productprice As Decimal
    Public Property productimage As Image
    Public Property productcount As Integer
    Public Event dispense(p As Image)

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = productimage
        IDlabel.Text = productID
        PriceLabel.Text = productprice.ToString("c2")
    End Sub
    Public Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
            RaiseEvent dispense(productimage)
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
