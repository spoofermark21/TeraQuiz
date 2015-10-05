Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Threading

Public Class LoginForm

    Public sqlViewDsQuestions, sqlViewDsChoices, sqlViewDsContestants, sqlViewDsWinners As New DataSet

    Public type As String = "opening"
    Public idNo As String

    Public showForm As Thread
    Public setBackground As Thread

    Public q As QuestionForm

    Private password As String = "mouse"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ControlProperties()
        displayWinners()


    End Sub

    Private Sub ControlProperties()
        IdNoTextBox.ShortcutsEnabled = False
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Show()
        IdNoTextBox.Focus()

        'setBackground = New Thread(AddressOf setBackgroundImage)
        'setBackground.IsBackground = True
        'setBackground.Start()
    End Sub

    Private Sub setBackgroundImage()
        'Me.BackgroundImage = My.Resources.tumblr_static_di0pp82xzfkkoco88k4g044g0
    End Sub


    Private Sub CaptureData()
        Dim sqlViewQuerryQuestions As String = "select * from quiz.questions where type ='" + type + "';"
        Dim sqlViewQuerryChoices As String = "select * from quiz.choices"
        Dim sqlViewQuerryContestants As String = "select * from quiz.contestants"
        Dim sqlViewQuerryWinners As String = "select * from quiz.winners"

        sqlViewCon.Open()
        sqlViewCom = New MySqlCommand(sqlViewQuerryQuestions, sqlViewCon)
        sqlViewDa = New MySqlDataAdapter(sqlViewCom)

        sqlViewDa.SelectCommand.CommandTimeout = 300
        sqlViewDsQuestions.Reset()
        sqlViewDsQuestions.Clear()
        sqlViewDsQuestions.Relations.Clear()
        sqlViewDsQuestions.Tables.Clear()

        sqlViewDa.Fill(sqlViewDsQuestions, "questions")

        sqlViewCom = New MySqlCommand(sqlViewQuerryChoices, sqlViewCon)
        sqlViewDa = New MySqlDataAdapter(sqlViewCom)

        sqlViewDa.SelectCommand.CommandTimeout = 300
        sqlViewDsChoices.Reset()
        sqlViewDsChoices.Clear()
        sqlViewDsChoices.Relations.Clear()
        sqlViewDsChoices.Tables.Clear()

        sqlViewDa.Fill(sqlViewDsChoices, "choices")

        sqlViewCom = New MySqlCommand(sqlViewQuerryContestants, sqlViewCon)
        sqlViewDa = New MySqlDataAdapter(sqlViewCom)

        sqlViewDa.SelectCommand.CommandTimeout = 300
        sqlViewDsContestants.Reset()
        sqlViewDsContestants.Clear()
        sqlViewDsContestants.Relations.Clear()
        sqlViewDsContestants.Tables.Clear()

        sqlViewDa.Fill(sqlViewDsContestants, "contestants")

        sqlViewCom = New MySqlCommand(sqlViewQuerryWinners, sqlViewCon)
        sqlViewDa = New MySqlDataAdapter(sqlViewCom)

        sqlViewDa.SelectCommand.CommandTimeout = 300
        sqlViewDsWinners.Reset()
        sqlViewDsWinners.Clear()
        sqlViewDsWinners.Relations.Clear()
        sqlViewDsWinners.Tables.Clear()

        sqlViewDa.Fill(sqlViewDsWinners, "winners")
        sqlViewCon.Close()

    End Sub

