Public Class ConsoleWindow
    Private Sub ConsoleWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Terminal_TextChanged(sender As Object, e As EventArgs) Handles Terminal.TextChanged
        Terminal.ScrollToCaret()
    End Sub

    Private Sub Terminal_MouseEnter(sender As Object, e As EventArgs) Handles Terminal.MouseEnter
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Terminal.ScrollToCaret()
    End Sub

    Private Sub Terminal_MouseLeave(sender As Object, e As EventArgs) Handles Terminal.MouseLeave
        Timer1.Start()
    End Sub
End Class