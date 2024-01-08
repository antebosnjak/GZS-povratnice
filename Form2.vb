
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ime_foldera As String
        Dim folderDlg As New FolderBrowserDialog

        folderDlg.ShowNewFolderButton = True

        If (folderDlg.ShowDialog() = DialogResult.OK) Then


            putanja_povratnice = folderDlg.SelectedPath


            ime_foldera = Microsoft.VisualBasic.Right(putanja_povratnice, 10)


            If ime_foldera <> "POVRATNICE" Then

                putanja_povratnice = ""
                MsgBox("Izaberi ispravnu lokaciju foldera POVRATNICE", MsgBoxStyle.Exclamation, "GZS povratnice")
                Exit Sub


            End If


            TextBox1.Text = putanja_povratnice


        End If








    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles spremi_postavke_buton.Click



        ime_prezime_operator = TextBox2.Text
        naziv_grupe = TextBox3.Text

        My.Settings.putanja_povratnice = putanja_povratnice
        My.Settings.ime_prezime_operator = ime_prezime_operator
        My.Settings.naziv_grupe = naziv_grupe



        putanja_povratnice = My.Settings.putanja_povratnice
        ime_prezime_operator = My.Settings.ime_prezime_operator
        naziv_grupe = My.Settings.naziv_grupe




        If putanja_povratnice <> "" And ime_prezime_operator <> "" And naziv_grupe <> "" Then
            Form1.zelena_kvacica_6.Visible = True
            Form1.crveni_kriz_3.Visible = False
        Else
            Form1.crveni_kriz_3.Visible = True
            Form1.zelena_kvacica_6.Visible = False
        End If




        If putanja_povratnice <> "" And ime_prezime_operator <> "" And naziv_grupe <> "" Then

            Form1.start_radnog_dana_buton.Enabled = True
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False

            Form1.metapodaci_check.Enabled = False


            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        Else
            Form1.start_radnog_dana_buton.Enabled = False
            Form1.zelena_kvacica_1.Visible = False


            Form1.skeniraj_buton.Enabled = False
            Form1.sken_check.Enabled = False

            Form1.metapodaci_check.Enabled = False


            Form1.metapodaci_buton.Enabled = False
            Form1.novi_sken_buton.Enabled = False
            Form1.zavrsi_dan_buton.Enabled = False
            Form1.reset_skena_buton.Enabled = False
        End If


        Me.Close()



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If start_radnog_dana = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            spremi_postavke_buton.Enabled = False
            Button1.Enabled = False


        End If



        ftp_slanje = My.Settings.ftp_slanje
        naziv_grupe = My.Settings.naziv_grupe
        TextBox1.Text = putanja_povratnice
        TextBox2.Text = ime_prezime_operator
        TextBox3.Text = naziv_grupe

        If ftp_slanje = True Then
            ftp_slanje_checkbox.Checked = True
            ftp_postavke_buton.Enabled = True
        Else
            ftp_slanje_checkbox.Checked = False
            ftp_postavke_buton.Enabled = False
        End If



    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles reset_dana_buton.Click



        Select Case MsgBox("Je li zaista želiš resetirati radni dan ?", MsgBoxStyle.YesNo, "GZS sken")


            Case MsgBoxResult.Yes


                Form1.o_programu_buton.Visible = True
                Form1.CircularProgressBar1.Visible = False



                novi_radni_dan = ""
                My.Settings.novi_radni_dan = novi_radni_dan
                Form1.start_radnog_dana_buton.Enabled = True


                start_radnog_dana = False
                My.Settings.start_radnog_dana = False


                Dim ChkBox As CheckBox = Nothing
                ' to unchecked all 
                For Each xObject As Object In Form1.GroupBox1.Controls
                    If TypeOf xObject Is CheckBox Then
                        ChkBox = xObject
                        ChkBox.Checked = False
                    End If
                Next


                Form1.zelena_kvacica_1.Visible = False

                Form1.zelena_kvacica_s.Visible = False
                Form1.zelena_kvacica_s.Refresh()

                Form1.zelena_kvacica_m.Visible = False
                Form1.zelena_kvacica_m.Refresh()
                Form1.zelena_kvacica_v.Visible = False
                Form1.zelena_kvacica_v.Refresh()
                Form1.zelena_kvacica_k.Visible = False
                Form1.zelena_kvacica_k.Refresh()




                Form1.metapodaci_buton.Enabled = False
                Form1.novi_sken_buton.Enabled = False
                Form1.skeniraj_buton.Enabled = False
                Form1.zelena_kvacica_1.Enabled = False
                Form1.reset_skena_buton.Enabled = False
                Form1.zavrsi_dan_buton.Enabled = False
                Form1.vrsta_akta_buton.Enabled = False
                Form1.kreiraj_pdf_buton.Enabled = False

                Form1.kreiran_pdf_check.Enabled = False
                Form1.sken_check.Enabled = False
                Form1.metapodaci_check.Enabled = False
                Form1.vrsta_akta_checkbox.Enabled = False



                Form1.broj_skena_textbox.Text = ""


                Me.Close()
                Exit Sub

            Case MsgBoxResult.No
                Exit Sub
        End Select

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ftp_slanje_checkbox.CheckedChanged
        If ftp_slanje_checkbox.Checked = True Then

            ftp_slanje = True
            My.Settings.ftp_slanje = ftp_slanje

            ftp_postavke_buton.Enabled = True

        Else

            ftp_slanje = False
            My.Settings.ftp_slanje = ftp_slanje

            ftp_postavke_buton.Enabled = False
        End If




    End Sub

    Private Sub ftp_postavke_buton_Click(sender As Object, e As EventArgs) Handles ftp_postavke_buton.Click


        If ime_prezime_operator = "" Or putanja_povratnice = "" Or naziv_grupe = "" Then

            MsgBox("Unesi Putanju, Ime i prezime i naziv grupe !", MsgBoxStyle.Exclamation, "GZS sken")
        Else

            Dim frmDialogue As New Form6

            frmDialogue.ShowDialog()

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class