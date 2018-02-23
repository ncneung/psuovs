Imports PSUOVS

Public Class clsBallots
    Implements IBallotsManagement

    Public Function GetBallotsForVote(psupassport As String, elecid As Integer) As List(Of Ballots) Implements IBallotsManagement.GetBallotsForVote
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1

        'Dim bIDs = db.MatchVoterBallots.Where(Function(m) m.PSUPassport = psupassport) _
        '             .Select(Function(x) x.ElectionID).Distinct()
        Dim bIDs = db.MatchVoterBallots.Where(Function(m) m.PSUPassport = psupassport And m.ElectionID = elecid) _
                     .Select(Function(x) x.BallotsID)

        Dim ballot As IBallotsManagement = New clsBallots
        Dim results As List(Of Ballots) = New List(Of Ballots)()
        For Each bid In bIDs
            Dim bal = ballot.getBallots(bid)
            If (bal IsNot Nothing) Then
                results.Add(bal)
            End If
        Next

        Return results

        Throw New NotImplementedException()
    End Function
    Public Function getBallots(ballotsID As Integer) As Ballots Implements IBallotsManagement.getBallots
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results As Ballots = db.Ballots.Where(Function(b) b.BallotsID = ballotsID).FirstOrDefault()

        If IsNothing(results) Then
            Return Nothing
        Else
            Return results
        End If

        Throw New NotImplementedException()
    End Function


End Class
