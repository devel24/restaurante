<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedido
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmPedido))
        lblMesa = New Label()
        txtMesa = New TextBox()
        PedidoBindingSource = New BindingSource(components)
        GroupBox1 = New GroupBox()
        flpAlimentos = New FlowLayoutPanel()
        GroupBox2 = New GroupBox()
        flpBebidas = New FlowLayoutPanel()
        tlpMenu = New TableLayoutPanel()
        tlpGeneral = New TableLayoutPanel()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        gbCuenta = New GroupBox()
        tlpCuenta = New TableLayoutPanel()
        dgvPedido = New DataGridView()
        CuentaBindingSource = New BindingSource(components)
        Panel2 = New Panel()
        lblTotal = New Label()
        Label1 = New Label()
        ToolStripContainer1 = New ToolStripContainer()
        ToolStrip1 = New ToolStrip()
        tsbAceptar = New ToolStripButton()
        tsbCancelar = New ToolStripButton()
        NombreDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        CantidadDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        TotalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        QuitarUno = New DataGridViewButtonColumn()
        CType(PedidoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        tlpMenu.SuspendLayout()
        tlpGeneral.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        gbCuenta.SuspendLayout()
        tlpCuenta.SuspendLayout()
        CType(dgvPedido, ComponentModel.ISupportInitialize).BeginInit()
        CType(CuentaBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblMesa
        ' 
        lblMesa.AutoSize = True
        lblMesa.Location = New Point(9, 6)
        lblMesa.Name = "lblMesa"
        lblMesa.Size = New Size(98, 15)
        lblMesa.TabIndex = 0
        lblMesa.Text = "Numero de Mesa"
        ' 
        ' txtMesa
        ' 
        txtMesa.DataBindings.Add(New Binding("Text", PedidoBindingSource, "Mesa", True))
        txtMesa.Location = New Point(113, 3)
        txtMesa.Name = "txtMesa"
        txtMesa.Size = New Size(100, 23)
        txtMesa.TabIndex = 1
        ' 
        ' PedidoBindingSource
        ' 
        PedidoBindingSource.DataSource = GetType(Pedido)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(flpAlimentos)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Location = New Point(3, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(388, 136)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Alimentos"
        ' 
        ' flpAlimentos
        ' 
        flpAlimentos.Dock = DockStyle.Fill
        flpAlimentos.FlowDirection = FlowDirection.TopDown
        flpAlimentos.Location = New Point(3, 19)
        flpAlimentos.Name = "flpAlimentos"
        flpAlimentos.Size = New Size(382, 114)
        flpAlimentos.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(flpBebidas)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(397, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(388, 136)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Bebidas"
        ' 
        ' flpBebidas
        ' 
        flpBebidas.Dock = DockStyle.Fill
        flpBebidas.FlowDirection = FlowDirection.TopDown
        flpBebidas.Location = New Point(3, 19)
        flpBebidas.Name = "flpBebidas"
        flpBebidas.Size = New Size(382, 114)
        flpBebidas.TabIndex = 0
        ' 
        ' tlpMenu
        ' 
        tlpMenu.ColumnCount = 2
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpMenu.Controls.Add(GroupBox1, 0, 0)
        tlpMenu.Controls.Add(GroupBox2, 1, 0)
        tlpMenu.Dock = DockStyle.Fill
        tlpMenu.Location = New Point(3, 19)
        tlpMenu.Name = "tlpMenu"
        tlpMenu.RowCount = 1
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMenu.Size = New Size(788, 142)
        tlpMenu.TabIndex = 0
        ' 
        ' tlpGeneral
        ' 
        tlpGeneral.ColumnCount = 1
        tlpGeneral.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpGeneral.Controls.Add(Panel1, 0, 0)
        tlpGeneral.Controls.Add(GroupBox3, 0, 1)
        tlpGeneral.Controls.Add(gbCuenta, 0, 2)
        tlpGeneral.Dock = DockStyle.Fill
        tlpGeneral.Location = New Point(0, 0)
        tlpGeneral.Name = "tlpGeneral"
        tlpGeneral.RowCount = 3
        tlpGeneral.RowStyles.Add(New RowStyle(SizeType.Absolute, 35F))
        tlpGeneral.RowStyles.Add(New RowStyle(SizeType.Absolute, 170F))
        tlpGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpGeneral.Size = New Size(800, 425)
        tlpGeneral.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblMesa)
        Panel1.Controls.Add(txtMesa)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 29)
        Panel1.TabIndex = 1
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(tlpMenu)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.Location = New Point(3, 38)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(794, 164)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Menú"
        ' 
        ' gbCuenta
        ' 
        gbCuenta.Controls.Add(tlpCuenta)
        gbCuenta.Dock = DockStyle.Fill
        gbCuenta.Location = New Point(3, 208)
        gbCuenta.Name = "gbCuenta"
        gbCuenta.Size = New Size(794, 214)
        gbCuenta.TabIndex = 5
        gbCuenta.TabStop = False
        gbCuenta.Text = "Cuenta"
        ' 
        ' tlpCuenta
        ' 
        tlpCuenta.ColumnCount = 1
        tlpCuenta.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        tlpCuenta.Controls.Add(dgvPedido, 0, 0)
        tlpCuenta.Controls.Add(Panel2, 0, 1)
        tlpCuenta.Dock = DockStyle.Fill
        tlpCuenta.Location = New Point(3, 19)
        tlpCuenta.Name = "tlpCuenta"
        tlpCuenta.RowCount = 2
        tlpCuenta.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        tlpCuenta.RowStyles.Add(New RowStyle(SizeType.Absolute, 30F))
        tlpCuenta.Size = New Size(788, 192)
        tlpCuenta.TabIndex = 1
        ' 
        ' dgvPedido
        ' 
        dgvPedido.AllowUserToAddRows = False
        dgvPedido.AllowUserToDeleteRows = False
        dgvPedido.AutoGenerateColumns = False
        dgvPedido.BackgroundColor = Color.White
        dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPedido.Columns.AddRange(New DataGridViewColumn() {NombreDataGridViewTextBoxColumn, CantidadDataGridViewTextBoxColumn, TotalDataGridViewTextBoxColumn, QuitarUno})
        dgvPedido.DataSource = CuentaBindingSource
        dgvPedido.Dock = DockStyle.Fill
        dgvPedido.Location = New Point(3, 3)
        dgvPedido.Name = "dgvPedido"
        dgvPedido.ReadOnly = True
        dgvPedido.RowTemplate.Height = 25
        dgvPedido.Size = New Size(782, 156)
        dgvPedido.TabIndex = 0
        ' 
        ' CuentaBindingSource
        ' 
        CuentaBindingSource.DataMember = "Cuenta"
        CuentaBindingSource.DataSource = PedidoBindingSource
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblTotal)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 165)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(782, 24)
        Panel2.TabIndex = 1
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.DataBindings.Add(New Binding("Text", PedidoBindingSource, "Total", True))
        lblTotal.Location = New Point(38, 6)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(13, 15)
        lblTotal.TabIndex = 1
        lblTotal.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 0
        Label1.Text = "Total"
        ' 
        ' ToolStripContainer1
        ' 
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.Controls.Add(tlpGeneral)
        ToolStripContainer1.ContentPanel.Size = New Size(800, 425)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.Location = New Point(0, 0)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.Size = New Size(800, 450)
        ToolStripContainer1.TabIndex = 3
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer1.TopToolStripPanel
        ' 
        ToolStripContainer1.TopToolStripPanel.Controls.Add(ToolStrip1)
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Dock = DockStyle.None
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsbAceptar, tsbCancelar})
        ToolStrip1.Location = New Point(3, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(153, 25)
        ToolStrip1.TabIndex = 0
        ' 
        ' tsbAceptar
        ' 
        tsbAceptar.Image = CType(resources.GetObject("tsbAceptar.Image"), Image)
        tsbAceptar.ImageTransparentColor = Color.Magenta
        tsbAceptar.Name = "tsbAceptar"
        tsbAceptar.Size = New Size(68, 22)
        tsbAceptar.Text = "Aceptar"
        ' 
        ' tsbCancelar
        ' 
        tsbCancelar.Image = CType(resources.GetObject("tsbCancelar.Image"), Image)
        tsbCancelar.ImageTransparentColor = Color.Magenta
        tsbCancelar.Name = "tsbCancelar"
        tsbCancelar.Size = New Size(73, 22)
        tsbCancelar.Text = "Cancelar"
        ' 
        ' NombreDataGridViewTextBoxColumn
        ' 
        NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        NombreDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' CantidadDataGridViewTextBoxColumn
        ' 
        CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        CantidadDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' TotalDataGridViewTextBoxColumn
        ' 
        TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        TotalDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' QuitarUno
        ' 
        QuitarUno.HeaderText = ""
        QuitarUno.Name = "QuitarUno"
        QuitarUno.ReadOnly = True
        QuitarUno.Text = "Quitar 1"
        QuitarUno.UseColumnTextForButtonValue = True
        ' 
        ' frmPedido
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStripContainer1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmPedido"
        Text = "frmPedido"
        CType(PedidoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        tlpMenu.ResumeLayout(False)
        tlpGeneral.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        gbCuenta.ResumeLayout(False)
        tlpCuenta.ResumeLayout(False)
        CType(dgvPedido, ComponentModel.ISupportInitialize).EndInit()
        CType(CuentaBindingSource, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer1.TopToolStripPanel.PerformLayout()
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblMesa As Label
    Friend WithEvents txtMesa As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents flpAlimentos As FlowLayoutPanel
    Friend WithEvents flpBebidas As FlowLayoutPanel
    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents tlpGeneral As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents gbCuenta As GroupBox
    Friend WithEvents tlpCuenta As TableLayoutPanel
    Friend WithEvents dgvPedido As DataGridView
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents CuentaBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbAceptar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuitarUno As DataGridViewButtonColumn
End Class
