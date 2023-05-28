Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        zupanija_skeniranja = combobox_zupanija.Text
        lokacija_izmjere = combobox_lokacija_izmjere.Text


        My.Settings.zupanija_skeniranja = zupanija_skeniranja
        My.Settings.lokacija_izmjere = lokacija_izmjere



        If zupanija_skeniranja = "" Or lokacija_izmjere = "" Then

            MsgBox("Unesi sve postavke! ", MsgBoxStyle.Exclamation, "GZS povratnice")
            Exit Sub
        End If
        If zupanija_skeniranja <> "" And lokacija_izmjere <> "" Then
            Form1.zelena_kvacica_5.Visible = True
            Form1.crveni_kriz_2.Visible = False
        Else
            Form1.crveni_kriz_2.Visible = True
            Form1.zelena_kvacica_5.Visible = False
        End If




        If zupanija_skeniranja <> "" And lokacija_izmjere <> "" Then

            Form1.start_radnog_dana_buton.Enabled = True
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False
            Form1.potpis_check.Enabled = False
            Form1.metapodaci_check.Enabled = False

            Form1.digitalni_potpis_buton.Enabled = False
            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        Else
            Form1.start_radnog_dana_buton.Enabled = False
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False
            Form1.potpis_check.Enabled = False
            Form1.metapodaci_check.Enabled = False

            Form1.digitalni_potpis_buton.Enabled = False
            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        End If



        Me.Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If start_radnog_dana = True Then
            combobox_zupanija.Enabled = False
            combobox_lokacija_izmjere.Enabled = False


            Button1.Enabled = False


        End If




        zupanija_skeniranja = My.Settings.zupanija_skeniranja
        lokacija_izmjere = My.Settings.lokacija_izmjere




        combobox_zupanija.Text = zupanija_skeniranja
        combobox_lokacija_izmjere.Text = lokacija_izmjere






        If combobox_zupanija.Items.Count > 0 And zupanija_skeniranja = "" Then
            combobox_zupanija.SelectedIndex = 0    ' The first item has index 0 '

        Else
            combobox_zupanija.Text = zupanija_skeniranja
        End If

        If combobox_lokacija_izmjere.Items.Count > 0 And lokacija_izmjere = "" Then
            combobox_zupanija.SelectedIndex = 0    ' The first item has index 0 '

        Else
            combobox_lokacija_izmjere.Text = lokacija_izmjere
        End If




    End Sub











    Private Sub lokacija_izmjere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_lokacija_izmjere.SelectedIndexChanged







        combobox_nadlezni_odjel.Items.Clear()
        combobox_nadlezni_odjel.Text = ""





    End Sub

    Private Sub combobox_tip_odjela_MouseClick(sender As Object, e As MouseEventArgs) Handles combobox_lokacija_izmjere.MouseClick



        'combobox_nadlezni_odjel.Items.Clear()
        'combobox_nadlezni_odjel.Text = ""
    End Sub

    Private Sub combobox_zupanija_MouseClick(sender As Object, e As MouseEventArgs) Handles combobox_zupanija.MouseClick



        'combobox_tip_odjela.Items.Clear()
        'combobox_tip_odjela.Text = ""


    End Sub

    Private Sub combobox_zupanija_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_zupanija.SelectedIndexChanged

        combobox_lokacija_izmjere.Items.Clear()
        combobox_lokacija_izmjere.Text = ""







        If combobox_zupanija.SelectedItem = "Dubrovačko-neretvanska županija" Then

            '*******************
            combobox_lokacija_izmjere.Items.Add("Staševica")
        ElseIf combobox_zupanija.SelectedItem = "Zadarska županija" Then

            combobox_lokacija_izmjere.Items.Add("Starigrad")

        ElseIf combobox_zupanija.SelectedItem = "Splitsko-dalmatinska županija" Then

            combobox_lokacija_izmjere.Items.Add("Zmijavci")

        ElseIf combobox_zupanija.SelectedItem = "Splitsko-dalmatinska županija" Then

            combobox_lokacija_izmjere.Items.Add("Zmijavci")

        ElseIf combobox_zupanija.SelectedItem = "Sisačko-moslavačka županija" Then

            combobox_lokacija_izmjere.Items.Add("Petrinja")
        End If





    End Sub

    Private Sub combobox_nadlezni_odjel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_nadlezni_odjel.SelectedIndexChanged

    End Sub
End Class