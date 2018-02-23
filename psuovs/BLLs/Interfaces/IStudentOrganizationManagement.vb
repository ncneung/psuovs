Public Interface IStudentOrganizationManagement
    Function countVoter(ByVal electionid As Integer) As List(Of String)
    Function countVoted(ByVal electionid As Integer) As List(Of String)
    Function countMale(ByVal electionid As Integer) As List(Of String)
    Function countFemale(ByVal electionid As Integer) As List(Of String)
    Function countFacultyTE(ByVal electionid As Integer) As List(Of String)
    Function countFacultyInter(ByVal electionid As Integer) As List(Of String)
    Function countFacultyFHT(ByVal electionid As Integer) As List(Of String)
    Function countFacultyCOE(ByVal electionid As Integer) As List(Of String)
    Function countFacultyCOC(ByVal electionid As Integer) As List(Of String)


End Interface
