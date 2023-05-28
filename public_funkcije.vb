Module public_funkcije


    'Funkcija koja provjerava je li neki BROJ INTEGER ili NE
    Public Function IsInteger(value As Object) As Boolean
        Dim output As Integer ' I am not using this by intent it is needed by the TryParse Method
        If (Integer.TryParse(value.ToString(), output)) Then
            Return True
        Else
            Return False
        End If
    End Function



    'Provjera je li postoji veza s internetom ili ne
    Public Function vezasinternetom() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try

    End Function


    Public Function vezasinternetom2() As Boolean

        Try
            Return My.Computer.Network.Ping("www.geozavod-st.hr")
        Catch
            Return False
        End Try

    End Function

    Public Function IsFileInUse(path As String) As Boolean
        If path Is Nothing Then
            Throw New ArgumentNullException("path")
            Return False
        Else
            If IO.File.Exists(path) Then
                Dim fi = New IO.FileInfo(path)
                Try
                    Using fs = fi.OpenWrite
                        Return Not fs.CanWrite
                    End Using
                Catch
                    Return True
                End Try
            Else
                Return False
            End If
        End If
    End Function



End Module
