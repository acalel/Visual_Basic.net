Imports MySql.Data.MySqlClient


Public Class conectados
    Public conexion As String = "DataSource=localhost; " &
"Database=northwind;Uid=root; Pwd=;"
    Public conectar As MySqlConnection = New MySqlConnection(conexion)
    Public comando As MySqlCommand = New MySqlCommand()


    Private Sub conectados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim consulta As String = "SELECT EmployeeID, 	LastName, FirstName " &
" FROM employees;"
        Dim llenar As MySqlDataReader

        Try
            comando.CommandType = CommandType.Text
            comando.Connection = conectar
            comando.CommandText = consulta
            conectar.Open()
            llenar = comando.ExecuteReader
            While llenar.Read
                Dim codigo As Integer = llenar(0).ToString
                Dim nombre1 As String = llenar(1).ToString
                Dim nombre2 As String = llenar(2).ToString
                dtemployees.Rows.Add(codigo, nombre1, nombre2)
                dtemployees.Refresh()

            End While

        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & ex.Message)
        Finally
            conectar.Close()
        End Try
    End Sub


    Private Sub ListarOrders(ByVal idProv As Integer)
        Dim sqlSentence As String
        Dim myReader As MySqlDataReader
        sqlSentence = "SELECT ProductId, ProductName, QuantityPerUnit, " &
        "UnitPrice, UnitsInStock, UnitsOnOrder, Discontinued " &
        "FROM products WHERE SupplierId = @IdProv;"
        Try
            comando.CommandType = CommandType.Text
            comando.Connection = conectar
            comando.CommandText = sqlSentence
            comando.Parameters.Clear()
            comando.Parameters.AddWithValue("@IdProv", idProv)
            conectar.Open()
            myReader = comando.ExecuteReader()
            While myReader.Read()
                Dim idProd As Integer = myReader(0).ToString
                Dim nomProducto As String = myReader(1).ToString
                Dim cantPorUnidad As String = myReader(2).ToString
                Dim precUnitario As String = myReader(3).ToString
                Dim unidEnStock As String = myReader(4).ToString
                Dim unidEnOrden As String = myReader(5).ToString
                Dim discont As String = myReader(6).ToString
                dgvProductos.Rows.Add(idProd, nomProducto, cantPorUnidad,
                precUnitario, unidEnStock, unidEnOrden, discont)
                dgvProductos.Refresh()
            End While
        Catch ex As Exception
            MessageBox.Show("Se produjo el siguiente error: " & ex.Message)
        Finally
            myConnection.Close()
        End Try
    End Sub


End Class