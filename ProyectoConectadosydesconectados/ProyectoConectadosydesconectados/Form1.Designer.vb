<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btndesconectados = New System.Windows.Forms.Button()
        Me.btnconectados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MENU"
        '
        'btndesconectados
        '
        Me.btndesconectados.Location = New System.Drawing.Point(78, 172)
        Me.btndesconectados.Name = "btndesconectados"
        Me.btndesconectados.Size = New System.Drawing.Size(128, 23)
        Me.btndesconectados.TabIndex = 4
        Me.btndesconectados.Text = "Desconectados"
        Me.btndesconectados.UseVisualStyleBackColor = True
        '
        'btnconectados
        '
        Me.btnconectados.Location = New System.Drawing.Point(78, 121)
        Me.btnconectados.Name = "btnconectados"
        Me.btnconectados.Size = New System.Drawing.Size(128, 23)
        Me.btnconectados.TabIndex = 3
        Me.btnconectados.Text = "Conectados"
        Me.btnconectados.UseVisualStyleBackColor = True
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndesconectados)
        Me.Controls.Add(Me.btnconectados)
        Me.Name = "INICIO"
        Me.Text = "MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btndesconectados As Button
    Friend WithEvents btnconectados As Button
End Class
