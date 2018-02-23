Imports PSUOVS

Public Class clsElection
    Implements IElectionManagement

    Public Function GetElection(electionID As Integer) As ElectionVote Implements IElectionManagement.GetElection
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results As ElectionVote = db.ElectionVote.Where(Function(e) e.ElectionID = electionID).FirstOrDefault()

        If IsNothing(results) Then
            Return Nothing
        Else
            Return results

        End If
        Throw New NotImplementedException()
    End Function

    Public Function GetElectionForVote(electionID As Integer) As ElectionVote Implements IElectionManagement.GetElectionForVote
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results As ElectionVote = db.ElectionVote.Where(Function(e) e.ElectionID = electionID And e.ElectionStatus.StatusName <> "Close").FirstOrDefault()

        If IsNothing(results) Then
            Return Nothing
        Else
            Return results

        End If
        Throw New NotImplementedException()
    End Function
End Class
