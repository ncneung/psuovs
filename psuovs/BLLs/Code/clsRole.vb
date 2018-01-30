Imports PSUOVS

Public Class clsRole
    Implements IRoleManageMent
    Dim _conn As clsConnect = New clsConnect()

    Public Function CheckRole(strPSUPassport As String, roleID As Integer) As Boolean Implements IRoleManageMent.CheckRole
        Dim strSQL As String = "SELECT * FROM ManageRole Where PSUPassport = '" & strPSUPassport & "' and RoleID =  " & roleID & "  "
        Dim ds As DataSet = _conn.Fill(strSQL, "role")
        If ds.Tables("role").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

        'Throw New NotImplementedException()
    End Function

    Public Function GetRoleData(strPSUPassport As String) As Role Implements IRoleManageMent.GetRoleData
        Throw New NotImplementedException()
    End Function








    'Function GetRoles(ByVal strPSUPassport As String) As List(Of Role)
    '    Dim strSqL As String = "Select * from ManageRole Where PSUPassport = " & "'" & strPSUPassport & "'"

    '    Dim results As New List(Of Role)

    '    Dim ds As DataSet = _conn.Fill(strSqL, "role")

    '    If (ds IsNot Nothing) Then

    '        For Each role As DataRow In ds.Tables("role").Rows

    '            Dim r = New Role()
    '            With r
    '                r.RoleID = role.Item("RoleID")
    '                r.PSUPassport = role.Item("PSUPassport")
    '                r.IsActived = role.Item("IsActived")
    '                r.ElectionsID = role.Item("ElectionID")

    '            End With
    '            results.Add(r)
    '        Next

    '    End If

    '    Return results
    'End Function

    'Function GetRole(ByVal strPSUPassport As String) As Role
    '    Dim strSQL As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & strPSUPassport & "'"
    '    Dim result As Role

    '    'Return Sql_Dataset(strSQL)

    '    Dim ds As DataSet = _conn.Fill(strSQL, "role")

    '    If (ds IsNot Nothing) Then
    '        result = New Role()
    '        With result
    '            .RoleID = ds.Tables("role").Rows(0).Item("RoleID")
    '        End With

    '    End If
    '    Return result
    'End Function


End Class
