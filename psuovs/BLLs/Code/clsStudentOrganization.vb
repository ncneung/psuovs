Imports PSUOVS

Public Class clsStudentOrganization
    Implements IStudentOrganizationManagement

    Public Function countFacultyCOC(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFacultyCOC
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.FAC_ID = "70") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function

    Public Function countFacultyCOE(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFacultyCOE
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.FAC_ID = "06") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function



    Public Function countFacultyFHT(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFacultyFHT
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.FAC_ID = "23") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function

    Public Function countFacultyInter(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFacultyInter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.FAC_ID = "62") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function
    Public Function countFacultyTE(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFacultyTE
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.FAC_ID = "48") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function

    Public Function countMale(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countMale
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.SEX_CODE = "M") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function
    Public Function countFemale(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countFemale
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.SEX_CODE = "F") _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function


    Public Function countVoter(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid) _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If

        Throw New NotImplementedException()
    End Function

    Public Function countVoted(electionid As Integer) As List(Of String) Implements IStudentOrganizationManagement.countVoted
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.V_Voter.Where(Function(v) v.ElectionID = electionid And v.Voted = True) _
                                .Select(Function(d) d.PSUPassport).Distinct()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result.ToList()
        End If
        Throw New NotImplementedException()
    End Function
End Class
