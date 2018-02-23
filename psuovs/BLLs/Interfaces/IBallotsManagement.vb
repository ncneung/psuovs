Public Interface IBallotsManagement
#Region "ข้อมูลบัตรเลือกตั้ง"
    Function getBallots(ByVal ballotsID As Integer) As Ballots
    Function GetBallotsForVote(ByVal psupassport As String, ByVal elecid As Integer) As List(Of Ballots)

#End Region

End Interface
