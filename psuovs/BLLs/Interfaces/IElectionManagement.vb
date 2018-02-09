Public Interface IElectionManagement

#Region "การจัดการเลือกตั้ง"
    Function GetElection(ElectionID As String) As ElectionVote
    'Function GetElections() As List(Of ElectionVote)
    'รายการเลือกตั้งที่ปรากฎรายชื่อของ ผู้มีสิทธิ์
    'Function GetElections(VoterID As String) As IEnumerable(Of Models.Election)
    'Function InsertElection(obj As Models.Election)
    'Function UpdateElection(obj As Models.Election)
    'Function DeleteElection(ElectionID As String)
#End Region

#Region "บัตรลงคะแนน"
    'บัตรลงคะแนนของการเลือกตั้ง
    'Function GetBallots(ElectionID As String) As IEnumerable(Of Models.Ballot)
    'บัตรลงคะแนนที่ผู้มีสิทธิ์ลงคะแนนได้
    'Function GetBallots(ElectionID As String, VoterID As String) As IEnumerable(Of Models.Ballot)
    'Function GetBallot(BallotID As String)
    'Function InsertBallot(obj As Models.Ballot)
    'Function UpdateBallot(obj As Models.Ballot)
    'Function DeleteBallot(BallotID As String)
#End Region

#Region "ตัวเลือกในบัตรลงคะแนน"
    'Function GetChoices(BallotID As String) As IEnumerable(Of Models.BallotChoice)
    'Function GetChoice(BallotChoiceID As String) As Models.BallotChoice
    'Function Insert(obj As Models.BallotChoice)
    'Function Update(obj As Models.BallotChoice)
    'Function Delete(BallotChoiceID As String)
#End Region

End Interface



