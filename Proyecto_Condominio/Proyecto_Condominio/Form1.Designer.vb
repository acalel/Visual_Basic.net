<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantencionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarNuevoCondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapasDeCondominioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.recepcion = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CondominioToolStripMenuItem, Me.MantencionToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(604, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'CondominioToolStripMenuItem
        '
        Me.CondominioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarNuevoCondominioToolStripMenuItem, Me.ConsultarCondominioToolStripMenuItem, Me.MapasDeCondominioToolStripMenuItem})
        Me.CondominioToolStripMenuItem.Name = "CondominioToolStripMenuItem"
        Me.CondominioToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CondominioToolStripMenuItem.Text = "Condominio"
        '
        'MantencionToolStripMenuItem
        '
        Me.MantencionToolStripMenuItem.Name = "MantencionToolStripMenuItem"
        Me.MantencionToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.MantencionToolStripMenuItem.Text = "Mantencion"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'IngresarNuevoCondominioToolStripMenuItem
        '
        Me.IngresarNuevoCondominioToolStripMenuItem.Name = "IngresarNuevoCondominioToolStripMenuItem"
        Me.IngresarNuevoCondominioToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.IngresarNuevoCondominioToolStripMenuItem.Text = "Ingresar Nuevo Condominio"
        '
        'ConsultarCondominioToolStripMenuItem
        '
        Me.ConsultarCondominioToolStripMenuItem.Name = "ConsultarCondominioToolStripMenuItem"
        Me.ConsultarCondominioToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ConsultarCondominioToolStripMenuItem.Text = "Consultar Condominio"
        '
        'MapasDeCondominioToolStripMenuItem
        '
        Me.MapasDeCondominioToolStripMenuItem.Name = "MapasDeCondominioToolStripMenuItem"
        Me.MapasDeCondominioToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.MapasDeCondominioToolStripMenuItem.Text = "Mapas de Condominio"
        '
        'recepcion
        '
        Me.recepcion.AutoSize = True
        Me.recepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recepcion.Location = New System.Drawing.Point(5, 27)
        Me.recepcion.Name = "recepcion"
        Me.recepcion.Size = New System.Drawing.Size(160, 29)
        Me.recepcion.TabIndex = 3
        Me.recepcion.Text = "BIENVENIDO"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto_Condominio.My.Resources.Resources._4_min_620x350
        Me.ClientSize = New System.Drawing.Size(604, 261)
        Me.Controls.Add(Me.recepcion)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "menu"
        Me.Text = "MENU"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents CondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantencionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarNuevoCondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarCondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MapasDeCondominioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents recepcion As Label
End Class
