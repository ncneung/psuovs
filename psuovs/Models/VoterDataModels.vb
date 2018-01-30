Namespace Models
    Public Class Voter
        Public ID As String

    End Class

    Public Class MatchVoterBallots
        Private _psupassport As String
        Private _ballotsID As Integer
        Private _voted As Boolean
        Private _Voteddate As Date
        Public Property VotedDate() As Date
            Get
                Return _Voteddate
            End Get
            Set(ByVal value As Date)
                _Voteddate = value
            End Set
        End Property
        Public Property Voted() As Boolean
            Get
                Return _voted
            End Get
            Set(ByVal value As Boolean)
                _voted = value
            End Set
        End Property
        Public Property BallotsID() As Integer
            Get
                Return _ballotsID
            End Get
            Set(ByVal value As Integer)
                _ballotsID = value
            End Set
        End Property
        Public Property PSUPassport() As String
            Get
                Return _psupassport
            End Get
            Set(ByVal value As String)
                _psupassport = value
            End Set
        End Property
    End Class

End Namespace
