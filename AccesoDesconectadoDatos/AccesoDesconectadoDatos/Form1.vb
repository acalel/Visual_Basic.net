Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnnavegacion_Click(sender As Object, e As EventArgs) Handles btnnavegacion.Click
        Navegacion.Show()
    End Sub

    Private Sub btnmantencion_Click(sender As Object, e As EventArgs) Handles btnmantencion.Click
        Mantencion.Show()
    End Sub
End Class
