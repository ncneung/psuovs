Namespace Models
    Public Class Voter
        Public ID As String

    End Class
    Public Class VoterDetail
        Private _psupassport As String
        Private _gender As String
        Private _nameTH As String
        Private _snameTH As String
        Private _nameEN As String
        Private _snameEN As String
        Private _facnameTH As String
        Private _chkvoter As Boolean
        Public Property checkVoter() As Boolean
            Get
                Return _chkvoter
            End Get
            Set(ByVal value As Boolean)
                _chkvoter = value
            End Set
        End Property
        Public Property FacNameTH() As String
            Get
                Return _facnameTH
            End Get
            Set(ByVal value As String)
                _facnameTH = value
            End Set
        End Property
        Public Property SNameEN() As String
            Get
                Return _snameEN
            End Get
            Set(ByVal value As String)
                _snameEN = value
            End Set
        End Property
        Public Property NameEN() As String
            Get
                Return _nameEN
            End Get
            Set(ByVal value As String)
                _nameEN = value
            End Set
        End Property
        Public Property SNameTH() As String
            Get
                Return _snameTH
            End Get
            Set(ByVal value As String)
                _snameTH = value
            End Set
        End Property
        Public Property NameTH() As String
            Get
                Return _nameTH
            End Get
            Set(ByVal value As String)
                _nameTH = value
            End Set
        End Property
        Public Property Genger() As String
            Get
                Return _gender
            End Get
            Set(ByVal value As String)
                _gender = value
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
