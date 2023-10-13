Public Class frmMain
    Private ventanaPedido As New frmPedido
    Private Sub tsbNuevoPedido_Click(sender As Object, e As EventArgs) Handles tsbNuevoPedido.Click
        Dim pedido = ventanaPedido.NuevoPedido()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Application.Exit()
    End Sub
End Class