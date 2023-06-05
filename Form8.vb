Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim CurDir As String = My.Application.Info.DirectoryPath


            CurDir = CurDir + "\" + "gzs_povratnice_upute.pdf"


            Process.Start(CurDir)


        Catch
            MsgBox("Adobe Reader nije postavljen kao startni program za PDF !", MsgBoxStyle.Exclamation, "GZS sken")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim CurDir As String = My.Application.Info.DirectoryPath


            CurDir = CurDir + "\" + "gzs_povratnice_verzije.txt"

            Process.Start(CurDir)


        Catch
            MsgBox("Pogreška u otvaranju txt datoteke !", MsgBoxStyle.Exclamation, "GZS sken")
        End Try
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class