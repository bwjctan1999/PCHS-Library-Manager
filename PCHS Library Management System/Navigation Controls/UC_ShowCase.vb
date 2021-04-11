Public Class UC_ShowCase
    Dim scID1 As Integer = 1
    Dim scID2 As Integer = 2

    Public Sub LoadData()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT * FROM tbl_showcase")

            reader = cmd.ExecuteReader

            Dim ids(1) As String

            Dim counter As Integer = 0
            While reader.Read
                ids(counter) = reader("sc_title")
                counter += 1
            End While

            closeCon()

            Txtbox_SC1.Text = ids(0)
            Txtbox_SC2.Text = ids(1)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Btn_Save1.Hide()
        Btn_Save2.Hide()
        UC_SCBookShelf1.LoadData(scID1)
        UC_SCBookShelf2.LoadData(scID2)
    End Sub

    Private Sub UpdateTitles(txtbox, id)
        Try
            openCon()
            cmd.Parameters.Clear()
            command("UPDATE tbl_showcase SET `sc_title` = @title WHERE (`scID` = @scID)")
            cmd.Parameters.AddWithValue("@title", txtbox)
            cmd.Parameters.AddWithValue("@scID", id)

            execute()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txtbox_SC1_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_SC1.TextChanged
        Btn_Save1.Show()
    End Sub

    Private Sub Txtbox_SC2_TextChanged(sender As Object, e As EventArgs) Handles Txtbox_SC2.TextChanged
        Btn_Save2.Show()
    End Sub

    Private Sub Btn_Save1_Click(sender As Object, e As EventArgs) Handles Btn_Save1.Click
        UpdateTitles(Txtbox_SC1.Text, scID1)
        Btn_Save1.Hide()
    End Sub

    Private Sub Btn_Save2_Click(sender As Object, e As EventArgs) Handles Btn_Save2.Click
        UpdateTitles(Txtbox_SC2.Text, scID2)
        Btn_Save2.Hide()
    End Sub
End Class
