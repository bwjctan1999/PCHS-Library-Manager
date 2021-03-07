Imports System.Security.Policy
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.VisualBasic.ApplicationServices

Public Class UC_BookShelf
    Private books(4) As UC_Book

    Private Sub UserControl_BookShowcase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To books.Length - 1
            books(i) = New UC_Book
            Me.Controls.Add(books(i))
        Next

        Set_Book_Location()
        AddHandler Me.Layout, AddressOf Adjust_Location
    End Sub

    Private Sub Adjust_Location(sender As Object, e As EventArgs)
        Set_Book_Location()
    End Sub

    'Arranges The Item Location
    Private Sub Set_Book_Location()
        Dim divide = Me.Width / 5
        Dim start = divide

        For i As Integer = 0 To books.Length - 1
            Dim picwidth = start - (divide / 2) - (books(i).Width / 2)
            books(i).Location = New Point(picwidth, 3)
            start += divide
        Next
    End Sub

    Public Sub Set_Panel_Color(color)
        Me.BackColor = color
    End Sub
End Class
