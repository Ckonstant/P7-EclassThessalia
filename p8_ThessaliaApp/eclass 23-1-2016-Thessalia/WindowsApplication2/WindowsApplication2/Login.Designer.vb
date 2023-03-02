<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ElegantThemeCheckBox1 = New WindowsApplication2.ElegantThemeCheckBox()
        Me.ElegantThemeTextBox2 = New WindowsApplication2.ElegantThemeTextBox()
        Me.ElegantThemeTextBox1 = New WindowsApplication2.ElegantThemeTextBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(21, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Είσοδος"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(251, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(234, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "-"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 312)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(167, 16)
        Me.LinkLabel1.TabIndex = 65
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ξεχάσατε τον Kωδικό σας?"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(21, 39)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(229, 59)
        Me.PictureBox6.TabIndex = 59
        Me.PictureBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 31)
        Me.Panel1.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "E-course v1.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(231, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(18, 292)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(62, 16)
        Me.LinkLabel2.TabIndex = 69
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Εγγραφή"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(133, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ElegantThemeCheckBox1
        '
        Me.ElegantThemeCheckBox1.BaseColour = System.Drawing.Color.Transparent
        Me.ElegantThemeCheckBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.ElegantThemeCheckBox1.Checked = False
        Me.ElegantThemeCheckBox1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ElegantThemeCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElegantThemeCheckBox1.DefaultSqaureColour = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ElegantThemeCheckBox1.FontColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ElegantThemeCheckBox1.HoverSqaureColour = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ElegantThemeCheckBox1.Location = New System.Drawing.Point(21, 188)
        Me.ElegantThemeCheckBox1.Name = "ElegantThemeCheckBox1"
        Me.ElegantThemeCheckBox1.Size = New System.Drawing.Size(164, 22)
        Me.ElegantThemeCheckBox1.TabIndex = 66
        Me.ElegantThemeCheckBox1.Text = "Αποθήκευση στοιχείων"
        '
        'ElegantThemeTextBox2
        '
        Me.ElegantThemeTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ElegantThemeTextBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ElegantThemeTextBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElegantThemeTextBox2.LeftPolygonColour = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ElegantThemeTextBox2.LineColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ElegantThemeTextBox2.Location = New System.Drawing.Point(21, 152)
        Me.ElegantThemeTextBox2.MaxLength = 32767
        Me.ElegantThemeTextBox2.Multiline = False
        Me.ElegantThemeTextBox2.Name = "ElegantThemeTextBox2"
        Me.ElegantThemeTextBox2.Picture = WindowsApplication2.ElegantThemeTextBox.Pictures.Password
        Me.ElegantThemeTextBox2.ReadOnly = False
        Me.ElegantThemeTextBox2.Size = New System.Drawing.Size(229, 27)
        Me.ElegantThemeTextBox2.TabIndex = 64
        Me.ElegantThemeTextBox2.Text = "montragon12"
        Me.ElegantThemeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ElegantThemeTextBox2.UseSystemPasswordChar = True
        '
        'ElegantThemeTextBox1
        '
        Me.ElegantThemeTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.ElegantThemeTextBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ElegantThemeTextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ElegantThemeTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ElegantThemeTextBox1.LeftPolygonColour = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ElegantThemeTextBox1.LineColour = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ElegantThemeTextBox1.Location = New System.Drawing.Point(21, 110)
        Me.ElegantThemeTextBox1.MaxLength = 32767
        Me.ElegantThemeTextBox1.Multiline = False
        Me.ElegantThemeTextBox1.Name = "ElegantThemeTextBox1"
        Me.ElegantThemeTextBox1.Picture = WindowsApplication2.ElegantThemeTextBox.Pictures.Username
        Me.ElegantThemeTextBox1.ReadOnly = False
        Me.ElegantThemeTextBox1.Size = New System.Drawing.Size(229, 27)
        Me.ElegantThemeTextBox1.TabIndex = 63
        Me.ElegantThemeTextBox1.Text = "username"
        Me.ElegantThemeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ElegantThemeTextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ElegantThemeTextBox1.UseSystemPasswordChar = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(276, 353)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ElegantThemeCheckBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ElegantThemeTextBox2)
        Me.Controls.Add(Me.ElegantThemeTextBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents ElegantThemeTextBox1 As WindowsApplication2.ElegantThemeTextBox
    Friend WithEvents ElegantThemeTextBox2 As WindowsApplication2.ElegantThemeTextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ElegantThemeCheckBox1 As WindowsApplication2.ElegantThemeCheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
