Imports System.Diagnostics.CodeAnalysis
Imports System.Text.Json

Public Class frmPedido

    Private ReadOnly menuRepository As New MenuRepository()
    Private pedido As Pedido
    Private pedidoAceptado As Boolean = False

    Public Function NuevoPedido() As Pedido
        pedidoAceptado = False
        pedido = New Pedido()
        Text = "Nuevo Pedido"
        txtMesa.Clear()
        ActualizarMenu()

        PedidoBindingSource.DataSource = pedido

        ShowDialog()

        If pedidoAceptado Then
            Return pedido
        Else
            Return Nothing
        End If
    End Function

    Public Function EditarPedido(ByVal pedido As Pedido) As Pedido
        pedidoAceptado = False
        Me.pedido = pedido.Clone()
        Text = "Editar Pedido"

        ActualizarMenu()

        PedidoBindingSource.DataSource = Me.pedido
        PedidoBindingSource.ResetBindings(True)

        ShowDialog()

        If pedidoAceptado Then
            Return Me.pedido
        Else
            Return pedido
        End If
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
        Dim ll As LinkLabel = sender
        pedido.AgregarElemento(ll.Tag)
        PedidoBindingSource.ResetBindings(True)

    End Sub

    Private Sub lblMesa_Click(sender As Object, e As EventArgs) Handles lblMesa.Click

    End Sub

    Private Sub txtMesa_TextChanged(sender As Object, e As EventArgs) Handles txtMesa.TextChanged

    End Sub

    Private Sub tlpGeneral_Paint(sender As Object, e As PaintEventArgs) Handles tlpGeneral.Paint

    End Sub

    Private Sub tsbAceptar_Click(sender As Object, e As EventArgs) Handles tsbAceptar.Click
        pedidoAceptado = True
        Close()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        Close()
    End Sub

    Private Sub dgvPedido_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedido.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then
            Dim boton As DataGridViewButtonColumn = senderGrid.Columns(e.ColumnIndex)
            Dim partida As Partida = pedido.Cuenta(e.RowIndex)
            pedido.EliminarElemento(partida.Nombre)
            PedidoBindingSource.ResetBindings(True)
        End If
    End Sub
End Class