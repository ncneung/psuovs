Public Interface IResultManagement
    Function getResultVote(ByVal ballotsid As Integer, ByVal candidateid As Integer) As VoteResult
    Function insertScore(ByVal ballotsid As Integer, ByVal candidateid As Integer) As VoteResult
    Function updateScore(ByVal ballotsid As Integer, ByVal candidateid As Integer) As VoteResult
    Function selectScore(ByVal ballotsid As Integer, ByVal candidateid As Integer) As VoteResult
    Function checkVoted(ByVal psupassport As String, ByVal electionid As Integer) As MatchVoterBallots
    Function updateVoted(ByVal psupassport As String, ByVal ballotid As Integer, ByVal electionid As Integer) As MatchVoterBallots
End Interface
