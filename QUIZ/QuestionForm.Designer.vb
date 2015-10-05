<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrQuestion = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.IdNoPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.btnForfeit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstQuestion = New System.Windows.Forms.Label()
        Me.radioFirstChoice4 = New System.Windows.Forms.RadioButton()
        Me.radioFirstChoice1 = New System.Windows.Forms.RadioButton()
        Me.radioFirstChoice3 = New System.Windows.Forms.RadioButton()
        Me.radioFirstChoice2 = New System.Windows.Forms.RadioButton()
        Me.panelQuestion1 = New System.Windows.Forms.Panel()
        Me.tabCtrlQuestion = New System.Windows.Forms.TabControl()
        Me.tabQuestion1 = New System.Windows.Forms.TabPage()
        Me.tabQuestion2 = New System.Windows.Forms.TabPage()
        Me.panelQuestion2 = New System.Windows.Forms.Panel()
        Me.radioSecondChoice4 = New System.Windows.Forms.RadioButton()
        Me.lblSecondQuestion = New System.Windows.Forms.Label()
        Me.radioSecondChoice2 = New System.Windows.Forms.RadioButton()
        Me.radioSecondChoice3 = New System.Windows.Forms.RadioButton()
        Me.radioSecondChoice1 = New System.Windows.Forms.RadioButton()
        Me.tabQuestion3 = New System.Windows.Forms.TabPage()
        Me.panelQuestion3 = New System.Windows.Forms.Panel()
        Me.radioThirdChoice4 = New System.Windows.Forms.RadioButton()
        Me.lblThirdQuestion = New System.Windows.Forms.Label()
        Me.radioThirdChoice2 = New System.Windows.Forms.RadioButton()
        Me.radioThirdChoice3 = New System.Windows.Forms.RadioButton()
        Me.radioThirdChoice1 = New System.Windows.Forms.RadioButton()
        Me.IdNoPanel.SuspendLayout()
        Me.panelQuestion1.SuspendLayout()
        Me.tabCtrlQuestion.SuspendLayout()
        Me.tabQuestion1.SuspendLayout()
        Me.tabQuestion2.SuspendLayout()
        Me.panelQuestion2.SuspendLayout()
        Me.tabQuestion3.SuspendLayout()
        Me.panelQuestion3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrQuestion
        '
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(51, 113)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(211, 128)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "100"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IdNoPanel
        '
        Me.IdNoPanel.BackColor = System.Drawing.Color.Transparent
        Me.IdNoPanel.Controls.Add(Me.Label3)
        Me.IdNoPanel.Controls.Add(Me.lblPlayer)
        Me.IdNoPanel.Controls.Add(Me.btnForfeit)
        Me.IdNoPanel.Controls.Add(Me.Label2)
        Me.IdNoPanel.Controls.Add(Me.Label1)
        Me.IdNoPanel.Controls.Add(Me.lblTimer)
        Me.IdNoPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.IdNoPanel.Location = New System.Drawing.Point(933, 0)
        Me.IdNoPanel.Name = "IdNoPanel"
        Me.IdNoPanel.Size = New System.Drawing.Size(352, 747)
        Me.IdNoPanel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 94)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayer
        '
        Me.lblPlayer.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.ForeColor = System.Drawing.Color.White
        Me.lblPlayer.Location = New System.Drawing.Point(25, 449)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(315, 165)
        Me.lblPlayer.TabIndex = 6
        Me.lblPlayer.Text = "100"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnForfeit
        '
        Me.btnForfeit.BackColor = System.Drawing.Color.LightCoral
        Me.btnForfeit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForfeit.Location = New System.Drawing.Point(97, 644)
        Me.btnForfeit.Name = "btnForfeit"
        Me.btnForfeit.Size = New System.Drawing.Size(165, 58)
        Me.btnForfeit.TabIndex = 4
        Me.btnForfeit.Text = "Forfeit"
        Me.btnForfeit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(259, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "sec"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Time limit"
        '
        'lblFirstQuestion
        '
        Me.lblFirstQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFirstQuestion.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstQuestion.Location = New System.Drawing.Point(20, 20)
        Me.lblFirstQuestion.Name = "lblFirstQuestion"
        Me.lblFirstQuestion.Padding = New System.Windows.Forms.Padding(10)
        Me.lblFirstQuestion.Size = New System.Drawing.Size(879, 231)
        Me.lblFirstQuestion.TabIndex = 12
        Me.lblFirstQuestion.Text = "first question"
        '
        'radioFirstChoice4
        '
        Me.radioFirstChoice4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFirstChoice4.Location = New System.Drawing.Point(480, 440)
        Me.radioFirstChoice4.Name = "radioFirstChoice4"
        Me.radioFirstChoice4.Size = New System.Drawing.Size(439, 195)
        Me.radioFirstChoice4.TabIndex = 11
        Me.radioFirstChoice4.TabStop = True
        Me.radioFirstChoice4.Text = "firstChoice"
        Me.radioFirstChoice4.UseVisualStyleBackColor = True
        '
        'radioFirstChoice1
        '
        Me.radioFirstChoice1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFirstChoice1.Location = New System.Drawing.Point(46, 272)
        Me.radioFirstChoice1.Name = "radioFirstChoice1"
        Me.radioFirstChoice1.Size = New System.Drawing.Size(431, 175)
        Me.radioFirstChoice1.TabIndex = 8
        Me.radioFirstChoice1.TabStop = True
        Me.radioFirstChoice1.Text = "firstChoice"
        Me.radioFirstChoice1.UseVisualStyleBackColor = True
        '
        'radioFirstChoice3
        '
        Me.radioFirstChoice3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFirstChoice3.Location = New System.Drawing.Point(480, 272)
        Me.radioFirstChoice3.Name = "radioFirstChoice3"
        Me.radioFirstChoice3.Size = New System.Drawing.Size(439, 175)
        Me.radioFirstChoice3.TabIndex = 10
        Me.radioFirstChoice3.TabStop = True
        Me.radioFirstChoice3.Text = "firstChoice"
        Me.radioFirstChoice3.UseVisualStyleBackColor = True
        '
        'radioFirstChoice2
        '
        Me.radioFirstChoice2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFirstChoice2.Location = New System.Drawing.Point(46, 440)
        Me.radioFirstChoice2.Name = "radioFirstChoice2"
        Me.radioFirstChoice2.Size = New System.Drawing.Size(431, 195)
        Me.radioFirstChoice2.TabIndex = 9
        Me.radioFirstChoice2.TabStop = True
        Me.radioFirstChoice2.Text = "firstChoice"
        Me.radioFirstChoice2.UseVisualStyleBackColor = True
        '
        'panelQuestion1
        '
        Me.panelQuestion1.Controls.Add(Me.radioFirstChoice4)
        Me.panelQuestion1.Controls.Add(Me.lblFirstQuestion)
        Me.panelQuestion1.Controls.Add(Me.radioFirstChoice2)
        Me.panelQuestion1.Controls.Add(Me.radioFirstChoice1)
        Me.panelQuestion1.Controls.Add(Me.radioFirstChoice3)
        Me.panelQuestion1.Location = New System.Drawing.Point(3, 3)
        Me.panelQuestion1.Name = "panelQuestion1"
        Me.panelQuestion1.Padding = New System.Windows.Forms.Padding(20)
        Me.panelQuestion1.Size = New System.Drawing.Size(919, 715)
        Me.panelQuestion1.TabIndex = 13
        '
        'tabCtrlQuestion
        '
        Me.tabCtrlQuestion.Controls.Add(Me.tabQuestion1)
        Me.tabCtrlQuestion.Controls.Add(Me.tabQuestion2)
        Me.tabCtrlQuestion.Controls.Add(Me.tabQuestion3)
        Me.tabCtrlQuestion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCtrlQuestion.Location = New System.Drawing.Point(0, 0)
        Me.tabCtrlQuestion.Name = "tabCtrlQuestion"
        Me.tabCtrlQuestion.SelectedIndex = 0
        Me.tabCtrlQuestion.Size = New System.Drawing.Size(933, 747)
        Me.tabCtrlQuestion.TabIndex = 16
        '
        'tabQuestion1
        '
        Me.tabQuestion1.Controls.Add(Me.panelQuestion1)
        Me.tabQuestion1.Location = New System.Drawing.Point(4, 22)
        Me.tabQuestion1.Name = "tabQuestion1"
        Me.tabQuestion1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQuestion1.Size = New System.Drawing.Size(925, 721)
        Me.tabQuestion1.TabIndex = 0
        Me.tabQuestion1.Text = "1 - EASY "
        Me.tabQuestion1.UseVisualStyleBackColor = True
        '
        'tabQuestion2
        '
        Me.tabQuestion2.Controls.Add(Me.panelQuestion2)
        Me.tabQuestion2.Location = New System.Drawing.Point(4, 22)
        Me.tabQuestion2.Name = "tabQuestion2"
        Me.tabQuestion2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQuestion2.Size = New System.Drawing.Size(925, 721)
        Me.tabQuestion2.TabIndex = 1
        Me.tabQuestion2.Text = "2 - EASY "
        Me.tabQuestion2.UseVisualStyleBackColor = True
        '
        'panelQuestion2
        '
        Me.panelQuestion2.Controls.Add(Me.radioSecondChoice4)
        Me.panelQuestion2.Controls.Add(Me.lblSecondQuestion)
        Me.panelQuestion2.Controls.Add(Me.radioSecondChoice2)
        Me.panelQuestion2.Controls.Add(Me.radioSecondChoice3)
        Me.panelQuestion2.Controls.Add(Me.radioSecondChoice1)
        Me.panelQuestion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelQuestion2.Location = New System.Drawing.Point(3, 3)
        Me.panelQuestion2.Name = "panelQuestion2"
        Me.panelQuestion2.Padding = New System.Windows.Forms.Padding(20)
        Me.panelQuestion2.Size = New System.Drawing.Size(919, 715)
        Me.panelQuestion2.TabIndex = 14
        '
        'radioSecondChoice4
        '
        Me.radioSecondChoice4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSecondChoice4.Location = New System.Drawing.Point(477, 440)
        Me.radioSecondChoice4.Name = "radioSecondChoice4"
        Me.radioSecondChoice4.Size = New System.Drawing.Size(439, 195)
        Me.radioSecondChoice4.TabIndex = 16
        Me.radioSecondChoice4.TabStop = True
        Me.radioSecondChoice4.Text = "firstChoice"
        Me.radioSecondChoice4.UseVisualStyleBackColor = True
        '
        'lblSecondQuestion
        '
        Me.lblSecondQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSecondQuestion.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondQuestion.Location = New System.Drawing.Point(20, 20)
        Me.lblSecondQuestion.Name = "lblSecondQuestion"
        Me.lblSecondQuestion.Padding = New System.Windows.Forms.Padding(10)
        Me.lblSecondQuestion.Size = New System.Drawing.Size(879, 240)
        Me.lblSecondQuestion.TabIndex = 17
        Me.lblSecondQuestion.Text = "first question"
        '
        'radioSecondChoice2
        '
        Me.radioSecondChoice2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSecondChoice2.Location = New System.Drawing.Point(43, 440)
        Me.radioSecondChoice2.Name = "radioSecondChoice2"
        Me.radioSecondChoice2.Size = New System.Drawing.Size(431, 195)
        Me.radioSecondChoice2.TabIndex = 14
        Me.radioSecondChoice2.TabStop = True
        Me.radioSecondChoice2.Text = "firstChoice"
        Me.radioSecondChoice2.UseVisualStyleBackColor = True
        '
        'radioSecondChoice3
        '
        Me.radioSecondChoice3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSecondChoice3.Location = New System.Drawing.Point(477, 272)
        Me.radioSecondChoice3.Name = "radioSecondChoice3"
        Me.radioSecondChoice3.Size = New System.Drawing.Size(439, 175)
        Me.radioSecondChoice3.TabIndex = 15
        Me.radioSecondChoice3.TabStop = True
        Me.radioSecondChoice3.Text = "firstChoice"
        Me.radioSecondChoice3.UseVisualStyleBackColor = True
        '
        'radioSecondChoice1
        '
        Me.radioSecondChoice1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSecondChoice1.Location = New System.Drawing.Point(43, 272)
        Me.radioSecondChoice1.Name = "radioSecondChoice1"
        Me.radioSecondChoice1.Size = New System.Drawing.Size(431, 175)
        Me.radioSecondChoice1.TabIndex = 13
        Me.radioSecondChoice1.TabStop = True
        Me.radioSecondChoice1.Text = "firstChoice"
        Me.radioSecondChoice1.UseVisualStyleBackColor = True
        '
        'tabQuestion3
        '
        Me.tabQuestion3.Controls.Add(Me.panelQuestion3)
        Me.tabQuestion3.Location = New System.Drawing.Point(4, 22)
        Me.tabQuestion3.Name = "tabQuestion3"
        Me.tabQuestion3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabQuestion3.Size = New System.Drawing.Size(925, 721)
        Me.tabQuestion3.TabIndex = 2
        Me.tabQuestion3.Text = "3 - HARD"
        Me.tabQuestion3.UseVisualStyleBackColor = True
        '
        'panelQuestion3
        '
        Me.panelQuestion3.Controls.Add(Me.radioThirdChoice4)
        Me.panelQuestion3.Controls.Add(Me.lblThirdQuestion)
        Me.panelQuestion3.Controls.Add(Me.radioThirdChoice2)
        Me.panelQuestion3.Controls.Add(Me.radioThirdChoice3)
        Me.panelQuestion3.Controls.Add(Me.radioThirdChoice1)
        Me.panelQuestion3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelQuestion3.Location = New System.Drawing.Point(3, 3)
        Me.panelQuestion3.Name = "panelQuestion3"
        Me.panelQuestion3.Padding = New System.Windows.Forms.Padding(20)
        Me.panelQuestion3.Size = New System.Drawing.Size(919, 715)
        Me.panelQuestion3.TabIndex = 28
        '
        'radioThirdChoice4
        '
        Me.radioThirdChoice4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioThirdChoice4.Location = New System.Drawing.Point(477, 440)
        Me.radioThirdChoice4.Name = "radioThirdChoice4"
        Me.radioThirdChoice4.Size = New System.Drawing.Size(439, 195)
        Me.radioThirdChoice4.TabIndex = 16
        Me.radioThirdChoice4.TabStop = True
        Me.radioThirdChoice4.Text = "firstChoice"
        Me.radioThirdChoice4.UseVisualStyleBackColor = True
        '
        'lblThirdQuestion
        '
        Me.lblThirdQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblThirdQuestion.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThirdQuestion.Location = New System.Drawing.Point(20, 20)
        Me.lblThirdQuestion.Name = "lblThirdQuestion"
        Me.lblThirdQuestion.Padding = New System.Windows.Forms.Padding(10)
        Me.lblThirdQuestion.Size = New System.Drawing.Size(879, 247)
        Me.lblThirdQuestion.TabIndex = 17
        Me.lblThirdQuestion.Text = "first question"
        '
        'radioThirdChoice2
        '
        Me.radioThirdChoice2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioThirdChoice2.Location = New System.Drawing.Point(43, 440)
        Me.radioThirdChoice2.Name = "radioThirdChoice2"
        Me.radioThirdChoice2.Size = New System.Drawing.Size(431, 195)
        Me.radioThirdChoice2.TabIndex = 14
        Me.radioThirdChoice2.TabStop = True
        Me.radioThirdChoice2.Text = "firstChoice"
        Me.radioThirdChoice2.UseVisualStyleBackColor = True
        '
        'radioThirdChoice3
        '
        Me.radioThirdChoice3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioThirdChoice3.Location = New System.Drawing.Point(477, 272)
        Me.radioThirdChoice3.Name = "radioThirdChoice3"
        Me.radioThirdChoice3.Size = New System.Drawing.Size(439, 175)
        Me.radioThirdChoice3.TabIndex = 15
        Me.radioThirdChoice3.TabStop = True
        Me.radioThirdChoice3.Text = "firstChoice"
        Me.radioThirdChoice3.UseVisualStyleBackColor = True
        '
        'radioThirdChoice1
        '
        Me.radioThirdChoice1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioThirdChoice1.Location = New System.Drawing.Point(43, 272)
        Me.radioThirdChoice1.Name = "radioThirdChoice1"
        Me.radioThirdChoice1.Size = New System.Drawing.Size(431, 175)
        Me.radioThirdChoice1.TabIndex = 13
        Me.radioThirdChoice1.TabStop = True
        Me.radioThirdChoice1.Text = "firstChoice"
        Me.radioThirdChoice1.UseVisualStyleBackColor = True
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.BackgroundImage = Global.QUIZ.My.Resources.Resources.Colorful_Polygon_iPhone_6_Plus_Wallpaper1
        Me.ClientSize = New System.Drawing.Size(1285, 747)
        Me.ControlBox = False
        Me.Controls.Add(Me.tabCtrlQuestion)
        Me.Controls.Add(Me.IdNoPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QuestionForm"
        Me.Text = "Question"
        Me.IdNoPanel.ResumeLayout(False)
        Me.IdNoPanel.PerformLayout()
        Me.panelQuestion1.ResumeLayout(False)
        Me.tabCtrlQuestion.ResumeLayout(False)
        Me.tabQuestion1.ResumeLayout(False)
        Me.tabQuestion2.ResumeLayout(False)
        Me.panelQuestion2.ResumeLayout(False)
        Me.tabQuestion3.ResumeLayout(False)
        Me.panelQuestion3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrQuestion As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents IdNoPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFirstQuestion As System.Windows.Forms.Label
    Friend WithEvents radioFirstChoice4 As System.Windows.Forms.RadioButton
    Friend WithEvents radioFirstChoice1 As System.Windows.Forms.RadioButton
    Friend WithEvents radioFirstChoice3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioFirstChoice2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnForfeit As System.Windows.Forms.Button
    Friend WithEvents panelQuestion1 As System.Windows.Forms.Panel
    Friend WithEvents tabCtrlQuestion As System.Windows.Forms.TabControl
    Friend WithEvents tabQuestion1 As System.Windows.Forms.TabPage
    Friend WithEvents tabQuestion2 As System.Windows.Forms.TabPage
    Friend WithEvents tabQuestion3 As System.Windows.Forms.TabPage
    Friend WithEvents panelQuestion2 As System.Windows.Forms.Panel
    Friend WithEvents panelQuestion3 As System.Windows.Forms.Panel
    Friend WithEvents lblSecondQuestion As System.Windows.Forms.Label
    Friend WithEvents radioSecondChoice2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioThirdChoice4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblThirdQuestion As System.Windows.Forms.Label
    Friend WithEvents radioThirdChoice2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioThirdChoice3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioThirdChoice1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents radioSecondChoice4 As System.Windows.Forms.RadioButton
    Friend WithEvents radioSecondChoice3 As System.Windows.Forms.RadioButton
    Friend WithEvents radioSecondChoice1 As System.Windows.Forms.RadioButton
End Class
