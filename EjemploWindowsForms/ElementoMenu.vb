Public Class ElementoMenu
    Implements ICloneable
    Public Property Nombre As String
    Public Property Precio As Decimal

    Public Function Clone() As Object Implements ICloneable.Clone
        Return New ElementoMenu() With {
            .Nombre = Nombre,
            .Precio = Precio
        }
    End Function
End Class
