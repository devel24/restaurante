Public Class frmPedido

    Private ReadOnly menuRepository As New MenuRepository()
    Private pedido As Pedido

    Public Function NuevoPedido() As Pedido
        pedido = New Pedido()
        Text = "Nuevo Pedido"
        txtMesa.Clear()
        ActualizarMenu()

        ShowDialog()


        Return pedido
    End Function

    Private Sub ActualizarMenu()
        flpAlimentos.SuspendLayout()
        flpAlimentos.Controls.Clear()
        Dim menuAlimentos = menuRepository.ObtenerMenuAlimentos()
        For Each alimento In menuAlimentos
            Dim ll As New LinkLabel() With {
                .Text = $"{alimento.Nombre} {alimento.Precio:C}",
                .Tag = alimento,
                .AutoSize = True
            }
            AddHandler ll.LinkClicked, AddressOf ll_LinkClicked
            flpAlimentos.Controls.Add(ll)
        Next
        flpAlimentos.ResumeLayout()

        flpAlimentos.SuspendLayout()
        flpBebidas.Controls.Clear()
        Dim menuBebidas = menuRepository.ObtenerMenuBebidas()
        For Each bebida In menuBebidas
            Dim ll As New LinkLabel() With {
                .Text = $"{bebida.Nombre} {bebida.Precio:C}",
                .Tag = bebida,
                .AutoSize = True
            }
            AddHandler ll.LinkClicked, AddressOf ll_LinkClicked
            flpBebidas.Controls.Add(ll)
        Next
        flpAlimentos.ResumeLayout()

    End Sub

    Private Sub ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub lblMesa_Click(sender As Object, e As EventArgs) Handles lblMesa.Click

    End Sub

    Private Sub txtMesa_TextChanged(sender As Object, e As EventArgs) Handles txtMesa.TextChanged

    End Sub

    Private Sub tlpGeneral_Paint(sender As Object, e As PaintEventArgs) Handles tlpGeneral.Paint

    End Sub
End Class