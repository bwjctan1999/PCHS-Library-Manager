Public Class Form_Borrow

    '================================
    'TABLE OF CONTENTS
    '   1. Setters
    '       1.1 Set Mode
    '       1.1 Set To Visible
    '       1.3 Set Information from Book
    '   
    '   2. Button Controls
    '       2.1 Okay Button
    '       2.2 Close Button
    '       2.3 Borrow Book Button
    '       2.4 Remove Book Button
    '================================

    'Modes: View - Borrow - Remove
    Private Mode As String = "Borrow"
    Private Book As UC_Book
    Private Picture As Image



    '================
    '  1. Setters 
    '================

    '=== 1.1 Set Mode ===
    Public Sub Set_Mode(mode)
        Me.Mode = mode

        Select Case mode
            Case "View"
                Set_To_Visible(Btn_Close, Btn_Okay)
                Btn_Close.Hide()

            Case "Borrow"
                Set_To_Visible(Btn_Close, Btn_Borrow)

            Case "Remove"
                Set_To_Visible(Btn_Remove, Btn_Okay)
                Btn_Close.Hide()
        End Select
    End Sub

    '=== 1.2 Set To Visible ===
    Public Sub Set_To_Visible(showthis As Button, showthis2 As Button)
        Dim buttons = New Button() {Btn_Okay, Btn_Close, Btn_Borrow, Btn_Remove}

        For Each button In buttons
            button.Hide()
        Next

        showthis.Show()
        showthis2.Show()
    End Sub

    '=== 1.3 Set Information from Book ===
    Public Sub Set_Book(book As UC_Book)
        Me.Book = book
        Me.Picture = book.Picture
        Lbl_Title.Text = book.Title
        Lbl_Author.Text = book.Author
        Lbl_ISBNNo.Text = book.ISBN_No
        Lbl_YearPub.Text = book.Year_Published
        Lbl_Quantity.Text = book.Quantity
        Lbl_Subject.Text = book.Subject
        Lbl_ShelfNo.Text = book.Shelf_No

        Picbox_Cover.Image = Picture
    End Sub



    '=======================
    '  2. Button Controls 
    '=======================

    '=== 2.1 Okay Button ===
    Private Sub Btn_Okay_Click(sender As Object, e As EventArgs) Handles Btn_Okay.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    '=== 2.2 Close Button ===
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    '=== 2.3 Borrow Book Button ===
    Private Sub Btn_AddBook_Click(sender As Object, e As EventArgs) Handles Btn_Borrow.Click
        Book.Set_Mode("Remove")
        Form_CheckOut.Add_Book(Book)
        Me.Close()
    End Sub

    '=== 2.3 Remove Book Button ===
    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        Form_CheckOut.Remove_Book(Book)
        Me.Close()
    End Sub

    Private Sub Form_Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Author.Location = New Point(338, Lbl_Title.Height + Lbl_Title.Location.Y + 1)
        Lbl_By.Location = New Point(301, Lbl_Title.Height + Lbl_Title.Location.Y + 1)
    End Sub
End Class