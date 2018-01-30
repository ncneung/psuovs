Public Interface IRoleManageMent
    Function CheckRole(ByVal strPSUPassport As String, ByVal roleID As Integer) As Boolean
    Function GetRoleData(ByVal strPSUPassport As String) As Role

End Interface
