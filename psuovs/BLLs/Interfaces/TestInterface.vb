Public Interface TestInterface
#Region "ทดสอบดู"
    Function GetElection(ElectionID As String) As testnamespace.Election
    Function GetRole(ByVal RoleID As String) As testnamespace.Election
#End Region

End Interface
