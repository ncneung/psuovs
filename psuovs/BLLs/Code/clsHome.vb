Imports System.Data.SqlClient

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

    Function GetCheckRole(ByVal stPSUPassport As String) As Array
        Dim arPassportRole() As String = {}
        Dim arRole() As Integer = {}
        Dim strSqlPSUOVS As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & stPSUPassport & "'"
        Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
        Dim dsPSUOVS As New DataSet
        daPSUOVS.Fill(dsPSUOVS, "UserPSUOVS")

        If dsPSUOVS.Tables("UserPSUOVS").Rows.Count > 0 Then
            For m As Integer = 0 To dsPSUOVS.Tables("UserPSUOVS").Rows.Count - 1
                arPassportRole(m) = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("PSUPassport")
                arRole(m) = dsPSUOVS.Tables("UserPSUOVS").Rows(m).Item("RoleID")

            Next
            Return arPassportRole
            'Return dsPSUOVS.Tables("UserPSUOVS").Rows(0).Item("RoleID")
        Else
            Return Nothing

        End If
    End Function
End Class
