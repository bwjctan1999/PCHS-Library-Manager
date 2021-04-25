Public Class UC_Subjects
    Private Sub UC_Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip

        CMS.Items.Add("Update")
        CMS.Items.Add("Add")
        CMS.Items.Add("Delete")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Update_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_Add_Click
        AddHandler CMS.Items(2).Click, AddressOf Me.Btn_Delete_Click

        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    Public Sub Load_Data()
        CreateListViewColumns()
        PopulateListView()
    End Sub

    Private Sub CreateListViewColumns()
        Dim HeaderText = New String() {"Subject", "ID"}
        Dim HeaderWidth = New Integer() {700, 100}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    '== 2.1 Populate List View ==
    Public Sub PopulateListView()
        UserControl_DataViewer.ListViewer.Items.Clear()
        Dim limages As New ImageList
        Dim simages As New ImageList
        limages.ColorDepth = ColorDepth.Depth32Bit
        simages.ColorDepth = ColorDepth.Depth32Bit
        limages.ImageSize = New Size(5, 100)
        simages.ImageSize = New Size(5, 50)

        Try
            openCon()
            command("SELECT subjectID, sub_name FROM tbl_subjects")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("sub_name"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("subjectID"))
                    End With
                End With
            End While
            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Subjects")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddSubject()
        Dim subForm As New Form_AddSubject

        If subForm.ShowDialog = DialogResult.OK Then
            Dim publisher As New ListViewItem
            publisher.SubItems(0).Text = subForm.Txtbox_Subject.Text
            publisher.SubItems.Add(subForm.subID)

            UserControl_DataViewer.ListViewer.Items.Add(publisher)
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub UpdateSubject()
        Dim pubForm As New Form_AddSubject

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            Msg.SetContent("", "None Selected")
            Msg.ShowDialog()
        Else

            pubForm.UpdateItems(UserControl_DataViewer.Get_SelectedItems())
            pubForm.ShowDialog()
        End If
    End Sub

    Private Sub DeleteSubject()
        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            Msg.SetContent("", "None Selected")
            Msg.ShowDialog()
        Else
            Msg.SetContent("", "Are you sure you would want to Delete these Subject/s ?")
            If Msg.ShowDialog = DialogResult.OK Then
                Try
                    openCon()

                    For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems
                        cmd.Parameters.Clear()
                        command("DELETE FROM tbl_subjects WHERE (subjectID = @id)")

                        cmd.Parameters.AddWithValue("@id", item.SubItems(1).Text)
                        execute()
                    Next

                    closeCon()
                    UserControl_DataViewer.Remove_SelectedItems()
                    UserControl_DataViewer.RecolorDivisions()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        AddSubject()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        UpdateSubject()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        DeleteSubject()
    End Sub
    Public Sub Double_Click_Event()
        UpdateSubject()
    End Sub
End Class
