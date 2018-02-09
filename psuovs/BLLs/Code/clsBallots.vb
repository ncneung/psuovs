Imports PSUOVS

Public Class clsBallots
    Implements IBallotsManagement

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
