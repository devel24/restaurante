Imports System.ComponentModel

Public Class Pedido
    Implements ICloneable

    Public Property Mesa As String
    Public Property Total As Decimal

    Private Elementos As New List(Of ElementoMenu)

    Public Sub AgregarElemento(elemento As ElementoMenu)
        Elementos.Add(elemento)
        ActualizarCuenta()
    End Sub

    Public Sub EliminarElemento(nombre As String)
        Dim elemento = Elementos.First(Function(e) e.Nombre = nombre)
        Dim idx As Integer = Elementos.IndexOf(elemento)
        Elementos.RemoveAt(idx)
        ActualizarCuenta()
    End Sub

    Private Sub ActualizarCuenta()
        Cuenta.Clear()
        Dim total As Decimal = 0

        For Each elemento In Elementos
            If Cuenta.Any(Function(c) c.Nombre = elemento.Nombre) Then
                Cuenta.First(Function(c) c.Nombre = elemento.Nombre).Cantidad += 1
            Else
                Cuenta.Add(New Partida(elemento, 1))
            End If
            total += elemento.Precio
        Next

        Me.Total = total
    End Sub

    Public Function Clone() As Object Implements ICloneable.Clone
        Dim clon = New Pedido() With {
        .Mesa = Mesa,
        .Total = Total
        }

        Elementos.ForEach(Sub(e) clon.AgregarElemento(e.Clone()))

        Return clon

    End Function

    Public Property Cuenta As New BindingList(Of Partida)




End Class
