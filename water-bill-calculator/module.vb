Imports MySql.Data.MySqlClient

Module validataNumeric
    Public Function onlyNumeric(ByVal key As String) As Boolean
        If (key >= 48 And key <= 57 Or key = 8) Then
            onlyNumeric = False
        Else
            onlyNumeric = True
            MsgBox("Only accepts numbers")
        End If
    End Function

End Module
