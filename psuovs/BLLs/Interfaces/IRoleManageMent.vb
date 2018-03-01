Public Interface IRoleManageMent
    Function CheckRole(ByVal psupassport As String, ByVal rolename As String) As ManageRole
    Function RoleGetElection(ByVal psupassport As String) As List(Of ElectionVote)
    Function RoleCheckVoter(ByVal psupassport As String) As Boolean
    Function RoleRegistedVoter(ByVal psupassport As String) As Boolean
    Function RoleVote(ByVal psupassport As String) As Boolean
    Function RoleResultElection(ByVal psupassport As String) As Boolean
    Function RoleStatusElection(ByVal psupassport As String) As Boolean
    'Function GetRoleData(ByVal strPSUPassport As String) As Role

End Interface
