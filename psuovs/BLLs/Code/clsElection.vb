Imports PSUOVS

Public Class clsElection
    Implements IElectionManagement

    Public Function checkElectionStatus(electionid As Integer) As ElectionVote Implements IElectionManagement.checkElectionStatus
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result As ElectionVote = db.ElectionVote.Where(Function(e) e.ElectionID = electionid).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function GetDetailElectionForVote(psupassport As String) As List(Of ElectionVote) Implements IElectionManagement.GetDetailElectionForVote
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1()
        'Dim eIDs = db.RegistedVoter.Where(Function(r) r.PSUPassport = psupassport And r.Registed = True) _
        Dim eIDs = db.RegistedVoter.Where(Function(r) r.PSUPassport = psupassport) _
                   .Select(Function(x) x.ElectionID).Distinct()
        Dim classElection As IElectionManagement = New clsElection
        Dim results As List(Of ElectionVote) = New List(Of ElectionVote)()

        For Each eID In eIDs
            Dim ele = classElection.GetElectionForVote(eID)
            If (ele IsNot Nothing) Then
                results.Add(ele)
            End If
        Next
        Return results
        Throw New NotImplementedException()
    End Function

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
        Dim avalibleStatus = {"open", "continue", "pause"}
        Dim results As ElectionVote = db.ElectionVote.Where(Function(e) e.ElectionID = electionID And avalibleStatus.Contains(e.ElectionStatus.StatusName.ToLower())).FirstOrDefault()

        If IsNothing(results) Then
            Return Nothing
        Else
            Return results

        End If
        Throw New NotImplementedException()
    End Function
End Class
