<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Greetings
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.picGreetings = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.picGreetings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblGreetings)
        Me.Panel1.Controls.Add(Me.btnOkay)
        Me.Panel1.Controls.Add(Me.picGreetings)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 670)
        Me.Panel1.TabIndex = 0
        '
        'lblGreetings
        '
        Me.lblGreetings.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGreetings.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreetings.ForeColor = System.Drawing.Color.White
        Me.lblGreetings.Location = New System.Drawing.Point(0, 360)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(728, 237)
        Me.lblGreetings.TabIndex = 2
        Me.lblGreetings.Text = "Label1"
        Me.lblGreetings.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOkay
        '
        Me.btnOkay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnOkay.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(0, 599)
        Me.btnOkay.Margin = New System.Windows.Forms.Padding(20)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOkay.Size = New System.Drawing.Size(728, 71)
        Me.btnOkay.TabIndex = 1
        Me.btnOkay.Text = "OKAY"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'picGreetings
        '
        Me.picGreetings.Dock = System.Windows.Forms.DockStyle.Top
        Me.picGreetings.Location = New System.Drawing.Point(0, 0)
        Me.picGreetings.Name = "picGreetings"
        Me.picGreetings.Size = New System.Drawing.Size(728, 360)
        Me.picGreetings.TabIndex = 0
        Me.picGreetings.TabStop = False
        '
        'Greetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QUIZ.My.Resources.Resources.Colorful_Polygon_iPhone_6_Plus_Wallpaper1
        Me.ClientSize = New System.Drawing.Size(728, 670)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Greetings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Greetings"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.picGreetings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents picGreetings As System.Windows.Forms.PictureBox
    Friend WithEvents lblGreetings As System.Windows.Forms.Label
End Class
