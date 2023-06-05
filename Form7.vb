Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vrsta_akta_combobox.Items.Add("Uredno zaprimljeno")
        vrsta_akta_combobox.Items.Add("Obaviješten - nije predigao")
        vrsta_akta_combobox.Items.Add("Nepoznat")
        vrsta_akta_combobox.Items.Add("Odselio")
        vrsta_akta_combobox.Items.Add("Umro")



        vrsta_akta_combobox.SelectedIndex = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vrsta_akta = vrsta_akta_combobox.SelectedItem
        broj_povratnice = TextBox1.Text

        If vrsta_akta = "" Then

            vrsta_akta = vrsta_akta_combobox.Text
        End If

        If vrsta_akta = "Obaviješten - nije predigao" Then
            vrsta_akta = "Obaviješten - nije predigao"

            putanja_pdf = putanja_pdf_ob



        ElseIf vrsta_akta = "Nepoznat" Then
            vrsta_akta = "Nepoznat, odselio, umro"
            putanja_pdf = putanja_pdf_nps

        ElseIf vrsta_akta = "Odselio" Then
            vrsta_akta = "Nepoznat, odselio, umro"
            putanja_pdf = putanja_pdf_nps
        ElseIf vrsta_akta = "Umro" Then
            vrsta_akta = "Nepoznat, odselio, umro"
            putanja_pdf = putanja_pdf_nps
        ElseIf vrsta_akta = "Uredno zaprimljeno" Then
            vrsta_akta = "Uredno zaprimljeno"
            putanja_pdf = putanja_pdf_ur

        End If








        If broj_povratnice = "" Then

            MsgBox("Unesi broj povratnice !", MsgBoxStyle.Exclamation, "GZS povratnice")
            Exit Sub
        End If



        If lokacija_izmjere = "Zmijavci" Then
            broj_povratnice = "ZM-" + broj_povratnice
        ElseIf lokacija_izmjere = "Petrinja" Then
            broj_povratnice = "PET_" + broj_povratnice

        ElseIf lokacija_izmjere = "Starigrad" Then
            broj_povratnice = "ST-" + broj_povratnice

        ElseIf lokacija_izmjere = "Staševica" Then
            broj_povratnice = "STA-" + broj_povratnice


        End If







        Me.Close()

    End Sub






    Private Sub vrsta_akta_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vrsta_akta_combobox.SelectedIndexChanged
        SendKeys.Send("{TAB}")
    End Sub
End Class