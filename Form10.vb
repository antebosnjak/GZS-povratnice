Imports System.IO

Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        putanja_grupe_textbox.Text = My.Settings.putanja_prijenosa
        putanja_servera_textbox.Text = My.Settings.putanja_servera
        putanja_servera = My.Settings.putanja_servera
        If putanja_servera <> "" Then

            Label3.Visible = False
        Else
            Label3.Visible = True
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Dim putanja_rc As String
        putanja_rc = putanja_povratnice + "\" + "GZS_backup.bat"
        ' MsgBox(putanja_postavki_ime)




        putanja_servera = putanja_servera_textbox.Text
        My.Settings.putanja_servera = putanja_servera




        If putanja_servera = "" Or putanja_prijenosa = "" Then

            MsgBox("Unesi putanje grupe i servera !", MsgBoxStyle.Exclamation, "GZS sken")
            Exit Sub
        End If






        '@echo off
        'robocopy C:\Users\Ante_Ured\Desktop\SKENIRANJE_HR \\65.108.9.195\SKENIRANJE_TEREN\_GZS134_ *.* /E /Z /COPY:DAT / DCOPY: T / MT: 3 /R:3 /W:10 /LOG:C : \sync\log\sve.log /TEE
        Dim rc_naredba As String

        rc_naredba = "robocopy" + " " + Chr(34) & putanja_prijenosa & Chr(34) + " " + Chr(34) & putanja_servera & Chr(34) + " " + "*.* /E /Z /COPY:DAT /DCOPY:T /MT:3 /R:3 /W:10 /LOG:C:\sync\log\sve.log /TEE"

        Using writer As StreamWriter = New StreamWriter(putanja_rc)

            writer.WriteLine("@echo off")

            writer.WriteLine(rc_naredba)

            writer.Close()

        End Using



        Dim proc As Process = Nothing
        Try
            Dim batDir As String = putanja_povratnice + "\"
            Dim batfile As String

            batfile = batDir + "gzs_backup.bat"

            proc = New Process()
            proc.StartInfo.WorkingDirectory = batDir
            proc.StartInfo.FileName = "gzs_backup.bat"


            If Not System.IO.File.Exists(batfile) Then


                MsgBox("Datoteka gzs_backup.bat ne postoji !", MsgBoxStyle.Exclamation, "GZS sken")
                Exit Sub

            End If

            proc.StartInfo.CreateNoWindow = False
            proc.Start()
            proc.WaitForExit()



        Catch ex As Exception
            Console.WriteLine(ex.StackTrace.ToString())
        End Try




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim CurDir As String = "C:\sync\log\"


            CurDir = CurDir + "sve.log"

            Process.Start(CurDir)


        Catch
            MsgBox("Pogreška u otvaranju txt datoteke !", MsgBoxStyle.Exclamation, "GZS sken")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


End Class