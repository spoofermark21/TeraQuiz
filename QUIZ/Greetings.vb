Public Class Greetings

    Public isFinal As Boolean = False
    Public tab As String = String.Empty

    Public Sub New(imageName As String, greetings As String, tab As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If imageName = "happy" Then
            picGreetings.BackgroundImage = My.Resources.happy
        ElseIf imageName = "sad" Then
            picGreetings.BackgroundImage = My.Resources.sad
        ElseIf imageName = "congratulations" Then
            picGreetings.BackgroundImage = My.Resources.congratulations
        End If

        picGreetings.BackgroundImageLayout = ImageLayout.Stretch
        lblGreetings.Text = greetings

        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.tab = tab

    End Sub

    Private Sub btnOkay_Click(sender As System.Object, e As System.EventArgs) Handles btnOkay.Click
        'QuestionForm.tmrQuestion.Start()
        If tab = "tab2" Then
            QuestionForm.tabCtrlQuestion.SelectedTab = QuestionForm.tabQuestion2
            QuestionForm.tmrQuestion.Start()
        ElseIf tab = "tab3" Then
            QuestionForm.tabCtrlQuestion.SelectedTab = QuestionForm.tabQuestion3
            QuestionForm.tmrQuestion.Start()
        Else
            LoginForm.IdNoTextBox.Focus()
            QuestionForm.Close()
        End If

        Me.Close()
    End Sub
End Class