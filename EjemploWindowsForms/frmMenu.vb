Public Class frmMenu

    Private ReadOnly menuRepository As New MenuRepository()
    Private pedido As New Pedido()
    Private pedidoAceptado As Boolean = False
    Private reloj As New Timer() With {.Interval = 1000}

    Public Function NuevoPedido() As Pedido
        pedidoAceptado = False
        pedido = New Pedido()
        Text = "Nuevo Pedido"
        txtMesa.Clear()
        ActualizarCuenta()

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
        txtMesa.Text = pedido.Mesa
        ActualizarCuenta()

        ShowDialog()

        If pedidoAceptado Then
            Return Me.pedido
        Else
            Return pedido
        End If
    End Function

    Private Sub pbxMenu_Click(sender As Object, e As EventArgs) Handles pbxDonaChocolate.Click, pbxDonaVainilla.Click, pbxPanini.Click, pbxBrownie.Click, pbxGalletaChocolate.Click, pbxCocaCola.Click, pbxPepsi.Click, pbxAmericano.Click, pbxAgua.Click, pbxExpresso.Click
        Dim pbx As PictureBox = sender
        pedido.AgregarElemento(pbx.Tag)
        ActualizarCuenta()

    End Sub

    Private Sub ActualizarCuenta()
        flpCuenta.SuspendLayout()
        flpCuenta.Controls.Clear()
        For Each partida In pedido.Cuenta
            Dim ll As New LinkLabel() With {
                .Text = $"{partida.Cantidad} {partida.Nombre}: {partida.Total:C}",
                .Tag = partida,
                .AutoSize = True
            }
            AddHandler ll.LinkClicked, AddressOf ll_LinkClicked
            flpCuenta.Controls.Add(ll)
        Next
        flpCuenta.ResumeLayout()
    End Sub

    Private Sub ll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim ll As LinkLabel = sender
        pedido.EliminarElemento(ll.Tag.Nombre)
        ActualizarCuenta()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbxDonaChocolate.Tag = New ElementoMenu() With {.Nombre = "Dona de chocolate", .Precio = 15}
        pbxDonaVainilla.Tag = New ElementoMenu() With {.Nombre = "Dona de vainilla", .Precio = 15}
        pbxPanini.Tag = New ElementoMenu() With {.Nombre = "Panini", .Precio = 25}
        pbxBrownie.Tag = New ElementoMenu() With {.Nombre = "Brownie", .Precio = 30}
        pbxGalletaChocolate.Tag = New ElementoMenu() With {.Nombre = "Galletas de chocolate", .Precio = 10}
        pbxCocaCola.Tag = New ElementoMenu() With {.Nombre = "Refresco coca cola", .Precio = 15}
        pbxPepsi.Tag = New ElementoMenu() With {.Nombre = "Refresco Pepsi", .Precio = 15}
        pbxAmericano.Tag = New ElementoMenu() With {.Nombre = "Café americano", .Precio = 15}
        pbxAgua.Tag = New ElementoMenu() With {.Nombre = "Agua", .Precio = 20}
        pbxExpresso.Tag = New ElementoMenu() With {.Nombre = "Café expresso", .Precio = 15}

        lblTimer.Text = $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}"
        AddHandler reloj.Tick, Sub() lblTimer.Text = $"{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}"
        reloj.Start()

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If String.IsNullOrEmpty(txtMesa.Text) Then
            MessageBox.Show("Debe ingresar el número de mesa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        pedidoAceptado = True
        Close()
    End Sub

    Private Sub txtMesa_Leave(sender As Object, e As EventArgs) Handles txtMesa.Leave
        pedido.Mesa = txtMesa.Text
    End Sub
End Class