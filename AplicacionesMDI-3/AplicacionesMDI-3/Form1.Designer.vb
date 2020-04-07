<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.menud = New System.Windows.Forms.MenuStrip()
        Me.IngresarDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarDietaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDeLaDietaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menud.SuspendLayout()
        Me.SuspendLayout()
        '
        'menud
        '
        Me.menud.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDietaToolStripMenuItem})
        Me.menud.Location = New System.Drawing.Point(0, 0)
        Me.menud.Name = "menud"
        Me.menud.Size = New System.Drawing.Size(284, 24)
        Me.menud.TabIndex = 1
        Me.menud.Text = "MenuStrip1"
        '
        'IngresarDietaToolStripMenuItem
        '
        Me.IngresarDietaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDietaToolStripMenuItem1, Me.InformeDeLaDietaToolStripMenuItem})
        Me.IngresarDietaToolStripMenuItem.Name = "IngresarDietaToolStripMenuItem"
        Me.IngresarDietaToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.IngresarDietaToolStripMenuItem.Text = "Menu Dietas"
        '
        'IngresarDietaToolStripMenuItem1
        '
        Me.IngresarDietaToolStripMenuItem1.Name = "IngresarDietaToolStripMenuItem1"
        Me.IngresarDietaToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.IngresarDietaToolStripMenuItem1.Text = "Ingresar Dieta"
        '
        'InformeDeLaDietaToolStripMenuItem
        '
        Me.InformeDeLaDietaToolStripMenuItem.Name = "InformeDeLaDietaToolStripMenuItem"
        Me.InformeDeLaDietaToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.InformeDeLaDietaToolStripMenuItem.Text = "Informe de la Dieta"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.menud)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menud
        Me.Name = "Form1"
        Me.Text = "MENU DIETAS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menud.ResumeLayout(False)
        Me.menud.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menud As MenuStrip
    Friend WithEvents IngresarDietaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngresarDietaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InformeDeLaDietaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