#Region "Verify user"
    Private Sub IdNoTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles IdNoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub IdNoTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles IdNoTextBox.TextChanged
        Dim result As String = EmployeeCheck(IdNoTextBox.Text)
        IdLoginResultLabel.Text = String.Empty

        If result = "already played" Then
            btnPlay.Visible = False
            IdLoginResultLabel.Text = currentEmployeeName + ", " + "You have already played this game. You can only try once."
        ElseIf result = "not yet played" Then
            btnPlay.Visible = True
            IdLoginResultLabel.Text = "Welcome, " + currentEmployeeName + " !"
        ElseIf result = "not exists" Then
            btnPlay.Visible = False
            IdLoginResultLabel.Text = "Please input a valid id number"
        End If

    End Sub

    Private Function EmployeeCheck(id As String) As String

        'Dim sqlQueryEmployeeCheck As String = "Select * from entity.ref_employees where employee_id ='" & id & "' and terminated flag ='N'"
        Dim sqlQueryEmployeeCheck As String = "SELECT CASE WHEN EXISTS(SELECT employee_id FROM entity.ref_employees WHERE employee_id ='" & id & "' AND terminated_flag ='N') THEN 1 ELSE 0 END AS exist;"
        Dim exists As Byte = 0
        Dim played As Byte = 0
        Dim strReturn = String.Empty

        Try

            sqlViewCon.Open()
            sqlViewCom = New MySqlCommand(sqlQueryEmployeeCheck, sqlViewCon)
            exists = CByte(sqlViewCom.ExecuteScalar)
            If CBool(exists) Then
                'Dim sqlQueryEmployeePlayed As String = "SELECT CASE WHEN EXISTS(SELECT * FROM (SELECT CASE WHEN EXISTS( SELECT id_no FROM quiz.contestants WHERE id_no ='" & id & "') THEN 1 ELSE 0 END AS contestants) a, (SELECT CASE WHEN EXISTS( SELECT id_no FROM quiz.winners WHERE id_no ='" & id & "' ) THEN 1 ELSE 0 END AS winners) b WHERE contestants = 1 OR winners = 1) THEN 1 ELSE 0 END AS played "
                Dim sqlQueryEmployeePlayed As String = "SELECT CASE WHEN EXISTS(SELECT * FROM (SELECT CASE WHEN EXISTS(SELECT id_no FROM quiz.contestants WHERE id_no ='" & id & "') THEN 1 ELSE 0 END AS contestants) a WHERE contestants = 1) THEN 1 ELSE 0 END AS played "
                sqlViewCom = New MySqlCommand(sqlQueryEmployeePlayed, sqlViewCon)
                played = CByte(sqlViewCom.ExecuteScalar)
                Dim sqlQueryemployeeName As String = "SELECT CONCAT(first_name,' ' ,last_name) FROM entity.ref_employees WHERE employee_id ='" & id & "'"
                sqlViewCom = New MySqlCommand(sqlQueryemployeeName, sqlViewCon)
                currentEmployeeName = ""
                currentEmployeeName = sqlViewCom.ExecuteScalar
                idNo = id

                If played Then
                    strReturn = "already played"
                Else
                    strReturn = "not yet played"
                End If
            Else
                strReturn = "not exists"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlViewCon.Close()
        End Try

        Return strReturn

    End Function

#End Region

    Private Sub BtnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        Try
            If MessageBox.Show("Are you ready?", "Goodluck!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sqlViewCon.Open()
                Dim strQuery As String = "INSERT INTO quiz.contestants (id_no,date_created) VALUES ('" & IdNoTextBox.Text & "',NOW())"

                sqlViewCom = New MySqlCommand(strQuery, sqlViewCon)
                sqlViewCom.ExecuteNonQuery()

                'session user
                currentUserId = CType(IdNoTextBox.Text, Integer)

                Dim p As New Player
                p.UserIdInfo = currentUserId
                p.UserNameInfo = currentEmployeeName

                sqlViewCon.Close()

                'showForm = New Thread(AddressOf showQuestionForm)
                'showForm.IsBackground = True
                'showForm.Start()

                QuestionForm.Show()

                'Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Sub showQuestionForm()
        q = New QuestionForm() ' Must be created on this thread!
        Application.Run(q)
    End Sub

    Public Sub displayWinners()
        Try
            sqlViewCon.Open()

            Dim strQuery As String = "SELECT * FROM quiz.winners ORDER BY time_spent, date_created DESC"
            sqlViewCom = New MySqlCommand(strQuery, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader

            gridWinners.Rows.Clear()

            While sqlViewReader.Read
                'MessageBox.Show(sqlViewReader.GetString(0))
                gridWinners.Rows.Add(New String() {sqlViewReader.GetString(1), sqlViewReader.GetString(2), sqlViewReader.GetString(3), sqlViewReader.GetString(4) & " seconds"})
            End While
        Catch ex As Exception
            'for debugging
            MessageBox.Show(ex.ToString)
        Finally
            sqlViewCon.Close()
        End Try
    End Sub

    Private Sub LoginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not InputBox("Enter password to exit:", "Security") = password Then
            e.Cancel = True
        End If
    End Sub
End Class