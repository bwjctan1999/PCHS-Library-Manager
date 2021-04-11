Imports System.IO

Public Class UC_Book
    Public Picture As Image
    Public Title As String
    Public Author As String
    Public Subject As String
    Public Shelf_No As String
    Public Year_Published As String
    Public Quantity As String
    Public ISBN_No As String
    Public BookID As String
    Public Mode As String
    'Modes: View - Remove

    Public Sub Set_BookInfo(title, author, subject, shelfno, yearpub, quantity, isbn, bookid)
        Me.Title = title
        Me.Author = author
        Me.Subject = subject
        Me.Shelf_No = shelfno
        Me.Year_Published = yearpub
        Me.Quantity = quantity
        Me.ISBN_No = isbn
        Me.BookID = bookid

        Me.Picture = Get_DB_BookCover(bookid)
        PicBox_Cover.Image = Picture
        Lbl_Title.Text = title
    End Sub

    Public Sub Set_Mode(mode)
        Me.Mode = mode
    End Sub

    Public Function Get_DB_BookCover(bookid)
        Dim img As Image = My.Resources.BOOK_IMAGE_NOT_AVAILABLE

        Try
            openCon()
            command("SELECT cover FROM tbl_book WHERE bookID = @bookID")
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@bookID", bookid)

            Dim bytes() As Byte
            bytes = cmd.ExecuteScalar()

            If bytes IsNot Nothing Then
                Dim memStream As New MemoryStream(bytes)
                img = Drawing.Image.FromStream(memStream)
            End If

            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return img
    End Function

    Private Sub Items_Click(sender As Object, e As EventArgs) Handles PicBox_Cover.Click, Lbl_Title.Click
        Form_Borrow.Set_Book(Me)
        Form_Borrow.Set_Mode(Mode)
        Form_Borrow.ShowDialog()
    End Sub


    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub Cover_MouseEnter(sender As Object, e As EventArgs) Handles PicBox_Cover.MouseEnter
        PicBox_Cover.Size = New Size(100, 100)
        PicBox_Cover.Location = New Point(24, 3)
    End Sub

    Private Sub Cover_MouseLeave(sender As Object, e As EventArgs) Handles PicBox_Cover.MouseLeave
        PicBox_Cover.Size = New Size(90, 90)
        PicBox_Cover.Location = New Point(30, 13)
    End Sub

    Private Sub Lbl_Title_MouseEnter(sender As Object, e As EventArgs) Handles Lbl_Title.MouseEnter
        Lbl_Title.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub Lbl_Title_MouseLeave(sender As Object, e As EventArgs) Handles Lbl_Title.MouseLeave
        Lbl_Title.ForeColor = Color.White
    End Sub
End Class
