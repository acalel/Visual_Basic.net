Public Class menu
    Private fMensaje As New Form2
    Private contador As Integer
    Private Sub btncondominio_Click(sender As Object, e As EventArgs)
        Dim ncondo As New condominio
        ncondo.MdiParent = Me
        ncondo.Show()
    End Sub

    Private Sub btnmantencion_Click(sender As Object, e As EventArgs)
        Mantencion.Show()
    End Sub

    Private Sub btnreportes_Click(sender As Object, e As EventArgs)
        reportes.Show()

    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip.Enabled = False
        recepcion.Visible = False
        contador = 0
        Timer1.Enabled = True
        Timer1.Interval = 1000
        fMensaje.MdiParent = Me
        fMensaje.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object,
ByVal e As System.EventArgs) Handles Timer1.Tick
        contador = contador + 1
        If contador = 5 Then
            fMensaje.Close()
            Timer1.Enabled = False
            MenuStrip.Enabled = True
            recepcion.Visible = True
        End If
    End Sub

    Private Sub CondominioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CondominioToolStripMenuItem.Click

    End Sub

    Private Sub IngresarNuevoCondominioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarNuevoCondominioToolStripMenuItem.Click
        Dim ingresar As New Ingreso_Condominio

        ingresar.MdiParent = Me
        ingresar.Show()
    End Sub

    Private Sub ConsultarCondominioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarCondominioToolStripMenuItem.Click
        Dim consultar As New consultar_condominio
        consultar.MdiParent = Me
        consultar.Show()
    End Sub

    Private Sub MapasDeCondominioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapasDeCondominioToolStripMenuItem.Click
        Dim ver As New mapa
        ver.MdiParent = Me
        ver.Show()
    End Sub
End Class
