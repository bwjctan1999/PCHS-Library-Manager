Public Class Form_DatabaseSettings
    Private Sub Form_Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtbox_Server.Text = My.Settings.Server
        Txtbox_Username.Text = My.Settings.Username
        Txtbox_Password.Text = My.Settings.Password
        Txtbox_Database.Text = My.Settings.Database

    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        My.Settings.Server = Txtbox_Server.Text
        My.Settings.Username = Txtbox_Username.Text
        My.Settings.Password = Txtbox_Password.Text
        My.Settings.Database = Txtbox_Database.Text
        My.Settings.Save()
        Application.Restart()
    End Sub
End Class