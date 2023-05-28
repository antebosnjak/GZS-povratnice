Imports System.IO

Imports System.Data.SQLite
Imports Spire.Pdf

Imports Spire.Pdf.Graphics

Imports Spire.Pdf.Conversion




Public Class Form1

    Private files() As System.IO.FileInfo

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmDialogue As New Form3

        frmDialogue.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frmDialogue As New Form2

        frmDialogue.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        start_radnog_dana = My.Settings.start_radnog_dana

        broj_skena = My.Settings.broj_skena


        naziv_grupe = My.Settings.naziv_grupe
        putanja_povratnice = My.Settings.putanja_povratnice
        ime_prezime_operator = My.Settings.ime_prezime_operator
        zupanija_skeniranja = My.Settings.zupanija_skeniranja
        lokacija_izmjere = My.Settings.lokacija_izmjere
        nadlezni_odjel = My.Settings.nadlezni_odjel
        novi_radni_dan = My.Settings.novi_radni_dan

        putanja_pdf = My.Settings.putanja_pdf

        putanja_txt = My.Settings.putanja_txt

        putanja_slika = My.Settings.putanja_slika

        putanja_tiff = My.Settings.putanja_tiff
        putanja_jpgtemp = My.Settings.putanja_jpgtemp

        putanja_pdf2 = My.Settings.putanja_pdf2

        putanja_pdf_a = My.Settings.putanja_pdf_a
        putanja_pdf2_a = My.Settings.putanja_pdf2_a
        putanja_not_pdf_a = My.Settings.putanja_not_pdf_a

        putanja_txt2 = My.Settings.putanja_txt2

        putanja_slika2 = My.Settings.putanja_slika2

        putanja_tiff2 = My.Settings.putanja_tiff2
        putanja_db = My.Settings.putanja_db
        dbpath = My.Settings.dbpath
        putanja_broj_skena = My.Settings.putanja_broj_skena
        putanja_prijenosa = My.Settings.putanja_prijenosa
        putanja_grupe = My.Settings.putanja_grupe
        putanja_grupe2 = My.Settings.putanja_grupe2



        ime_grupe_folder = My.Settings.ime_grupe_folder

        putanja_postavki = My.Settings.putanja_postavki
        naziv_grupe = My.Settings.naziv_grupe



        If broj_skena = 0 Then
            broj_skena_textbox.Text = ""
        Else
            broj_skena_textbox.Text = broj_skena
        End If



        If ime_prezime_operator = "" Or putanja_povratnice = "" Or naziv_grupe = "" Or zupanija_skeniranja = "" Or lokacija_izmjere = "" Then

            start_radnog_dana_buton.Enabled = False
            zelena_kvacica_1.Visible = False
            skeniraj_buton.Enabled = False
            sken_check.Enabled = False
            potpis_check.Enabled = False
            metapodaci_check.Enabled = False
            kreiran_pdf_check.Enabled = False
            vrsta_akta_checkbox.Enabled = False


            digitalni_potpis_buton.Enabled = False
            metapodaci_buton.Enabled = False
            novi_sken_buton.Enabled = False
            zavrsi_dan_buton.Enabled = False
            kreiraj_pdf_buton.Enabled = False
            reset_skena_buton.Enabled = False
            vrsta_akta_buton.Enabled = False


            o_programu_buton.Visible = True
            CircularProgressBar1.Visible = False



        ElseIf novi_radni_dan = DateTime.Now.ToString("MM/dd/yyyy") Then
            'MsgBox(novi_radni_dan)
            start_radnog_dana_buton.Enabled = False
            zelena_kvacica_1.Visible = True


            o_programu_buton.Visible = False
            CircularProgressBar1.Visible = True
            CircularProgressBar1.Minimum = 0
            CircularProgressBar1.Maximum = 100
            CircularProgressBar1.StartAngle = 270
            CircularProgressBar1.Text = 0
            CircularProgressBar1.Value = 0
            CircularProgressBar1.Refresh()



            skeniraj_buton.Enabled = True
            sken_check.Enabled = False
            potpis_check.Enabled = False
            metapodaci_check.Enabled = False
            kreiran_pdf_check.Enabled = False
            vrsta_akta_checkbox.Enabled = False


            digitalni_potpis_buton.Enabled = False
            metapodaci_buton.Enabled = False
            novi_sken_buton.Enabled = False
            zavrsi_dan_buton.Enabled = True
            kreiraj_pdf_buton.Enabled = False
            vrsta_akta_buton.Enabled = False

            reset_skena_buton.Enabled = True

        Else

            start_radnog_dana_buton.Enabled = True
            zelena_kvacica_1.Visible = False

            o_programu_buton.Visible = True
            CircularProgressBar1.Visible = False


            skeniraj_buton.Enabled = False
            sken_check.Enabled = False
            potpis_check.Enabled = False
            metapodaci_check.Enabled = False
            kreiran_pdf_check.Enabled = False
            vrsta_akta_checkbox.Enabled = False

            digitalni_potpis_buton.Enabled = False
            metapodaci_buton.Enabled = False
            vrsta_akta_buton.Enabled = False

            novi_sken_buton.Enabled = False

            zavrsi_dan_buton.Enabled = True
            zavrsi_dan_buton.Text = "Slanje podataka"

            kreiraj_pdf_buton.Enabled = False
            reset_skena_buton.Enabled = False

        End If



        If zupanija_skeniranja <> "" And lokacija_izmjere <> "" Then
            zelena_kvacica_5.Visible = True

            crveni_kriz_2.Visible = False
        Else
            crveni_kriz_2.Visible = True
            zelena_kvacica_5.Visible = False
        End If

        If putanja_povratnice <> "" And ime_prezime_operator <> "" And naziv_grupe <> "" Then
            zelena_kvacica_6.Visible = True
            crveni_kriz_3.Visible = False
        Else
            crveni_kriz_3.Visible = True
            zelena_kvacica_6.Visible = False
        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles start_radnog_dana_buton.Click


        If ime_prezime_operator = "" Or putanja_povratnice = "" Or naziv_grupe = "" Or zupanija_skeniranja = "" Or lokacija_izmjere = "" Or nadlezni_odjel = "" Then

            MsgBox("Unesi postavke...", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If


        start_radnog_dana = True
        My.Settings.start_radnog_dana = start_radnog_dana


        zavrsi_dan_buton.Text = "Završi dan"



        Dim trenutni_radni_dan As String




        broj_skena = 1
        broj_skena_textbox.Text = broj_skena

        novi_radni_dan = DateTime.Now.ToString("MM/dd/yyyy")
        My.Settings.novi_radni_dan = novi_radni_dan
        My.Settings.broj_skena = broj_skena


        start_radnog_dana_buton.Enabled = False
        zelena_kvacica_1.Visible = True

        skeniraj_buton.Enabled = True
        reset_skena_buton.Enabled = True
        zavrsi_dan_buton.Enabled = True


        trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")



        ime_grupe_folder = trenutni_radni_dan + naziv_grupe

        putanja_grupe = putanja_povratnice + "\" + ime_grupe_folder
        putanja_grupe2 = "C:\SKENIRANJE_HR" + "\" + ime_grupe_folder
        putanja_prijenosa = putanja_povratnice

        My.Settings.putanja_grupe = putanja_grupe
        My.Settings.putanja_grupe2 = putanja_grupe2
        My.Settings.ime_grupe_folder = ime_grupe_folder


        My.Settings.putanja_prijenosa = putanja_prijenosa

        putanja_postavki = putanja_povratnice + "\POSTAVLJANJE"



        'Putanja grupe
        If Not System.IO.Directory.Exists(putanja_grupe) Then
            System.IO.Directory.CreateDirectory(putanja_grupe)
        End If



        'Putanja grupe2
        If Not System.IO.Directory.Exists(putanja_grupe2) Then
            System.IO.Directory.CreateDirectory(putanja_grupe2)
        End If


        'Putanja postavki
        If Not System.IO.Directory.Exists(putanja_postavki) Then
            System.IO.Directory.CreateDirectory(putanja_postavki)
        End If



        putanja_pdf = putanja_grupe + "\PDF"
        putanja_txt = putanja_grupe + "\TXT"
        putanja_slika = putanja_grupe + "\SLIKANO"
        putanja_tiff = putanja_grupe + "\TIFF"
        putanja_jpgtemp = putanja_grupe + "\JPGTEMP"


        putanja_pdf2 = putanja_grupe2 + "\PDF"
        putanja_txt2 = putanja_grupe2 + "\TXT"
        putanja_slika2 = putanja_grupe2 + "\SLIKANO"
        putanja_tiff2 = putanja_grupe2 + "\TIFF"
        ' putanja_db = putanja_grupe2 + "\DB"
        putanja_db = putanja_grupe + "\DB"

        putanja_pdf_a = putanja_grupe + "\PDF_A"
        putanja_pdf2_a = putanja_grupe2 + "\PDF_A"
        putanja_not_pdf_a = putanja_grupe + "\N_PDF_A"


        My.Settings.putanja_pdf = putanja_pdf
        My.Settings.putanja_pdf_a = putanja_pdf_a
        My.Settings.putanja_not_pdf_a = putanja_not_pdf_a

        My.Settings.putanja_pdf2_a = putanja_pdf2_a


        My.Settings.putanja_txt = putanja_txt
        My.Settings.putanja_slika = putanja_slika
        My.Settings.putanja_tiff = putanja_tiff
        My.Settings.putanja_jpgtemp = putanja_jpgtemp


        My.Settings.putanja_pdf2 = putanja_pdf2
        My.Settings.putanja_txt2 = putanja_txt2
        My.Settings.putanja_slika2 = putanja_slika2
        My.Settings.putanja_tiff2 = putanja_tiff2
        My.Settings.putanja_db = putanja_db

        My.Settings.putanja_postavki = putanja_postavki



        'Putanja PDF
        If Not System.IO.Directory.Exists(putanja_pdf) Then
            System.IO.Directory.CreateDirectory(putanja_pdf)
        End If

        If Not System.IO.Directory.Exists(putanja_pdf2) Then
            System.IO.Directory.CreateDirectory(putanja_pdf2)
        End If


        If Not System.IO.Directory.Exists(putanja_pdf_a) Then
            System.IO.Directory.CreateDirectory(putanja_pdf_a)
        End If



        If Not System.IO.Directory.Exists(putanja_not_pdf_a) Then
            System.IO.Directory.CreateDirectory(putanja_not_pdf_a)
        End If


        If Not System.IO.Directory.Exists(putanja_pdf2_a) Then
            System.IO.Directory.CreateDirectory(putanja_pdf2_a)
        End If



        'Putanja TXT
        If Not System.IO.Directory.Exists(putanja_txt) Then
            System.IO.Directory.CreateDirectory(putanja_txt)
        End If

        If Not System.IO.Directory.Exists(putanja_txt2) Then
            System.IO.Directory.CreateDirectory(putanja_txt2)
        End If



        'Putanja SLIKANO
        If Not System.IO.Directory.Exists(putanja_slika) Then
            System.IO.Directory.CreateDirectory(putanja_slika)
        End If

        If Not System.IO.Directory.Exists(putanja_slika2) Then
            System.IO.Directory.CreateDirectory(putanja_slika2)
        End If



        'Putanja slika
        If Not System.IO.Directory.Exists(putanja_jpgtemp) Then
            System.IO.Directory.CreateDirectory(putanja_jpgtemp)
        End If

        'Putanja baue
        If Not System.IO.Directory.Exists(putanja_db) Then
            System.IO.Directory.CreateDirectory(putanja_db)
        End If


        Dim putanja_postavki_grupa As String
        putanja_postavki_grupa = putanja_postavki + "\" + "datoteka.txt"



        Using writer As StreamWriter = New StreamWriter(putanja_postavki_grupa)

            writer.WriteLine((DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe))
            writer.Close()

        End Using



        Dim putanja_postavki_ime As String
        putanja_postavki_ime = putanja_postavki + "\" + "korisnik.txt"
        ' MsgBox(putanja_postavki_ime)


        Using writer As StreamWriter = New StreamWriter(putanja_postavki_ime)

            writer.WriteLine(("author=" + ime_prezime_operator))
            writer.Close()

        End Using


        putanja_broj_skena = putanja_postavki + "\" + "num.txt"
        My.Settings.putanja_broj_skena = putanja_broj_skena


        'MsgBox(putanja_broj_skena)



        Using writer As StreamWriter = New StreamWriter(putanja_broj_skena)

            writer.WriteLine(broj_skena)
            writer.Close()


        End Using



        Dim putanja_path As String

        putanja_path = putanja_postavki + "\" + "putanja.txt"



        Using writer As StreamWriter = New StreamWriter(putanja_path)

            writer.WriteLine(("path=" + putanja_grupe))
            writer.Close()

        End Using


        Dim putanja_path1 As String


        putanja_path1 = putanja_postavki + "\" + "putanja1.txt"

        If System.IO.File.Exists(putanja_path1) = True Then

            System.IO.File.Delete(putanja_path1)

        End If


        Using writer As StreamWriter = New StreamWriter(putanja_path1)

            writer.WriteLine(("path1=" + putanja_grupe2))
            writer.Close()

        End Using



        Dim putanja_sync As String


        putanja_sync = "C:\sync\log\sve.log"



        If Not System.IO.Directory.Exists("C:\sync\log") Then
            System.IO.Directory.CreateDirectory("C:\sync\log")
        End If



        If Not System.IO.File.Exists(putanja_sync) = True Then

            System.IO.File.Create(putanja_sync)

        End If





        'Kreiranje SQLITE baze

        dbname = ime_grupe_folder + ".db;"


        'Private dbpath As String = Application.StartupPath & "\" & DBNAME
        dbpath = putanja_db & "\" & dbname

        My.Settings.dbpath = dbpath


        Dim CONSTRING As String = "Data Source=" & dbpath & "Version=3;New=False;Compress=True;"



        If Not System.IO.File.Exists(dbpath) Then

            Try

                ' Create the SQLite database
                SQLiteConnection.CreateFile(dbpath)

                Dim SQLconnect As New SQLiteConnection()
                Dim SQLcommand As New SQLiteCommand
                SQLconnect.ConnectionString = CONSTRING
                SQLconnect.Open()
                SQLcommand = SQLconnect.CreateCommand
                'SQL Query to Create Table'
                SQLcommand.CommandText = "CREATE TABLE Skeniranje (AutoID INTEGER PRIMARY KEY AUTOINCREMENT, Broj_skena TEXT, Pdf TEXT, Tip_dozvole TEXT, Ispostava TEXT, Upravni_odjel TEXT, 
                                            Zupanija TEXT, Datum_akta TEXT, Ostecena_stranica TEXT, Nedostajuca_stranica TEXT, Kreirano_od TEXT, Datum_kreiranja TEXT);"
                SQLcommand.ExecuteNonQuery()
                SQLcommand.Dispose()
                SQLconnect.Close()


                AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                              Return MessageBox.Show(Me, "SQLite dnevna baza skeniranja je uspješno kreirana...  ", caption, buttons, MessageBoxIcon.Information)
                                                          End Function, caption:="GZS sken").Show(timeout:=2000, buttons:=MessageBoxButtons.OK)


            Catch ex As Exception
                MsgBox("Pogreška u kreiranju SQLite baze", MsgBoxStyle.Exclamation, "GZS sken")
            End Try

        Else
            MsgBox("SQLite baza već postoji...", MsgBoxStyle.Information, "GZS sken")

        End If

        o_programu_buton.Visible = False
        CircularProgressBar1.Visible = True
        CircularProgressBar1.Minimum = 0
        CircularProgressBar1.Maximum = 100
        CircularProgressBar1.StartAngle = 270
        CircularProgressBar1.Text = 0
        CircularProgressBar1.Value = 0
        CircularProgressBar1.Refresh()


    End Sub

    Private Sub nevidljivi_buton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub zelena_kvacica_2_Click(sender As Object, e As EventArgs) Handles zelena_kvacica_s.Click

    End Sub

    Private Sub minus_1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles digitalni_potpis_buton.Click


        Dim pdf_nepotpisani As String
        Dim pdf_nepotpisani2 As String

        Dim imefilea As String
        Dim putanja_filea As String
        Dim putanja_filea1 As String

        Dim trenutni_radni_dan As String

        trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")




        pdf_nepotpisani = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

        pdf_nepotpisani2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"



        pdf_potpisani = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"
        pdf_potpisani2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"



        Dim argument_pdf As String
        argument_pdf = Chr(34) & pdf_nepotpisani & Chr(34) + " " + Chr(34) & pdf_potpisani & Chr(34)

        'MsgBox(argument_pdf)
        imefilea = "PDF Server.exe" ' The Name of file with its Extension Example A.txt or A.xml


        'Putanja PDF Signer Server
        putanja_filea = "C:\Program Files (x86)\Secure Soft\PDF Signer Server" & "\" & imefilea  'First Name of Directory and Then Name of Folder if it exists and then attach the name of file you want to search.


        'Putanja PDF Signer Server
        putanja_filea1 = Chr(34) & "C:\Program Files (x86)\Secure Soft\PDF Signer Server" & "\" & imefilea & Chr(34) ' putanja u navodnicima


        If System.IO.File.Exists(putanja_filea) Then



            If System.IO.File.Exists(pdf_nepotpisani) Then



                If jedanaest = False Then


                    Dim document As New PdfDocument()
                    document.LoadFromFile(pdf_nepotpisani)

                    document.DocumentInformation.Author = ime_prezime_operator
                    document.DocumentInformation.Title = vrsta_akta
                    document.DocumentInformation.Subject = nadlezni_odjel
                    document.DocumentInformation.Producer = "GZS sken ver. 2.5"
                    document.DocumentInformation.Keywords = "GZS sken"


                    document.SaveToFile(pdf_nepotpisani)



                    Dim converter As PdfStandardsConverter = New PdfStandardsConverter(pdf_nepotpisani)

                    converter.ToPdfA1A(pdf_nepotpisani)





                    Dim info As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(putanja_filea1, argument_pdf)
                    info.UseShellExecute = False
                    info.RedirectStandardOutput = True
                    Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(info)
                    Dim output As String = p.StandardOutput.ReadToEnd()

                    Console.WriteLine("Out: " & output)



                    AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                                  Return MessageBox.Show(Me, "Potpisano...", caption, buttons, MessageBoxIcon.Information)
                                                              End Function, caption:="GZS sken").Show(timeout:=1200, buttons:=MessageBoxButtons.OK)

                    CircularProgressBar1.Value = 60
                    CircularProgressBar1.Text = 60
                    CircularProgressBar1.Refresh()


                    'Promjena imena PDF datoteke
                    If File.Exists(pdf_potpisani) Then



                        Dim strNewFileName As String = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim strNewFileName2 As String = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        Dim pdfa1 As String = putanja_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim pdfa2 As String = putanja_pdf2_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim pdfa3 As String = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        If Not File.Exists(strNewFileName) Then

                            System.IO.File.Move(pdf_potpisani, strNewFileName)
                            System.IO.File.Move(pdf_nepotpisani2, strNewFileName2)

                            pdf_potpisani = strNewFileName
                            pdf_nepotpisani2 = strNewFileName2

                            System.IO.File.Copy(pdf_potpisani, pdfa1)
                            System.IO.File.Copy(pdf_potpisani, pdfa2)

                            System.IO.File.Delete(pdf_potpisani)
                            System.IO.File.Copy(pdf_nepotpisani2, pdfa3)

                        Else
                            MsgBox("PDF datoteka već postoji!" & vbCrLf & "Resetiraj tekući sken!", MsgBoxStyle.Exclamation, "GZS sken")
                            System.IO.File.Delete(pdf_potpisani)
                            Exit Sub
                        End If
                    End If


                    Try
                        Diagnostics.Process.Start(putanja_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf")
                    Catch ex As Exception
                        MsgBox("Nije moguće otvoriti tekući PDF jer.. " & vbCrLf & " ..u Windowsima nije zadan program za otvaranje PDF-a !!", MsgBoxStyle.Exclamation, "GZS sken")
                    End Try


                ElseIf jedanaest = True Then

                    Dim info As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo(putanja_filea1, argument_pdf)
                    info.UseShellExecute = False
                    info.RedirectStandardOutput = True
                    Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(info)
                    Dim output As String = p.StandardOutput.ReadToEnd()

                    Console.WriteLine("Out: " & output)

                    AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                                  Return MessageBox.Show(Me, "Potpisano...", caption, buttons, MessageBoxIcon.Information)
                                                              End Function, caption:="GZS sken").Show(timeout:=1200, buttons:=MessageBoxButtons.OK)

                    CircularProgressBar1.Value = 60
                    CircularProgressBar1.Text = 60
                    CircularProgressBar1.Refresh()

                    'Promjena imena PDF datoteke
                    If File.Exists(pdf_potpisani) Then

                        Dim strNewFileName As String = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim strNewFileName2 As String = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        Dim pdfa1 As String = putanja_not_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim pdfa2 As String = putanja_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim pdfa3 As String = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        Dim pdfa4 As String = putanja_pdf2_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"


                        If Not File.Exists(strNewFileName) Then


                            System.IO.File.Move(pdf_potpisani, strNewFileName)
                            System.IO.File.Move(pdf_nepotpisani2, strNewFileName2)

                            pdf_potpisani = strNewFileName
                            pdf_nepotpisani2 = strNewFileName2



                            System.IO.File.Copy(pdf_potpisani, pdfa1)
                            System.IO.File.Copy(pdf_potpisani, pdfa2)
                            System.IO.File.Copy(pdf_potpisani, pdfa4)


                            System.IO.File.Delete(pdf_potpisani)
                            System.IO.File.Copy(pdf_nepotpisani2, pdfa3)

                        Else
                            MsgBox("PDF datoteka već postoji!" & vbCrLf & "Resetiraj tekući sken!", MsgBoxStyle.Exclamation, "GZS sken")
                            System.IO.File.Delete(pdf_potpisani)
                            Exit Sub
                        End If
                    End If


                    Try
                        Diagnostics.Process.Start(putanja_not_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf")
                    Catch ex As Exception
                        MsgBox("Nije moguće otvoriti tekući PDF jer.. " & vbCrLf & " ..u Windowsima nije zadan program za otvaranje PDF-a !!", MsgBoxStyle.Exclamation, "GZS sken")
                    End Try



                End If

            Else

                MsgBox("Tekuća PDF datoteka za potpis: " & trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf" & vbCrLf & " nije kreirana!  Resetiraj tekući sken!", MsgBoxStyle.Exclamation, "GZS sken")


                Exit Sub


            End If


        Else


            MsgBox("PDF Signer Server nije instaliran", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End If


        digitalni_potpis_buton.Enabled = False
        potpis_check.Enabled = True

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles zavrsi_dan_buton.Click




        Dim datoteka As String
        Dim datoteka2 As String

        Dim trenutni_radni_dan As String

        trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")


        datoteka = ""


        Try




            If zavrsi_dan_buton.Text = "Slanje podataka" Then


                Dim frmDialogue As New Form9

                frmDialogue.ShowDialog()


            Else



                Select Case MsgBox("Je li zaista želiš završiti radni dan ?", MsgBoxStyle.YesNo, "GZS sken")


                    Case MsgBoxResult.Yes

                        ftp_slanje = False
                        My.Settings.ftp_slanje = ftp_slanje

                        start_radnog_dana = False
                        My.Settings.start_radnog_dana = start_radnog_dana




                        novi_radni_dan = ""
                        My.Settings.novi_radni_dan = novi_radni_dan

                        start_radnog_dana_buton.Enabled = True


                        o_programu_buton.Visible = True
                        CircularProgressBar1.Visible = False

                        Dim ChkBox As CheckBox = Nothing
                        ' to unchecked all 
                        For Each xObject As Object In GroupBox1.Controls
                            If TypeOf xObject Is CheckBox Then
                                ChkBox = xObject
                                ChkBox.Checked = False
                            End If
                        Next


                        zelena_kvacica_s.Visible = False
                        zelena_kvacica_s.Refresh()
                        zelena_kvacica_d.Visible = False
                        zelena_kvacica_d.Refresh()
                        zelena_kvacica_m.Visible = False
                        zelena_kvacica_m.Refresh()
                        zelena_kvacica_k.Visible = False
                        zelena_kvacica_k.Refresh()
                        zelena_kvacica_v.Visible = False
                        zelena_kvacica_v.Refresh()



                        digitalni_potpis_buton.Enabled = False
                        metapodaci_buton.Enabled = False
                        novi_sken_buton.Enabled = False
                        skeniraj_buton.Enabled = True
                        kreiraj_pdf_buton.Enabled = False
                        vrsta_akta_buton.Enabled = False
                        reset_skena_buton.Enabled = False
                        skeniraj_buton.Enabled = False


                        kreiran_pdf_check.Enabled = False
                        sken_check.Enabled = False
                        metapodaci_check.Enabled = False
                        vrsta_akta_checkbox.Enabled = False
                        potpis_check.Enabled = False


                        'Brisanje nepotrebnih datoteka
                        Dim dirinfo As New System.IO.DirectoryInfo(putanja_jpgtemp)
                        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.AllDirectories)



                        For Each file In files


                            datoteka = file.Name
                            datoteka = putanja_slika + "\" + datoteka


                            System.IO.File.Delete(datoteka)



                        Next

                        For Each file In files


                            datoteka = file.Name

                            datoteka2 = putanja_slika2 + "\" + datoteka


                            System.IO.File.Delete(datoteka2)


                        Next

                        Dim dirinfo2 As New System.IO.DirectoryInfo(putanja_povratnice)
                        files = dirinfo2.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)

                        For Each file In files
                            file.Delete()
                        Next



                        Dim dirinfo3 As New System.IO.DirectoryInfo(putanja_jpgtemp)
                        files = dirinfo3.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)

                        For Each file In files
                            file.Delete()
                        Next



                        Dim pdf_nepotpisani As String

                        Dim pdf_nepotpisani2 As String

                        Dim pdfa1 As String
                        Dim pdfa2 As String

                        Dim pdf1 As String
                        Dim pdf2 As String



                        Dim putanja_txt_save As String

                        Dim putanja_txt_save2 As String



                        pdf_nepotpisani = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

                        pdf_nepotpisani2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

                        pdf1 = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                        pdf2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        pdfa1 = putanja_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        pdfa2 = putanja_pdf2_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                        putanja_txt_save = putanja_txt + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"

                        putanja_txt_save2 = putanja_txt2 + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"



                        If File.Exists(pdf_nepotpisani) Then

                            System.IO.File.Delete(pdf_nepotpisani)

                        End If


                        If File.Exists(pdf_nepotpisani2) Then

                            System.IO.File.Delete(pdf_nepotpisani2)

                        End If


                        If File.Exists(pdfa1) Then

                            System.IO.File.Delete(pdfa1)

                        End If


                        If File.Exists(pdfa2) Then

                            System.IO.File.Delete(pdfa2)

                        End If


                        If File.Exists(pdf1) Then

                            System.IO.File.Delete(pdf1)

                        End If


                        If File.Exists(pdf2) Then

                            System.IO.File.Delete(pdf2)

                        End If



                        If File.Exists(putanja_txt_save) Then

                            System.IO.File.Delete(putanja_txt_save)

                        End If



                        If File.Exists(putanja_txt_save2) Then

                            System.IO.File.Delete(putanja_txt_save2)

                        End If


                        'Brisanje kraj


                        zavrsi_dan_buton.Text = "Slanje podataka"
                        broj_skena_textbox.Text = ""
                        broj_skena = 0
                        My.Settings.broj_skena = broj_skena


                        Exit Sub

                    Case MsgBoxResult.No
                        Exit Sub
                End Select


            End If



        Catch

            MsgBox("Zatvori sve otvorene datoteke !! ", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles metapodaci_buton.Click
        Dim frmDialogue As New Form4
        frmDialogue.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles skeniraj_buton.Click


        MsgBox("Pokreni CZUR skener i skeniraj tekući akt...", MsgBoxStyle.Information, "GZS sken")
        skeniraj_buton.Enabled = False
        sken_check.Enabled = True
        'sken_check.Checked = False
        'sken_check.Enabled = True

        CircularProgressBar1.Value = 20
        CircularProgressBar1.Text = 20
        CircularProgressBar1.Refresh()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles novi_sken_buton.Click

        broj_skena = broj_skena + 1

        broj_skena_textbox.Text = broj_skena
        My.Settings.broj_skena = broj_skena

        'Zapisivanje novog broja skena
        putanja_broj_skena = putanja_postavki + "\" + "num.txt"

        Dim writer As StreamWriter = New StreamWriter(putanja_broj_skena)
        Using writer

            writer.WriteLine(broj_skena)
            writer.Close()
        End Using



        Dim ChkBox As CheckBox = Nothing
        ' to unchecked all 
        For Each xObject As Object In Me.GroupBox1.Controls
            If TypeOf xObject Is CheckBox Then
                ChkBox = xObject
                ChkBox.Checked = False
            End If
        Next



        zelena_kvacica_s.Visible = False
        zelena_kvacica_s.Refresh()
        zelena_kvacica_d.Visible = False
        zelena_kvacica_d.Refresh()
        zelena_kvacica_m.Visible = False
        zelena_kvacica_m.Refresh()
        zelena_kvacica_k.Visible = False
        zelena_kvacica_k.Refresh()
        zelena_kvacica_v.Visible = False
        zelena_kvacica_v.Refresh()



        skeniraj_buton.Enabled = True
        digitalni_potpis_buton.Enabled = False
        metapodaci_buton.Enabled = False
        novi_sken_buton.Enabled = False
        kreiraj_pdf_buton.Enabled = False
        vrsta_akta_buton.Enabled = False


        ' Thread.Sleep(1000)


        sken_check.Enabled = False

        kreiran_pdf_check.Enabled = False
        potpis_check.Enabled = False

        metapodaci_check.Enabled = False

        zavrsi_dan_buton.Enabled = True
        reset_skena_buton.Enabled = True



        Dim dirinfo As New System.IO.DirectoryInfo(putanja_jpgtemp)
        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)


        For Each file In files
            file.Delete()
        Next


        CircularProgressBar1.Text = 0
        CircularProgressBar1.Value = 0
        CircularProgressBar1.Refresh()


    End Sub

    Private Sub sken_check_CheckedChanged(sender As Object, e As EventArgs) Handles sken_check.CheckedChanged
        zelena_kvacica_s.Visible = True
        sken_check.Enabled = False
        vrsta_akta_buton.Enabled = True

    End Sub


    Private Sub kreiraj_pdf_buton_Click(sender As Object, e As EventArgs) Handles kreiraj_pdf_buton.Click

        Dim broj_datoteka As Integer



        Dim files() As System.IO.FileInfo
        Dim dirinfo As New System.IO.DirectoryInfo(putanja_povratnice)
        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)

        broj_datoteka = 0
        For Each file In files
            broj_datoteka = broj_datoteka + 1



        Next


        If broj_datoteka = 0 Then

            MsgBox("Nijedna skenirana *.jpg datoteke ne postoji u folderu ...SKENIRANJE_HR\", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        ElseIf broj_datoteka > 0 And broj_datoteka < 11 Then
            jedanaest = False
        ElseIf broj_datoteka > 10 Then

            jedanaest = True
            MsgBox("Broj skeniranih stranica veći je od 10 !!" & vbCrLf & "Neće biti kreiran PDF/A !", MsgBoxStyle.Exclamation, "GZS sken")
        End If




        Dim proc As Process = Nothing
        Try
            Dim batDir As String = putanja_povratnice + "\"
            Dim batfile As String

            batfile = batDir + "gzs_sken.bat"

            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir
            proc.StartInfo.FileName = "gzs_sken.bat"


            If Not System.IO.File.Exists(batfile) Then


                MsgBox("Datoteka gzs_sken.bat nije instalirana!", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub

            End If

            proc.StartInfo.CreateNoWindow = False
            proc.Start()
            proc.WaitForExit()

            AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                          Return MessageBox.Show(Me, "Kreiran PDF....", caption, buttons, MessageBoxIcon.Information)
                                                      End Function, caption:="GZS sken").Show(timeout:=1200, buttons:=MessageBoxButtons.OK)


        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try



        CircularProgressBar1.Value = 60
        CircularProgressBar1.Text = 60
        CircularProgressBar1.Refresh()

        kreiraj_pdf_buton.Enabled = False
        kreiran_pdf_check.Enabled = True


    End Sub



    Private Sub kreiran_pdf_check_CheckedChanged(sender As Object, e As EventArgs) Handles kreiran_pdf_check.CheckedChanged


        zelena_kvacica_k.Visible = True
        kreiran_pdf_check.Enabled = False
        digitalni_potpis_buton.Enabled = True
    End Sub




    Private Sub potpis_check_CheckedChanged(sender As Object, e As EventArgs) Handles potpis_check.CheckedChanged
        zelena_kvacica_d.Visible = True
        potpis_check.Enabled = False
        metapodaci_buton.Enabled = True

    End Sub

    Private Sub metapodaci_check_CheckedChanged(sender As Object, e As EventArgs) Handles metapodaci_check.CheckedChanged
        metapodaci_check.Enabled = False
        zelena_kvacica_m.Visible = True
        novi_sken_buton.Enabled = True

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)



        zelena_kvacica_s.Visible = False
        zelena_kvacica_d.Visible = False
        zelena_kvacica_m.Visible = False

    End Sub


    'FormClosing Event
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Je li stvarno želiš izaći iz programa ?", "GZS sken", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        'detect up arrow key
        If keyData = Keys.N And novi_sken_buton.Enabled = True Then
            novi_sken_buton.PerformClick()
            Return True
        End If
        'detect down arrow key
        If keyData = Keys.D Then
            digitalni_potpis_buton.PerformClick()
            Return True
        End If
        'detect left arrow key
        If keyData = Keys.S Then
            skeniraj_buton.PerformClick()
            Return True
        End If
        If keyData = Keys.M Then
            metapodaci_buton.PerformClick()
            Return True
        End If

        If keyData = Keys.K Then
            kreiraj_pdf_buton.PerformClick()
            Return True
        End If

        If keyData = Keys.V Then
            vrsta_akta_buton.PerformClick()
            Return True
        End If



        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub zelena_kvacica_6_Click(sender As Object, e As EventArgs) Handles zelena_kvacica_6.Click

    End Sub

    Private Sub reset_skena_buton_Click(sender As Object, e As EventArgs) Handles reset_skena_buton.Click


        Try

            Dim datoteka As String
            Dim datoteka2 As String

            Dim trenutni_radni_dan As String

            trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")


            datoteka = ""



            Select Case MsgBox("Je li zaista želiš resetirati tekući sken ?", MsgBoxStyle.YesNo, "GZS sken")


                Case MsgBoxResult.Yes

                    CircularProgressBar1.Text = 0
                    CircularProgressBar1.Value = 0
                    CircularProgressBar1.Refresh()


                    Dim ChkBox As CheckBox = Nothing
                    ' to unchecked all 
                    For Each xObject As Object In GroupBox1.Controls
                        If TypeOf xObject Is CheckBox Then
                            ChkBox = xObject
                            ChkBox.Checked = False
                        End If
                    Next

                    zelena_kvacica_s.Visible = False
                    zelena_kvacica_s.Refresh()
                    zelena_kvacica_d.Visible = False
                    zelena_kvacica_d.Refresh()
                    zelena_kvacica_m.Visible = False
                    zelena_kvacica_m.Refresh()
                    zelena_kvacica_k.Visible = False
                    zelena_kvacica_k.Refresh()
                    zelena_kvacica_v.Visible = False
                    zelena_kvacica_v.Refresh()



                    digitalni_potpis_buton.Enabled = False
                    metapodaci_buton.Enabled = False
                    novi_sken_buton.Enabled = False
                    skeniraj_buton.Enabled = True
                    kreiraj_pdf_buton.Enabled = False
                    vrsta_akta_buton.Enabled = False


                    kreiran_pdf_check.Enabled = False
                    sken_check.Enabled = False
                    metapodaci_check.Enabled = False
                    vrsta_akta_checkbox.Enabled = False
                    potpis_check.Enabled = False


                    'Brisanje nepotrebnih datoteka
                    Dim dirinfo As New System.IO.DirectoryInfo(putanja_jpgtemp)
                    files = dirinfo.GetFiles("*.jpg", IO.SearchOption.AllDirectories)



                    For Each file In files


                        datoteka = file.Name
                        datoteka = putanja_slika + "\" + datoteka


                        System.IO.File.Delete(datoteka)



                    Next

                    For Each file In files


                        datoteka = file.Name

                        datoteka2 = putanja_slika2 + "\" + datoteka


                        System.IO.File.Delete(datoteka2)


                    Next

                    Dim dirinfo2 As New System.IO.DirectoryInfo(putanja_povratnice)
                    files = dirinfo2.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)

                    For Each file In files
                        file.Delete()
                    Next



                    Dim dirinfo3 As New System.IO.DirectoryInfo(putanja_jpgtemp)
                    files = dirinfo3.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)

                    For Each file In files
                        file.Delete()
                    Next



                    Dim pdf_nepotpisani As String

                    Dim pdf_nepotpisani2 As String

                    Dim pdfa1 As String
                    Dim pdfa2 As String

                    Dim pdf1 As String
                    Dim pdf2 As String



                    Dim putanja_txt_save As String

                    Dim putanja_txt_save2 As String



                    pdf_nepotpisani = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

                    pdf_nepotpisani2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

                    pdf1 = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"
                    pdf2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                    pdfa1 = putanja_pdf_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                    pdfa2 = putanja_pdf2_a + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".pdf"

                    putanja_txt_save = putanja_txt + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"

                    putanja_txt_save2 = putanja_txt2 + "\" + DateTime.Now.ToString("yyyy-MM-dd") + naziv_grupe + Trim(Str(broj_skena)) + "_" + vrsta_akta + ".txt"



                    If File.Exists(pdf_nepotpisani) Then

                        System.IO.File.Delete(pdf_nepotpisani)

                    End If


                    If File.Exists(pdf_nepotpisani2) Then

                        System.IO.File.Delete(pdf_nepotpisani2)

                    End If


                    If File.Exists(pdfa1) Then

                        System.IO.File.Delete(pdfa1)

                    End If


                    If File.Exists(pdfa2) Then

                        System.IO.File.Delete(pdfa2)

                    End If

                    If File.Exists(pdf1) Then

                        System.IO.File.Delete(pdf1)

                    End If


                    If File.Exists(pdf2) Then

                        System.IO.File.Delete(pdf2)

                    End If



                    If File.Exists(putanja_txt_save) Then

                        System.IO.File.Delete(putanja_txt_save)

                    End If



                    If File.Exists(putanja_txt_save2) Then

                        System.IO.File.Delete(putanja_txt_save2)

                    End If


                    'Brisanje kraj

                    Dim myNum As Integer

                    Try


                        myNum = InputBox("Unesi novi broj skena!")


                        Dim broj_skena2

                        broj_skena2 = myNum



                        If broj_skena2 < broj_skena Then

                            MsgBox("Nije moguće zadati već korišteni broj skena !!", MsgBoxStyle.Exclamation, "GZS sken")



                            broj_skena_textbox.Text = broj_skena


                            My.Settings.broj_skena = broj_skena

                            Using writer As StreamWriter = New StreamWriter(putanja_broj_skena)

                                writer.WriteLine(broj_skena)
                                writer.Close()


                            End Using

                        Else

                            broj_skena = broj_skena2


                            broj_skena_textbox.Text = broj_skena


                            My.Settings.broj_skena = broj_skena


                            Using writer As StreamWriter = New StreamWriter(putanja_broj_skena)

                                writer.WriteLine(broj_skena)
                                writer.Close()


                            End Using

                        End If

                    Catch

                        MsgBox("Moguć je unos isključivo cijelog broja")

                    End Try



                'BRISANJE JPG PDF I TIF

                Case MsgBoxResult.No
                    Exit Sub
            End Select


        Catch

            MsgBox("Zatvori sve otvorene datoteke !! ", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub

        End Try


    End Sub

    Private Sub pregled_skeniranih_podataka_buton_Click(sender As Object, e As EventArgs) Handles pregled_skeniranih_podataka_buton.Click





        If start_radnog_dana_buton.Enabled = False And naziv_grupe = "" Then


            Dim imebaze As New OpenFileDialog


            imebaze.Filter = "SQLite  (*.db)|*.db"
            imebaze.Title = "Selektiraj SQLite bazu"

            imebaze.ShowDialog()


            imesqlitedatoteke = imebaze.FileName

            dbpath = imesqlitedatoteke + ";"

            ' MsgBox(imesqlitedatoteke)

            If imesqlitedatoteke = "" Then
                MsgBox("Nije selektirana nijedna SQLite *.db datoteka", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub
            End If

        ElseIf start_radnog_dana_buton.Enabled = True And naziv_grupe <> "" Then
            Dim imebaze As New OpenFileDialog

            imebaze.Filter = "SQLite  (*.db)|*.db"
            imebaze.Title = "Selektiraj SQLite bazu"

            imebaze.ShowDialog()


            imesqlitedatoteke = imebaze.FileName

            dbpath = imesqlitedatoteke + ";"

            ' MsgBox(imesqlitedatoteke)

            If imesqlitedatoteke = "" Then
                MsgBox("Nije selektirana nijedna SQLite *.db datoteka", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub
            End If


        ElseIf start_radnog_dana_buton.Enabled = False And naziv_grupe <> "" And novi_radni_dan <> DateTime.Now.ToString("MM/dd/yyyy") Then


            Dim imebaze As New OpenFileDialog

            imebaze.Filter = "SQLite  (*.db)|*.db"
            imebaze.Title = "Selektiraj SQLite bazu"

            imebaze.ShowDialog()


            imesqlitedatoteke = imebaze.FileName

            dbpath = imesqlitedatoteke + ";"

            ' MsgBox(imesqlitedatoteke)

            If imesqlitedatoteke = "" Then
                MsgBox("Nije selektirana nijedna SQLite *.db datoteka", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub
            End If



        ElseIf start_radnog_dana_buton.Enabled = False And naziv_grupe <> "" And novi_radni_dan = DateTime.Now.ToString("MM/dd/yyyy") Then


            dbname = ime_grupe_folder + ".db;"


            dbpath = putanja_db & "\" & dbname



        End If


        Dim frmDialogue As New Form5

        frmDialogue.ShowDialog()





    End Sub
    'otvaranje uputa

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles o_programu_buton.Click

        Dim frmDialogue As New Form8

        frmDialogue.ShowDialog()


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles vrsta_akta_checkbox.CheckedChanged
        zelena_kvacica_v.Visible = True
        vrsta_akta_checkbox.Enabled = False
        kreiraj_pdf_buton.Enabled = True
    End Sub

    Private Sub vrsta_akta_buton_Click(sender As Object, e As EventArgs) Handles vrsta_akta_buton.Click

        Dim frmDialogue As New Form7
        frmDialogue.ShowDialog()


        vrsta_akta_buton.Enabled = False
        vrsta_akta_checkbox.Enabled = True

        CircularProgressBar1.Value = 40
        CircularProgressBar1.Text = 40
        CircularProgressBar1.Refresh()

    End Sub

    'RESAMPLE SA SPIRE.NET PDF-om
    Sub resample()



        Dim dirinfo As New System.IO.DirectoryInfo(putanja_povratnice)
        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)




        For Each file In files


            Dim newPdf As New PdfDocument()

            Dim image As Image = Image.FromFile(putanja_povratnice + "\" + file.Name)

            Dim pdfImage As PdfImage = PdfImage.FromImage(image)

            Dim uinit As New PdfUnitConvertor()

            Dim width As Single = 2480 * 96 \ 300

            Dim height As Single = 3506 * 96 \ 300

            Dim pageSize As SizeF = uinit.ConvertFromPixels(New SizeF(width, height), PdfGraphicsUnit.Point)

            'add new page

            Dim newPage As PdfPageBase = newPdf.Pages.Add(pageSize, New PdfMargins(0F))

            'draw

            newPage.Canvas.DrawImage(pdfImage, New PointF(0, 0), pageSize)

            'save a new iamge

            Dim outimage As Image = newPdf.SaveAsImage(0, 300, 300)

            outimage.Save(putanja_jpgtemp + "\" + file.Name, System.Drawing.Imaging.ImageFormat.Jpeg)





        Next


    End Sub

    ' KONVERZIJA U PDF SA SPIRE.NET PDF-om
    Sub konverzija()

        Dim pdf_nepotpisani As String
        Dim pdf_nepotpisani2 As String


        Dim trenutni_radni_dan As String

        trenutni_radni_dan = DateTime.Now.ToString("yyyy-MM-dd")

        Dim broj_datoteka As Integer
        Dim broj_jpg As Integer
        Dim datoteka As String

        Dim datoteka2 As String

        Dim datoteka3 As String


        datoteka = ""
        datoteka2 = ""
        datoteka3 = ""


        Dim dirinfo As New System.IO.DirectoryInfo(putanja_povratnice)
        files = dirinfo.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)



        Dim ukupni_broj_jpg

        ukupni_broj_jpg = 0
        For Each file In files
            ukupni_broj_jpg = ukupni_broj_jpg + 1
        Next
        Dim postotak As Integer




        broj_jpg = 0
        For Each file In files
            broj_jpg = broj_jpg + 1

            'RESAMPLIRANJE S MAGICK-OM

            ' Using image = New MagickImage(putanja_skeniranje_hr + "\" + file.Name)
            'Dim size = New MagickGeometry(2481, 3508)
            'Size.IgnoreAspectRatio = True
            'Image.Resample(300, 300)
            'Image.Resize(size)
            ' Image.Write(putanja_skeniranje_hr + "\" + file.Name)
            'End Using


            postotak = (broj_jpg / ukupni_broj_jpg) * 40



            CircularProgressBar1.Refresh()
            CircularProgressBar1.Value = 20 + postotak
            CircularProgressBar1.Refresh()
            CircularProgressBar1.Text = 20 + postotak
            CircularProgressBar1.Refresh()


        Next







        Dim files2(broj_jpg - 1) As String

        broj_datoteka = 0
        For Each file In files
            broj_datoteka = broj_datoteka + 1



            Dim slika As PdfImage = PdfImage.FromFile(putanja_povratnice + "\" + file.Name)




            Dim doc As New PdfDocument()
            Dim section As PdfSection = doc.Sections.Add()

            Dim page As PdfPageBase = doc.Pages.Add(PdfPageSize.A4, New PdfMargins(0))







            'Load a tif image from system
            Dim image As PdfImage = PdfImage.FromFile(putanja_povratnice + "\" + file.Name)
            'Set image display location and size in PDF

            Dim unitConvertor As New PdfUnitConvertor()

            Dim widthMM As Single = unitConvertor.ConvertUnits(210, PdfGraphicsUnit.Millimeter, PdfGraphicsUnit.Point)
            Dim heightMM As Single = unitConvertor.ConvertUnits(297, PdfGraphicsUnit.Millimeter, PdfGraphicsUnit.Point)


            page.Canvas.DrawImage(image, 0, 0, widthMM, heightMM)

            doc.FileInfo.Version = PdfVersion.Version1_4


            doc.SaveToFile(putanja_povratnice + "\" + Trim(Str(broj_datoteka)) + ".pdf")


            doc.Close()


            datoteka2 = putanja_povratnice + "\" + Trim(Str(broj_datoteka)) + ".pdf"


            files2(broj_datoteka - 1) = datoteka2

        Next


        CircularProgressBar1.Value = 65
        CircularProgressBar1.Text = 65
        CircularProgressBar1.Refresh()


        pdf_nepotpisani = putanja_pdf + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"

        pdf_nepotpisani2 = putanja_pdf2 + "\" + trenutni_radni_dan + naziv_grupe + Trim(Str(broj_skena)) + ".pdf"



        Dim outputfile1 As String = pdf_nepotpisani
        Dim outputfile2 As String = pdf_nepotpisani2



        Dim doc2 As PdfDocumentBase = PdfDocument.MergeFiles(files2)
        doc2.Save(outputfile1, FileFormat.PDF)
        doc2.Save(outputfile2, FileFormat.PDF)



        Dim doc3 As New PdfDocument(outputfile1)
        'Disables the incremental update
        doc3.FileInfo.IncrementalUpdate = False

        'Traverses all pages
        For Each page As PdfPageBase In doc3.Pages
            'Extracts images from page
            Dim images As Image() = page.ExtractImages()
            If images IsNot Nothing AndAlso images.Length > 0 Then
                'Traverses all images
                For j As Integer = 0 To images.Length - 1
                    Dim image As Image = images(j)
                    Dim bp As New PdfBitmap(image)

                    'Reduces the quality of the image
                    bp.Quality = 45
                    'Replaces the old image in the document with the compressed image
                    page.ReplaceImage(j, bp)
                Next
            End If
        Next
        'Saves and closes the resultant document
        doc3.FileInfo.Version = PdfVersion.Version1_4
        doc3.SaveToFile(pdf_nepotpisani)
        doc3.Close()


        Dim document As New PdfDocument()
        document.LoadFromFile(pdf_nepotpisani)

        document.DocumentInformation.Author = ime_prezime_operator
        document.DocumentInformation.Title = vrsta_akta
        document.DocumentInformation.Subject = nadlezni_odjel
        document.DocumentInformation.Producer = "GZS sken ver. 2.6"
        document.DocumentInformation.Keywords = "GZS sken"


        document.SaveToFile(pdf_nepotpisani)


        System.IO.File.Delete(outputfile2)


        If Not System.IO.File.Exists(outputfile2) Then
            System.IO.File.Copy(pdf_nepotpisani, pdf_nepotpisani2)
        End If




        Dim files3() As System.IO.FileInfo
        '
        Dim dirinfo3 As New System.IO.DirectoryInfo(putanja_povratnice)
        files3 = dirinfo3.GetFiles("*.pdf", IO.SearchOption.TopDirectoryOnly)


        For Each file In files3
            file.Delete()
        Next


        CircularProgressBar1.Value = 70
        CircularProgressBar1.Text = 70
        CircularProgressBar1.Refresh()


        AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                      Return MessageBox.Show(Me, "Kreiran PDF....", caption, buttons, MessageBoxIcon.Information)
                                                  End Function, caption:="GZS sken").Show(timeout:=1200, buttons:=MessageBoxButtons.OK)



        Dim files4() As System.IO.FileInfo
        '
        Dim dirinfo4 As New System.IO.DirectoryInfo(putanja_povratnice)
        files4 = dirinfo4.GetFiles("*.jpg", IO.SearchOption.TopDirectoryOnly)




        For Each file In files4



            If System.IO.File.Exists(putanja_slika + "\" + file.Name) Then
                Dim poruka As String
                poruka = "U direktoriju SLIKANO datoteka " + file.Name + " već  postoji !" & vbCrLf & "Resetiraj tekući sken !"
                MsgBox(poruka, MsgBoxStyle.Exclamation, "GZS sken")
            End If


            If Not System.IO.File.Exists(putanja_slika + "\" + file.Name) Then
                file.CopyTo(putanja_slika + "\" + file.Name)
            End If


            If System.IO.File.Exists(putanja_slika2 + "\" + file.Name) Then
                Dim poruka As String
                poruka = "U direktoriju SLIKANO2 datoteka " + file.Name + " već  postoji !" & vbCrLf & "Resetiraj tekući sken !"
                MsgBox(poruka, MsgBoxStyle.Exclamation, "GZS sken")
            End If



            If Not System.IO.File.Exists(putanja_slika2 + "\" + file.Name) Then
                file.CopyTo(putanja_slika2 + "\" + file.Name)
            End If



            If System.IO.File.Exists(putanja_jpgtemp + "\" + file.Name) Then
                Dim poruka As String
                poruka = "U direktoriju JPGTEMP datoteka " + file.Name + " već  postoji !" & vbCrLf & "Resetiraj tekući sken !"
                MsgBox(poruka, MsgBoxStyle.Exclamation, "GZS sken")
            End If



            If Not System.IO.File.Exists(putanja_jpgtemp + "\" + file.Name) Then
                file.MoveTo(putanja_jpgtemp + "\" + file.Name)
            End If



        Next



    End Sub

End Class
