<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignupForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignupForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btn_submit = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.rb_male = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.cb_iAgree = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.tb_reenteredPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(374, -2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox3.TabIndex = 5
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(406, -2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_submit.Animated = True
        Me.btn_submit.BackColor = System.Drawing.Color.Transparent
        Me.btn_submit.BorderRadius = 8
        Me.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_submit.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.btn_submit.Font = New System.Drawing.Font("Gill Sans MT", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_submit.ForeColor = System.Drawing.Color.White
        Me.btn_submit.IndicateFocus = True
        Me.btn_submit.Location = New System.Drawing.Point(264, 338)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(162, 39)
        Me.btn_submit.TabIndex = 12
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseTransparentBackground = True
        '
        'tb_password
        '
        Me.tb_password.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.tb_password.Location = New System.Drawing.Point(59, 142)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.PlaceholderText = "Password"
        Me.tb_password.SelectedText = ""
        Me.tb_password.Size = New System.Drawing.Size(329, 36)
        Me.tb_password.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(51, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 45)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Signup"
        '
        'tb_username
        '
        Me.tb_username.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.tb_username.Location = New System.Drawing.Point(59, 90)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PlaceholderText = "Username"
        Me.tb_username.SelectedText = ""
        Me.tb_username.Size = New System.Drawing.Size(329, 36)
        Me.tb_username.TabIndex = 9
        '
        'rb_male
        '
        Me.rb_male.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rb_male.AutoSize = True
        Me.rb_male.Checked = True
        Me.rb_male.CheckedState.BorderThickness = 0
        Me.rb_male.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.rb_male.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rb_male.CheckedState.InnerOffset = -2
        Me.rb_male.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.rb_male.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rb_male.Location = New System.Drawing.Point(65, 247)
        Me.rb_male.Name = "rb_male"
        Me.rb_male.Size = New System.Drawing.Size(51, 22)
        Me.rb_male.TabIndex = 14
        Me.rb_male.TabStop = True
        Me.rb_male.Text = "Male"
        Me.rb_male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.rb_male.UncheckedState.BorderThickness = 1
        Me.rb_male.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rb_male.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -2
        Me.Guna2RadioButton1.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.Guna2RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(119, 247)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(63, 22)
        Me.Guna2RadioButton1.TabIndex = 15
        Me.Guna2RadioButton1.Text = "Female"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 1
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'cb_iAgree
        '
        Me.cb_iAgree.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cb_iAgree.AutoSize = True
        Me.cb_iAgree.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.cb_iAgree.CheckedState.BorderRadius = 0
        Me.cb_iAgree.CheckedState.BorderThickness = 0
        Me.cb_iAgree.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cb_iAgree.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.cb_iAgree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_iAgree.Location = New System.Drawing.Point(65, 285)
        Me.cb_iAgree.Name = "cb_iAgree"
        Me.cb_iAgree.Size = New System.Drawing.Size(219, 22)
        Me.cb_iAgree.TabIndex = 16
        Me.cb_iAgree.Text = "I agree to the Terms and Condition"
        Me.cb_iAgree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.cb_iAgree.UncheckedState.BorderRadius = 0
        Me.cb_iAgree.UncheckedState.BorderThickness = 1
        Me.cb_iAgree.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'tb_reenteredPassword
        '
        Me.tb_reenteredPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tb_reenteredPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tb_reenteredPassword.BorderRadius = 8
        Me.tb_reenteredPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_reenteredPassword.CustomizableEdges.BottomRight = False
        Me.tb_reenteredPassword.CustomizableEdges.TopLeft = False
        Me.tb_reenteredPassword.DefaultText = ""
        Me.tb_reenteredPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_reenteredPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_reenteredPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_reenteredPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_reenteredPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_reenteredPassword.Font = New System.Drawing.Font("Gill Sans MT", 9.75!)
        Me.tb_reenteredPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_reenteredPassword.Location = New System.Drawing.Point(60, 195)
        Me.tb_reenteredPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_reenteredPassword.Name = "tb_reenteredPassword"
        Me.tb_reenteredPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_reenteredPassword.PlaceholderText = "Re enter password"
        Me.tb_reenteredPassword.SelectedText = ""
        Me.tb_reenteredPassword.Size = New System.Drawing.Size(329, 36)
        Me.tb_reenteredPassword.TabIndex = 17
        '
        'SignupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 389)
        Me.Controls.Add(Me.tb_reenteredPassword)
        Me.Controls.Add(Me.cb_iAgree)
        Me.Controls.Add(Me.Guna2RadioButton1)
        Me.Controls.Add(Me.rb_male)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SignupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignupForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rb_male As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btn_submit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_iAgree As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents tb_reenteredPassword As Guna.UI2.WinForms.Guna2TextBox
End Class
