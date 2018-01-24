Public Class clsRole
    Inherits clsConnect
    Function GetRole(ByVal strPSUPassport As String) As DataSet
        Dim strSQL As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & strPSUPassport & "'"
        Return Sql_Dataset(strSQL)

    End Function


End Class
