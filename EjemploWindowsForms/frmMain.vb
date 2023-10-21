Imports System.ComponentModel
Imports System.Text.Json

Public Class frmMain
    Private ventanaPedido As New frmMenu()
    Private pedidos As New BindingList(Of Pedido)
    Private reloj As New Timer() With {.Interval = 1000}

    Private Sub tsbNuevoPedido_Click(sender As Object, e As EventArgs) Handles tsbNuevoPedido.Click
        NuevoPedido()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Application.Exit()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PedidoBindingSource.DataSource = pedidos

        Dim tmr As New Timer()
        AddHandler tmr.Tick, Sub() Splash.Close()
        tmr.Interval = 5000
        tmr.Start()

        tslHora.Text = $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}"
        AddHandler reloj.Tick, Sub() tslHora.Text = $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}"
        reloj.Start()

        Splash.ShowDialog()
        tmr.Dispose()

        Login.ShowDialog()

        NuevoPedido()
    End Sub

    Private Sub NuevoPedido()
        Dim pedido = ventanaPedido.NuevoPedido()
        If pedido IsNot Nothing Then
            pedidos.Add(pedido)
        End If
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