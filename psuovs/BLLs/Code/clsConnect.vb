Imports System.Data.SqlClient

Public Class clsConnect
    'Public Function Sql_Dataset(ByVal strSQL As String) As DataSet
    '    Dim conPSUOVS As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectPSUOVS").ConnectionString())
    '    Dim strSqlPSUOVS As String = strSQL
    '    Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
    '    Dim dsPSUOVS As New DataSet

    '    Try
    '        daPSUOVS.Fill(dsPSUOVS, "PSUOVS")
    '        Return dsPSUOVS
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function


    Public Function Fill(ByVal strSQL As String, ByVal name As String) As DataSet
        Dim conPSUOVS As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectPSUOVS").ConnectionString())
        Dim strSqlPSUOVS As String = strSQL
        Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
        Dim dsPSUOVS As New DataSet

        Try
            daPSUOVS.Fill(dsPSUOVS, name)
            Return dsPSUOVS
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
