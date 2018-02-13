Public Interface IRegistedManagement
#Region "ลงทะเบียนเลือกตั้ง"
    Function getElectionsForRegisted(ByVal psupassport As String) As List(Of ElectionVote)
    Function getBallotsForRegisted(ByVal electionID As Integer) As List(Of Ballots)
    Function getBallotsForVoter(ByVal psupassport As String) As List(Of MatchVoterBallots)
    Function selectMatchVoterBallots(ByVal psupassport As String, ByVal ballotsID As Integer, ByVal electionID As Integer) As MatchVoterBallots
    Function updateMatchVoterBallots(ByVal autoid As Integer) As MatchVoterBallots
    Function insertMatchVoterBallots(ByVal psupassport As String, ByVal ballotsID As Integer, ByVal electionID As Integer) As MatchVoterBallots
    Function deleteMatchVoterBallots(ByVal psupassport As String, ByVal ballotsID As Integer, ByVal electionID As Integer) As MatchVoterBallots
    Function insertRegistedVoter(ByVal psupassport As String, ByVal electionID As Integer, ByVal BallotsID As Integer, ByVal Registed As Boolean, ByVal RegistedDate As Date, ByVal RegistedBy As String) As RegistedVoter
#End Region



End Interface
