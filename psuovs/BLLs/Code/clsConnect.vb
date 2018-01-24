Imports System.Data.SqlClient

Public Class clsConnect
    Function Sql_Dataset(ByVal strSQL As String) As DataSet
        Dim conPSUOVS As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnectPSUOVS").ConnectionString())
        Dim strSqlPSUOVS As String = strSQL
        Dim daPSUOVS As New SqlDataAdapter(strSqlPSUOVS, conPSUOVS)
        Dim dsPSUOVS As New DataSet

        Try
            daPSUOVS.Fill(dsPSUOVS, "PSUOVS")
            Return dsPSUOVS
        Catch ex As Exception
            Throw ex
        End Try

    End Function
End Class
