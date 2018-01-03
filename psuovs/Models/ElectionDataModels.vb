Namespace Models

    Public Class Election
        Public ID As String

    End Class

    Public Class Ballot
        Public ID As String
        Public ElectionID As String

    End Class

    Public Class BallotChoice
        Public ID As String
        Public BallotID As String


    End Class

End Namespace
