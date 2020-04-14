Public Class ingresardieta
    Private Sub ingresardieta_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnagregardia_Click(sender As Object, e As EventArgs) Handles btnagregardia.Click


        TextBox1.Enabled = True
        btnagregardia.Text = "Guardar"
        If TextBox1.Text = "" Then
            TextBox1.Focus()
        Else
            ComboBox1.Items.Add(TextBox1.Text)
            TextBox1.Text = ""
            TextBox1.Enabled = False
            btnagregardia.Text = "Agregar"

        End If

    End Sub

    Private Sub btnbebestible_Click(sender As Object, e As EventArgs) Handles btnbebestible.Click
        TextBox2.Enabled = True
        btnbebestible.Text = "Guardar"
        If TextBox2.Text = "" Then

            TextBox2.Focus()
        Else
            ListBox1.Items.Add(TextBox2.Text)
            TextBox2.Enabled = False
            btnbebestible.Text = "Agregar Bebestible"
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub btncomestible_Click(sender As Object, e As EventArgs) Handles btncomestible.Click
        TextBox3.Enabled = True
        btncomestible.Text = "Guardar"
        If TextBox3.Text = "" Then
            TextBox3.Focus()
        Else
            ListBox2.Items.Add(TextBox3.Text)
            TextBox3.Enabled = False
            TextBox3.Text = ""
            btncomestible.Text = "Agregar Comestible"
        End If
    End Sub

    Private Sub btnmenu_ClickClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
        Dim resumenb, resumenc, diadieta, rp, ra, rv, rf As String






        If ListBox1.SelectedIndex = -1 Or ListBox2.SelectedIndex = -1 Or ComboBox1.SelectedIndex = -1 Then
            MsgBox("Por favor valide sus opciones")
            Exit Sub
        Else

            resumenb = ListBox1.SelectedItem
            resumenc = ListBox2.SelectedItem
            diadieta = ComboBox1.SelectedItem
            ' Label3.Text = resumenb + " con " + resumenc

            ListBox7.BeginUpdate()

            ListBox7.Items.Add(diadieta + " - " + resumenb + " con " + resumenc)
            ListBox7.EndUpdate()



            Dim inven As Integer = ListBox1.Items.Count - 1
            ListBox1.BeginUpdate()
            For indice As Integer = inven To 0 Step -1
                If ListBox1.GetSelected(indice) Then
                    ListBox1.Items.RemoveAt(indice)
                End If
            Next
            ListBox1.EndUpdate()


            Dim invenc As Integer = ListBox2.Items.Count - 1
            ListBox2.BeginUpdate()
            For indicec As Integer = invenc To 0 Step -1
                If ListBox2.GetSelected(indicec) Then
                    ListBox2.Items.RemoveAt(indicec)
                End If
            Next
            ListBox2.EndUpdate()


            ComboBox1.Text = ""

            'validacion de la informacion de los listados de la opcion almuerzo

            If ListBox3.SelectedIndex = -1 Or ListBox4.SelectedIndex = -1 Then
                MsgBox("selecciones un opcion")

                Exit Sub
            Else
                rp = ListBox3.SelectedItem
                ra = ListBox4.SelectedItem
                diadieta = ComboBox1.SelectedItem
                ListBox7.BeginUpdate()
                ListBox7.Items.Add(diadieta + " - " + rp + " con " + ra)
                ListBox7.EndUpdate()
                'actualizacion de listado proteinas el cual remueve el item seleccionado 
                Dim invena As Integer = ListBox3.Items.Count - 1
                ListBox3.BeginUpdate()
                For indicea As Integer = invena To 0 Step -1
                    If ListBox3.GetSelected(indicea) Then
                        ListBox3.Items.RemoveAt(indicea)
                    End If
                Next
                ListBox3.EndUpdate()


                'se actualiza el listado de los acompañamientos
                Dim invenac As Integer = ListBox4.Items.Count - 1
                ListBox4.BeginUpdate()
                For indiceac As Integer = invenac To 0 Step -1
                    If ListBox4.GetSelected(indiceac) Then
                        ListBox4.Items.RemoveAt(indiceac)
                    End If
                Next
                ListBox4.EndUpdate()


            End If
            'fin de la validacion de este menu

            'validacion de la informacion de los listados de la opcion cena

            If ListBox5.SelectedIndex = -1 Or ListBox6.SelectedIndex = -1 Then
                MsgBox("selecciones un opcion")

                Exit Sub
            Else
                rv = ListBox5.SelectedItem
                rf = ListBox6.SelectedItem
                diadieta = ComboBox1.SelectedItem
                ListBox7.BeginUpdate()
                ListBox7.Items.Add(diadieta + " - " + rv + " con " + rf)
                ListBox7.EndUpdate()
                'actualizacion de listado proteinas el cual remueve el item seleccionado 
                Dim invenv As Integer = ListBox5.Items.Count - 1
                ListBox5.BeginUpdate()
                For indicev As Integer = invenv To 0 Step -1
                    If ListBox5.GetSelected(indicev) Then
                        ListBox5.Items.RemoveAt(indicev)
                    End If
                Next
                ListBox5.EndUpdate()


                'se actualiza el listado de los acompañamientos
                Dim invenaf As Integer = ListBox6.Items.Count - 1
                ListBox6.BeginUpdate()
                For indiceaf As Integer = invenaf To 0 Step -1
                    If ListBox6.GetSelected(indiceaf) Then
                        ListBox6.Items.RemoveAt(indiceaf)
                    End If
                Next
                ListBox6.EndUpdate()


            End If
            'fin de la validacion de este menu



        End If




    End Sub

    Private Sub btnproteina_Click(sender As Object, e As EventArgs) Handles btnproteina.Click
        TextBox4.Enabled = True
        btnproteina.Text = "Guardar"
        If TextBox4.Text = "" Then

            TextBox4.Focus()
        Else
            ListBox3.Items.Add(TextBox4.Text)
            TextBox4.Enabled = False
            btnproteina.Text = "Agregar Proteina"
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub btnacompañamiento_Click(sender As Object, e As EventArgs) Handles btnacompañamiento.Click
        TextBox5.Enabled = True
        btnacompañamiento.Text = "Guardar"
        If TextBox5.Text = "" Then
            TextBox5.Focus()
        Else
            ListBox4.Items.Add(TextBox5.Text)
            TextBox5.Enabled = False
            btnacompañamiento.Text = "Agregar Acompañamiento"
            TextBox5.Text = ""
        End If
    End Sub

    Private Sub btnverduras_Click(sender As Object, e As EventArgs) Handles btnverduras.Click
        TextBox6.Enabled = True
        btnverduras.Text = "Guardar"
        If TextBox6.Text = "" Then
            TextBox6.Focus()
        Else
            ListBox5.Items.Add(TextBox6.Text)
            TextBox6.Enabled = False
            btnverduras.Text = "Agregar Verdura"
            TextBox6.Text = ""
        End If
    End Sub

    Private Sub btnfrutas_Click(sender As Object, e As EventArgs) Handles btnfrutas.Click
        TextBox7.Enabled = True
        btnfrutas.Text = "Guardar"
        If TextBox7.Text = "" Then
            TextBox7.Focus()
        Else
            ListBox6.Items.Add(TextBox7.Text)
            TextBox7.Enabled = False
            btnfrutas.Text = "Agregar Fruta"
            TextBox7.Text = ""
        End If
    End Sub
End Class