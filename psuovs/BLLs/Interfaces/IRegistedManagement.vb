Public Interface IRegistedManagement
#Region "ลงทะเบียนเลือกตั้ง"
    Function getElectionsForRegisted(ByVal psupassport As String) As List(Of ElectionVote)
    Function getBallotsForRegisted(ByVal electionID As Integer) As List(Of Ballots)
#End Region



End Interface
