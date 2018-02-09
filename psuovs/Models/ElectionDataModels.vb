Namespace Models

    Public Class Election
        Private _electionid As String
        Private _electionnameth As String
        Private _electionnameen As String
        Private _electiondesth As String
        Private _electiondesen As String
        Private _statusid As Integer
        Private _statusreport As Boolean
        'Private _date


        Public Property ElectionID() As String
            Get
                Return _electionid
            End Get
            Set(ByVal value As String)
                _electionid = value
            End Set
        End Property

        Public Property ElectionnameTH As String
            Get
                Return _electionnameth
            End Get
            Set(value As String)
                _electionnameth = value
            End Set
        End Property

        Public Property ElectionnameEN As String
            Get
                Return _electionnameen
            End Get
            Set(value As String)
                _electionnameen = value
            End Set
        End Property
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
