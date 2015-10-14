<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IdNoTextBox = New System.Windows.Forms.TextBox()
        Me.IDNoLabel = New System.Windows.Forms.Label()
        Me.IdNoPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.IdLoginResultLabel = New System.Windows.Forms.Label()
        Me.gridWinners = New System.Windows.Forms.DataGridView()
        Me.idnumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timein = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timespent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IdNoPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.gridWinners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdNoTextBox
        '
        Me.IdNoTextBox.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdNoTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdNoTextBox.Location = New System.Drawing.Point(235, 25)
        Me.IdNoTextBox.MaxLength = 6
        Me.IdNoTextBox.Name = "IdNoTextBox"
        Me.IdNoTextBox.Size = New System.Drawing.Size(295, 43)
        Me.IdNoTextBox.TabIndex = 0
        '
        'IDNoLabel
        '
        Me.IDNoLabel.AutoSize = True
        Me.IDNoLabel.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDNoLabel.ForeColor = System.Drawing.Color.White
        Me.IDNoLabel.Location = New System.Drawing.Point(17, 20)
        Me.IDNoLabel.Name = "IDNoLabel"
        Me.IDNoLabel.Size = New System.Drawing.Size(212, 47)
        Me.IDNoLabel.TabIndex = 1
        Me.IDNoLabel.Text = "ID Number:"
        Me.IDNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IdNoPanel
        '
        Me.IdNoPanel.BackColor = System.Drawing.Color.Transparent
        Me.IdNoPanel.Controls.Add(Me.Panel3)
        Me.IdNoPanel.Controls.Add(Me.Panel2)
        Me.IdNoPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.IdNoPanel.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdNoPanel.Location = New System.Drawing.Point(0, 0)
        Me.IdNoPanel.Name = "IdNoPanel"
        Me.IdNoPanel.Size = New System.Drawing.Size(1146, 874)
        Me.IdNoPanel.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1146, 208)
        Me.Panel3.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(185, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(641, 86)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TERVIA CHALLENGE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.gridWinners)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(3, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(30)
        Me.Panel2.Size = New System.Drawing.Size(1143, 664)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btnPlay)
        Me.Panel4.Controls.Add(Me.IdNoTextBox)
        Me.Panel4.Controls.Add(Me.IDNoLabel)
        Me.Panel4.Controls.Add(Me.IdLoginResultLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(30, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1083, 259)
        Me.Panel4.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(445, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TOP WINNERS"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlay.Location = New System.Drawing.Point(25, 178)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(322, 51)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = False
        Me.btnPlay.Visible = False
        '
        'IdLoginResultLabel
        '
        Me.IdLoginResultLabel.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdLoginResultLabel.ForeColor = System.Drawing.Color.White
        Me.IdLoginResultLabel.Location = New System.Drawing.Point(18, 82)
        Me.IdLoginResultLabel.Name = "IdLoginResultLabel"
        Me.IdLoginResultLabel.Size = New System.Drawing.Size(1041, 84)
        Me.IdLoginResultLabel.TabIndex = 2
        Me.IdLoginResultLabel.Text = "Please input a valid id number"
        '
        'gridWinners
        '
        Me.gridWinners.AllowUserToAddRows = False
        Me.gridWinners.AllowUserToDeleteRows = False
        Me.gridWinners.AllowUserToResizeColumns = False
        Me.gridWinners.AllowUserToResizeRows = False
        Me.gridWinners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridWinners.BackgroundColor = System.Drawing.Color.White
        Me.gridWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridWinners.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idnumber, Me.empname, Me.timein, Me.timespent})
        Me.gridWinners.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gridWinners.GridColor = System.Drawing.SystemColors.ControlLight
        Me.gridWinners.Location = New System.Drawing.Point(30, 300)
        Me.gridWinners.MultiSelect = False
        Me.gridWinners.Name = "gridWinners"
        Me.gridWinners.ReadOnly = True
        Me.gridWinners.RowHeadersVisible = False
        Me.gridWinners.RowHeadersWidth = 30
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.gridWinners.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridWinners.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridWinners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridWinners.Size = New System.Drawing.Size(1083, 334)
        Me.gridWinners.TabIndex = 6
        '
        'idnumber
        '
        Me.idnumber.HeaderText = "ID NUMBER"
        Me.idnumber.Name = "idnumber"
        Me.idnumber.ReadOnly = True
        '
        'empname
        '
        Me.empname.HeaderText = "EMPLOYEE NAME"
        Me.empname.Name = "empname"
        Me.empname.ReadOnly = True
        '
        'timein
        '
        Me.timein.HeaderText = "TIME IN"
        Me.timein.Name = "timein"
        Me.timein.ReadOnly = True
        '
        'timespent
        '
        Me.timespent.HeaderText = "TIME SPENT"
        Me.timespent.Name = "timespent"
        Me.timespent.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1147, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 874)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 624)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(10)
        Me.Label4.Size = New System.Drawing.Size(396, 250)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Powered by: SSG_CEBU"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(396, 409)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Answer all 3 questions correctly. (2 Easy and 1 Hard)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The time limit is 1 mi" & _
    "nute only." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(20)
        Me.Label2.Size = New System.Drawing.Size(396, 145)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INSTRUCTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.QUIZ.My.Resources.Resources.Colorful_Polygon_iPhone_6_Plus_Wallpaper1
        Me.ClientSize = New System.Drawing.Size(1543, 874)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.IdNoPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.TransparencyKey = System.Drawing.Color.LightPink
        Me.IdNoPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.gridWinners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IdNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDNoLabel As System.Windows.Forms.Label
    Friend WithEvents IdNoPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents IdLoginResultLabel As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents gridWinners As System.Windows.Forms.DataGridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents idnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents empname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timein As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents timespent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
