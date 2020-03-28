Imports MySql.Data.MySqlClient



Public Class Navegacion
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
            myAdapter.InsertCommand = myCommandBuilder.GetInsertCommand
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


    Private Sub Navegacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatosEmpleados()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprimero.Click
        numRegistro = 0
        Me.BindingContext(miTabla).Position = numRegistro

    End Sub
    Private Sub btUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnultimo.Click
        numRegistro = miTabla.Rows.Count - 1
        Me.BindingContext(miTabla).Position = numRegistro

    End Sub

    Private Sub btAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        numRegistro = numRegistro - 1
        If numRegistro < 0 Then
            MessageBox.Show("Error de Navegación" & vbCrLf & "No existe registro
anterior al primero")
            Exit Sub
        End If
        Me.BindingContext(miTabla).Position = numRegistro

    End Sub

    Private Sub btSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        numRegistro = numRegistro + 1
        If (numRegistro > miTabla.Rows.Count - 1) Then
            MessageBox.Show("Error de Navegación" & vbCrLf & "No existe registro
posterior al último")
            Exit Sub
        End If
        Me.BindingContext(miTabla).Position = numRegistro

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

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        AgregarRegistro()
        ActivaDesactiva(False)
        Me.BindingContext(miTabla).Position = numRegistro
        btnguardar.Enabled = False
    End Sub

    Private Sub btAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

        Me.BindingContext(miTabla).AddNew()
        TextBox1.Text = miTabla.Rows.Count + 1
        ActivaDesactiva(True)
        TextBox2.Focus()
        btnagregar.Enabled = False
        btnguardar.Enabled = True
    End Sub



    Private Sub btGrabarBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarBD.Click
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


    Private Sub AgregarRegistro()
        Try
            BindingContext(miTabla).EndCurrentEdit()
            MessageBox.Show("Registro ingresado correctamente")
            numRegistro = miTabla.Rows.Count - 1
            operacion = ""
            btnagregar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & vbCrLf & ex.Message)
        End Try
    End Sub
End Class
