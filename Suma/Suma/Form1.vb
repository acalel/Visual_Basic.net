Public Class Form1
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim suma As Integer


        n1 = txtn1.Text
        n2 = txtn2.Text

        suma = n1 + n2



        MsgBox(suma)


    End Sub
End Class
