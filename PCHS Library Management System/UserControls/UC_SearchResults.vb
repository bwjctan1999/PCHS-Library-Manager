Public Class UC_SearchResults
    Dim booklist As New List(Of UC_Book)

    Private Sub UC_SearchResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        booklist.Add(New UC_Book)
        For i As Integer = 0 To 32
            booklist.Add(New UC_Book)
            Panel1.Controls.Add(booklist.Item(i))
        Next

        Set_Book_Location()
        AddHandler Me.Layout, AddressOf Adjust_Location
    End Sub

    Private Sub Adjust_Location()
        Set_Book_Location()
    End Sub

    Private Sub Set_Book_Location()
        Dim divide = Me.Width / 5
        Dim start = divide

        Dim counter = 1
        Dim rows = booklist.Count / 5
        Dim columns = 0
        Dim locY = 3
        '156

        For i As Integer = 0 To booklist.Count - 1
            Dim picwidth = start - (divide / 2) - (booklist.Item(i).Width / 2)
            booklist.Item(i).Location = New Point(picwidth, locY)

            start += divide

            If counter Mod 5 = 0 Then
                locY += 156
                start = divide
            End If

            counter += 1
        Next
    End Sub
End Class
