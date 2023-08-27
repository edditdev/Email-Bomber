<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleWindow
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsoleWindow))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Terminal = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TopBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopBar
        '
        Me.TopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.TopBar.Controls.Add(Me.Label4)
        Me.TopBar.Controls.Add(Me.Label3)
        Me.TopBar.Controls.Add(Me.Label1)
        Me.TopBar.Controls.Add(Me.PictureBox1)
        Me.TopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBar.Location = New System.Drawing.Point(0, 0)
        Me.TopBar.Name = "TopBar"
        Me.TopBar.Size = New System.Drawing.Size(681, 30)
        Me.TopBar.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(154, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "by edditdev"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(657, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(29, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EMAIL BOMBER V2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EMAIL_BOMBER_V2.My.Resources.Resources.icons8_bomb_32px
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Terminal
        '
        Me.Terminal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Terminal.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Terminal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Terminal.Font = New System.Drawing.Font("Consolas", 11.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Terminal.ForeColor = System.Drawing.Color.Silver
        Me.Terminal.Location = New System.Drawing.Point(5, 5)
        Me.Terminal.Name = "Terminal"
        Me.Terminal.ReadOnly = True
        Me.Terminal.Size = New System.Drawing.Size(652, 367)
        Me.Terminal.TabIndex = 2
        Me.Terminal.Text = "// EMAIL BOMBER BY EDDIT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Terminal)
        Me.Panel1.Location = New System.Drawing.Point(10, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(661, 378)
        Me.Panel1.TabIndex = 3
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 2
        Me.GunaElipse1.TargetControl = Me.Panel1
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 2
        Me.GunaElipse2.TargetControl = Me.Terminal
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.TopBar
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ConsoleWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsoleWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsoleWindow"
        Me.TopMost = True
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Terminal As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Timer1 As Timer
End Class
