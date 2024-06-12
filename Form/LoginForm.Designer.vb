<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.tb_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_signup = New Guna.UI2.WinForms.Guna2Button()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.LoginPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.ResizeForm = False
        Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'LoginPanel
        '
        Me.LoginPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoginPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginPanel.Controls.Add(Me.PictureBox1)
        Me.LoginPanel.Controls.Add(Me.Label3)
        Me.LoginPanel.Controls.Add(Me.Label2)
        Me.LoginPanel.Controls.Add(Me.Label1)
        Me.LoginPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.LoginPanel.Location = New System.Drawing.Point(-8, -19)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.ShadowColor = System.Drawing.Color.Black
        Me.LoginPanel.Size = New System.Drawing.Size(417, 484)
        Me.LoginPanel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox1.Image = Global.Youtube_Video_to_Music.My.Resources.Resources._20943684_Photoroom
        Me.PictureBox1.Location = New System.Drawing.Point(164, 166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 126)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jimwell Ibay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Iverson Sta. Rosa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Benedick Danga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Arceo Alejandro" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frederick Malla" &
    "ri" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jonard Sanga" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 46)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Convert youtube video into music" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as fast as possible." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 90)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convert you're " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Favorite Music!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(769, -1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(737, -1)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox3.TabIndex = 3
        '
        'tb_username
        '
        Me.tb_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_username.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tb_username.BorderRadius = 8
        Me.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_username.CustomizableEdges.BottomRight = False
        Me.tb_username.CustomizableEdges.TopLeft = False
        Me.tb_username.DefaultText = ""
        Me.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.tb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_username.Location = New System.Drawing.Point(441, 174)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PlaceholderText = "Username"
        Me.tb_username.SelectedText = ""
        Me.tb_username.Size = New System.Drawing.Size(329, 36)
        Me.tb_username.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(433, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 45)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Login"
        '
        'tb_password
        '
        Me.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_password.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tb_password.BorderRadius = 8
        Me.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_password.CustomizableEdges.BottomRight = False
        Me.tb_password.CustomizableEdges.TopLeft = False
        Me.tb_password.DefaultText = ""
        Me.tb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.tb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_password.Location = New System.Drawing.Point(441, 226)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.PlaceholderText = "Password"
        Me.tb_password.SelectedText = ""
        Me.tb_password.Size = New System.Drawing.Size(329, 36)
        Me.tb_password.TabIndex = 6
        '
        'btn_login
        '
        Me.btn_login.Animated = True
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BorderRadius = 8
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.IndicateFocus = True
        Me.btn_login.Location = New System.Drawing.Point(440, 278)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(162, 39)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Login"
        Me.btn_login.UseTransparentBackground = True
        '
        'btn_signup
        '
        Me.btn_signup.Animated = True
        Me.btn_signup.BackColor = System.Drawing.Color.Transparent
        Me.btn_signup.BorderRadius = 8
        Me.btn_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_signup.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_signup.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.IndicateFocus = True
        Me.btn_signup.Location = New System.Drawing.Point(608, 278)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(162, 39)
        Me.btn_signup.TabIndex = 8
        Me.btn_signup.Text = "Signup"
        Me.btn_signup.UseTransparentBackground = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.LoginPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tb_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_signup As Guna.UI2.WinForms.Guna2Button
End Class
