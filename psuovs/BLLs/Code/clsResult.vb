Imports PSUOVS

Public Class clsResult
    Implements IResultManagement

    Public Function checkVoted(psupassport As String, ballotid As Integer, electionid As Integer) As MatchVoterBallots Implements IResultManagement.checkVoted
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.MatchVoterBallots.Where(Function(s) s.PSUPassport = psupassport And s.BallotsID = ballotid And s.ElectionID = electionid And s.Voted = True).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function
    Public Function updateVoted(psupassport As String, ballotid As Integer, electionid As Integer) As MatchVoterBallots Implements IResultManagement.updateVoted
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim u = db.MatchVoterBallots.Where(Function(s) s.PSUPassport = psupassport And s.BallotsID = ballotid And s.ElectionID = electionid).FirstOrDefault()
        u.Voted = True
        u.VotedDate = Date.Now()
        If IsNothing(u) Then
            Return Nothing
        Else
            db.SaveChanges()
            Return u
        End If

    End Function

    Public Function getResultVote(ballotsid As Integer, candidateid As Integer) As VoteResult Implements IResultManagement.getResultVote
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.VoteResult.Where(Function(r) r.BallotsID = ballotsid And r.CandidateID = candidateid).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If

    End Function

    Public Function insertScore(ballotsid As Integer, candidateid As Integer) As VoteResult Implements IResultManagement.insertScore
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim addScore As New VoteResult
        addScore.BallotsID = ballotsid
        addScore.CandidateID = candidateid
        addScore.Score = 1
        Dim result = db.VoteResult.Add(addScore)
        If IsNothing(result) Then
            Return Nothing
        Else
            db.SaveChanges()
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function selectScore(ballotsid As Integer, candidateid As Integer) As VoteResult Implements IResultManagement.selectScore
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.VoteResult.Where(Function(s) s.BallotsID = ballotsid And s.CandidateID = candidateid).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function updateScore(ballotsid As Integer, candidateid As Integer) As VoteResult Implements IResultManagement.updateScore
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim u = db.VoteResult.Where(Function(s) s.BallotsID = ballotsid And s.CandidateID = candidateid).FirstOrDefault()

        u.Score = u.Score + 1
        If IsNothing(u) Then
            Return Nothing
        Else
            db.SaveChanges()
            Return u

        End If

    End Function


End Class
