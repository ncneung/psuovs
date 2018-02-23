Imports PSUOVS

Public Class clsVoters
    Implements IVoterManagement

    Public Function AssignVoter(BallotID As String, passport As String, otherInfo As String) As Object Implements IVoterManagement.AssignVoter
        Throw New NotImplementedException()
    End Function

    Public Function checkVoter(PSUPassport As String) As Boolean Implements IVoterManagement.checkVoter
        Throw New NotImplementedException()
    End Function

    Public Function GetVoter(passport As String) As V_Voter Implements IVoterManagement.GetVoter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1()
        Dim result = db.V_Voter.Where(Function(v) v.PSUPassport = passport).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing

        Else
            Return result

        End If
        'Throw New NotImplementedException()
    End Function

    Public Function GetVoters(ElectionID As String) As IEnumerable(Of V_Voter) Implements IVoterManagement.GetVoters
        Throw New NotImplementedException()
    End Function

    Public Function Registration(BallotID As String, passport As String, registedBy As String) As Object Implements IVoterManagement.Registration
        Throw New NotImplementedException()
    End Function

    Public Function RemoveVoter(BallotID As String, passport As String) As Object Implements IVoterManagement.RemoveVoter
        Throw New NotImplementedException()
    End Function

    Public Function SetVoted(BallotID As String, passport As String) As Object Implements IVoterManagement.SetVoted
        Throw New NotImplementedException()
    End Function


End Class
