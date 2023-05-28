
Imports System.IO
Imports System.Text
Imports System.Data.SQLite
Imports WinSCP


Public Class Form4


    Private dbcommand As String = ""
    Private bindingsrc As BindingSource

    Private CONSTRING As String = "Data Source=" & dbpath & "Version=3;New=False;Compress=True;"

    Private connection As New SQLiteConnection(CONSTRING)
    Private command As New SQLiteCommand("", connection)
    Private sql As String = ""

    Private linija_jedan As String
    Private linija_dva As String
    Private linija_tri As String
    Private linija_cetiri As String
    Private linija_pet As String
    Private linija_sest As String
    Private linija_sedam As String
    Private linija_osam As String
    Private linija_devet As String
    Private linija_deset As String
    Private linija_jedanaest As String

    Private linija_1 As String
    Private linija_2 As String
    Private linija_3 As String
    Private linija_4 As String
    Private linija_5 As String
    Private linija_6 As String
    Private linija_7 As String
    Private linija_8 As String
    Private linija_9 As String
    Private linija_10 As String
    Private linija_11 As String


    Private datoteka As String
    Private trenutni_radni_dan As String

    Private files() As System.IO.FileInfo



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spremi_podatke.Click


        Dim dakta As String
        Dim dan As String

        Dim mjesec As String
        Dim godina As String
        Dim duljina As Integer
        Dim crta_1 As Integer
        Dim crta_2 As Integer
        Dim crta_3 As String
        Dim crta_4 As String
        Dim cs As String



        dan = ""
        mjesec = ""
        godina = ""
        crta_3 = ""
        crta_4 = ""

        crta_1 = 0
        crta_2 = 0
        dakta = datum_aktatextbox.Text.Trim()
        duljina = Len(dakta)


        If dakta = "Null" Then
            GoTo 100
        ElseIf dakta = "" Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        ElseIf duljina < 8 Or duljina > 10 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If



        cs = ""

        For i = 1 To duljina
            cs = Mid(dakta, i, 1)
            If cs <> "-" Then
                Continue For
            ElseIf cs = "-" Then
                crta_1 = i
                Exit For
            ElseIf i = duljina Then
                datum_aktatextbox.BackColor = Color.LightCoral
                MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub
            End If
        Next

        cs = ""

        For i = (crta_1 + 1) To duljina
            cs = Mid(dakta, i, 1)
            If cs <> "-" Then
                Continue For
            ElseIf cs = "-" Then
                crta_2 = i
                Exit For
            ElseIf i = duljina Then
                datum_aktatextbox.BackColor = Color.LightCoral
                MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub
            End If
        Next


        If crta_1 = 2 Then
            dan = Microsoft.VisualBasic.Left(dakta, 1)
        ElseIf crta_1 = 3 Then
            dan = Microsoft.VisualBasic.Left(dakta, 2)
        ElseIf crta_1 > 3 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End If


        If crta_2 = 4 And (Len(dan)) = 1 Then
            mjesec = Mid(dakta, 3, 1)

        ElseIf crta_2 = 5 And (Len(dan)) = 2 Then
            mjesec = Mid(dakta, 4, 1)

        ElseIf crta_2 = 5 And (Len(dan)) = 1 Then
            mjesec = Mid(dakta, 3, 2)


        ElseIf crta_2 = 6 And (Len(dan)) = 2 Then
            mjesec = Mid(dakta, 4, 2)



        ElseIf crta_2 > 6 Or crta_2 < 4 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End If



        crta_3 = Microsoft.VisualBasic.Right(dakta, 6)
        crta_4 = Mid(crta_3, 1, 1)


        If IsNumeric(crta_4) <> True Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")

            Exit Sub

        End If

        godina = Microsoft.VisualBasic.Right(dakta, 4)

        If IsNumeric(dan) <> True Or IsNumeric(mjesec) <> True Or IsNumeric(godina) <> True Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos datuma!" & vbCrLf & "Datum unesi u obliku 7-1-1977 ili 07-01-1977", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If



        If (Val(dan)) < 1 Or (Val(dan)) > 31 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos dana !" & vbCrLf & "Dan može biti u rasponu od 1-31", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        ElseIf (Val(mjesec)) < 1 Or (Val(mjesec)) > 12 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos mjeseca!" & vbCrLf & "Mjesec može biti u rasponu od 1-12", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        ElseIf (Val(godina)) < 1968 Then
            datum_aktatextbox.BackColor = Color.LightCoral
            MsgBox("Pogrešan format za unos godine!" & vbCrLf & "Moguće unijeti samo godine u rasponu od 1968-....", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End If


        datum_aktatextbox.BackColor = Color.YellowGreen


100:    Dim broj_datoteka As Integer
        Dim putanja_txt_save As String

        Dim putanja_txt_save2 As String


        'Imena JSON datoteka

        putanja_txt_save = putanja_txt + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"
        putanja_txt_save2 = putanja_txt2 + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"


        datoteka = ""
        linija_10 = ""



        cs = ""



        Dim dirinfo As New System.IO.DirectoryInfo(putanja_jpgtemp)
        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.AllDirectories)


        broj_datoteka = 0
        For Each file In files
            broj_datoteka = broj_datoteka + 1

            If broj_datoteka = 1 Then
                datoteka = datoteka + file.Name
            Else
                datoteka = datoteka + ";" + file.Name
            End If


        Next

        Dim di As Integer
        Dim di2 As Integer


        imepdf = ""
        di2 = 0
        cs = ""
        di = 0



        di = Len(pdf_potpisani)

        For i = di To 1 Step -1
            cs = Mid(pdf_potpisani, i, 1)
            If cs <> "\" Then
                Continue For
            Else
                di2 = i

                imepdf = Microsoft.VisualBasic.Right(pdf_potpisani, (di - di2))
                Exit For

            End If
        Next

        If String.IsNullOrEmpty(ostecena_stranicatextbox.Text.Trim()) Then
            linija_devet = "0"
        Else
            linija_devet = ostecena_stranicatextbox.Text.Trim()
        End If

        If String.IsNullOrEmpty(neodostajuca_stranicatextbox.Text.Trim()) Then
            linija_osam = "0"
        Else
            linija_osam = neodostajuca_stranicatextbox.Text.Trim()
        End If



        linija_jedan = imepdf

        linija_tri = vrsta_akta
        linija_cetiri = ispostavatextbox.Text
        linija_pet = upravni_odjeltextbox.Text
        linija_sest = zupanijatextbox.Text
        If dakta = "Null" Then

            linija_sedam = "Null"
        Else
            linija_sedam = godina + "-" + mjesec + "-" + dan
        End If
        linija_sedam = godina + "-" + mjesec + "-" + dan

        linija_deset = datoteka

        Dim pomdatum As String
        pomdatum = Date.Today.ToString("ddd")

        linija_jedanaest = pomdatum + " " + DateTime.Now.ToString("dd.MM.yyyy")




        linija_1 = Chr(34) & "nazivDatoteke" & Chr(34) + ":" + " " + "" + Chr(34) & linija_jedan & Chr(34) + ","
        'linija_2 = Chr(34) & "nazivDatotekeTIFF" & Chr(34) + ":" + " " + "" + Chr(34) & linija_dva & Chr(34) + ","
        linija_3 = Chr(34) & "tipDozvole" & Chr(34) + ":" + " " + "" + Chr(34) & linija_tri & Chr(34) + ","
        linija_4 = Chr(34) & "ispostava" & Chr(34) + ":" + " " + "" + Chr(34) & linija_cetiri & Chr(34) + ","
        linija_5 = Chr(34) & "tipUpravnogodjela" & Chr(34) + ":" + " " + "" + Chr(34) & linija_pet & Chr(34) + ","
        linija_6 = Chr(34) & "zupanija" & Chr(34) + ":" + " " + "" + Chr(34) & linija_sest & Chr(34) + ","
        linija_7 = Chr(34) & "Datum_rjesenja_akta" & Chr(34) + ":" + " " + "" + Chr(34) & linija_sedam & Chr(34) + ","
        linija_8 = Chr(34) & "Broj_stranice_koja_nedostaje" & Chr(34) + ":" + " " + "" + Chr(34) & linija_osam & Chr(34) + ","
        linija_9 = Chr(34) & "Broj_ostecene_stranice" & Chr(34) + ":" + " " + "" + Chr(34) & linija_devet & Chr(34) + ","
        linija_10 = Chr(34) & "Kreirano_od" & Chr(34) + ":" + " " + "" + Chr(34) & linija_deset & Chr(34) + ","
        linija_11 = Chr(34) & "Datum_kreiranja" & Chr(34) + ":" + " " + "" + Chr(34) & linija_jedanaest & Chr(34) + ","


        ' {
        '"nazivDatoteke": "2021-12-13Druga_grupa2.pdf",
        '"nazivDatotekeTIFF": "2021-12-13Druga_grupa2.TIFF",
        '"tipdozvole": "Rješenje",
        '"ispostava": "Ispostava Imotski",
        '"tipUpravnogOdjela": "Odjel Imotski",
        '"zupanija": "Splitsko-dalmatinska",
        '"Datum_rjesenja_akta": "1994-10-08",
        '"Broj_stranice_koja_nedostaje": "",
        '"Broj_ostecene_stranice": "",
        ' "Kreirano_od": "image00001.jpg;image00002.jpg",
        '"Datum_kreiranja": "pon 13.12.2021." 
        '},


        If String.IsNullOrEmpty(tipdozvole_textbox.Text.Trim()) Or
                String.IsNullOrEmpty(zupanijatextbox.Text.Trim()) Or
                String.IsNullOrEmpty(datum_aktatextbox.Text.Trim()) Then
            MessageBox.Show("Popuni sva polja ili za prazna polja dodaj tekst NULL", "GZS sken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If



        Using writer As StreamWriter = New StreamWriter(putanja_txt_save)

            writer.WriteLine("{")
            writer.WriteLine(linija_1)
            'writer.WriteLine(linija_2)
            writer.WriteLine(linija_3)
            writer.WriteLine(linija_4)
            writer.WriteLine(linija_5)
            writer.WriteLine(linija_6)
            writer.WriteLine(linija_7)
            writer.WriteLine(linija_8)
            writer.WriteLine(linija_9)
            writer.WriteLine(linija_10)
            writer.WriteLine(linija_11)
            writer.WriteLine("},")
            writer.Close()

        End Using


        putanja_txt_save = ""


        Using writer As StreamWriter = New StreamWriter(putanja_txt_save2)

            writer.WriteLine("{")
            writer.WriteLine(linija_1)
            'writer.WriteLine(linija_2)
            writer.WriteLine(linija_3)
            writer.WriteLine(linija_4)
            writer.WriteLine(linija_5)
            writer.WriteLine(linija_6)
            writer.WriteLine(linija_7)
            writer.WriteLine(linija_8)
            writer.WriteLine(linija_9)
            writer.WriteLine(linija_10)
            writer.WriteLine(linija_11)
            writer.WriteLine("},")

            writer.Close()


        End Using


        putanja_txt_save2 = ""



        Form1.reset_skena_buton.Enabled = False
        Form1.metapodaci_buton.Enabled = False
        Form1.metapodaci_check.Enabled = True
        Form1.metapodaci_check.Checked = True
        Form1.zavrsi_dan_buton.Enabled = True


        Try



            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If




            dbcommand = "INSERT"
            sql = "INSERT INTO Skeniranje (Broj_skena, Pdf, Tip_dozvole, Ispostava, Upravni_odjel, Zupanija, Datum_akta, Ostecena_stranica, Nedostajuca_stranica, Kreirano_od, Datum_kreiranja) " &
                            "VALUES (@Broj_skena, @Pdf, @Tip_dozvole, @Ispostava, @Upravni_odjel, @Zupanija, @Datum_akta, @Ostecena_stranica, @Nedostajuca_stranica, @Kreirano_od, @Datum_kreiranja)"


            AddCmdParameters()


            Dim execute As Integer = command.ExecuteNonQuery()

            If execute = -1 Then
                MessageBox.Show("Podaci nisu spremeljeni u SQLite bazu - Pogreška u spremnanju..", "GZS sken",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else



                AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                              Return MessageBox.Show(Me, "Podaci uspješno dodani u SQLite bazu", caption, buttons, MessageBoxIcon.Information)
                                                          End Function, caption:="GZS sken").Show(timeout:=1000, buttons:=MessageBoxButtons.OK)


                Form1.CircularProgressBar1.Value = 100
                Form1.CircularProgressBar1.Text = 100
                Form1.CircularProgressBar1.Refresh()

            End If



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(),
                            "GZS sken",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbcommand = ""
            connection.Close()


        End Try


        If ftp_slanje = True Then
            spremi_podatke.Enabled = False
            Task.Run(Sub() Upload())
        Else

            Me.Close()

        End If

    End Sub


    Private Sub AddCmdParameters()
        command.Parameters.Clear()
        command.CommandText = sql


        command.Parameters.AddWithValue("Broj_skena", broj_skenatextbox.Text.Trim())
        command.Parameters.AddWithValue("Pdf", imepdf.Trim())
        command.Parameters.AddWithValue("Tip_dozvole", tipdozvole_textbox.Text.Trim())
        command.Parameters.AddWithValue("Ispostava", ispostavatextbox.Text.Trim())
        command.Parameters.AddWithValue("Upravni_odjel", upravni_odjeltextbox.Text.Trim())
        command.Parameters.AddWithValue("Zupanija", zupanijatextbox.Text.Trim())
        command.Parameters.AddWithValue("Datum_akta", datum_aktatextbox.Text.Trim())
        command.Parameters.AddWithValue("Ostecena_stranica", linija_osam.Trim())
        command.Parameters.AddWithValue("Nedostajuca_stranica", linija_devet.Trim())
        command.Parameters.AddWithValue("Kreirano_od", linija_deset.Trim())
        command.Parameters.AddWithValue("Datum_kreiranja", linija_jedanaest.Trim())

    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ftp_slanje = My.Settings.ftp_slanje

        ProgressBar1.Visible = False
        Label11.Visible = False

        Dim di As Integer
        Dim di2 As Integer
        Dim cs As String


        imepdf = ""
        di2 = 0
        cs = ""
        di = 0



        di = Len(pdf_potpisani)

        For i = di To 1 Step -1
            cs = Mid(pdf_potpisani, i, 1)
            If cs <> "\" Then
                Continue For
            Else
                di2 = i

                imepdf = Microsoft.VisualBasic.Right(pdf_potpisani, (di - di2))
                Exit For

            End If
        Next



        broj_skenatextbox.Text = broj_skena

        pdf_datotekatextbox.Text = imepdf
        tipdozvole_textbox.Text = vrsta_akta



        If lokacija_izmjere = "Ured" Then


            upravni_odjeltextbox.Text = My.Settings.nadlezni_odjel
            zupanijatextbox.Text = My.Settings.zupanija_skeniranja
            ispostavatextbox.Text = ""

        ElseIf lokacija_izmjere = "Ispostava" Then


            upravni_odjeltextbox.Text = ""
            zupanijatextbox.Text = My.Settings.zupanija_skeniranja
            ispostavatextbox.Text = My.Settings.nadlezni_odjel

        End If




    End Sub



    Private Sub tip_dozvolecombobox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub


    Private Sub ispostavatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ispostavatextbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub



    Private Sub upravni_odjeltextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles upravni_odjeltextbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub



    Private Sub zupanijatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles zupanijatextbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub datum_aktatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datum_aktatextbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ostecena_stranicatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ostecena_stranicatextbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Upload()

        Dim sftp_slanje As String

        sftp_slanje = My.Settings.sftp_slanje

        trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")


        Try


            Using session As New Session
                Dim sessionOptions As New SessionOptions
                With sessionOptions

                    If sftp_slanje = True Then
                        .Protocol = Protocol.Sftp
                        .HostName = My.Settings.ime_servera
                        .UserName = My.Settings.username
                        .Password = My.Settings.lozinka
                        .SshHostKeyFingerprint = My.Settings.fingerprint

                        .PortNumber = My.Settings.broj_porta
                        .TimeoutInMilliseconds = 60000
                        session.DisableVersionCheck = True
                    Else
                        .Protocol = Protocol.Ftp

                        .HostName = My.Settings.ime_servera
                        .UserName = My.Settings.username
                        .Password = My.Settings.lozinka


                        .PortNumber = My.Settings.broj_porta
                        .TimeoutInMilliseconds = 60000
                        session.DisableVersionCheck = True

                    End If


                End With


                AddHandler session.FileTransferProgress, Sub(sender, e) ProgressBar1.Invoke(
                    Sub()

                        ProgressBar1.Visible = True
                        spremi_podatke.Text = "Šalju se podaci akta..."
                        spremi_podatke.Enabled = False


                        Label11.Visible = True
                        ProgressBar1.Value = CInt(e.OverallProgress * 100)
                        Label11.Text = (Str(CInt(e.OverallProgress * 100))) + " %"

                    End Sub)

                session.Open(sessionOptions)

                'session.PutFilesToDirectory(localDirectory, remoteDirectory).Check()


                If Not session.FileExists("SKENIRANJE_TEREN") Then
                    session.CreateDirectory("SKENIRANJE_TEREN")
                End If



                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe) Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe)
                End If


                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder) Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder)
                End If

                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/DB") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/DB")
                End If


                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/JPGTEMP") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/JPGTEMP")

                End If


                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/SLIKANO") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/SLIKANO")

                End If

                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF")

                End If


                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF_A") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF_A")

                End If



                If Not session.FileExists("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/TXT") Then
                    session.CreateDirectory("SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/TXT")

                End If


                session.PutFilesToDirectory(putanja_grupe + "\JPGTEMP", "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/SLIKANO", "*.jpg").Check()
                session.PutFilesToDirectory(putanja_grupe + "\PDF", "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF", trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf").Check()
                session.PutFilesToDirectory(putanja_grupe + "\PDF_A", "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/PDF_A", trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf").Check()
                session.PutFilesToDirectory(putanja_grupe + "\TXT", "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/TXT", trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt").Check()
                session.PutFilesToDirectory(putanja_grupe + "\DB", "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder + "/DB").Check()

                '
                '
                MsgBox("Slanje podataka na server uspješno je izvršeno..", MsgBoxStyle.Information, "GZS sken")


                Me.Invoke(Sub() zavrseno())

            End Using


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Exclamation, "GZS sken")

        End Try



    End Sub

    Private Sub zavrseno()
        spremi_podatke.Enabled = True
        spremi_podatke.Text = "Spremi podatke"

        ProgressBar1.Visible = False
        Label11.Visible = False


        For Each file In files
            file.Delete()
        Next



        Me.Close()

    End Sub

End Class

