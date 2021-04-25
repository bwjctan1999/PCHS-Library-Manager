Public Class UC_SCBookShelf
    Private scbooks As New List(Of UC_SCBook)

    Public Sub LoadData(scid)
        For Each book In scbooks
            Me.Controls.Remove(book)
        Next

        scbooks.Clear()

        Try
            openCon()
            cmd.Parameters.Clear()
            command("SELECT scbID FROM tbl_showcase_books WHERE (scID = @scID)")
            cmd.Parameters.AddWithValue("@scID", scid)
            reader = cmd.ExecuteReader()

            Dim scbids As New List(Of Integer)

            Dim counter = 0
            While reader.Read()
                scbids.Add(reader("scbID"))
            End While

            closeCon()

            For i As Integer = 0 To scbids.Count - 1
                Dim book As New UC_SCBook
                book.Set_Mode("Remove", scid)
                book.Set_BookInfo(scbids(i))
                book.SetParentControl(Me)

                scbooks.Add(book)
                Me.Controls.Add(scbooks(i))
            Next

            If scbooks.Count < 5 Then
                Dim bookadder As New UC_SCBook
                bookadder.Set_Mode("Add", scid)
                bookadder.SetParentControl(Me)
                scbooks.Add(bookadder)

                Me.Controls.Add(scbooks(scbooks.Count - 1))
            End If

            Set_Book_Location()
            AddHandler Me.Layout, AddressOf Adjust_Location

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Adjust_Location(sender As Object, e As EventArgs)
        Set_Book_Location()
    End Sub

    'Arranges The Item Location
    Private Sub Set_Book_Location()
        Dim divide = Me.Width / 5
        Dim start = divide

        For i As Integer = 0 To scbooks.Count - 1
            Dim picwidth = start - (divide / 2) - (scbooks(i).Width / 2)
            scbooks(i).Location = New Point(picwidth, 3)
            start += divide
        Next
    End Sub

    Public Sub Set_Panel_Color(color)
        Me.BackColor = color
    End Sub

    Public Sub RemoveSCBook(book)
        scbooks.Remove(book)
    End Sub
End Class
