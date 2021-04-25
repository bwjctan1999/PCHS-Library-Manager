Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.ApplicationServices

Public Class UC_BookShelf
    Private books As New List(Of UC_Book)
    Private Mode As String

    Private Sub UC_BookShelf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Layout, AddressOf Adjust_Location
        Set_Book_Location()
    End Sub

    Public Sub Add_Book(book)
        Me.books.Add(book)
        Me.Controls.Add(books(books.Count - 1))
        Set_Book_Location()
    End Sub

    Public Sub Remove_Book(book)
        books.Remove(book)
        Controls.Remove(book)
        Set_Book_Location()
    End Sub

    Public Sub Clear_Books()
        For Each book In books
            Controls.Remove(book)
        Next

        books.Clear()
    End Sub

    Private Sub Adjust_Location(sender As Object, e As EventArgs)
        Set_Book_Location()
    End Sub

    'Arranges The Item Location
    Private Sub Set_Book_Location()
        Dim divide = Me.Width / books.Count
        Dim start = divide

        For i As Integer = 0 To books.Count - 1
            Dim picwidth = start - (divide / 2) - (books(i).Width / 2)
            books(i).Location = New Point(picwidth, 3)
            start += divide
        Next
    End Sub

    Public Sub Set_Panel_Color(color)
        Me.BackColor = color
    End Sub

    Public Function GetBooks()
        Return books
    End Function
End Class
