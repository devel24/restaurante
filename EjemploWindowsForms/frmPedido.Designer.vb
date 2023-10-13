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
        lblMesa = New Label()
        txtMesa = New TextBox()
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
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        tlpMenu.SuspendLayout()
        tlpGeneral.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        gbCuenta.SuspendLayout()
        tlpCuenta.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        txtMesa.Location = New Point(113, 3)
        txtMesa.Name = "txtMesa"
        txtMesa.Size = New Size(100, 23)
        txtMesa.TabIndex = 1
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
        tlpGeneral.Size = New Size(800, 450)
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
        gbCuenta.Size = New Size(794, 239)
        gbCuenta.TabIndex = 5
        gbCuenta.TabStop = False
        gbCuenta.Text = "Cuenta"
        ' 
        ' tlpCuenta
        ' 
        tlpCuenta.ColumnCount = 1
        tlpCuenta.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        tlpCuenta.Controls.Add(DataGridView1, 0, 0)
        tlpCuenta.Dock = DockStyle.Fill
        tlpCuenta.Location = New Point(3, 19)
        tlpCuenta.Name = "tlpCuenta"
        tlpCuenta.RowCount = 2
        tlpCuenta.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpCuenta.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        tlpCuenta.Size = New Size(788, 217)
        tlpCuenta.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(782, 102)
        DataGridView1.TabIndex = 0
        ' 
        ' frmPedido
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tlpGeneral)
        Name = "frmPedido"
        Text = "frmPedido"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        tlpMenu.ResumeLayout(False)
        tlpGeneral.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        gbCuenta.ResumeLayout(False)
        tlpCuenta.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
End Class
