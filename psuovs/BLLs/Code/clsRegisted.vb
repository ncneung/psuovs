Imports PSUOVS
Imports PSUOVS.Models

Public Class clsRegisted
    Implements IRegistedManagement

    Public Function getBallotsForRegisted(electionID As Integer) As List(Of Ballots) Implements IRegistedManagement.getBallotsForRegisted
        'Dim getElection As IElectionManagement = New clsElection

        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results = db.Ballots.Where(Function(b) b.ElectionID = electionID)
        If IsNothing(results) Then
            Return Nothing
        Else
            Return results.ToList()
        End If

        Throw New NotImplementedException()
    End Function

    Public Function getElectionsForRegisted(psupassport As String) As List(Of ElectionVote) Implements IRegistedManagement.getElectionsForRegisted
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1()
        'Dim results = db.MatchVoterBallots.Where(Function(m) m.PSUPassport = psupassport) _
        '             .Select(Function(x) New With {
        '                 .PSUPassport = x.PSUPassport,
        '                .ElectionID = x.ElectionID
        '             }).Distinct()

        Dim eIDs = db.MatchVoterBallots.Where(Function(m) m.PSUPassport = psupassport) _
                     .Select(Function(x) x.ElectionID).Distinct()


        Dim election As IElectionManagement = New clsElection


        Dim result As List(Of ElectionVote) = New List(Of ElectionVote)()
        For Each eid In eIDs
            Dim ele = election.GetElection(eid)
            If (ele IsNot Nothing) Then
                result.Add(ele)
            End If
        Next

        Return result



        '.GroupBy(Function(x) New With {Key x.ElectionID}) _

        'Dim results = db.MatchVoterBallots.Where()

        'If IsNothing(results) Then
        '    Return Nothing
        'Else
        '    Return results
        'End If

        Throw New NotImplementedException()
    End Function
End Class
