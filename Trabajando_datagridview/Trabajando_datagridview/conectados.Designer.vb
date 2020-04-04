<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conectados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtemployees = New System.Windows.Forms.DataGridView()
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtdetalle = New System.Windows.Forms.DataGridView()
        Me.NorthwindDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NorthwindDataSet = New Trabajando_datagridview.northwindDataSet()
        Me.nombrecliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecharequerida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaembarque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombrebarco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccionbarco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudadbarco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paisbarco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtemployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtemployees
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dtemployees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtemployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.LastName, Me.FirstName})
        Me.dtemployees.Location = New System.Drawing.Point(12, 12)
        Me.dtemployees.Name = "dtemployees"
        Me.dtemployees.RowHeadersVisible = False
        Me.dtemployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtemployees.Size = New System.Drawing.Size(304, 303)
        Me.dtemployees.TabIndex = 0
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "EmployeeID"
        Me.EmployeeID.Name = "EmployeeID"
        '
        'LastName
        '
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        '
        'FirstName
        '
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        '
        'dtdetalle
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtdetalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtdetalle.AutoGenerateColumns = False
        Me.dtdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtdetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombrecliente, Me.fecha_orden, Me.fecharequerida, Me.fechaembarque, Me.carga, Me.Nombrebarco, Me.direccionbarco, Me.ciudadbarco, Me.paisbarco})
        Me.dtdetalle.DataSource = Me.NorthwindDataSetBindingSource
        Me.dtdetalle.Location = New System.Drawing.Point(332, 12)
        Me.dtdetalle.Name = "dtdetalle"
        Me.dtdetalle.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.dtdetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtdetalle.Size = New System.Drawing.Size(365, 302)
        Me.dtdetalle.TabIndex = 1
        '
        'NorthwindDataSetBindingSource
        '
        Me.NorthwindDataSetBindingSource.DataSource = Me.NorthwindDataSet
        Me.NorthwindDataSetBindingSource.Position = 0
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "northwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nombrecliente
        '
        Me.nombrecliente.HeaderText = "Nombre Cliente"
        Me.nombrecliente.Name = "nombrecliente"
        '
        'fecha_orden
        '
        Me.fecha_orden.HeaderText = "Fecha Orden"
        Me.fecha_orden.Name = "fecha_orden"
        '
        'fecharequerida
        '
        Me.fecharequerida.HeaderText = "Fecha Requerida"
        Me.fecharequerida.Name = "fecharequerida"
        '
        'fechaembarque
        '
        Me.fechaembarque.HeaderText = "Fecha Embarque"
        Me.fechaembarque.Name = "fechaembarque"
        '
        'carga
        '
        Me.carga.HeaderText = "Carga"
        Me.carga.Name = "carga"
        '
        'Nombrebarco
        '
        Me.Nombrebarco.HeaderText = "Nombre del Barco"
        Me.Nombrebarco.Name = "Nombrebarco"
        '
        'direccionbarco
        '
        Me.direccionbarco.HeaderText = "Direccion Barco"
        Me.direccionbarco.Name = "direccionbarco"
        '
        'ciudadbarco
        '
        Me.ciudadbarco.HeaderText = "Ciudad Barco"
        Me.ciudadbarco.Name = "ciudadbarco"
        '
        'paisbarco
        '
        Me.paisbarco.HeaderText = "Pais Barco"
        Me.paisbarco.Name = "paisbarco"
        '
        'conectados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 324)
        Me.Controls.Add(Me.dtdetalle)
        Me.Controls.Add(Me.dtemployees)
        Me.Name = "conectados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONECTADOS"
        CType(Me.dtemployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtemployees As DataGridView
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents LastName As DataGridViewTextBoxColumn
    Friend WithEvents FirstName As DataGridViewTextBoxColumn
    Friend WithEvents dtdetalle As DataGridView
    Friend WithEvents NorthwindDataSetBindingSource As BindingSource
    Friend WithEvents NorthwindDataSet As northwindDataSet
    Friend WithEvents nombrecliente As DataGridViewTextBoxColumn
    Friend WithEvents fecha_orden As DataGridViewTextBoxColumn
    Friend WithEvents fecharequerida As DataGridViewTextBoxColumn
    Friend WithEvents fechaembarque As DataGridViewTextBoxColumn
    Friend WithEvents carga As DataGridViewTextBoxColumn
    Friend WithEvents Nombrebarco As DataGridViewTextBoxColumn
    Friend WithEvents direccionbarco As DataGridViewTextBoxColumn
    Friend WithEvents ciudadbarco As DataGridViewTextBoxColumn
    Friend WithEvents paisbarco As DataGridViewTextBoxColumn
End Class
