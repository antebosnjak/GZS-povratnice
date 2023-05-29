Imports System.Data.SQLite
Imports System.IO
Imports System.Threading

Public Class Form5


    Private dbcommand As String = ""
    Private bindingsrc As BindingSource

    Private CONSTRING As String = "Data Source=" & dbpath & "Version=3;New=False;Compress=True;"

    Private connection As New SQLiteConnection(CONSTRING)
    Private command As New SQLiteCommand("", connection)
    Private sql As String = ""
    Private imedatoteke2 As String









    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub delete_buton_Click(sender As Object, e As EventArgs) Handles delete_buton.Click
        If addnew_buton.Text = "Cancel" Then
            Exit Sub
        End If

        If autoidtextbox.Text.Trim() = "" Or
                String.IsNullOrEmpty(autoidtextbox.Text.Trim()) Then
            MsgBox("Selektiraj bilo koji element liste..",
            MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Briši")
            Return


        End If


        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If


        Try

            If MessageBox.Show("ID: " & autoidtextbox.Text.Trim() &
                    "--> Je li stvarno želiš brisati selektirani redak?",
                               "GZS sken",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            dbcommand = "DELETE"
            sql = "DELETE FROM Skeniranje WHERE AutoID = @AutoID"
            command.Parameters.Clear()
            command.CommandText = sql

            command.Parameters.AddWithValue("AutoID", autoidtextbox.Text.Trim())


            Dim execute As Integer = command.ExecuteNonQuery()

            If execute = 1 Then
                MessageBox.Show("Redak je uspješno obrisan...",
                                "GZS povratnice",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)


                UpdateDataBiding()


            End If







        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message.ToString(), "Error message!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)


        Finally
            dbcommand = ""
            connection.Close()


        End Try









    End Sub


    Private Sub exit_buton_Click(sender As Object, e As EventArgs) Handles exit_buton.Click
        Me.Close()
    End Sub

    Private Sub refresh_buton_Click(sender As Object, e As EventArgs) Handles refresh_buton.Click
        If addnew_buton.Text = "Cancel" Then
            Exit Sub
        End If
        UpdateDataBiding()
    End Sub

    Private Sub movefirst_buton_Click(sender As Object, e As EventArgs) Handles movefirst_buton.Click
        bindingsrc.MoveFirst()
        displayposition()
    End Sub

    Private Sub moveprevious_buton_Click(sender As Object, e As EventArgs) Handles moveprevious_buton.Click
        bindingsrc.MovePrevious()
        displayposition()
    End Sub

    Private Sub movenext_buton_Click(sender As Object, e As EventArgs) Handles movenext_buton.Click
        bindingsrc.MoveNext()
        displayposition()
    End Sub

    Private Sub movelast_buton_Click(sender As Object, e As EventArgs) Handles movelast_buton.Click
        bindingsrc.MoveLast()
        displayposition()
    End Sub

    Private Sub addnew_buton_Click(sender As Object, e As EventArgs) Handles addnew_buton.Click

        With addnew_buton
            If .Text = "Dodaj novi" Then
                .Text = "Cancel"
                DataGridView1.ClearSelection()
                DataGridView1.Enabled = False
            Else
                .Text = "Dodaj novi"
                UpdateDataBiding()
                Exit Sub

            End If
        End With


        Dim tb As TextBox

        For Each ctr As Control In GroupBox1.Controls
            If TypeOf ctr Is TextBox Then
                tb = CType(ctr, TextBox)
                tb.DataBindings.Clear()
                tb.Text = ""
                If tb.Name.Equals("brojskenatextbox") Then
                    If tb.CanFocus Then
                        tb.Focus()
                    End If
                End If



            End If
        Next
    End Sub


    Private Sub UpdateDataBiding(Optional cmd As SQLiteCommand = Nothing)


        Try
            If cmd Is Nothing Then
                command.CommandText = "SELECT * FROM Skeniranje ORDER BY AutoID ASC"
            Else
                command = cmd
            End If

            Dim adapter As New SQLiteDataAdapter(command)
            Dim datast As New DataSet()
            adapter.Fill(datast, "Skeniranje")
            bindingsrc = New BindingSource()
            bindingsrc.DataSource = datast.Tables("Skeniranje")

            Dim tb As TextBox
            For Each ctr As Control In GroupBox1.Controls
                If TypeOf ctr Is TextBox Then
                    tb = CType(ctr, TextBox)
                    tb.DataBindings.Clear()
                    tb.Text = ""
                End If
            Next


            autoidtextbox.DataBindings.Add("Text", bindingsrc, "AutoID")
            brojskenatextbox.DataBindings.Add("Text", bindingsrc, "Broj_skena")
            pdftextbox.DataBindings.Add("Text", bindingsrc, "Pdf")
            vrsta_povratnicetextbox.DataBindings.Add("Text", bindingsrc, "Vrsta_povratnice")
            naziv_izmjeretextbox.DataBindings.Add("Text", bindingsrc, "Naziv_izmjere")
            kreirano_odtextbox.DataBindings.Add("Text", bindingsrc, "Kreirano_od")
            datum_kreiranjatextbox.DataBindings.Add("Text", bindingsrc, "Datum_kreiranja")



            DataGridView1.Enabled = True
            DataGridView1.DataSource = bindingsrc


            DataGridView1.AutoResizeColumns(CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeColumnsMode))

            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridView1.Columns(0).Width = 60


            'DataGridView1.Columns("Kreirano_od").Visible = False


            displayposition()




        Catch ex As Exception
            MessageBox.Show("Data Binding Error: " & ex.Message.ToString())
        End Try




    End Sub




    Private Sub displayposition()

        positionlabel.Text = "Pozicija: " & bindingsrc.Position + 1 & "/" & bindingsrc.Count
    End Sub



    Private Sub search_buton_Click(sender As Object, e As EventArgs) Handles search_buton.Click

        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If


        Try
            If String.IsNullOrEmpty(keywordtextbox.Text.Trim()) Then
                UpdateDataBiding()
                Exit Sub
            End If

            sql = "SELECT * FROM Skeniranje "
            sql &= "WHERE Broj_skena LIKE @keyword2 "
            sql &= "OR Pdf LIKE @keyword2 "
            sql &= "OR Vrsta_povratnice LIKE @keyword2 "
            sql &= "OR Naziv_izmjere LIKE @keyword2 "
            sql &= "OR Kreirano_od LIKE @keyword2 "
            sql &= "OR Datum_kreiranja LIKE @keyword2 "
            sql &= "ORDER BY AutoID ASC"

            command.CommandType = CommandType.Text
            command.CommandText = sql

            command.Parameters.Clear()


            Dim Keywordstring As String = String.Format("%{0}%", keywordtextbox.Text)

            command.Parameters.AddWithValue("@keyword1", keywordtextbox.Text)
            command.Parameters.AddWithValue("@keyword2", Keywordstring)

            ' MsgBox(Keywordstring)


            UpdateDataBiding(command)

        Catch ex As Exception

            MessageBox.Show("Pogreška u pretraživanju: " & ex.Message.ToString(),
                "GZS povratnice",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
            keywordtextbox.Focus()

        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 100
        Timer1.Start()

    End Sub


    Private Sub AddCmdParameters()
        command.Parameters.Clear()
        command.CommandText = sql


        command.Parameters.AddWithValue("Broj_skena", brojskenatextbox.Text.Trim())
        command.Parameters.AddWithValue("Pdf", pdftextbox.Text.Trim())
        command.Parameters.AddWithValue("Vrsta_povratnice", vrsta_povratnicetextbox.Text.Trim())
        command.Parameters.AddWithValue("Naziv_izmjere", naziv_izmjeretextbox.Text.Trim())
        command.Parameters.AddWithValue("Kreirano_od", kreirano_odtextbox.Text.Trim())
        command.Parameters.AddWithValue("Datum_kreiranja", datum_kreiranjatextbox.Text.Trim())




        If dbcommand.ToUpper() = "UPDATE" Then
            command.Parameters.AddWithValue("AutoID", autoidtextbox.Text.Trim())
        End If





    End Sub


    Private Sub save_buton_Click(sender As Object, e As EventArgs) Handles save_buton.Click



        If String.IsNullOrEmpty(brojskenatextbox.Text.Trim()) Or
            String.IsNullOrEmpty(pdftextbox.Text.Trim()) Or
                  String.IsNullOrEmpty(vrsta_povratnicetextbox.Text.Trim()) Or
            String.IsNullOrEmpty(naziv_izmjeretextbox.Text.Trim()) Or
            String.IsNullOrEmpty(kreirano_odtextbox.Text.Trim()) Or
            String.IsNullOrEmpty(datum_kreiranjatextbox.Text.Trim()) Then

            MessageBox.Show("Popuni polja ili za prazna polja dodaj tekst NULL", "GZS povratnice", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Exit Sub
        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If

        Try
            If addnew_buton.Text = "Dodaj novi" Then

                If autoidtextbox.Text.Trim() = "" Or
                        String.IsNullOrEmpty(autoidtextbox.Text.Trim()) Then
                    MessageBox.Show("Pritisni dugme  -Dodaj novi-  za dodavanje novih podataka!", "GZS povratnice",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If



                If MessageBox.Show("ID: " & autoidtextbox.Text.Trim() &
                            "--> Želiš li osvježiti podatke u selektiranom retku SQLite baze?",
                                       "GZS sken",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                       MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    Exit Sub

                End If






                dbcommand = "UPDATE"
                sql = "UPDATE Skeniranje SET Broj_skena = @Broj_skena, Pdf = @Pdf, Vrsta_povratnice = @Vrsta_povratnice, Naziv_izmjere = @Naziv_izmjere, "
                sql &= "Kreirano_od = @Kreirano_od, Datum_kreiranja = @Datum_kreiranja  WHERE AutoID = @AutoID"
                AddCmdParameters()



            ElseIf addnew_buton.Text.Equals("Cancel") Then


                Dim result As DialogResult
                result = MessageBox.Show("Želiš li u SQLite bazu dodatni novi redak? (Y/N)",
                "GZS sken",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    dbcommand = "INSERT"
                    sql = "INSERT INTO Skeniranje (Broj_skena, Pdf, Vrsta_povratnice, Naziv_izmjere, Kreirano_od, Datum_kreiranja) " &
                        "VALUES (@Broj_skena, @Pdf, @Vrsta_povratnice, @Naziv_izmjere, @Kreirano_od, @Datum_kreiranja)"


                    AddCmdParameters()

                Else
                    Exit Sub

                End If

            End If



            Dim execute As Integer = command.ExecuteNonQuery()

            If execute = -1 Then
                MessageBox.Show("Podaci nisu spremeljeni u SQLite bazu - Pogreška u spremnanju..", "GZS povratnice",
                MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                MessageBox.Show("Podaci uspješno dodani u SQLite bazu",
                "GZS sken", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            UpdateDataBiding()
            addnew_buton.Text = "Dodaj novi"




        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(),
                            "GZS sken",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbcommand = ""
            connection.Close()


        End Try

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Try


            If Form1.start_radnog_dana_buton.Enabled = False Then



                If e.ColumnIndex = 2 Then
                    'Do any thing

                    Dim row1 As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value




                    If System.IO.File.Exists(putanja_pdf + "\" + row1) Then

                        Process.Start(putanja_pdf + "\" + row1)
                    ElseIf System.IO.File.Exists(putanja_pdf_nps + "\" + row1) Then

                        Process.Start(putanja_pdf_nps + "\" + row1)
                    ElseIf System.IO.File.Exists(putanja_pdf_ob + "\" + row1) Then

                        Process.Start(putanja_pdf_ob + "\" + row1)

                    ElseIf System.IO.File.Exists(putanja_pdf_ur + "\" + row1) Then

                        Process.Start(putanja_pdf_ur + "\" + row1)
                    End If

                End If



            ElseIf Form1.start_radnog_dana_buton.Enabled = True Then


                Dim di As Integer
                Dim di2 As Integer
                Dim cs As String
                Dim imesql As String


                imesql = ""
                di2 = 0
                cs = ""
                di = 0



                di = Len(imesqlitedatoteke)

                For i = di To 1 Step -1
                    cs = Mid(imesqlitedatoteke, i, 1)
                    If cs <> "\" Then
                        Continue For
                    Else
                        di2 = i

                        imesql = Microsoft.VisualBasic.Right(imesqlitedatoteke, (di - di2))
                        Exit For

                    End If
                Next



                di = Len(imesql)
                imesql = Microsoft.VisualBasic.Left(imesql, (di - 3))



                If e.ColumnIndex = 2 Then
                    'Do any thing
                    Dim row1 As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value











                    If System.IO.File.Exists(putanja_povratnice + "\" + imesql + "\" + "PDF\" + row1) Then

                        Process.Start(putanja_povratnice + "\" + imesql + "\" + "PDF\" + row1)



                    ElseIf System.IO.File.Exists(putanja_povratnice + "\" + imesql + "\" + "PDF_NPS\" + row1) Then

                        Process.Start(putanja_povratnice + "\" + imesql + "\" + "PDF_NPS\" + row1)
                    ElseIf System.IO.File.Exists(putanja_povratnice + "\" + imesql + "\" + "PDF_OB\" + row1) Then

                        Process.Start(putanja_povratnice + "\" + imesql + "\" + "PDF_OB\" + row1)

                    ElseIf System.IO.File.Exists(putanja_povratnice + "\" + imesql + "\" + "PDF_UR\" + row1) Then

                        Process.Start(putanja_povratnice + "\" + imesql + "\" + "PDF_UR\" + row1)
                    End If

                End If








            End If



        Catch

            MsgBox("Pogreška u selektiranju datoteka!", MsgBoxStyle.Exclamation, "GZS povratnice")

        End Try


    End Sub






    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub keywordtextbox_TextChanged(sender As Object, e As EventArgs) Handles keywordtextbox.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'MsgBox("Dobar dan Ana..........................")

        ' If connection.State = ConnectionState.Closed Then
        'connection.Open()

        'End If

        'Dim commandetext As String = "INSERT INTO Skeniranje VALUES(null,'XXXXXX', 'YYYYYYYYY', 'RRRRRRRRRRR', '33333333333', 'FFFFFFFFF', 'CVVCVCVVC', 'FGTERERERE', '343434342424', '343423432432432', 'TZTZTRZTRZTRZTRZ', 'YYYYYYYYYY', '7777777777777777')"
        'Dim COMM As New SQLiteCommand(commandetext, connection)





        ' COMM.ExecuteNonQuery()


        'dbcommand = ""
        'connection.Close()


    End Sub



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        connection.Open()
        'Thread.Sleep(1000)
        UpdateDataBiding()

        connection.Close()
        Timer1.Stop()
    End Sub


    Private Sub exportcsv_buton_Click(sender As Object, e As EventArgs) Handles exportcsv_buton.Click

        Dim brredaka As Integer
        Dim brstupaca As Integer
        Dim broj_redaka As Integer

        brredaka = DataGridView1.RowCount
        brstupaca = DataGridView1.ColumnCount


        If brredaka = 1 Then
            MsgBox("Nema podataka za export!!", MsgBoxStyle.Exclamation, "GZS povratnice")
            Exit Sub
        End If

        savecsvdlg.Filter = "ASCII CSV  (*.txt)|*.txt"
        savecsvdlg.Title = "Spremi CSV datoteku"
        savecsvdlg.FilterIndex = 1

        Select Case savecsvdlg.ShowDialog()
            Case DialogResult.OK



                imedatoteke2 = savecsvdlg.FileName

                If IsFileInUse(imedatoteke2) = True Then

                    MsgBox("TXT datoteka je otvorena u drugoj aplikaciji !", MsgBoxStyle.Exclamation, "GZS povratnice")

                    Exit Sub
                End If

                If System.IO.File.Exists(imedatoteke2) Then

                    Select Case MsgBox("TXT datoteka postoji!! Je li je zaista želiš izbrisati ?", MsgBoxStyle.YesNo, "GZS povratnice")


                        Case MsgBoxResult.Yes
                            Exit Select

                        Case MsgBoxResult.No
                            Exit Sub
                    End Select

                End If

                Dim csv As String = String.Empty

                'Add the Header row for CSV file.
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    csv += column.HeaderText & ";"c
                Next

                'Add new line.
                csv += vbCr & vbLf


                broj_redaka = 0

                'Adding the Rows
                For Each row As DataGridViewRow In DataGridView1.Rows

                    broj_redaka = broj_redaka + 1
                    If broj_redaka = brredaka Then
                        Exit For
                    End If
                    For Each cell As DataGridViewCell In row.Cells
                        'Add the Data rows.
                        csv += cell.Value.ToString().Replace(";", ",") & ";"c
                    Next

                    'Add new line.
                    csv += vbCr & vbLf
                Next

                'Exporting to Excel

                File.WriteAllText(imedatoteke2, csv)

                AutoClosingMessageBox.Factory(showMethod:=Function(caption, buttons)
                                                              Return MessageBox.Show(Me, "CSV datoteka je uspješno kreirana !", caption, buttons, MessageBoxIcon.Information)
                                                          End Function, caption:="GZS povratnice").Show(timeout:=1200, buttons:=MessageBoxButtons.OK)



                Dim path As String = IO.Path.GetDirectoryName(imedatoteke2) ' aktiviranje putanje datoteke

                Process.Start(imedatoteke2) 'otvaranje TXT datoteke u Notepadu

            Case DialogResult.Cancel
                Exit Sub
        End Select

    End Sub

End Class