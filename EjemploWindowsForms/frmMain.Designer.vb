<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmMain))
        ToolStrip1 = New ToolStrip()
        tsbNuevoPedido = New ToolStripButton()
        tsbSalir = New ToolStripButton()
        dgvPedidos = New DataGridView()
        MesaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        TotalDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Editar = New DataGridViewButtonColumn()
        Pagar = New DataGridViewButtonColumn()
        PedidoBindingSource = New BindingSource(components)
        StatusStrip1 = New StatusStrip()
        tslHora = New ToolStripStatusLabel()
        ToolStrip1.SuspendLayout()
        CType(dgvPedidos, ComponentModel.ISupportInitialize).BeginInit()
        CType(PedidoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {tsbNuevoPedido, tsbSalir})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' tsbNuevoPedido
        ' 
        tsbNuevoPedido.Image = My.Resources.Resources.Agregar_Pedido_21
        tsbNuevoPedido.ImageTransparentColor = Color.Magenta
        tsbNuevoPedido.Name = "tsbNuevoPedido"
        tsbNuevoPedido.Size = New Size(102, 22)
        tsbNuevoPedido.Text = "&Nuevo Pedido"
        ' 
        ' tsbSalir
        ' 
        tsbSalir.Image = My.Resources.Resources.Salir2
        tsbSalir.ImageTransparentColor = Color.Magenta
        tsbSalir.Name = "tsbSalir"
        tsbSalir.Size = New Size(49, 22)
        tsbSalir.Text = "Salir"
        ' 
        ' dgvPedidos
        ' 
        dgvPedidos.AllowUserToAddRows = False
        dgvPedidos.AllowUserToDeleteRows = False
        dgvPedidos.AutoGenerateColumns = False
        dgvPedidos.BackgroundColor = Color.White
        dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPedidos.Columns.AddRange(New DataGridViewColumn() {MesaDataGridViewTextBoxColumn, TotalDataGridViewTextBoxColumn, Editar, Pagar})
        dgvPedidos.DataSource = PedidoBindingSource
        dgvPedidos.Dock = DockStyle.Fill
        dgvPedidos.Location = New Point(0, 25)
        dgvPedidos.Name = "dgvPedidos"
        dgvPedidos.ReadOnly = True
        dgvPedidos.RowTemplate.Height = 25
        dgvPedidos.Size = New Size(800, 425)
        dgvPedidos.TabIndex = 1
        ' 
        ' MesaDataGridViewTextBoxColumn
        ' 
        MesaDataGridViewTextBoxColumn.DataPropertyName = "Mesa"
        MesaDataGridViewTextBoxColumn.HeaderText = "Mesa"
        MesaDataGridViewTextBoxColumn.Name = "MesaDataGridViewTextBoxColumn"
        MesaDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' TotalDataGridViewTextBoxColumn
        ' 
        TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        TotalDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' Editar
        ' 
        Editar.HeaderText = "Editar"
        Editar.Name = "Editar"
        Editar.ReadOnly = True
        Editar.Resizable = DataGridViewTriState.True
        Editar.Text = "Editar"
        Editar.UseColumnTextForButtonValue = True
        ' 
        ' Pagar
        ' 
        Pagar.HeaderText = "Pagar"
        Pagar.Name = "Pagar"
        Pagar.ReadOnly = True
        Pagar.Resizable = DataGridViewTriState.True
        Pagar.Text = "Pagar"
        Pagar.UseColumnTextForButtonValue = True
        ' 
        ' PedidoBindingSource
        ' 
        PedidoBindingSource.DataSource = GetType(Pedido)
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {tslHora})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' tslHora
        ' 
        tslHora.Name = "tslHora"
        tslHora.Size = New Size(45, 17)
        tslHora.Text = "tslHora"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(dgvPedidos)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMain"
        Text = "Restaurante Los Hermanos"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(dgvPedidos, ComponentModel.ISupportInitialize).EndInit()
        CType(PedidoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNuevoPedido As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents PedidoBindingSource As BindingSource
    Friend WithEvents MesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents Pagar As DataGridViewButtonColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslHora As ToolStripStatusLabel
End Class
