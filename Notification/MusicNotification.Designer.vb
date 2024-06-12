<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicNotification
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
        Dim Timer As System.Windows.Forms.Timer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MusicNotification))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pb_thumbnail = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.MusicPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb_thumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MusicPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer
        '
        Timer.Enabled = True
        Timer.Interval = 20000
        AddHandler Timer.Tick, AddressOf Me.Timer_Tick
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'pb_thumbnail
        '
        Me.pb_thumbnail.Image = Global.Youtube_Video_to_Music.My.Resources.Resources._20944608_Photoroom
        Me.pb_thumbnail.ImageRotate = 0!
        Me.pb_thumbnail.Location = New System.Drawing.Point(0, 0)
        Me.pb_thumbnail.Name = "pb_thumbnail"
        Me.pb_thumbnail.Size = New System.Drawing.Size(250, 205)
        Me.pb_thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_thumbnail.TabIndex = 0
        Me.pb_thumbnail.TabStop = False
        '
        'MusicPanel
        '
        Me.MusicPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.MusicPanel.Controls.Add(Me.lb_title)
        Me.MusicPanel.Location = New System.Drawing.Point(0, 200)
        Me.MusicPanel.Name = "MusicPanel"
        Me.MusicPanel.Size = New System.Drawing.Size(250, 52)
        Me.MusicPanel.TabIndex = 1
        '
        'lb_title
        '
        Me.lb_title.AllowDrop = True
        Me.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lb_title.AutoEllipsis = True
        Me.lb_title.BackColor = System.Drawing.Color.Transparent
        Me.lb_title.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.White
        Me.lb_title.Location = New System.Drawing.Point(12, 12)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(226, 23)
        Me.lb_title.TabIndex = 4
        Me.lb_title.Text = "Title of the music downloaded"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(217, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 25)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'MusicNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(250, 250)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.MusicPanel)
        Me.Controls.Add(Me.pb_thumbnail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MusicNotification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music"
        CType(Me.pb_thumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MusicPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pb_thumbnail As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents MusicPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lb_title As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
