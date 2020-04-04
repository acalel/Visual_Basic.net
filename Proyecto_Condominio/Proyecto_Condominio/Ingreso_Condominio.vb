Public Class Ingreso_Condominio
    Dim control As Integer = 0


    Private Sub btnagrega_Click(sender As Object, e As EventArgs) Handles btnagrega.Click
        Dim punto As String = TextBox6.Text
        Dim descripcion As String = TextBox7.Text




        If control < 4 Then


            If descripcion = "" Or punto = "" Then
                MsgBox("no hay datos")
                If descripcion = "" Then
                    TextBox7.Focus()
                End If
                If punto = "" Then
                    TextBox6.Focus()
                End If

            Else
                limites.Rows.Add(punto, descripcion)
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox6.Focus()
                control = control + 1


            End If
        Else
            MsgBox("Ya no es posible ingresar mas datos")
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox6.Focus()
        End If

    End Sub
End Class