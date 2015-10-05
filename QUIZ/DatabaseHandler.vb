Imports MySql.Data.MySqlClient

Module DatabaseHandler

    Public sqlViewCon As MySqlConnection = New MySqlConnection("server=sprite;user id=root; password=bamysqlroot; database=rework; check parameters=false; Connect Timeout=120")
    'Public sqlViewCon As MySqlConnection = New MySqlConnection("server=jeepme;user id=root; password=bamysqlroot; check parameters=false; Connect Timeout=120")
    Public sqlViewCom As MySqlCommand
    Public sqlViewReader As MySqlDataReader
    Public sqlViewDa As MySqlDataAdapter

    Public currentUserId As Integer
    Public currentEmployeeName As String

End Module