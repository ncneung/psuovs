Imports PSUOVS
Imports PSUOVS.testnamespace

Public Class TestClass
    Implements TestInterface

    Public Function GetElection(ElectionID As String) As Election Implements TestInterface.GetElection
        Throw New NotImplementedException()
    End Function

    Public Function GetRole(RoleID As String) As Election Implements TestInterface.GetRole
        Throw New NotImplementedException()
    End Function
End Class
