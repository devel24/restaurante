Public Class Pedido

    Private Elementos As New List(Of ElementoMenu)

    Public Sub AgregarElemento(elemento As ElementoMenu)
        Elementos.Add(elemento)
    End Sub

    Private Sub ActualizarCuenta()
        For Each elemento In Elementos

            If Cuenta.Any(Function(c) c.Nombre = elemento.Nombre) Then
                Cuenta.First(Function(c) c.Nombre = elemento.Nombre).Cantidad += 1
            Else
                Cuenta.Add(New Partida(elemento, 1))
            End If
        Next
    End Sub

    Public Property Cuenta As New List(Of Partida)




End Class
