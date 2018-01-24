Imports System.Data.SqlClient
Imports PSUOVS



Public Interface IRoleProvider
    Function GetRole(ByVal sPsuPassport As String) As String
    Function GetElectionID(ByVal sPsuPassport As String) As String


End Interface

Public Class PSUPassportRoleV1Provider
    Implements IRoleProvider

    Public Function GetElectionID(sPsuPassport As String) As String Implements IRoleProvider.GetElectionID
        Throw New NotImplementedException()
    End Function

    'Public Function GetRole()
    '    Return ""
    'End Function

    Public Function GetRole(memberID As String) As String Implements IRoleProvider.GetRole
        Throw New NotImplementedException()
    End Function

End Class


'Public Class PSUPassportRoleV2Provider
'    Inherits IRoleProvider

'    Public Function GetRole()
'        Return "";
'    End Function

'End Class



'IRoleProvider roleProvider = New PSUPassportRoleV1Provider()
'roleProvider.GetRole()


Public Class clsHome
    Dim conPSUOVS As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectPSUOVS").ConnectionString())
    '1function checkRole ว่าคนนั้นมี Role อะไร และ election id อะไร
    '1.2 เพิ่มเติม Function รับค่าของ CheckRole
    '2function checkMenuRole ว่าสิทธิ์นั้นเห็นมีเมนูอะไรบ้าง
    '3function checkElector
    '4function checkBallots
    Function chkRole(ByVal stPSUPassport As String) As Boolean


        Dim strSqlPSUOVS As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & stPSUPassport & "'"
        Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
        Dim dsPSUOVS As New DataSet
        daPSUOVS.Fill(dsPSUOVS, "UserPSUOVS")

        If dsPSUOVS.Tables("UserPSUOVS").Rows.Count > 0 Then

            Return True
        Else
            Return False

        End If

    End Function


    'Function GetCheckRole(ByVal stPSUPassport As String) As Models.Election

    '    Dim strSqlPSUOVS As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & stPSUPassport & "'"
    '    Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
    '    Dim dsPSUOVS As New DataSet
    '    daPSUOVS.Fill(dsPSUOVS, "UserPSUOVS")

    '    If dsPSUOVS.Tables("UserPSUOVS").Rows.Count > 0 Then
    '        Dim arPassportRole(dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1) As String
    '        Dim arRole(dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1) As Integer
    '        For m As Integer = 0 To dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1
    '            = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("ElectionID")
    '            = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("RoleID")

    '        Next
    '        Return

    '    Else
    '        Return Nothing

    '    End If


    'End Function


    'Function GetCheckRole(ByVal stPSUPassport As String) As Array
    '    'Dim arPassportRole() As String = {}
    '    'Dim arPassportRole() As Integer
    '    'Dim arRole() As Integer = {}
    '    Dim strSqlPSUOVS As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & stPSUPassport & "'"
    '    Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
    '    Dim dsPSUOVS As New DataSet
    '    daPSUOVS.Fill(dsPSUOVS, "UserPSUOVS")

    '    If dsPSUOVS.Tables("UserPSUOVS").Rows.Count > 0 Then
    '        Dim arPassportRole(dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1) As String
    '        Dim arRole(dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1) As Integer
    '        For m As Integer = 0 To dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1
    '            arPassportRole(m) = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("PSUPassport")
    '            arRole(m) = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("RoleID")

    '        Next
    '        Return arPassportRole
    '        'Return arRole
    '        'Return arPassportRole
    '        'Return arRole
    '        'Return dsPSUOVS.Tables("UserPSUOVS").Rows(0).Item("RoleID")
    '    Else
    '        Return Nothing

    '    End If


    'End Function



    'Function GetCheckRole() As Array

    '    Dim students(6) As Integer
    '    students(0) = 23
    '    students(1) = 19
    '    students(2) = 21
    '    students(3) = 17
    '    students(4) = 19
    '    students(5) = 20
    '    students(6) = 22
    '    Return students
    'End Function
End Class
