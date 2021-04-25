Imports System.IO

Public Class UC_SCBook
    Private ParentControl As UC_SCBookShelf

    Private Title As String
    Private BookID As String
    Private SCBID As String
    Private SCID As String
    Private Mode As String = "Change"

    Public Sub Set_Mode(mode, scID)
        Me.Mode = mode
        Me.SCID = scID
    End Sub

    Public Sub SetParentControl(control)
        Me.ParentControl = control
    End Sub

    Private Sub UC_SCBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "Add" Then

        ElseIf Mode = "Remove" Then
            Lbl_Plus.Hide()
        End If
    End Sub

    Public Sub Set_BookInfo(scbID)
        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT title, booksID, cover FROM tbl_showcase_books  
                     INNER JOIN tbl_book a ON a.bookID = tbl_showcase_books.booksID 
                     WHERE (scbID = @scbID)")

            cmd.Parameters.AddWithValue("@scbID", scbID)

            reader = cmd.ExecuteReader()

            While reader.Read()
                Me.Title = reader("title")
                Me.BookID = reader("booksID")
                Me.SCBID = scbID

                Dim bytes() As Byte
                bytes = (reader("cover"))
                Dim memStream As New MemoryStream(bytes)
                BookCover.BackgroundImage = Drawing.Image.FromStream(memStream)
            End While

            Lbl_Title.Text = Title

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub BookAdder_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Plus.MouseEnter
        If Mode = "Add" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 38, FontStyle.Regular)
            Lbl_Plus.Text = "+"
        ElseIf Mode = "Remove" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            Lbl_Plus.Text = "Remove"
        End If
    End Sub

    Private Sub BookAdder_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Plus.MouseLeave
        If Mode = "Add" Then
            Lbl_Plus.Font = New Font("Microsoft Sans Serif", 28, FontStyle.Regular)
            Lbl_Plus.ForeColor = Color.White
        ElseIf Mode = "Remove" Then
            Lbl_Plus.Hide()
        End If
    End Sub

    Private Sub Lbl_Title_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Title.MouseEnter
        Lbl_Title.ForeColor = Color.DeepSkyBlue

        If Mode = "Remove" Then
            Lbl_Title.Text = "Remove"
        End If
    End Sub

    Private Sub Lbl_Title_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Title.MouseLeave
        Lbl_Title.ForeColor = Color.White

        If Mode = "Remove" Then
            Lbl_Title.Text = Title
        End If
    End Sub

    Private Sub BookCover_MouseEnter(sender As Object, e As EventArgs) Handles BookCover.MouseEnter
        Lbl_Plus.Show()
    End Sub

    Private Sub SCBook_Click(sender As Object, e As EventArgs) Handles Lbl_Plus.Click, Lbl_Title.Click
        If Mode = "Add" Then
            AddBook()
        ElseIf Mode = "Remove" Then
            RemoveBook()
        End If
    End Sub

    Private Sub AddBook()
        Dim BookList As New Form_BookList
        BookList.SetMode("Showcase")

        If BookList.ShowDialog = DialogResult.OK Then
            Try
                openCon()
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_showcase_books (`scID`, `booksID`) 
                            VALUES (@scID, @booksID); SELECT @@identity")

                cmd.Parameters.AddWithValue("@scID", SCID)
                cmd.Parameters.AddWithValue("@booksID", BookList.selectedID)

                Dim tempID = cmd.ExecuteScalar()
                closeCon()

                Set_BookInfo(tempID)
                ParentControl.LoadData(SCID)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub RemoveBook()
        Msg.SetContent("", "Remove This Book From the Showcase?")
        If Msg.ShowDialog = DialogResult.OK Then
            openCon()

            cmd.Parameters.Clear()
            command("DELETE FROM tbl_showcase_books WHERE (scbID = @scbID)")
            cmd.Parameters.AddWithValue("@scbID", SCBID)
            execute()

            closeCon()

            ParentControl.Controls.Remove(Me)
            ParentControl.RemoveSCBook(Me)
            ParentControl.LoadData(SCID)
        End If
    End Sub
End Class
