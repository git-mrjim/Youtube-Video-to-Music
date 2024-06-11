<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.navbar = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.pb_avatar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lb_username = New System.Windows.Forms.Label()
        Me.tb_url = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_logout = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_download = New Guna.UI2.WinForms.Guna2Button()
        Me.navbar.SuspendLayout()
        CType(Me.pb_avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(757, 12)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox3.TabIndex = 5
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(789, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gill Sans MT", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(238, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 104)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Convert Youtube " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Video Into Music!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'navbar
        '
        Me.navbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.navbar.BackColor = System.Drawing.Color.Transparent
        Me.navbar.Controls.Add(Me.pb_avatar)
        Me.navbar.Controls.Add(Me.lb_username)
        Me.navbar.Controls.Add(Me.Guna2ControlBox1)
        Me.navbar.Controls.Add(Me.Guna2ControlBox3)
        Me.navbar.FillColor = System.Drawing.Color.White
        Me.navbar.Location = New System.Drawing.Point(-24, -9)
        Me.navbar.Name = "navbar"
        Me.navbar.ShadowColor = System.Drawing.Color.Black
        Me.navbar.Size = New System.Drawing.Size(834, 49)
        Me.navbar.TabIndex = 7
        '
        'pb_avatar
        '
        Me.pb_avatar.Image = Global.Youtube_Video_to_Music.My.Resources.Resources.AvatarMale
        Me.pb_avatar.ImageRotate = 0!
        Me.pb_avatar.Location = New System.Drawing.Point(36, 12)
        Me.pb_avatar.Name = "pb_avatar"
        Me.pb_avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pb_avatar.Size = New System.Drawing.Size(28, 25)
        Me.pb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_avatar.TabIndex = 11
        Me.pb_avatar.TabStop = False
        '
        'lb_username
        '
        Me.lb_username.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lb_username.AutoSize = True
        Me.lb_username.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lb_username.Location = New System.Drawing.Point(70, 12)
        Me.lb_username.Name = "lb_username"
        Me.lb_username.Size = New System.Drawing.Size(73, 23)
        Me.lb_username.TabIndex = 11
        Me.lb_username.Text = "username"
        '
        'tb_url
        '
        Me.tb_url.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tb_url.BackColor = System.Drawing.Color.Transparent
        Me.tb_url.BorderRadius = 8
        Me.tb_url.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_url.CustomizableEdges.BottomRight = False
        Me.tb_url.CustomizableEdges.TopLeft = False
        Me.tb_url.DefaultText = ""
        Me.tb_url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_url.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_url.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.tb_url.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_url.Location = New System.Drawing.Point(154, 242)
        Me.tb_url.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_url.Name = "tb_url"
        Me.tb_url.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_url.PlaceholderText = "Url..."
        Me.tb_url.SelectedText = ""
        Me.tb_url.Size = New System.Drawing.Size(492, 43)
        Me.tb_url.TabIndex = 8
        '
        'btn_logout
        '
        Me.btn_logout.Animated = True
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BorderRadius = 8
        Me.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_logout.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_logout.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.IndicateFocus = True
        Me.btn_logout.Location = New System.Drawing.Point(404, 312)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(162, 39)
        Me.btn_logout.TabIndex = 10
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseTransparentBackground = True
        '
        'btn_download
        '
        Me.btn_download.Animated = True
        Me.btn_download.BackColor = System.Drawing.Color.Transparent
        Me.btn_download.BorderRadius = 8
        Me.btn_download.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_download.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_download.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_download.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_download.FillColor = System.Drawing.Color.White
        Me.btn_download.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_download.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btn_download.IndicateFocus = True
        Me.btn_download.Location = New System.Drawing.Point(236, 312)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(162, 39)
        Me.btn_download.TabIndex = 9
        Me.btn_download.Text = "Download"
        Me.btn_download.UseTransparentBackground = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Youtube_Video_to_Music.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.tb_url)
        Me.Controls.Add(Me.navbar)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.navbar.ResumeLayout(False)
        Me.navbar.PerformLayout()
        CType(Me.pb_avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents navbar As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_url As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_download As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pb_avatar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lb_username As Label
End Class
