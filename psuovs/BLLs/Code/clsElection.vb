Imports PSUOVS
Imports PSUOVS.Models

Public Class clsElection
    Implements IElectionManagement

    Public Function GetElection(ElectionID As String) As ElectionVote Implements IElectionManagement.GetElection
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results As ElectionVote = db.ElectionVote.Where(Function(e) e.ElectionID = ElectionID).FirstOrDefault()

        If IsNothing(results) Then
            Return Nothing
        Else
            Return results

        End If



        Throw New NotImplementedException()
    End Function

End Class
