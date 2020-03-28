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
        Me.btnnavegacion = New System.Windows.Forms.Button()
        Me.btnmantencion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnnavegacion
        '
        Me.btnnavegacion.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnnavegacion.Location = New System.Drawing.Point(76, 78)
        Me.btnnavegacion.Name = "btnnavegacion"
        Me.btnnavegacion.Size = New System.Drawing.Size(158, 37)
        Me.btnnavegacion.TabIndex = 0
        Me.btnnavegacion.Text = "Navegacion"
        Me.btnnavegacion.UseVisualStyleBackColor = False
        '
        'btnmantencion
        '
        Me.btnmantencion.Location = New System.Drawing.Point(76, 135)
        Me.btnmantencion.Name = "btnmantencion"
        Me.btnmantencion.Size = New System.Drawing.Size(158, 34)
        Me.btnmantencion.TabIndex = 1
        Me.btnmantencion.Text = "Mantencion"
        Me.btnmantencion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Menu de Opciones"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmantencion)
        Me.Controls.Add(Me.btnnavegacion)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnavegacion As Button
    Friend WithEvents btnmantencion As Button
    Friend WithEvents Label1 As Label
End Class
