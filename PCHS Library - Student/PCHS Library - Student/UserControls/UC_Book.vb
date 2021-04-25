Imports System.IO

'================================
'TABLE OF CONTENTS
'   1. Book Information
'   2. Set Book Information
'   3. Get Book Cover from DB
'   4. Book Click
'   5. GUI Subs
'================================


Public Class UC_Book
    '=========================
    '   1. BOOK INFORMATION
    '=========================
    Public Picture As Image
    Public Title As String
    Public Author As String
    Public Subject As String
    Public Shelf_No As String
    Public Publisher As String
    Public Year_Published As String
    Public Quantity As String
    Public ISBN_No As String
    Public BookID As String
    Public Mode As String
    'Modes: View - Remove


    '==============================
    '   2. SET BOOK INFORMATION
    '==============================
    Public Sub Set_BookInfo(title, author, subject, shelfno, publisher, yearpub, quantity, isbn, bookid)
        Me.Title = title
        Me.Author = author
        Me.Subject = subject
        Me.Shelf_No = shelfno
        Me.Publisher = publisher
        Me.Year_Published = yearpub
        Me.Quantity = quantity
        Me.ISBN_No = isbn
        Me.BookID = bookid

        Me.Picture = Get_DB_BookCover(bookid)
        PicBox_Cover.Image = Picture
        Lbl_Title.Text = title
    End Sub


    '================================
    '   3. GET BOOK COVER FROM DB
    '================================
    Public Function Get_DB_BookCover(bookid)
        Dim img As Image = My.Resources.Book_Default

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


    '=========================
    '   4. BOOK CLICK
    '=========================
    Private Sub Items_Click(sender As Object, e As EventArgs) Handles PicBox_Cover.Click, Lbl_Title.Click
        Form_View.Set_Book(Me)
        Form_View.ShowDialog()
    End Sub


    '===================
    '   5. GUI SUBS
    '===================
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
