Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ftp_radiobuton.Checked = True Then
            vrsta_prijenosa = "ftp"
        ElseIf rc_radiobuton.Checked = True Then

            vrsta_prijenosa = "rc"
        End If
        My.Settings.vrsta_prijenosa = vrsta_prijenosa



        If vrsta_prijenosa = "ftp" Then


            Me.Close()

            Dim frmDialogue As New Form6

            frmDialogue.ShowDialog()

        ElseIf vrsta_prijenosa = "rc" Then

            Me.Close()

            Dim frmDialogue As New Form10

            frmDialogue.ShowDialog()

        End If


    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vrsta_prijenosa = My.Settings.vrsta_prijenosa

        If vrsta_prijenosa = "ftp" Then
            ftp_radiobuton.Checked = True
            rc_radiobuton.Checked = False
        ElseIf vrsta_prijenosa = "rc" Then
            ftp_radiobuton.Checked = False
            rc_radiobuton.Checked = True
        End If

    End Sub
End Class