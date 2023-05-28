
Imports WinSCP


Public Class Form6

    Private sftp_slanje As Boolean
    Private ime_servera As String
    Private username As String
    Private lozinka As String
    Private broj_porta As Integer
    Private fingerprint As String


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles salji_buton.Click

        If ime_servera = "" Or username = "" Or lozinka = "" Then
            MsgBox("Unesi podatke za spajanje na FTP server!", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If

        If vezasinternetom() = False And vezasinternetom2() = False Then

            MsgBox("Ne postoji veza s internetom!" & vbCrLf & "Provjeri mrežne postavke....", MsgBoxStyle.Exclamation, "GZS sken")

            Exit Sub
        Else



            Task.Run(Sub() Upload())

        End If


    End Sub

    Private Sub Upload()
        Try


            Using session As New Session
                Dim sessionOptions As New SessionOptions
                With sessionOptions

                    If sftp_slanje = True Then
                        .Protocol = Protocol.Sftp
                        .HostName = ime_servera
                        .UserName = username
                        .Password = lozinka
                        .SshHostKeyFingerprint = fingerprint

                        .PortNumber = broj_porta
                        .TimeoutInMilliseconds = 60000
                        session.DisableVersionCheck = True
                    Else
                        .Protocol = Protocol.Ftp

                        .HostName = ime_servera
                        .UserName = username
                        .Password = lozinka


                        .PortNumber = broj_porta
                        .TimeoutInMilliseconds = 6000
                        session.DisableVersionCheck = True

                    End If

                End With


                AddHandler session.FileTransferProgress, Sub(sender, e) ProgressBar1.Invoke(
                    Sub()
                        Button3.Visible = False
                        ProgressBar1.Visible = True
                        salji_buton.Text = "Šalju se podaci grupe: " + ime_grupe_folder
                        salji_buton.Enabled = False
                        test_buton.Enabled = False

                        ProgressBar1.Value = CInt(e.OverallProgress * 100)
                        Label1.Text = (Str(CInt(e.OverallProgress * 100))) + " %"

                        'If ProgressBar1.Value = 100 Or ProgressBar1.Value = 0 Then

                        'End If
                    End Sub)

                session.Open(sessionOptions)

                'session.PutFilesToDirectory(localDirectory, remoteDirectory).Check()
                'session.PutFilesToDirectory(putanja_grupe, "SKENIRANJE_TEREN\" + ime_grupe_folder).Check()
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

                session.PutFilesToDirectory(putanja_grupe, "SKENIRANJE_TEREN/" + naziv_grupe + "/" + ime_grupe_folder).Check()

                MsgBox("Slanje podataka na server uspješno je izvršeno..", MsgBoxStyle.Information, "GZS sken")


                Me.Invoke(Sub() zavrseno())

            End Using


        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Exclamation, "GZS sken")

        End Try



    End Sub


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If ime_prezime_operator = "" Or putanja_povratnice = "" Or naziv_grupe = "" Then

            MsgBox("Unesi Putanju, Ime i prezime i naziv grupe !", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If

        Label1.Text = ""


        ftp_slanje = My.Settings.ftp_slanje
        sftp_slanje = My.Settings.sftp_slanje


        If sftp_slanje = True Then
            sftp_checkbox.Checked = True
            Label7.Text = "SFTP protokol"
        Else
            sftp_checkbox.Checked = False
            Label7.Text = "FTP protokol"

            fingerprint_textbox.Enabled = False
            fingerprint_textbox.Text = ""

        End If

        If ftp_slanje = True Then

            salji_buton.Enabled = False
        Else
            salji_buton.Enabled = True

        End If


        ime_servera = My.Settings.ime_servera
        username = My.Settings.username
        lozinka = My.Settings.lozinka
        broj_porta = My.Settings.broj_porta
        fingerprint = My.Settings.fingerprint

        host_textbox.Text = ime_servera
        username_textbox.Text = username
        password_textbox.Text = lozinka
        fingerprint_textbox.Text = fingerprint


        If ime_servera = "" And username = "" And lozinka = "" Then
            port_textbox.Text = ""
            test_buton.Text = "Spremi FTP postavke!"
        Else
            port_textbox.Text = broj_porta
            test_buton.Text = "Test veze"
        End If

        grupa_textbox.Text = ime_grupe_folder

        ProgressBar1.Visible = False

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles port_textbox.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles test_buton.Click


        If host_textbox.Text = "" Or username_textbox.Text = "" Or password_textbox.Text = "" Or port_textbox.Text = "" Then

            MsgBox("Unesi FTP postavke!", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If


        test_buton.Text = "Test veze"

        test_buton.Enabled = False

        Dim port As String



        ime_servera = host_textbox.Text.Trim()
        username = username_textbox.Text.Trim()
        lozinka = password_textbox.Text.Trim()
        port = port_textbox.Text.Trim()
        fingerprint = fingerprint_textbox.Text.Trim()



        If vezasinternetom() = False And vezasinternetom2() = False Then

            MsgBox("Ne postoji veza s internetom!" & vbCrLf & "Provjeri mrežne postavke....", MsgBoxStyle.Exclamation, "GZS sken")


            test_buton.Text = "Test veze"

            test_buton.Enabled = True

            Exit Sub

        End If



        If ime_servera = "" Or username = "" Or lozinka = "" Then
            MsgBox("Unesi podatke za spajanje na FTP server!", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If




        Dim int_OK As Boolean
        int_OK = Integer.TryParse(port, broj_porta)
        If int_OK <> True Then
            MsgBox("Broj porta može biti jedino cijeli broj!", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If


        My.Settings.ime_servera = ime_servera

        My.Settings.username = username

        My.Settings.lozinka = lozinka

        My.Settings.broj_porta = broj_porta
        My.Settings.fingerprint = fingerprint



        Try
            Using session As New Session
                Dim sessionOptions As New SessionOptions
                With sessionOptions

                    If sftp_slanje = True Then
                        .Protocol = Protocol.Sftp
                        .HostName = ime_servera
                        .UserName = username
                        .Password = lozinka
                        .SshHostKeyFingerprint = fingerprint

                        .PortNumber = broj_porta
                        .TimeoutInMilliseconds = 60000
                        session.DisableVersionCheck = True
                    Else
                        .Protocol = Protocol.Ftp

                        .HostName = ime_servera
                        .UserName = username
                        .Password = lozinka


                        .PortNumber = broj_porta
                        .TimeoutInMilliseconds = 60000
                        session.DisableVersionCheck = True

                    End If

                End With

                session.Open(sessionOptions)

                session.PutFilesToDirectory("test", "test").Check()

                MsgBox("Veza je u redu...", MsgBoxStyle.Information, "GZS sken")
            End Using
        Catch f As Exception
            MsgBox(f.Message, MsgBoxStyle.Exclamation, "GZS sken")
        End Try
        test_buton.Enabled = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles google_drive_checkbox.CheckedChanged

        If google_drive_checkbox.Checked = Enabled Then
            ime_servera = "localhost"
            username = "user"
            lozinka = "user"
            broj_porta = 1821


            host_textbox.Text = ime_servera
            username_textbox.Text = username
            password_textbox.Text = lozinka
            port_textbox.Text = broj_porta



            My.Settings.ime_servera = ime_servera

            My.Settings.username = username

            My.Settings.lozinka = lozinka

            My.Settings.broj_porta = broj_porta



            host_textbox.Enabled = False
            username_textbox.Enabled = False
            password_textbox.Enabled = False
            port_textbox.Enabled = False

            test_buton.Text = "Test veze"


        ElseIf google_drive_checkbox.Checked = False Then


            host_textbox.Enabled = True
            username_textbox.Enabled = True
            password_textbox.Enabled = True
            port_textbox.Enabled = True


            ime_servera = ""
            username = ""
            lozinka = ""
            broj_porta = 21



            My.Settings.ime_servera = ime_servera

            My.Settings.username = username

            My.Settings.lozinka = lozinka

            My.Settings.broj_porta = broj_porta



            host_textbox.Text = ""
            username_textbox.Text = ""
            password_textbox.Text = ""
            port_textbox.Text = ""
            grupa_textbox.Text = ime_grupe_folder
            test_buton.Text = "Spremi FTP postavke"

        End If


    End Sub

    Private Sub zavrseno()
        salji_buton.Enabled = True
        salji_buton.Text = "Šalji dnevne podatke na server"
        test_buton.Enabled = True
        ProgressBar1.Visible = False
        Button3.Visible = True
        Label1.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub sftp_checkbox_CheckedChanged(sender As Object, e As EventArgs) Handles sftp_checkbox.CheckedChanged

        If sftp_checkbox.Checked = True Then
            Label7.Text = "SFTP protokol"

            sftp_slanje = True
            google_drive_checkbox.Enabled = False
            fingerprint_label.Enabled = True
            fingerprint_textbox.Enabled = True
            My.Settings.sftp_slanje = sftp_slanje

            port_textbox.Text = "22"
            broj_porta = 22


        ElseIf sftp_checkbox.Checked = False Then
            Label7.Text = "FTP protokol"
            sftp_slanje = False
            google_drive_checkbox.Enabled = True

            fingerprint_textbox.Enabled = False
            fingerprint_textbox.Text = ""
            My.Settings.sftp_slanje = sftp_slanje

            port_textbox.Text = "21"
            broj_porta = 21

        End If

    End Sub
End Class