Imports MySql.Data.MySqlClient

Public Class Mantencion
    Public myStrConnection As String = "DataSource=localhost; " &
"Database=northwind; " &
"Uid=root; " &
"Pwd=;"
    Public myConnection As MySqlConnection = New MySqlConnection(myStrConnection)
    Public myDataSet As New DataSet()
    Private numRegistro As Integer
    Private miTabla As DataTable
    Private myAdapter As New MySqlDataAdapter()
    Private myCommandBuilder As New MySqlCommandBuilder(myAdapter)
    Private operacion As String = ""


    Private Sub CargaDatosEmpleados()
        Dim sqlSentence As String
        sqlSentence = "SELECT * FROM suppliers ORDER BY SupplierID"
        Try

            myAdapter.SelectCommand = New MySqlCommand(sqlSentence, myConnection)
            myAdapter.UpdateCommand = myCommandBuilder.GetUpdateCommand()
            myAdapter.DeleteCommand = myCommandBuilder.GetDeleteCommand()
            myConnection.Open()
            myAdapter.Fill(myDataSet, "Proveedores")
            miTabla = myDataSet.Tables("Proveedores")
            TextBox1.DataBindings.Add("text", miTabla, "SupplierID")
            TextBox2.DataBindings.Add("text", miTabla, "CompanyName")
            TextBox3.DataBindings.Add("text", miTabla, "ContactName")
            TextBox4.DataBindings.Add("text", miTabla, "ContactTitle")
            TextBox5.DataBindings.Add("text", miTabla, "Address")
            TextBox6.DataBindings.Add("text", miTabla, "City")
            TextBox7.DataBindings.Add("text", miTabla, "Region")
            TextBox8.DataBindings.Add("text", miTabla, "PostalCode")
            TextBox9.DataBindings.Add("text", miTabla, "Country")
            TextBox10.DataBindings.Add("text", miTabla, "Phone")
            TextBox11.DataBindings.Add("text", miTabla, "Fax")
            TextBox12.DataBindings.Add("text", miTabla, "HomePage")


            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnconsultar_Click(sender As Object, e As EventArgs) Handles btnconsultar.Click
        Dim dato As Integer
        dato = TextBox1.Text
        numRegistro = dato - 1
        Me.BindingContext(miTabla).Position = numRegistro
        btnactualizar.Enabled = True
        btneliminar.Enabled = True
        btngrabarbd.Enabled = True
    End Sub

    Private Sub Navegacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatosEmpleados()
        ActivaDesactiva(False)
        btnactualizar.Enabled = False
        btneliminar.Enabled = False
        btnguardar.Enabled = False
        btngrabarbd.Enabled = False
    End Sub

    Private Sub btGrabarBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabarbd.Click
        Try
            If myDataSet.HasChanges() Then
                myAdapter.Update(myDataSet, "Proveedores")
                myDataSet.AcceptChanges()
                MessageBox.Show("BD Actualizada")
            End If
        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        modificarRegistro()
        ActivaDesactiva(False)
        Me.BindingContext(miTabla).Position = numRegistro
        btnguardar.Enabled = False
    End Sub

    Private Sub btModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        operacion = "M"
        ActivaDesactiva(True)
        TextBox2.Focus()
        btnactualizar.Enabled = False
        btneliminar.Enabled = False
        btnguardar.Enabled = True
    End Sub

    Private Sub btEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim posicion As Integer
        Try
            posicion = BindingContext(miTabla).Position
            myDataSet.Tables("Proveedores").Rows(posicion).Delete()
            MessageBox.Show("Registro eliminado correctamente")
            operacion = ""
            btnconsultar.Enabled = True
            btnactualizar.Enabled = True
            btneliminar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub modificarRegistro()
        Try
            BindingContext(miTabla).EndCurrentEdit()
            MessageBox.Show("Registro modificado correctamente")

            btnactualizar.Enabled = True
            btnconsultar.Enabled = True
            btneliminar.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ActivaDesactiva(ByVal flag As Boolean)
        TextBox2.Enabled = flag
        TextBox3.Enabled = flag
        TextBox4.Enabled = flag
        TextBox5.Enabled = flag
        TextBox6.Enabled = flag
        TextBox7.Enabled = flag
        TextBox8.Enabled = flag
        TextBox9.Enabled = flag
        TextBox10.Enabled = flag
        TextBox11.Enabled = flag
        TextBox12.Enabled = flag

    End Sub


End Class