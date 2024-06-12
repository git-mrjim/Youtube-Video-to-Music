<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SucessNotification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SucessNotification))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.lb_description = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-1, -10)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(10, 117)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(264, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(24, 19)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'lb_title
        '
        Me.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lb_title.AutoSize = True
        Me.lb_title.BackColor = System.Drawing.Color.Transparent
        Me.lb_title.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lb_title.Location = New System.Drawing.Point(24, 9)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(203, 30)
        Me.lb_title.TabIndex = 3
        Me.lb_title.Text = "Sucess Notification"
        '
        'lb_description
        '
        Me.lb_description.AllowDrop = True
        Me.lb_description.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lb_description.AutoEllipsis = True
        Me.lb_description.Font = New System.Drawing.Font("Gill Sans MT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lb_description.Location = New System.Drawing.Point(25, 37)
        Me.lb_description.Name = "lb_description"
        Me.lb_description.Size = New System.Drawing.Size(251, 21)
        Me.lb_description.TabIndex = 4
        Me.lb_description.Text = "Convert youtube video into music"
        '
        'Timer
        '
        Me.Timer.Interval = 10000
        '
        'SucessNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 78)
        Me.Controls.Add(Me.lb_description)
        Me.Controls.Add(Me.lb_title)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SucessNotification"
        Me.Text = "Sucess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lb_title As Label
    Friend WithEvents lb_description As Label
    Friend WithEvents Timer As Timer
End Class
