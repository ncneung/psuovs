Imports PSUOVS
Imports PSUOVS.Models

Public Class clsVoter
    Implements IVoterManagement
    Dim _conn As clsConnect = New clsConnect()
    Public Function AssignVoter(BallotID As String, passport As String, otherInfo As String) As Object Implements IVoterManagement.AssignVoter
        Throw New NotImplementedException()
    End Function

    Public Function checkVoter(PSUPassport As String) As Boolean Implements IVoterManagement.checkVoter
        '    Dim strSQL As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & strPSUPassport & "'"
        '    Dim result As Role

        '    'Return Sql_Dataset(strSQL)

        '    Dim ds As DataSet = _conn.Fill(strSQL, "role")

        '    If (ds IsNot Nothing) Then
        '        result = New Role()
        '        With result
        '            .RoleID = ds.Tables("role").Rows(0).Item("RoleID")
        '        End With

        '    End If
        '    Return result

        'Dim result As MatchVoterBallots

        'Dim ds As DataSet = _conn.Fill(strSQL, "MatchVoter")

        'If (ds IsNot Nothing) Then
        '    result = New MatchVoterBallots()
        '    With result
        '        .BallotsID = 
        '    End With
        'End If
        Dim strSQL As String = "SELECT * FROM MatchVoterBallots Where PSUPassport = " & "'" & PSUPassport & "'"
        Dim ds As DataSet = _conn.Fill(strSQL, "MatchVoter")
        If ds.Tables("MatchVoter").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
        Throw New NotImplementedException()
    End Function

    Public Function GetVoter(passport As String) As Object Implements IVoterManagement.GetVoter
        Throw New NotImplementedException()
    End Function

    Public Function GetVoters(ElectionID As String) As IEnumerable(Of Voter) Implements IVoterManagement.GetVoters
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
