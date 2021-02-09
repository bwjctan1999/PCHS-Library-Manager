Public Class Form_Login2
    Private Sub Form_Login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Windowstate to Fullscreen'
        Me.WindowState = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Do Until Panel2.Size.Height = 361
            Panel2.Size = New Size(Panel2.Width, Panel2.Height + 10)
            Refresh()
            System.Threading.Thread.Sleep(20)
        Loop

    End Sub
End Class