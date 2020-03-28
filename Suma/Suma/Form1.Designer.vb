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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese primer dato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese segundo dato"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(50, 54)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(192, 20)
        Me.txtn1.TabIndex = 2
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(50, 113)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(192, 20)
        Me.txtn2.TabIndex = 3
        '
        'btnsuma
        '
        Me.btnsuma.Location = New System.Drawing.Point(50, 201)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(160, 35)
        Me.btnsuma.TabIndex = 4
        Me.btnsuma.Text = "Suma"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Location = New System.Drawing.Point(51, 158)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(55, 13)
        Me.resultado.TabIndex = 5
        Me.resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SUMA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents btnsuma As Button
    Friend WithEvents resultado As Label
End Class
