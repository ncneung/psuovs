Public Class Role
    'Public ID As Integer
    'Public PSUPassport As String

    Private _roleid As Integer
    Private _psupassport As String
    Private _electionsid As Integer
    Private _isactived As Boolean
    Public Property IsActived() As Boolean
        Get
            Return _isactived
        End Get
        Set(ByVal value As Boolean)
            _isactived = value
        End Set
    End Property
    Public Property ElectionsID() As Integer
        Get
            Return _electionsid
        End Get
        Set(ByVal value As Integer)
            _electionsid = value
        End Set
    End Property
    Public Property RoleID() As Integer
        Get
            Return _roleid
        End Get
        Set(value As Integer)
            _roleid = value
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
