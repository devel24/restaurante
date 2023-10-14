Imports System.ComponentModel
Imports System.Text.Json

Public Class frmMain
    Private ventanaPedido As New frmPedido
    Private pedidos As New BindingList(Of Pedido)

    Private Sub tsbNuevoPedido_Click(sender As Object, e As EventArgs) Handles tsbNuevoPedido.Click
        Dim pedido = ventanaPedido.NuevoPedido()
        If pedido IsNot Nothing Then
            pedidos.Add(pedido)
        End If
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PedidoBindingSource.DataSource = pedidos
    End Sub

    Private Sub dgvPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidos.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            Dim boton As DataGridViewButtonColumn = senderGrid.Columns(e.ColumnIndex)
            Dim pedidoActual As Pedido = pedidos(e.RowIndex)
            Select Case boton.Text
                Case "Editar"
                    EditarPedido(pedidoActual, e.RowIndex)
                Case "Pagar"
                    PagarPedido(pedidoActual)
                Case Else
                    Throw New NotImplementedException()
            End Select
        End If
    End Sub

    Private Sub EditarPedido(ByVal pedido As Pedido, ByVal index As Integer)
        pedidos(index) = ventanaPedido.EditarPedido(pedido)
        PedidoBindingSource.ResetBindings(True)
    End Sub
    Private Sub PagarPedido(ByRef pedido As Pedido)
        pedidos.Remove(pedido)
    End Sub
End Class