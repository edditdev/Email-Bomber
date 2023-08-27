<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BomberMain
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BomberMain))
        Me.TopBar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AnimationPanel = New System.Windows.Forms.Panel()
        Me.GunaColorTransition1 = New Guna.UI.WinForms.GunaColorTransition(Me.components)
        Me.ColorAnimValue = New Guna.UI.WinForms.GunaColorTransition(Me.components)
        Me.StartAnimBar = New System.Windows.Forms.Timer(Me.components)
        Me.FormElipse = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.DragForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VictimText = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.sBox = New Guna.UI.WinForms.GunaComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NormalBox = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RandomBox = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel4 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.SetSpeed = New Guna.UI.WinForms.GunaComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel5 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel6 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.AddExistingTextBody = New Guna.UI.WinForms.GunaRadioButton()
        Me.AddNewTextBody = New Guna.UI.WinForms.GunaRadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddExistingText = New Guna.UI.WinForms.GunaRadioButton()
        Me.AddNewText = New Guna.UI.WinForms.GunaRadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.RandomBodyBtn = New Guna.UI.WinForms.GunaButton()
        Me.RandomSubjectBtn = New Guna.UI.WinForms.GunaButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GunaElipsePanel7 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.BodyText = New Guna.UI.WinForms.GunaTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SubjectText = New Guna.UI.WinForms.GunaTextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Dialog = New System.Windows.Forms.OpenFileDialog()
        Me.Btn1 = New Guna.UI.WinForms.GunaButton()
        Me.RandomServer = New System.Windows.Forms.Timer(Me.components)
        Me.SenderSpammer = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New Guna.UI.WinForms.GunaButton()
        Me.RandomSubjectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RandomBodyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GlitchStartBtn = New Guna.UI.WinForms.GunaButton()
        Me.RandomSubjectGlitch = New System.Windows.Forms.Timer(Me.components)
        Me.RandomBodyGlitch = New System.Windows.Forms.Timer(Me.components)
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Success = New System.Windows.Forms.Label()
        Me.Failed = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StopCheck = New System.Windows.Forms.Timer(Me.components)
        Me.ShowConsoleBtn = New Guna.UI.WinForms.GunaButton()
        Me.TopBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaElipsePanel4.SuspendLayout()
        Me.GunaElipsePanel5.SuspendLayout()
        Me.GunaElipsePanel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GunaElipsePanel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TopBar.Size = New System.Drawing.Size(963, 30)
        Me.TopBar.TabIndex = 0
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
        Me.Label3.Location = New System.Drawing.Point(942, 7)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "coded by eddit @ github.com/edditdev / discord: eddit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 755)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 20)
        Me.Panel1.TabIndex = 3
        '
        'AnimationPanel
        '
        Me.AnimationPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.AnimationPanel.Location = New System.Drawing.Point(0, 30)
        Me.AnimationPanel.Name = "AnimationPanel"
        Me.AnimationPanel.Size = New System.Drawing.Size(963, 1)
        Me.AnimationPanel.TabIndex = 4
        '
        'GunaColorTransition1
        '
        Me.GunaColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        Me.GunaColorTransition1.EndColor = System.Drawing.Color.Blue
        Me.GunaColorTransition1.StartColor = System.Drawing.Color.Red
        '
        'ColorAnimValue
        '
        Me.ColorAnimValue.AutoTransition = True
        Me.ColorAnimValue.ColorArray = New System.Drawing.Color() {System.Drawing.Color.SteelBlue, System.Drawing.Color.RoyalBlue, System.Drawing.Color.DeepSkyBlue}
        Me.ColorAnimValue.EndColor = System.Drawing.Color.DodgerBlue
        Me.ColorAnimValue.ProgessValue = 3
        Me.ColorAnimValue.StartColor = System.Drawing.Color.White
        '
        'StartAnimBar
        '
        Me.StartAnimBar.Enabled = True
        '
        'FormElipse
        '
        Me.FormElipse.TargetControl = Me
        '
        'DragForm
        '
        Me.DragForm.TargetControl = Me.TopBar
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel1.Controls.Add(Me.Label6)
        Me.GunaElipsePanel1.Controls.Add(Me.PictureBox2)
        Me.GunaElipsePanel1.Controls.Add(Me.VictimText)
        Me.GunaElipsePanel1.Controls.Add(Me.Label5)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(9, 50)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Radius = 8
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(344, 114)
        Me.GunaElipsePanel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(17, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Enter your victim email"
        '
        'VictimText
        '
        Me.VictimText.BackColor = System.Drawing.Color.Transparent
        Me.VictimText.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.VictimText.BorderColor = System.Drawing.Color.Gray
        Me.VictimText.BorderSize = 1
        Me.VictimText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VictimText.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.VictimText.FocusedBorderColor = System.Drawing.Color.DarkGray
        Me.VictimText.FocusedForeColor = System.Drawing.Color.White
        Me.VictimText.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.VictimText.ForeColor = System.Drawing.Color.Gray
        Me.VictimText.Location = New System.Drawing.Point(50, 61)
        Me.VictimText.Name = "VictimText"
        Me.VictimText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VictimText.Radius = 2
        Me.VictimText.Size = New System.Drawing.Size(269, 26)
        Me.VictimText.TabIndex = 7
        Me.VictimText.Text = "victim@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(16, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "VICTIM"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel2.Controls.Add(Me.PictureBox3)
        Me.GunaElipsePanel2.Controls.Add(Me.sBox)
        Me.GunaElipsePanel2.Controls.Add(Me.Label7)
        Me.GunaElipsePanel2.Controls.Add(Me.Label8)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(359, 50)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Radius = 8
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(282, 114)
        Me.GunaElipsePanel2.TabIndex = 6
        '
        'sBox
        '
        Me.sBox.BackColor = System.Drawing.Color.Transparent
        Me.sBox.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.sBox.BorderColor = System.Drawing.Color.Gray
        Me.sBox.BorderSize = 1
        Me.sBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.sBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sBox.FocusedColor = System.Drawing.Color.Empty
        Me.sBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.sBox.ForeColor = System.Drawing.Color.Gray
        Me.sBox.FormattingEnabled = True
        Me.sBox.Items.AddRange(New Object() {"Server #1 - Outlook", "Server #2 - Outlook", "Server #3 - Outlook", "Server #4 - Outlook"})
        Me.sBox.Location = New System.Drawing.Point(54, 61)
        Me.sBox.Name = "sBox"
        Me.sBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.sBox.OnHoverItemForeColor = System.Drawing.Color.White
        Me.sBox.Radius = 2
        Me.sBox.Size = New System.Drawing.Size(214, 24)
        Me.sBox.StartIndex = 0
        Me.sBox.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(21, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Choose smtp server for sended email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(20, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "SMTP Server"
        '
        'NormalBox
        '
        Me.NormalBox.BaseColor = System.Drawing.SystemColors.Control
        Me.NormalBox.Checked = True
        Me.NormalBox.CheckedOffColor = System.Drawing.Color.Gray
        Me.NormalBox.CheckedOnColor = System.Drawing.Color.Gray
        Me.NormalBox.FillColor = System.Drawing.Color.White
        Me.NormalBox.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.NormalBox.ForeColor = System.Drawing.Color.Gray
        Me.NormalBox.Location = New System.Drawing.Point(23, 75)
        Me.NormalBox.Name = "NormalBox"
        Me.NormalBox.Size = New System.Drawing.Size(66, 20)
        Me.NormalBox.TabIndex = 14
        Me.NormalBox.Text = "Normal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(20, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Sending method"
        '
        'RandomBox
        '
        Me.RandomBox.BaseColor = System.Drawing.SystemColors.Control
        Me.RandomBox.CheckedOffColor = System.Drawing.Color.Gray
        Me.RandomBox.CheckedOnColor = System.Drawing.Color.Gray
        Me.RandomBox.FillColor = System.Drawing.Color.White
        Me.RandomBox.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.RandomBox.ForeColor = System.Drawing.Color.Gray
        Me.RandomBox.Location = New System.Drawing.Point(23, 116)
        Me.RandomBox.Name = "RandomBox"
        Me.RandomBox.Size = New System.Drawing.Size(66, 20)
        Me.RandomBox.TabIndex = 16
        Me.RandomBox.Text = "Random"
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel3.Controls.Add(Me.Label12)
        Me.GunaElipsePanel3.Controls.Add(Me.Label10)
        Me.GunaElipsePanel3.Controls.Add(Me.RandomBox)
        Me.GunaElipsePanel3.Controls.Add(Me.Label11)
        Me.GunaElipsePanel3.Controls.Add(Me.NormalBox)
        Me.GunaElipsePanel3.Controls.Add(Me.Label9)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(647, 50)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Radius = 8
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(304, 156)
        Me.GunaElipsePanel3.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(20, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 14)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Random - use random server"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(20, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Normal - use one server"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(19, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Sending method"
        '
        'GunaElipsePanel4
        '
        Me.GunaElipsePanel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel4.Controls.Add(Me.PictureBox4)
        Me.GunaElipsePanel4.Controls.Add(Me.SetSpeed)
        Me.GunaElipsePanel4.Controls.Add(Me.Label13)
        Me.GunaElipsePanel4.Controls.Add(Me.Label14)
        Me.GunaElipsePanel4.Location = New System.Drawing.Point(359, 170)
        Me.GunaElipsePanel4.Name = "GunaElipsePanel4"
        Me.GunaElipsePanel4.Radius = 8
        Me.GunaElipsePanel4.Size = New System.Drawing.Size(282, 114)
        Me.GunaElipsePanel4.TabIndex = 18
        '
        'SetSpeed
        '
        Me.SetSpeed.BackColor = System.Drawing.Color.Transparent
        Me.SetSpeed.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.SetSpeed.BorderColor = System.Drawing.Color.Gray
        Me.SetSpeed.BorderSize = 1
        Me.SetSpeed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SetSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SetSpeed.FocusedColor = System.Drawing.Color.Empty
        Me.SetSpeed.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.SetSpeed.ForeColor = System.Drawing.Color.Gray
        Me.SetSpeed.FormattingEnabled = True
        Me.SetSpeed.Items.AddRange(New Object() {"Low", "Normal", "High", "Medium", "Extreme"})
        Me.SetSpeed.Location = New System.Drawing.Point(54, 61)
        Me.SetSpeed.Name = "SetSpeed"
        Me.SetSpeed.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.SetSpeed.OnHoverItemForeColor = System.Drawing.Color.White
        Me.SetSpeed.Radius = 2
        Me.SetSpeed.Size = New System.Drawing.Size(214, 24)
        Me.SetSpeed.StartIndex = 1
        Me.SetSpeed.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(21, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Time of sending emails"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(20, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 22)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Bombing Speed"
        '
        'GunaElipsePanel5
        '
        Me.GunaElipsePanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel5.Controls.Add(Me.Label26)
        Me.GunaElipsePanel5.Controls.Add(Me.Label24)
        Me.GunaElipsePanel5.Controls.Add(Me.Label23)
        Me.GunaElipsePanel5.Controls.Add(Me.PictureBox5)
        Me.GunaElipsePanel5.Controls.Add(Me.GunaButton1)
        Me.GunaElipsePanel5.Controls.Add(Me.Label15)
        Me.GunaElipsePanel5.Controls.Add(Me.Label16)
        Me.GunaElipsePanel5.Location = New System.Drawing.Point(9, 170)
        Me.GunaElipsePanel5.Name = "GunaElipsePanel5"
        Me.GunaElipsePanel5.Radius = 8
        Me.GunaElipsePanel5.Size = New System.Drawing.Size(344, 114)
        Me.GunaElipsePanel5.TabIndex = 19
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.Silver
        Me.Label26.Location = New System.Drawing.Point(282, 14)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 22)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "SOON"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label24.ForeColor = System.Drawing.Color.Silver
        Me.Label24.Location = New System.Drawing.Point(60, 90)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Unselected"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label23.ForeColor = System.Drawing.Color.Gray
        Me.Label23.Location = New System.Drawing.Point(20, 90)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 13)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Status"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Gray
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Silver
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(50, 58)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 2
        Me.GunaButton1.Size = New System.Drawing.Size(98, 24)
        Me.GunaButton1.TabIndex = 20
        Me.GunaButton1.Text = "Attach"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(21, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Attach file to mail message"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.Silver
        Me.Label16.Location = New System.Drawing.Point(20, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 22)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Attachment"
        '
        'GunaElipsePanel6
        '
        Me.GunaElipsePanel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel6.Controls.Add(Me.Label30)
        Me.GunaElipsePanel6.Controls.Add(Me.Label31)
        Me.GunaElipsePanel6.Controls.Add(Me.GunaButton2)
        Me.GunaElipsePanel6.Controls.Add(Me.GlitchStartBtn)
        Me.GunaElipsePanel6.Controls.Add(Me.Label25)
        Me.GunaElipsePanel6.Controls.Add(Me.Panel5)
        Me.GunaElipsePanel6.Controls.Add(Me.Panel4)
        Me.GunaElipsePanel6.Controls.Add(Me.Panel3)
        Me.GunaElipsePanel6.Controls.Add(Me.Panel2)
        Me.GunaElipsePanel6.Controls.Add(Me.Label28)
        Me.GunaElipsePanel6.Controls.Add(Me.Label27)
        Me.GunaElipsePanel6.Controls.Add(Me.RandomBodyBtn)
        Me.GunaElipsePanel6.Controls.Add(Me.RandomSubjectBtn)
        Me.GunaElipsePanel6.Controls.Add(Me.Label17)
        Me.GunaElipsePanel6.Controls.Add(Me.Label18)
        Me.GunaElipsePanel6.Location = New System.Drawing.Point(647, 212)
        Me.GunaElipsePanel6.Name = "GunaElipsePanel6"
        Me.GunaElipsePanel6.Radius = 8
        Me.GunaElipsePanel6.Size = New System.Drawing.Size(304, 402)
        Me.GunaElipsePanel6.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkGray
        Me.Panel5.Location = New System.Drawing.Point(16, 169)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 77)
        Me.Panel5.TabIndex = 33
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.AddExistingTextBody)
        Me.Panel4.Controls.Add(Me.AddNewTextBody)
        Me.Panel4.Location = New System.Drawing.Point(23, 189)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 52)
        Me.Panel4.TabIndex = 32
        '
        'AddExistingTextBody
        '
        Me.AddExistingTextBody.BaseColor = System.Drawing.SystemColors.Control
        Me.AddExistingTextBody.CheckedOffColor = System.Drawing.Color.Gray
        Me.AddExistingTextBody.CheckedOnColor = System.Drawing.Color.Gray
        Me.AddExistingTextBody.FillColor = System.Drawing.Color.White
        Me.AddExistingTextBody.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.AddExistingTextBody.ForeColor = System.Drawing.Color.Gray
        Me.AddExistingTextBody.Location = New System.Drawing.Point(3, 25)
        Me.AddExistingTextBody.Name = "AddExistingTextBody"
        Me.AddExistingTextBody.Size = New System.Drawing.Size(120, 20)
        Me.AddExistingTextBody.TabIndex = 30
        Me.AddExistingTextBody.Text = "Add to existing"
        '
        'AddNewTextBody
        '
        Me.AddNewTextBody.BaseColor = System.Drawing.SystemColors.Control
        Me.AddNewTextBody.Checked = True
        Me.AddNewTextBody.CheckedOffColor = System.Drawing.Color.Gray
        Me.AddNewTextBody.CheckedOnColor = System.Drawing.Color.Gray
        Me.AddNewTextBody.FillColor = System.Drawing.Color.White
        Me.AddNewTextBody.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.AddNewTextBody.ForeColor = System.Drawing.Color.Gray
        Me.AddNewTextBody.Location = New System.Drawing.Point(3, 3)
        Me.AddNewTextBody.Name = "AddNewTextBody"
        Me.AddNewTextBody.Size = New System.Drawing.Size(96, 20)
        Me.AddNewTextBody.TabIndex = 29
        Me.AddNewTextBody.Text = "Alywans new"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Location = New System.Drawing.Point(17, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 77)
        Me.Panel3.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddExistingText)
        Me.Panel2.Controls.Add(Me.AddNewText)
        Me.Panel2.Location = New System.Drawing.Point(24, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 52)
        Me.Panel2.TabIndex = 30
        '
        'AddExistingText
        '
        Me.AddExistingText.BaseColor = System.Drawing.SystemColors.Control
        Me.AddExistingText.CheckedOffColor = System.Drawing.Color.Gray
        Me.AddExistingText.CheckedOnColor = System.Drawing.Color.Gray
        Me.AddExistingText.FillColor = System.Drawing.Color.White
        Me.AddExistingText.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.AddExistingText.ForeColor = System.Drawing.Color.Gray
        Me.AddExistingText.Location = New System.Drawing.Point(3, 25)
        Me.AddExistingText.Name = "AddExistingText"
        Me.AddExistingText.Size = New System.Drawing.Size(120, 20)
        Me.AddExistingText.TabIndex = 30
        Me.AddExistingText.Text = "Add to existing"
        '
        'AddNewText
        '
        Me.AddNewText.BaseColor = System.Drawing.SystemColors.Control
        Me.AddNewText.Checked = True
        Me.AddNewText.CheckedOffColor = System.Drawing.Color.Gray
        Me.AddNewText.CheckedOnColor = System.Drawing.Color.Gray
        Me.AddNewText.FillColor = System.Drawing.Color.White
        Me.AddNewText.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.AddNewText.ForeColor = System.Drawing.Color.Gray
        Me.AddNewText.Location = New System.Drawing.Point(3, 3)
        Me.AddNewText.Name = "AddNewText"
        Me.AddNewText.Size = New System.Drawing.Size(96, 20)
        Me.AddNewText.TabIndex = 29
        Me.AddNewText.Text = "Alyways new"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label28.ForeColor = System.Drawing.Color.Gray
        Me.Label28.Location = New System.Drawing.Point(30, 169)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 28
        Me.Label28.Text = "Body"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label27.ForeColor = System.Drawing.Color.Gray
        Me.Label27.Location = New System.Drawing.Point(23, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(49, 13)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Subject"
        '
        'RandomBodyBtn
        '
        Me.RandomBodyBtn.AnimationHoverSpeed = 0.07!
        Me.RandomBodyBtn.AnimationSpeed = 0.03!
        Me.RandomBodyBtn.BackColor = System.Drawing.Color.Transparent
        Me.RandomBodyBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RandomBodyBtn.BorderColor = System.Drawing.Color.Gray
        Me.RandomBodyBtn.BorderSize = 1
        Me.RandomBodyBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RandomBodyBtn.FocusedColor = System.Drawing.Color.Empty
        Me.RandomBodyBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RandomBodyBtn.ForeColor = System.Drawing.Color.Silver
        Me.RandomBodyBtn.Image = Nothing
        Me.RandomBodyBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.RandomBodyBtn.Location = New System.Drawing.Point(76, 166)
        Me.RandomBodyBtn.Name = "RandomBodyBtn"
        Me.RandomBodyBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.RandomBodyBtn.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.RandomBodyBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.RandomBodyBtn.OnHoverImage = Nothing
        Me.RandomBodyBtn.OnPressedColor = System.Drawing.Color.Black
        Me.RandomBodyBtn.Radius = 2
        Me.RandomBodyBtn.Size = New System.Drawing.Size(176, 19)
        Me.RandomBodyBtn.TabIndex = 26
        Me.RandomBodyBtn.Text = "Start"
        Me.RandomBodyBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomSubjectBtn
        '
        Me.RandomSubjectBtn.AnimationHoverSpeed = 0.07!
        Me.RandomSubjectBtn.AnimationSpeed = 0.03!
        Me.RandomSubjectBtn.BackColor = System.Drawing.Color.Transparent
        Me.RandomSubjectBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.RandomSubjectBtn.BorderColor = System.Drawing.Color.Gray
        Me.RandomSubjectBtn.BorderSize = 1
        Me.RandomSubjectBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.RandomSubjectBtn.FocusedColor = System.Drawing.Color.Empty
        Me.RandomSubjectBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RandomSubjectBtn.ForeColor = System.Drawing.Color.Silver
        Me.RandomSubjectBtn.Image = Nothing
        Me.RandomSubjectBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.RandomSubjectBtn.Location = New System.Drawing.Point(76, 72)
        Me.RandomSubjectBtn.Name = "RandomSubjectBtn"
        Me.RandomSubjectBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.RandomSubjectBtn.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.RandomSubjectBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.RandomSubjectBtn.OnHoverImage = Nothing
        Me.RandomSubjectBtn.OnPressedColor = System.Drawing.Color.Black
        Me.RandomSubjectBtn.Radius = 2
        Me.RandomSubjectBtn.Size = New System.Drawing.Size(176, 19)
        Me.RandomSubjectBtn.TabIndex = 24
        Me.RandomSubjectBtn.Text = "Start"
        Me.RandomSubjectBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Silver
        Me.Label17.Location = New System.Drawing.Point(14, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(248, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Random strings in Subject/Body"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.Silver
        Me.Label18.Location = New System.Drawing.Point(20, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 22)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Extra settings"
        '
        'GunaElipsePanel7
        '
        Me.GunaElipsePanel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.GunaElipsePanel7.Controls.Add(Me.BodyText)
        Me.GunaElipsePanel7.Controls.Add(Me.Label22)
        Me.GunaElipsePanel7.Controls.Add(Me.Label21)
        Me.GunaElipsePanel7.Controls.Add(Me.SubjectText)
        Me.GunaElipsePanel7.Controls.Add(Me.Label19)
        Me.GunaElipsePanel7.Controls.Add(Me.Label20)
        Me.GunaElipsePanel7.Location = New System.Drawing.Point(9, 290)
        Me.GunaElipsePanel7.Name = "GunaElipsePanel7"
        Me.GunaElipsePanel7.Radius = 8
        Me.GunaElipsePanel7.Size = New System.Drawing.Size(632, 423)
        Me.GunaElipsePanel7.TabIndex = 21
        '
        'BodyText
        '
        Me.BodyText.BackColor = System.Drawing.Color.Transparent
        Me.BodyText.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BodyText.BorderColor = System.Drawing.Color.Gray
        Me.BodyText.BorderSize = 1
        Me.BodyText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BodyText.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BodyText.FocusedBorderColor = System.Drawing.Color.DarkGray
        Me.BodyText.FocusedForeColor = System.Drawing.Color.White
        Me.BodyText.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.BodyText.ForeColor = System.Drawing.Color.Gray
        Me.BodyText.Location = New System.Drawing.Point(24, 129)
        Me.BodyText.MultiLine = True
        Me.BodyText.Name = "BodyText"
        Me.BodyText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BodyText.Radius = 2
        Me.BodyText.Size = New System.Drawing.Size(583, 275)
        Me.BodyText.TabIndex = 15
        Me.BodyText.Text = "Bombed by github.com/edditdev"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Silver
        Me.Label22.Location = New System.Drawing.Point(20, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 19)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Body"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Silver
        Me.Label21.Location = New System.Drawing.Point(20, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 19)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Subject"
        '
        'SubjectText
        '
        Me.SubjectText.BackColor = System.Drawing.Color.Transparent
        Me.SubjectText.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.SubjectText.BorderColor = System.Drawing.Color.Gray
        Me.SubjectText.BorderSize = 1
        Me.SubjectText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectText.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.SubjectText.FocusedBorderColor = System.Drawing.Color.DarkGray
        Me.SubjectText.FocusedForeColor = System.Drawing.Color.White
        Me.SubjectText.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.SubjectText.ForeColor = System.Drawing.Color.Gray
        Me.SubjectText.Location = New System.Drawing.Point(24, 78)
        Me.SubjectText.Name = "SubjectText"
        Me.SubjectText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubjectText.Radius = 2
        Me.SubjectText.Size = New System.Drawing.Size(583, 26)
        Me.SubjectText.TabIndex = 12
        Me.SubjectText.Text = "Subject Text"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.Location = New System.Drawing.Point(21, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Email message details"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Silver
        Me.Label20.Location = New System.Drawing.Point(20, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 22)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Message details"
        '
        'Dialog
        '
        Me.Dialog.FileName = "OpenFileDialog1"
        '
        'Btn1
        '
        Me.Btn1.AnimationHoverSpeed = 0.07!
        Me.Btn1.AnimationSpeed = 0.03!
        Me.Btn1.BackColor = System.Drawing.Color.Transparent
        Me.Btn1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Btn1.BorderColor = System.Drawing.Color.Gray
        Me.Btn1.BorderSize = 1
        Me.Btn1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn1.FocusedColor = System.Drawing.Color.Empty
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn1.ForeColor = System.Drawing.Color.Silver
        Me.Btn1.Image = Nothing
        Me.Btn1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn1.Location = New System.Drawing.Point(830, 719)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Btn1.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.Btn1.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn1.OnHoverImage = Nothing
        Me.Btn1.OnPressedColor = System.Drawing.Color.Black
        Me.Btn1.Radius = 2
        Me.Btn1.Size = New System.Drawing.Size(121, 24)
        Me.Btn1.TabIndex = 22
        Me.Btn1.Text = "Send one [test]"
        Me.Btn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomServer
        '
        '
        'SenderSpammer
        '
        '
        'Start
        '
        Me.Start.AnimationHoverSpeed = 0.07!
        Me.Start.AnimationSpeed = 0.03!
        Me.Start.BackColor = System.Drawing.Color.Transparent
        Me.Start.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Start.BorderColor = System.Drawing.Color.Gray
        Me.Start.BorderSize = 1
        Me.Start.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Start.FocusedColor = System.Drawing.Color.Empty
        Me.Start.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Start.ForeColor = System.Drawing.Color.Silver
        Me.Start.Image = Nothing
        Me.Start.ImageSize = New System.Drawing.Size(20, 20)
        Me.Start.Location = New System.Drawing.Point(195, 15)
        Me.Start.Name = "Start"
        Me.Start.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Start.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.Start.OnHoverForeColor = System.Drawing.Color.White
        Me.Start.OnHoverImage = Nothing
        Me.Start.OnPressedColor = System.Drawing.Color.Black
        Me.Start.Radius = 4
        Me.Start.Size = New System.Drawing.Size(97, 33)
        Me.Start.TabIndex = 23
        Me.Start.Text = "Start bombing"
        Me.Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomSubjectTimer
        '
        '
        'RandomBodyTimer
        '
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Consolas", 11.0!)
        Me.Label25.ForeColor = System.Drawing.Color.Silver
        Me.Label25.Location = New System.Drawing.Point(13, 258)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(136, 18)
        Me.Label25.TabIndex = 34
        Me.Label25.Text = "Glitched message"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label30.ForeColor = System.Drawing.Color.Gray
        Me.Label30.Location = New System.Drawing.Point(21, 311)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 38
        Me.Label30.Text = "Body"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label31.ForeColor = System.Drawing.Color.Gray
        Me.Label31.Location = New System.Drawing.Point(14, 286)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(49, 13)
        Me.Label31.TabIndex = 37
        Me.Label31.Text = "Subject"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Gray
        Me.GunaButton2.BorderSize = 1
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.Silver
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(67, 308)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 2
        Me.GunaButton2.Size = New System.Drawing.Size(82, 19)
        Me.GunaButton2.TabIndex = 36
        Me.GunaButton2.Text = "Start"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GlitchStartBtn
        '
        Me.GlitchStartBtn.AnimationHoverSpeed = 0.07!
        Me.GlitchStartBtn.AnimationSpeed = 0.03!
        Me.GlitchStartBtn.BackColor = System.Drawing.Color.Transparent
        Me.GlitchStartBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.GlitchStartBtn.BorderColor = System.Drawing.Color.Gray
        Me.GlitchStartBtn.BorderSize = 1
        Me.GlitchStartBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GlitchStartBtn.FocusedColor = System.Drawing.Color.Empty
        Me.GlitchStartBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GlitchStartBtn.ForeColor = System.Drawing.Color.Silver
        Me.GlitchStartBtn.Image = Nothing
        Me.GlitchStartBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.GlitchStartBtn.Location = New System.Drawing.Point(67, 283)
        Me.GlitchStartBtn.Name = "GlitchStartBtn"
        Me.GlitchStartBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.GlitchStartBtn.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.GlitchStartBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.GlitchStartBtn.OnHoverImage = Nothing
        Me.GlitchStartBtn.OnPressedColor = System.Drawing.Color.Black
        Me.GlitchStartBtn.Radius = 2
        Me.GlitchStartBtn.Size = New System.Drawing.Size(82, 19)
        Me.GlitchStartBtn.TabIndex = 35
        Me.GlitchStartBtn.Text = "Start"
        Me.GlitchStartBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomSubjectGlitch
        '
        '
        'RandomBodyGlitch
        '
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.Silver
        Me.Label29.Location = New System.Drawing.Point(19, 14)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(150, 22)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "Spaming status"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label32.ForeColor = System.Drawing.Color.Silver
        Me.Label32.Location = New System.Drawing.Point(83, 54)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 13)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "/"
        '
        'Success
        '
        Me.Success.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Success.ForeColor = System.Drawing.Color.Silver
        Me.Success.Location = New System.Drawing.Point(33, 55)
        Me.Success.Name = "Success"
        Me.Success.Size = New System.Drawing.Size(52, 22)
        Me.Success.TabIndex = 41
        Me.Success.Text = "0"
        Me.Success.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Failed
        '
        Me.Failed.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.Failed.ForeColor = System.Drawing.Color.Red
        Me.Failed.Location = New System.Drawing.Point(95, 54)
        Me.Failed.Name = "Failed"
        Me.Failed.Size = New System.Drawing.Size(54, 22)
        Me.Failed.TabIndex = 42
        Me.Failed.Text = "0"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Panel6.Controls.Add(Me.ShowConsoleBtn)
        Me.Panel6.Controls.Add(Me.Label33)
        Me.Panel6.Controls.Add(Me.Failed)
        Me.Panel6.Controls.Add(Me.Success)
        Me.Panel6.Controls.Add(Me.Start)
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Controls.Add(Me.Label32)
        Me.Panel6.Location = New System.Drawing.Point(647, 620)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(304, 93)
        Me.Panel6.TabIndex = 24
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Label33.ForeColor = System.Drawing.Color.Gray
        Me.Label33.Location = New System.Drawing.Point(49, 41)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(91, 13)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Success/Failed"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.EMAIL_BOMBER_V2.My.Resources.Resources.icons8_pin_64px
        Me.PictureBox5.Location = New System.Drawing.Point(20, 58)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.EMAIL_BOMBER_V2.My.Resources.Resources.icons8_speedometer_64px
        Me.PictureBox4.Location = New System.Drawing.Point(24, 61)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.EMAIL_BOMBER_V2.My.Resources.Resources.icons8_server_linux_64px
        Me.PictureBox3.Location = New System.Drawing.Point(24, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.EMAIL_BOMBER_V2.My.Resources.Resources.icons8_mailbox_64px
        Me.PictureBox2.Location = New System.Drawing.Point(20, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
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
        'StopCheck
        '
        Me.StopCheck.Enabled = True
        Me.StopCheck.Interval = 1000
        '
        'ShowConsoleBtn
        '
        Me.ShowConsoleBtn.AnimationHoverSpeed = 0.07!
        Me.ShowConsoleBtn.AnimationSpeed = 0.03!
        Me.ShowConsoleBtn.BackColor = System.Drawing.Color.Transparent
        Me.ShowConsoleBtn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ShowConsoleBtn.BorderColor = System.Drawing.Color.Gray
        Me.ShowConsoleBtn.BorderSize = 1
        Me.ShowConsoleBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ShowConsoleBtn.FocusedColor = System.Drawing.Color.Empty
        Me.ShowConsoleBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ShowConsoleBtn.ForeColor = System.Drawing.Color.Silver
        Me.ShowConsoleBtn.Image = Nothing
        Me.ShowConsoleBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.ShowConsoleBtn.Location = New System.Drawing.Point(195, 54)
        Me.ShowConsoleBtn.Name = "ShowConsoleBtn"
        Me.ShowConsoleBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ShowConsoleBtn.OnHoverBorderColor = System.Drawing.Color.Gray
        Me.ShowConsoleBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.ShowConsoleBtn.OnHoverImage = Nothing
        Me.ShowConsoleBtn.OnPressedColor = System.Drawing.Color.Black
        Me.ShowConsoleBtn.Radius = 4
        Me.ShowConsoleBtn.Size = New System.Drawing.Size(97, 24)
        Me.ShowConsoleBtn.TabIndex = 25
        Me.ShowConsoleBtn.Text = "Show console"
        Me.ShowConsoleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BomberMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(963, 775)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.GunaElipsePanel7)
        Me.Controls.Add(Me.GunaElipsePanel6)
        Me.Controls.Add(Me.GunaElipsePanel5)
        Me.Controls.Add(Me.GunaElipsePanel4)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.AnimationPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BomberMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Bomber"
        Me.TopBar.ResumeLayout(False)
        Me.TopBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaElipsePanel4.ResumeLayout(False)
        Me.GunaElipsePanel4.PerformLayout()
        Me.GunaElipsePanel5.ResumeLayout(False)
        Me.GunaElipsePanel5.PerformLayout()
        Me.GunaElipsePanel6.ResumeLayout(False)
        Me.GunaElipsePanel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GunaElipsePanel7.ResumeLayout(False)
        Me.GunaElipsePanel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopBar As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AnimationPanel As Panel
    Friend WithEvents GunaColorTransition1 As Guna.UI.WinForms.GunaColorTransition
    Friend WithEvents ColorAnimValue As Guna.UI.WinForms.GunaColorTransition
    Friend WithEvents StartAnimBar As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FormElipse As Guna.UI.WinForms.GunaElipse
    Friend WithEvents DragForm As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label4 As Label
    Friend WithEvents VictimText As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents sBox As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RandomBox As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents NormalBox As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GunaElipsePanel4 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents SetSpeed As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GunaElipsePanel5 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipsePanel6 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label18 As Label
    Friend WithEvents GunaElipsePanel7 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents SubjectText As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BodyText As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Dialog As OpenFileDialog
    Friend WithEvents Btn1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents RandomServer As Timer
    Friend WithEvents SenderSpammer As Timer
    Friend WithEvents Start As Guna.UI.WinForms.GunaButton
    Friend WithEvents RandomBodyBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents RandomSubjectBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents RandomSubjectTimer As Timer
    Friend WithEvents RandomBodyTimer As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddExistingText As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents AddNewText As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents AddExistingTextBody As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents AddNewTextBody As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GlitchStartBtn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label25 As Label
    Friend WithEvents RandomSubjectGlitch As Timer
    Friend WithEvents RandomBodyGlitch As Timer
    Friend WithEvents Failed As Label
    Friend WithEvents Success As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents StopCheck As Timer
    Friend WithEvents ShowConsoleBtn As Guna.UI.WinForms.GunaButton
End Class
