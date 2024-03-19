
Public Class CoinSlot
    Public Event CoinReturnEvent(d As Integer, q As Integer, n As Integer, di As Integer)
    Public ReadOnly Property total As Decimal
        Get
            _total = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
            Return _total
        End Get
    End Property
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public Sub insertdollar()
        dollars += 1
    End Sub
    Public Sub insertnickel()
        nickels += 1
    End Sub
    Public Sub insertdime()
        dimes += 1
    End Sub
    Public Sub insertquarter()
        quarters += 1
    End Sub
    Public Sub coinreturn()
        RaiseEvent CoinReturnEvent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0
    End Sub
    Public Sub buy(p As ProductControl)
        If p.productcount > 0 And p.productprice <= _total Then
            _total = _total - p.productprice
            p.buy()
            dollars = 0
            quarters = 0
            dimes = 0
            nickels = _total / 0.05
        End If
    End Sub
End Class
