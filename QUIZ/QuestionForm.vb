Imports MySql.Data.MySqlClient
Imports System.Math
Imports System.Threading

Public Class QuestionForm

    Private timeLimitSec As Short = 60

    Private firstQuestionNo As String = String.Empty
    Private firstQuestionAnswer As String = String.Empty
    Private secondQuestionNo As String = String.Empty
    Private secondQuestionAnswer As String = String.Empty
    Private thirdQuestionNo As String = String.Empty
    Private thirdQuestionAnswer As String = String.Empty

    Private isReadyToChangeTab As Boolean = False
    Private isReadyToClose As Boolean = False

    Private isAnswered(3) As Boolean
    Private selectedTab As TabPage


    Public setBackground As Thread

    Private setOfGreetings() As String = {"EXCELLENT!!!", "WONDERFUL!!!", "IMPRESSIVE!!!", "GOOD JOB!!!"}



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

        tmrQuestion.Enabled = True
        tmrQuestion.Start()
        tmrQuestion.Interval = 1000
        lblTimer.Text = timeLimitSec.ToString

        'set the questions
        loadFirstEasyQuestion()
        loadSecondEasyQuestion()
        loadHardQuestion()

        'display the current user
        lblPlayer.Text = currentEmployeeName

        'setBackground = New Thread(AddressOf setBackgroundImage)
        'setBackground.IsBackground = True
        'setBackground.Start()

    End Sub

    Private Sub setBackgroundImage()
        'Me.BackgroundImage = My.Resources.tumblr_static_di0pp82xzfkkoco88k4g044g0
    End Sub

    Private Sub tmrQuestion_Tick(sender As System.Object, e As System.EventArgs) Handles tmrQuestion.Tick
        lblTimer.Text = CType(lblTimer.Text, Short) - 1

        If (CType(lblTimer.Text, Short) < 20) Then
            lblTimer.ForeColor = Color.Red
        End If

        If (CType(lblTimer.Text, Short) = 0) Then
            tmrQuestion.Enabled = False
            tmrQuestion.Stop()

            MessageBox.Show("Times up! Thank you!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            isReadyToClose = True
            Me.Close()
        End If
    End Sub

#Region "Random Questions"

    Public Sub loadFirstEasyQuestion()

        'first question

        Try
            sqlViewCon.Open()

            Dim strCommand As String = "SELECT * FROM quiz.questions WHERE difficulty = 'easy' AND TYPE = 'opening' ORDER BY RAND() LIMIT 1"
            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader
            sqlViewReader.Read()

            lblFirstQuestion.Text = sqlViewReader.GetString(1)
            firstQuestionNo = sqlViewReader.GetString(0)
            firstQuestionAnswer = sqlViewReader.GetString(2)

            sqlViewCon.Close()

            sqlViewCon.Open()
            strCommand = "SELECT * FROM " & _
                        "(SELECT answer FROM quiz.questions " & _
                        "WHERE id =  " & firstQuestionNo & " " & _
                        "UNION " & _
                        "SELECT choice FROM (SELECT choice FROM quiz.choices " & _
                        "WHERE question_id = " & firstQuestionNo & " " & _
                        "ORDER BY RAND() LIMIT 3) AS k) AS d ORDER BY RAND()"

            'strCommand = "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE (b.question_id = " & firstQuestionNo & " And a.answer = b.choice)" & _
            '                "UNION " & _
            '                "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE b.question_id = " & firstQuestionNo & "  AND a.answer <> b.choice " & _
            '                "ORDER BY RAND() LIMIT 3) AS k) AS k ORDER BY RAND()"


            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader


            Dim firstChoices(4) As String
            Dim ctr As Integer = 1

            While (sqlViewReader.Read)
                ' MessageBox.Show(sqlViewReader.GetString(4)) debugging
                    firstChoices(ctr) = sqlViewReader.GetString(0)
                    ctr += 1
            End While

            radioFirstChoice1.Text = firstChoices(1)
            radioFirstChoice2.Text = firstChoices(2)
            radioFirstChoice3.Text = firstChoices(3)
            radioFirstChoice4.Text = firstChoices(4)

            sqlViewCon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlViewCon.Close()
        End Try

    End Sub

    Public Sub loadSecondEasyQuestion()

        Try
            sqlViewCon.Open()

            Dim strCommand As String = "SELECT * FROM quiz.questions WHERE difficulty = 'easy' AND TYPE = 'opening' AND id <> '" & firstQuestionNo & "' ORDER BY RAND() LIMIT 1"
            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader
            sqlViewReader.Read()

            lblSecondQuestion.Text = sqlViewReader.GetString(1)
            secondQuestionNo = sqlViewReader.GetString(0)
            secondQuestionAnswer = sqlViewReader.GetString(2)

            sqlViewCon.Close()

            sqlViewCon.Open()

            strCommand = "SELECT * FROM " & _
                        "(SELECT answer FROM quiz.questions " & _
                        "WHERE id = " & secondQuestionNo & " " & _
                        "UNION " & _
                        "SELECT choice FROM (SELECT choice FROM quiz.choices " & _
                        "WHERE question_id = " & secondQuestionNo & " " & _
                        "ORDER BY RAND() LIMIT 3) AS k) AS d ORDER BY RAND()"

            'strCommand = "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE (b.question_id = " & secondQuestionNo & " And a.answer = b.choice)" & _
            '                "UNION " & _
            '                "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE b.question_id = " & secondQuestionNo & "  AND a.answer <> b.choice " & _
            '                "ORDER BY RAND() LIMIT 3) AS k) AS k ORDER BY RAND()"


            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader


            Dim secondChoices(4) As String
            Dim ctr As Integer = 1

            While (sqlViewReader.Read)
                ' MessageBox.Show(sqlViewReader.GetString(4)) debugging
                secondChoices(ctr) = sqlViewReader.GetString(0)
                ctr += 1
            End While

            radioSecondChoice1.Text = secondChoices(1)
            radioSecondChoice2.Text = secondChoices(2)
            radioSecondChoice3.Text = secondChoices(3)
            radioSecondChoice4.Text = secondChoices(4)

        Catch ex As Exception
            MessageBox.Show(ex.ToString & "second")
        Finally
            sqlViewCon.Close()
        End Try

    End Sub

    Public Sub loadHardQuestion()

        Try
            sqlViewCon.Open()

            Dim strCommand As String = "SELECT * FROM quiz.questions WHERE difficulty = 'hard' AND TYPE = 'opening' ORDER BY RAND() LIMIT 1"
            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader
            sqlViewReader.Read()

            lblThirdQuestion.Text = sqlViewReader.GetString(1)
            thirdQuestionNo = sqlViewReader.GetString(0)
            thirdQuestionAnswer = sqlViewReader.GetString(2)

            sqlViewCon.Close()

            sqlViewCon.Open()

            strCommand = "SELECT * FROM " & _
                        "(SELECT answer FROM quiz.questions " & _
                        "WHERE id = " & thirdQuestionNo & " " & _
                        "UNION " & _
                        "SELECT choice FROM (SELECT choice FROM quiz.choices " & _
                        "WHERE question_id = " & thirdQuestionNo & " " & _
                        "ORDER BY RAND() LIMIT 3) AS k) AS d ORDER BY RAND()"

            'strCommand = "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE (b.question_id = " & thirdQuestionNo & " And a.answer = b.choice)" & _
            '                "UNION " & _
            '                "SELECT * FROM (SELECT a.id, a.question, a.answer, b.question_id, b.choice FROM quiz.questions a LEFT JOIN quiz.choices b " & _
            '                "ON a.id = b.question_id " & _
            '                "WHERE b.question_id = " & thirdQuestionNo & "  AND a.answer <> b.choice " & _
            '                "ORDER BY RAND() LIMIT 3) AS k) AS k ORDER BY RAND()"


            sqlViewCom = New MySqlCommand(strCommand, sqlViewCon)
            sqlViewReader = sqlViewCom.ExecuteReader


            Dim thirdChoices(4) As String
            Dim ctr As Integer = 1

            While (sqlViewReader.Read)
                ' MessageBox.Show(sqlViewReader.GetString(4)) debugging
                thirdChoices(ctr) = sqlViewReader.GetString(0)
                ctr += 1
            End While

            radioThirdChoice1.Text = thirdChoices(1)
            radioThirdChoice2.Text = thirdChoices(2)
            radioThirdChoice3.Text = thirdChoices(3)
            radioThirdChoice4.Text = thirdChoices(4)

        Catch ex As Exception
            MessageBox.Show(ex.ToString & "third")
        Finally
            sqlViewCon.Close()
        End Try

    End Sub

#End Region


    Public Function isQuestionCorrect(panelQuestion As Panel, questionAnswer As String, isPop As Boolean) As Boolean

        Dim rButton As RadioButton = panelQuestion.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(r) r.Checked = True)
        Dim answer As String = rButton.Text

        If questionAnswer = answer Then
            'tmrQuestion.Stop()
            'Try
            '    'If isPop Then
            '    'MessageBox.Show(setOfGreetings(Int(Rnd() * 3)) & vbNewLine & "Your answer is correct!", "WOW!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    'End If
            'Catch ex As Exception

            'End Try
            ''MessageBox.Show(Int(Rnd() * 3))

            'tmrQuestion.Start()
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub showGreetings(imageName As String, greetings As String, tab As String)
        Try
            tmrQuestion.Stop()
            Dim g As Greetings
            g = New Greetings(imageName, greetings, tab)
            g.Show()

        Catch ex As Exception
            MessageBox.Show("something went wrong")
        End Try
    End Sub


#Region "validate answer"
    Private Sub radioFirstChoice1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioFirstChoice1.MouseClick, radioFirstChoice2.MouseClick, radioFirstChoice3.MouseClick, radioFirstChoice4.MouseClick

        If MessageBox.Show("Is that your final answer?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' do here
            If isQuestionCorrect(panelQuestion1, firstQuestionAnswer, True) Then
                isReadyToChangeTab = True
                tmrQuestion.Stop()
                showGreetings("happy", setOfGreetings(Int(Rnd() * 3)) & vbNewLine & "Your answer is correct!", "tab2")
            Else
                showGreetings("sad", "Oopppsss! Sorry - your answer was INCORRECT!" & vbNewLine & "" & vbNewLine & "The correct answer should be '" & firstQuestionAnswer & "'" & vbNewLine & "Thank you for playing! ", "no")
                wrongAnswerClose(firstQuestionAnswer)
            End If
        End If
    End Sub

    Private Sub radioSecondChoice2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioSecondChoice1.MouseClick, radioSecondChoice2.MouseClick, radioSecondChoice3.MouseClick, radioSecondChoice4.MouseClick

        If MessageBox.Show("Is that your final answer?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' do here
            If isQuestionCorrect(panelQuestion2, secondQuestionAnswer, True) Then
                isReadyToChangeTab = True
                showGreetings("happy", setOfGreetings(Int(Rnd() * 3)) & vbNewLine & "Your answer is correct!", "tab3")
            Else
                showGreetings("sad", "Oopppsss! Sorry - your answer was INCORRECT!" & vbNewLine & "" & vbNewLine & "The correct answer should be '" & secondQuestionAnswer & "'" & vbNewLine & "Thank you for playing! ", "no")
                wrongAnswerClose(secondQuestionAnswer)
            End If
        End If
    End Sub

    Private Sub radioThirdChoice3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radioThirdChoice1.MouseClick, radioThirdChoice2.MouseClick, radioThirdChoice3.MouseClick, radioThirdChoice4.MouseClick

        If MessageBox.Show("Is that your final answer?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ' do here
            If isQuestionCorrect(panelQuestion3, thirdQuestionAnswer, False) Then
                showGreetings("congratulations", "C O N G R A T U L A T I O N S !!!" & vbNewLine & "" & vbNewLine & "(YOU ARE CERTIFIED TERADYNE GENIUS)" & _
                        vbNewLine & "Thanks for playing!" & vbNewLine & "**Stay tuned for announcement on how to claim your PRIZE!", "no")
                insertNewWinners()
            Else
                showGreetings("sad", "Oopppsss! Sorry - your answer was INCORRECT!" & vbNewLine & "" & vbNewLine & "The correct answer should be '" & thirdQuestionAnswer & "'" & vbNewLine & "Thank you for playing! ", "no")
                wrongAnswerClose(thirdQuestionAnswer)
            End If
        End If
    End Sub

    Public Sub wrongAnswerClose(correctAnswer As String)
        tmrQuestion.Stop()
        'MessageBox.Show("Oopppsss! Sorry - your answer was INCORRECT!" & vbNewLine & "" & vbNewLine & "The correct answer should be '" & correctAnswer & "'" & vbNewLine & "Thank you for playing! ", "SORRY!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        isReadyToClose = True
        'Me.Close()
    End Sub

    Private Function checkTabAnswers() As Boolean
        Dim ctr As Integer = 0
        Dim returnBool As Boolean = True

        While ctr < isAnswered.Length - 1
            If isAnswered(ctr) = False Then
                returnBool = False
            End If
            ctr += 1
        End While

        Return returnBool
    End Function

#End Region

    Private Sub insertNewWinners()
        tmrQuestion.Stop()

        sqlViewCon.Open()
        Dim strQuery As String = "INSERT INTO quiz.winners (id_no,name, date_created, time_spent) VALUES ('" & currentUserId & "', '" & currentEmployeeName & "', NOW(), '" & timeLimitSec - CType(lblTimer.Text, Integer) & "')"
        sqlViewCom = New MySqlCommand(strQuery, sqlViewCon)
        sqlViewCom.ExecuteNonQuery()
        sqlViewCon.Close()

        'MessageBox.Show("C O N G R A T U L A T I O N S !!!" & vbNewLine & "" & vbNewLine & "(YOU ARE CERTIFIED TERADYNE GENIUS)" & _
        '                vbNewLine & "Thanks for playing!" & vbNewLine & "**Stay tuned for announcement on how to claim your PRIZE!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        isReadyToClose = True
        'Me.Close()

    End Sub

    Public Sub formClose()
        LoginForm.IdNoTextBox.Text = String.Empty
        LoginForm.displayWinners()
    End Sub

    Private Sub QuestionForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not isReadyToClose Then
            If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                formClose()
                LoginForm.IdNoTextBox.Focus()
            Else
                e.Cancel = True
            End If
        Else
            formClose()
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnForfeit.Click
        Me.Close()
    End Sub

    Private Sub tabCtrlQuestion_Deselecting(sender As System.Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tabCtrlQuestion.Deselecting
        If isReadyToChangeTab Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
        isReadyToChangeTab = False
    End Sub

    Private Sub tabCtrlQuestion_Selecting(sender As System.Object, e As System.Windows.Forms.TabControlCancelEventArgs) Handles tabCtrlQuestion.Selecting
        If isAnswered(0) And e.TabPage.Name = "tabQuestion1" Then
            e.Cancel = True
        ElseIf isAnswered(1) And e.TabPage.Name = "tabQuestion2" Then
            e.Cancel = True
        ElseIf isAnswered(2) And e.TabPage.Name = "tabQuestion3" Then
            e.Cancel = True
        End If
    End Sub

#Region "dumpcode"
    ' If isQuestionCorrect(panelQuestion1, firstQuestionAnswer) Then
    'direct to next page
    '            isReadyToChangeTab = True
    'tabCtrlQuestion.SelectedTab = tabQuestion2
    '            isAnswered(0) = True
    '            tabCtrlQuestion.TabPages(0).Enabled = False
    ''MessageBox.Show(checkTabAnswers())
    '            If Not isAnswered(1) Then
    '                tabCtrlQuestion.SelectedTab = tabQuestion2
    '            Else
    '                tabCtrlQuestion.SelectedTab = tabQuestion3
    '            End If

    '            If checkTabAnswers() Then
    '                If isQuestionCorrect(panelQuestion1, firstQuestionAnswer) And isQuestionCorrect(panelQuestion2, secondQuestionAnswer) And isQuestionCorrect(panelQuestion3, thirdQuestionAnswer) Then
    '                    insertNewWinners()
    '                End If
    '            End If
    '        Else
    '            tmrQuestion.Stop()
    '            MessageBox.Show("Ooppss! Wrong answer. Thank you :)", "SORRY!")
    '            isReadyToClose = True
    '            Me.Close()
    '        End If
#End Region

End Class