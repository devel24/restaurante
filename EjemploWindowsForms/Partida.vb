Public Class Partida

    Private Elemento As ElementoMenu

    Public Sub New(elemento As ElementoMenu, cantidad As Integer)
        Me.Elemento = elemento
        Me.Cantidad = cantidad
    End Sub

    Public ReadOnly Property Nombre As String
        Get
            Return Elemento.Nombre
        End Get
    End Property
    Public Property Cantidad As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Elemento.Precio * Cantidad
        End Get
    End Property

End Class
