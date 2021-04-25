Imports System.CodeDom.Compiler

Public Class UC_Settings
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save2.Click
        My.Settings.Server = Txtbox_Server.Text
        My.Settings.Username = Txtbox_Username.Text
        My.Settings.Password = Txtbox_Password.Text
        My.Settings.Database = Txtbox_Database.Text
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub Btn_Save1_Click(sender As Object, e As EventArgs) Handles Btn_Save1.Click
        SaveBorrowSettings()
        My.Settings.EmailerAddress = Txtbox_Email.Text
        My.Settings.EmailerPassword = Txtbox_Epassword.Text

        If IsNumeric(Txtbox_Fine.Text) Then
            My.Settings.BorrowFine = Txtbox_Fine.Text
        Else
            Msg.SetContent("", "Your Fine is not a number, please input a number")
            Msg.ShowDialog()
        End If

        My.Settings.Save()
    End Sub

    Private Sub UC_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtbox_Fine.Text = My.Settings.BorrowFine

        Txtbox_Email.Text = My.Settings.EmailerAddress
        Txtbox_Epassword.Text = My.Settings.EmailerPassword

        Txtbox_Server.Text = My.Settings.Server
        Txtbox_Username.Text = My.Settings.Username
        Txtbox_Password.Text = My.Settings.Password
        Txtbox_Database.Text = My.Settings.Database

        Cbox_Duration.Items.Clear()
        For Each item In My.Settings.BorrowDuration
            Cbox_Duration.Items.Add(item)
        Next

        Cbox_Interval.SelectedIndex = 0
        Cbox_Duration.SelectedIndex = 0
    End Sub

    Private Sub Btn_Inc_Click(sender As Object, e As EventArgs) Handles Btn_Inc.Click
        Dim int As Double
        Double.TryParse(Txtbox_Fine.Text, int)
        Txtbox_Fine.Text = (int + 1)
    End Sub

    Private Sub Btn_Minus_Click(sender As Object, e As EventArgs) Handles Btn_Minus.Click
        Dim int As Double
        Double.TryParse(Txtbox_Fine.Text, int)
        If (int - 1) < 0 Then
            int += 1
        End If
        Txtbox_Fine.Text = (int - 1)
    End Sub

    Private Sub Btn_AddDuration_Click(sender As Object, e As EventArgs) Handles Btn_AddDuration.Click
        Dim duration = Txtbox_Duration.Text & " - " & Cbox_Interval.Text

        If IsNumeric(Txtbox_Duration.Text) Then
            Cbox_Duration.Items.Add(duration)
            Cbox_Duration.SelectedIndex = Cbox_Duration.Items.Count - 1
            SaveBorrowSettings()
        Else
            Msg.SetContent("", "Your input is not a number, please input a number")
            Msg.ShowDialog()
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Msg.SetContent("", "Are you sure you want to delete this item?")
        If Msg.ShowDialog = DialogResult.OK Then
            Cbox_Duration.Items.Remove(Cbox_Duration.SelectedItem)
            Cbox_Duration.SelectedIndex = 0
            SaveBorrowSettings()
        End If
    End Sub

    Private Sub SaveBorrowSettings()
        My.Settings.BorrowDuration.Clear()
        For Each item In Cbox_Duration.Items
            My.Settings.BorrowDuration.Add(item.ToString)
        Next
        My.Settings.Save()
    End Sub

    Private Sub Txtbox_Duration_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Duration.TextChanged
        If IsNumeric(Txtbox_Duration.Text) Then
            If Txtbox_Duration.Text > 1 Then
                Cbox_Interval.Items(0) = "Days"
                Cbox_Interval.Items(1) = "Months"
            Else
                Cbox_Interval.Items(0) = "Day"
                Cbox_Interval.Items(1) = "Month"
            End If
        End If
    End Sub

    Private Sub NumericChecker_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbox_Fine.KeyPress, Txtbox_Duration.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub Txtbox_Fine_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_Fine.TextChanged
        If Txtbox_Fine.Text = "" Then
            Txtbox_Fine.Text = 0
        End If
    End Sub
End Class
