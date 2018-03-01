Imports PSUOVS

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

    Public Function getBallotsForVoter(psupassport As String) As List(Of MatchVoterBallots) Implements IRegistedManagement.getBallotsForVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results = db.MatchVoterBallots.Where(Function(m) m.PSUPassport = psupassport)
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

    Public Function insertMatchVoterBallots(psupassport As String, ballotsID As Integer, electionID As Integer) As MatchVoterBallots Implements IRegistedManagement.insertMatchVoterBallots
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim AddMatchVoterBallots As New MatchVoterBallots
        AddMatchVoterBallots.PSUPassport = psupassport
        AddMatchVoterBallots.BallotsID = ballotsID
        AddMatchVoterBallots.ElectionID = electionID


        Dim result = db.MatchVoterBallots.Add(AddMatchVoterBallots)
        If IsNothing(result) Then
            Return Nothing
        Else

            db.SaveChanges()
            Return result
        End If
    End Function
    Public Function deleteMatchVoterBallots(ByVal psupassport As String, ByVal ballotsID As Integer, ByVal electionID As Integer) As MatchVoterBallots Implements IRegistedManagement.deleteMatchVoterBallots
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim u = db.MatchVoterBallots.Where(Function(d) d.PSUPassport = psupassport And d.BallotsID = ballotsID And d.ElectionID = electionID).FirstOrDefault()
        If IsNothing(u) Then
            Return Nothing
        Else
            db.MatchVoterBallots.Remove(u)
            db.SaveChanges()
            Return u
        End If


        Throw New NotImplementedException()
    End Function

    Public Function insertRegistedVoter(psupassport As String, electionID As Integer, registed As Boolean, registedDate As Date, registedBy As String) As RegistedVoter Implements IRegistedManagement.insertRegistedVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim addRegist As New RegistedVoter
        addRegist.PSUPassport = psupassport
        addRegist.ElectionID = electionID
        addRegist.Registed = registed
        addRegist.RegistedDate = registedDate
        addRegist.RegistedBy = registedBy

        Dim result = db.RegistedVoter.Add(addRegist)
        If IsNothing(result) Then
            Return Nothing
        Else
            db.SaveChanges()
            Return result
        End If
    End Function

    Public Function selectMatchVoterBallots(psupassport As String, ballotsID As Integer, electionID As Integer) As MatchVoterBallots Implements IRegistedManagement.selectMatchVoterBallots
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.MatchVoterBallots.Where(Function(s) s.PSUPassport = psupassport And s.BallotsID = ballotsID And s.ElectionID = electionID).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function updateMatchVoterBallots(autoid As Integer) As MatchVoterBallots Implements IRegistedManagement.updateMatchVoterBallots
        'Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        'Dim u = db.MatchVoterBallots.Where(Function(s) s.AutoID = autoid).FirstOrDefault()
        'If IsNothing(u) Then
        '    Return Nothing
        'Else
        '    db.SaveChanges()
        'End If


        Throw New NotImplementedException()
    End Function

    Public Function selectRegistedVoter(psupassport As String, electionID As Integer) As RegistedVoter Implements IRegistedManagement.selectRegistedVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.RegistedVoter.Where(Function(r) r.PSUPassport = psupassport And r.ElectionID = electionID).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function

    Public Function countRegist(electionid As Integer) As List(Of RegistedVoter) Implements IRegistedManagement.countRegist
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results = db.RegistedVoter.Where(Function(r) r.ElectionID = electionid And r.Registed = True)
        If IsNothing(results) Then
            Return Nothing
        Else
            Return results.ToList()
        End If

        Throw New NotImplementedException()
    End Function

    Public Function checkRegistTrue(psupassport As String, electionid As Integer) As RegistedVoter Implements IRegistedManagement.checkRegistTrue
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim result = db.RegistedVoter.Where(Function(r) r.PSUPassport = psupassport And r.ElectionID = electionid And r.Registed = True).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result
        End If
        Throw New NotImplementedException()
    End Function
End Class
