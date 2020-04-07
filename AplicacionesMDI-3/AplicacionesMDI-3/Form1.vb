Public Class Form1
    Private mensaje As New ensamblado
    Private ingreso As New ingresardieta
    Private informe As New informedieta
    Private contador As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000
        menud.Enabled = False
        mensaje.MdiParent = Me
        mensaje.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        contador = contador + 1
        If contador = 5 Then
            mensaje.Close()
            Timer1.Enabled = False
            menud.Enabled = True
        End If
    End Sub

    Private Sub IngresarDietaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresarDietaToolStripMenuItem1.Click
        ingreso.MdiParent = Me
        ingreso.Show()

    End Sub

    Private Sub InformeDeLaDietaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDeLaDietaToolStripMenuItem.Click
        informe.MdiParent = Me
        informe.Show()
    End Sub
End Class
