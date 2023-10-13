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
        ToolStrip1 = New ToolStrip()
        tsbNuevoPedido = New ToolStripButton()
        tsbSalir = New ToolStripButton()
        ToolStrip1.SuspendLayout()
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
        tsbNuevoPedido.Image = My.Resources.Resources.Agregar_Pedido
        tsbNuevoPedido.ImageTransparentColor = Color.Magenta
        tsbNuevoPedido.Name = "tsbNuevoPedido"
        tsbNuevoPedido.Size = New Size(102, 22)
        tsbNuevoPedido.Text = "&Nuevo Pedido"
        ' 
        ' tsbSalir
        ' 
        tsbSalir.Image = My.Resources.Resources.Salir
        tsbSalir.ImageTransparentColor = Color.Magenta
        tsbSalir.Name = "tsbSalir"
        tsbSalir.Size = New Size(49, 22)
        tsbSalir.Text = "Salir"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Name = "frmMain"
        Text = "Restaurante Los Hermanos"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNuevoPedido As ToolStripButton
    Friend WithEvents tsbSalir As ToolStripButton
End Class
