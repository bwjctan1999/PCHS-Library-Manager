Public Class UC_Publishers
    Private Sub UC_Publishers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim HeaderText = New String() {"Name", "ID"}
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
            command("SELECT publisherID, pub_name FROM tbl_publishers")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("pub_name"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("publisherID"))
                    End With
                End With
            End While
            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Publishers")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddPublisher()
        Dim pubForm As New Form_AddPublisher

        If pubForm.ShowDialog = DialogResult.OK Then
            Dim publisher As New ListViewItem
            publisher.SubItems(0).Text = pubForm.Txtbox_Name.Text
            publisher.SubItems.Add(pubForm.pubID)

            UserControl_DataViewer.ListViewer.Items.Add(publisher)
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub UpdatePublisher()
        Dim pubForm As New Form_AddPublisher

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else

            pubForm.UpdateItems(UserControl_DataViewer.Get_SelectedItems())
            pubForm.ShowDialog()
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub DeletePublisher()
        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Msg.SetContent("", "Are you sure you would want to Delete these publisher/s ?")
            If Msg.ShowDialog = DialogResult.OK Then
                Try
                    openCon()

                    For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems
                        cmd.Parameters.Clear()
                        command("DELETE FROM tbl_publishers WHERE (publisherID = @id)")

                        cmd.Parameters.AddWithValue("@id", item.SubItems(1).Text)
                        execute()
                    Next

                    closeCon()
                    UserControl_DataViewer.Remove_SelectedItems()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        AddPublisher()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        UpdatePublisher()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        DeletePublisher()
    End Sub

    Public Sub Double_Click_Event()
        UpdatePublisher()
    End Sub
End Class
