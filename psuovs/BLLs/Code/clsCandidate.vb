Imports PSUOVS

Public Class clsCandidate
    Implements ICandidateManagement

    Public Function getCandidate(ballotsid As Integer) As List(Of Candidate) Implements ICandidateManagement.getCandidate
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1
        Dim results = db.Candidate.Where(Function(c) c.BallotsID = ballotsid)
        If IsNothing(results) Then
            Return Nothing
        Else
            Return results.ToList()
        End If
    End Function
End Class
