
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



        Dim dan As String

        Dim mjesec As String
        Dim godina As String

        Dim crta_3 As String
        Dim crta_4 As String
        Dim cs As String



        dan = ""
        mjesec = ""
        godina = ""
        crta_3 = ""
        crta_4 = ""







100:    Dim broj_datoteka As Integer







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



        di = Len(pdf_nepotpisani)

        For i = di To 1 Step -1
            cs = Mid(pdf_nepotpisani, i, 1)
            If cs <> "\" Then
                Continue For
            Else
                di2 = i

                imepdf = Microsoft.VisualBasic.Right(pdf_nepotpisani, (di - di2))
                Exit For

            End If
        Next






        If String.IsNullOrEmpty(vrstapovratnice_textbox.Text.Trim()) Or
                 String.IsNullOrEmpty(nazivizmjere_textbox.Text.Trim()) Or
                String.IsNullOrEmpty(datum_textbox.Text.Trim()) Then
            MessageBox.Show("Popuni sva polja ili za prazna polja dodaj tekst NULL", "GZS povratnice", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If






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
            sql = "INSERT INTO Skeniranje (Broj_skena, Pdf, Vrsta_povratnice, Naziv_izmjere, Kreirano_od, Datum_kreiranja)" &
                            "VALUES (@Broj_skena, @Pdf, @Vrsta_povratnice, @Naziv_izmjere, @Kreirano_od, @Datum_kreiranja)"


            AddCmdParameters()


            Dim execute As Integer = command.ExecuteNonQuery()

            If execute = -1 Then
                MessageBox.Show("Podaci nisu spremeljeni u SQLite bazu - Pogreška u spremnanju..", "GZS sken",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else



                AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                              Return MessageBox.Show(Me, "Podaci uspješno dodani u SQLite bazu", caption, buttons, MessageBoxIcon.Information)
                                                          End Function, caption:="GZS povratnice").Show(timeout:=1000, buttons:=MessageBoxButtons.OK)


                Form1.CircularProgressBar1.Value = 100
                Form1.CircularProgressBar1.Text = 100
                Form1.CircularProgressBar1.Refresh()

            End If



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(),
                            "GZS povratnice",
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
        command.Parameters.AddWithValue("Vrsta_povratnice", vrstapovratnice_textbox.Text.Trim())
        command.Parameters.AddWithValue("Naziv_izmjere", nazivizmjere_textbox.Text.Trim())
        command.Parameters.AddWithValue("Kreirano_od", datoteka.Trim())
        command.Parameters.AddWithValue("Datum_kreiranja", datum_textbox.Text.Trim())

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



        di = Len(pdf_nepotpisani)

        For i = di To 1 Step -1
            cs = Mid(pdf_nepotpisani, i, 1)
            If cs <> "\" Then
                Continue For
            Else
                di2 = i

                imepdf = Microsoft.VisualBasic.Right(pdf_nepotpisani, (di - di2))
                Exit For

            End If
        Next



        broj_skenatextbox.Text = broj_skena
        pdf_datotekatextbox.Text = imepdf
        vrstapovratnice_textbox.Text = vrsta_akta
        nazivizmjere_textbox.Text = lokacija_izmjere
        datum_textbox.Text = DateTime.Now.ToString("dd/MM/yyyy")






    End Sub



    Private Sub tip_dozvolecombobox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub


    Private Sub ispostavatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nazivizmjere_textbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub



    Private Sub upravni_odjeltextbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub



    Private Sub zupanijatextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datum_textbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub datum_aktatextbox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ostecena_stranicatextbox_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub ostecena_stranicatextbox_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class

