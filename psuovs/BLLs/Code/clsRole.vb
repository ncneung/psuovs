Imports PSUOVS

Public Class clsRole
    Implements IRoleManageMent

    Public Function CheckRole(psupassport As String, rolename As String) As ManageRole Implements IRoleManageMent.CheckRole
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.ManageRole.Where(Function(m) m.PSUPassport = psupassport And m.IsActived = True And m.ManageRoleStatus.RoleName.ToLower() = rolename).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function RoleCheckVoter(psupassport As String) As Boolean Implements IRoleManageMent.RoleCheckVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim avalibleStatus = {"president", "staff"}
        Dim result = db.ManageRole.Where(Function(m) m.PSUPassport = psupassport And avalibleStatus.Contains(m.ManageRoleStatus.RoleName.ToLower())).FirstOrDefault()
        If IsNothing(result) Then
            Return False
        Else
            Return True
        End If
        Throw New NotImplementedException()
    End Function

    Public Function RoleGetElection(psupassport As String) As List(Of ElectionVote) Implements IRoleManageMent.RoleGetElection
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim eIDs = db.ManageRole.Where(Function(r) r.PSUPassport = psupassport And r.IsActived = True) _
                   .Select(Function(x) x.ElectionID).Distinct()
        Dim classElection As IElectionManagement = New clsElection
        Dim results As List(Of ElectionVote) = New List(Of ElectionVote)()

        For Each eID In eIDs
            Dim ele = classElection.GetElectionForVote(eID)
            If (ele IsNot Nothing) Then
                results.Add(ele)
            End If
        Next
        Return results
        Throw New NotImplementedException()
    End Function

    Public Function RoleRegistedVoter(psupassport As String) As Boolean Implements IRoleManageMent.RoleRegistedVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim avalibleStatus = {"president", "staff"}
        Dim result = db.ManageRole.Where(Function(m) m.PSUPassport = psupassport And avalibleStatus.Contains(m.ManageRoleStatus.RoleName.ToLower())).FirstOrDefault()
        If IsNothing(result) Then
            Return False
        Else
            Return True
        End If
        Throw New NotImplementedException()
    End Function

    Public Function RoleResultElection(psupassport As String) As Boolean Implements IRoleManageMent.RoleResultElection
        'Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        'Dim avalibleStatus = {"president", "staff"}
        'Dim result = db.ManageRole.Where(Function(m) m.PSUPassport = psupassport And avalibleStatus.Contains(m.ManageRoleStatus.RoleName.ToLower())).FirstOrDefault()
        'If IsNothing(result) Then
        '    Return False
        'Else
        '    Return True
        'End If
        Throw New NotImplementedException()
    End Function

    Public Function RoleStatusElection(psupassport As String) As Boolean Implements IRoleManageMent.RoleStatusElection
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        'Dim avalibleStatus = {"president", "staff"}
        Dim result = db.ManageRole.Where(Function(m) m.PSUPassport = psupassport And m.ManageRoleStatus.RoleName.ToLower() = "president").FirstOrDefault()
        If IsNothing(result) Then
            Return False
        Else
            Return True
        End If
        Throw New NotImplementedException()
    End Function

    Public Function RoleVote(psupassport As String) As Boolean Implements IRoleManageMent.RoleVote
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.RegistedVoter.Where(Function(m) m.PSUPassport = psupassport).FirstOrDefault()
        If IsNothing(result) Then
            Return False
        Else
            Return True
        End If
        Throw New NotImplementedException()
    End Function
End Class
