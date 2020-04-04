Public Class Form1
    Private Sub AccesoConectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoConectadoToolStripMenuItem.Click
        Dim conectado As New conectados
        conectado.MdiParent = Me
        conectado.Show()
    End Sub

    Private Sub AccesoDesconectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoDesconectadoToolStripMenuItem.Click
        Dim desconectado As New desconectados
        desconectado.MdiParent = Me
        desconectado.Show()
    End Sub
End Class
