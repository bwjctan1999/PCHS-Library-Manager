Public Class UC_SNHolder
    Private stickynotes As New List(Of UC_StickyNote)

    'Button that creates a Sticky Note
    Private Sub Btn_AddNote_Click(sender As Object, e As EventArgs) Handles Btn_AddNote.Click
        stickynotes.Add(New UC_StickyNote)
        Me.Controls.Add(stickynotes.Item(stickynotes.Count - 1))
        stickynotes.Item(stickynotes.Count - 1).Location = New Point(10, 46)
        stickynotes.Item(stickynotes.Count - 1).BringToFront()
    End Sub

    Private Sub Size_Changed(sender As Object, e As EventArgs) Handles Me.Layout
        For Each note In stickynotes
            note.Set_Container_Size(Me.Size)
        Next
    End Sub
End Class
