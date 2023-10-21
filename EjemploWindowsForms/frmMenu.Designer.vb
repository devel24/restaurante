<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblMesa = New Label()
        txtMesa = New TextBox()
        flpMenu = New FlowLayoutPanel()
        pbxDonaChocolate = New PictureBox()
        pbxDonaVainilla = New PictureBox()
        pbxPanini = New PictureBox()
        pbxBrownie = New PictureBox()
        pbxGalletaChocolate = New PictureBox()
        pbxCocaCola = New PictureBox()
        pbxPepsi = New PictureBox()
        pbxAmericano = New PictureBox()
        pbxAgua = New PictureBox()
        pbxExpresso = New PictureBox()
        btnEnviar = New Button()
        btnCancelar = New Button()
        flpCuenta = New FlowLayoutPanel()
        lblTimer = New Label()
        flpMenu.SuspendLayout()
        CType(pbxDonaChocolate, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxDonaVainilla, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxPanini, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxBrownie, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxGalletaChocolate, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxCocaCola, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxPepsi, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxAmericano, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxAgua, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxExpresso, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMesa
        ' 
        lblMesa.AutoSize = True
        lblMesa.BackColor = Color.Transparent
        lblMesa.Location = New Point(12, 64)
        lblMesa.Name = "lblMesa"
        lblMesa.Size = New Size(35, 15)
        lblMesa.TabIndex = 0
        lblMesa.Text = "Mesa"
        ' 
        ' txtMesa
        ' 
        txtMesa.Location = New Point(53, 61)
        txtMesa.Name = "txtMesa"
        txtMesa.Size = New Size(109, 23)
        txtMesa.TabIndex = 1
        ' 
        ' flpMenu
        ' 
        flpMenu.AutoScroll = True
        flpMenu.BackColor = Color.Transparent
        flpMenu.Controls.Add(pbxDonaChocolate)
        flpMenu.Controls.Add(pbxDonaVainilla)
        flpMenu.Controls.Add(pbxPanini)
        flpMenu.Controls.Add(pbxBrownie)
        flpMenu.Controls.Add(pbxGalletaChocolate)
        flpMenu.Controls.Add(pbxCocaCola)
        flpMenu.Controls.Add(pbxPepsi)
        flpMenu.Controls.Add(pbxAmericano)
        flpMenu.Controls.Add(pbxAgua)
        flpMenu.Controls.Add(pbxExpresso)
        flpMenu.Location = New Point(12, 90)
        flpMenu.MinimumSize = New Size(291, 319)
        flpMenu.Name = "flpMenu"
        flpMenu.Size = New Size(291, 319)
        flpMenu.TabIndex = 2
        ' 
        ' pbxDonaChocolate
        ' 
        pbxDonaChocolate.Image = My.Resources.Resources.Dona_de_Chocolate
        pbxDonaChocolate.Location = New Point(3, 3)
        pbxDonaChocolate.Name = "pbxDonaChocolate"
        pbxDonaChocolate.Size = New Size(128, 128)
        pbxDonaChocolate.SizeMode = PictureBoxSizeMode.Zoom
        pbxDonaChocolate.TabIndex = 0
        pbxDonaChocolate.TabStop = False
        pbxDonaChocolate.Tag = ""
        ' 
        ' pbxDonaVainilla
        ' 
        pbxDonaVainilla.Image = My.Resources.Resources.Dona_de_vainilla
        pbxDonaVainilla.Location = New Point(137, 3)
        pbxDonaVainilla.Name = "pbxDonaVainilla"
        pbxDonaVainilla.Size = New Size(128, 128)
        pbxDonaVainilla.SizeMode = PictureBoxSizeMode.Zoom
        pbxDonaVainilla.TabIndex = 1
        pbxDonaVainilla.TabStop = False
        ' 
        ' pbxPanini
        ' 
        pbxPanini.Image = My.Resources.Resources.Panini
        pbxPanini.Location = New Point(3, 137)
        pbxPanini.Name = "pbxPanini"
        pbxPanini.Size = New Size(128, 128)
        pbxPanini.SizeMode = PictureBoxSizeMode.Zoom
        pbxPanini.TabIndex = 2
        pbxPanini.TabStop = False
        ' 
        ' pbxBrownie
        ' 
        pbxBrownie.Image = My.Resources.Resources.Brownie
        pbxBrownie.Location = New Point(137, 137)
        pbxBrownie.Name = "pbxBrownie"
        pbxBrownie.Size = New Size(128, 128)
        pbxBrownie.SizeMode = PictureBoxSizeMode.Zoom
        pbxBrownie.TabIndex = 3
        pbxBrownie.TabStop = False
        ' 
        ' pbxGalletaChocolate
        ' 
        pbxGalletaChocolate.Image = My.Resources.Resources.Galletas_de_chocolate
        pbxGalletaChocolate.Location = New Point(3, 271)
        pbxGalletaChocolate.Name = "pbxGalletaChocolate"
        pbxGalletaChocolate.Size = New Size(128, 128)
        pbxGalletaChocolate.SizeMode = PictureBoxSizeMode.Zoom
        pbxGalletaChocolate.TabIndex = 4
        pbxGalletaChocolate.TabStop = False
        ' 
        ' pbxCocaCola
        ' 
        pbxCocaCola.Image = My.Resources.Resources.Refresco_coca_cola
        pbxCocaCola.Location = New Point(137, 271)
        pbxCocaCola.Name = "pbxCocaCola"
        pbxCocaCola.Size = New Size(128, 128)
        pbxCocaCola.SizeMode = PictureBoxSizeMode.Zoom
        pbxCocaCola.TabIndex = 5
        pbxCocaCola.TabStop = False
        ' 
        ' pbxPepsi
        ' 
        pbxPepsi.Image = My.Resources.Resources.Refresco_Pepsi
        pbxPepsi.Location = New Point(3, 405)
        pbxPepsi.Name = "pbxPepsi"
        pbxPepsi.Size = New Size(128, 128)
        pbxPepsi.SizeMode = PictureBoxSizeMode.Zoom
        pbxPepsi.TabIndex = 6
        pbxPepsi.TabStop = False
        ' 
        ' pbxAmericano
        ' 
        pbxAmericano.Image = My.Resources.Resources.Café_americano
        pbxAmericano.Location = New Point(137, 405)
        pbxAmericano.Name = "pbxAmericano"
        pbxAmericano.Size = New Size(128, 128)
        pbxAmericano.SizeMode = PictureBoxSizeMode.Zoom
        pbxAmericano.TabIndex = 7
        pbxAmericano.TabStop = False
        ' 
        ' pbxAgua
        ' 
        pbxAgua.Image = My.Resources.Resources.Agua
        pbxAgua.Location = New Point(3, 539)
        pbxAgua.Name = "pbxAgua"
        pbxAgua.Size = New Size(128, 128)
        pbxAgua.SizeMode = PictureBoxSizeMode.Zoom
        pbxAgua.TabIndex = 9
        pbxAgua.TabStop = False
        ' 
        ' pbxExpresso
        ' 
        pbxExpresso.Image = My.Resources.Resources.Café_expresso
        pbxExpresso.Location = New Point(137, 539)
        pbxExpresso.Name = "pbxExpresso"
        pbxExpresso.Size = New Size(128, 128)
        pbxExpresso.SizeMode = PictureBoxSizeMode.Zoom
        pbxExpresso.TabIndex = 8
        pbxExpresso.TabStop = False
        ' 
        ' btnEnviar
        ' 
        btnEnviar.Location = New Point(12, 415)
        btnEnviar.Name = "btnEnviar"
        btnEnviar.Size = New Size(75, 23)
        btnEnviar.TabIndex = 3
        btnEnviar.Text = "&Enviar"
        btnEnviar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(401, 415)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "&Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' flpCuenta
        ' 
        flpCuenta.BackColor = Color.Transparent
        flpCuenta.Location = New Point(309, 90)
        flpCuenta.Name = "flpCuenta"
        flpCuenta.Size = New Size(167, 319)
        flpCuenta.TabIndex = 5
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = Color.Transparent
        lblTimer.Location = New Point(309, 9)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(41, 15)
        lblTimer.TabIndex = 6
        lblTimer.Text = "Label1"
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Menu
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(lblTimer)
        Controls.Add(flpCuenta)
        Controls.Add(btnCancelar)
        Controls.Add(btnEnviar)
        Controls.Add(flpMenu)
        Controls.Add(txtMesa)
        Controls.Add(lblMesa)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMenu"
        Text = "frmMenu"
        flpMenu.ResumeLayout(False)
        CType(pbxDonaChocolate, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxDonaVainilla, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxPanini, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxBrownie, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxGalletaChocolate, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxCocaCola, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxPepsi, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxAmericano, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxAgua, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxExpresso, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMesa As Label
    Friend WithEvents txtMesa As TextBox
    Friend WithEvents flpMenu As FlowLayoutPanel
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents pbxDonaChocolate As PictureBox
    Friend WithEvents pbxDonaVainilla As PictureBox
    Friend WithEvents pbxPanini As PictureBox
    Friend WithEvents pbxBrownie As PictureBox
    Friend WithEvents pbxGalletaChocolate As PictureBox
    Friend WithEvents pbxCocaCola As PictureBox
    Friend WithEvents pbxPepsi As PictureBox
    Friend WithEvents pbxAmericano As PictureBox
    Friend WithEvents pbxExpresso As PictureBox
    Friend WithEvents pbxAgua As PictureBox
    Friend WithEvents flpCuenta As FlowLayoutPanel
    Friend WithEvents lblTimer As Label
End Class
