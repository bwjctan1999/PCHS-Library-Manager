Public Class UC_SNHolder
    Public stickynotes As New List(Of UC_StickyNote)

    'Button that creates a Sticky Note
    Private Sub Btn_AddNote_Click(sender As Object, e As EventArgs) Handles Btn_AddNote.Click
        stickynotes.Add(New UC_StickyNote)
        Me.Controls.Add(stickynotes.Item(stickynotes.Count - 1))
        stickynotes.Item(stickynotes.Count - 1).Location = New Point(10, 46)
        stickynotes.Item(stickynotes.Count - 1).Set_ParentForm(Me)
        stickynotes.Item(stickynotes.Count - 1).BringToFront()
    End Sub

    Private Sub Size_Changed(sender As Object, e As EventArgs) Handles Me.Layout
        For Each note In stickynotes
            note.Set_Container_Size(Me.Size)
        Next
    End Sub

    Public Function GetNotes()
        Return stickynotes
    End Function

    Public Sub AddNote(text, location, size)
        Dim note As New UC_StickyNote
        Dim locs() As String = location.split(",")
        Dim sizes() As String = size.split(",")

        note.Set_ParentForm(Me)
        note.RTBox.Rtf = text
        note.Location = New Point(locs(0), locs(1))
        note.Size = New Size(sizes(0), sizes(1))

        stickynotes.Add(note)
        Me.Controls.Add(stickynotes.Item(stickynotes.Count - 1))
        stickynotes.Item(stickynotes.Count - 1).BringToFront()
    End Sub
End Class
