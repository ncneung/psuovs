Public Class testna
    'Function getTable(ByVal psuPassport As String) As Table

    'End Function
    Public Function testGet(ByVal passport As String) As V_Voter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1()
        Dim result = db.V_Voter.Where(Function(v) v.PSUPassport = passport).FirstOrDefault()
        Return result
    End Function

    Public Function testGets(ByVal passport As String) As V_Voter
        Dim db As PSUOVSEntities1 = New PSUOVSEntities1()
        Dim result = db.V_Voter.Where(Function(v) v.PSUPassport = passport).FirstOrDefault()
        If IsNothing(result) Then
            Return Nothing
        Else
            Return result

        End If

    End Function
End Class
