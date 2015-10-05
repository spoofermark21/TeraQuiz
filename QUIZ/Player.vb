Public Class Player

    Private UserId As Integer
    Private UserName As String


    Public Property UserIdInfo As Integer

        Get
            UserIdInfo = UserId
        End Get
        Set(value As Integer)
            UserId = value
        End Set

    End Property

    Public Property UserNameInfo As String

        Get
            UserNameInfo = UserName
        End Get
        Set(value As String)
            UserName = value
        End Set

    End Property



End Class
