Imports System.IO

Public Class UC_Authors

    '=======================
    '  1. FORM LOAD EVENT  
    '=======================
    Private Sub UC_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip

        CMS.Items.Add("Update")
        CMS.Items.Add("Add")
        CMS.Items.Add("Delete")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Update_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_Add_Click
        AddHandler CMS.Items(2).Click, AddressOf Me.Btn_Delete_Click

        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub

    '======================
    '  2. LIST VIEW SUBS 
    '======================
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
            command("SELECT authorID, author_name FROM tbl_authors")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("author_name"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("authorID"))
                    End With
                End With
            End While
            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Authors")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub EditAuthor()
        Dim authorform As New Form_AddAuthor

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Dim seLength As Integer = UserControl_DataViewer.Get_SelectedItems().Count
            Dim ids(seLength - 1) As Integer

            For i As Integer = 0 To seLength - 1
                ids(i) = UserControl_DataViewer.Get_SelectedItems()(i).SubItems(1).Text
            Next

            authorform.UpdateAuthor(ids)
            If authorform.ShowDialog = DialogResult.OK Then
                Dim i As Integer = 0
                For Each index In UserControl_DataViewer.ListViewer.SelectedIndices
                    UserControl_DataViewer.ListViewer.Items(index) = authorform.listviewItems(i)
                    i += 1
                Next
            End If
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    'CONTROL FUNCTIONS ============================================================================================
    Public Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim authorform As New Form_AddAuthor

        If authorform.ShowDialog = DialogResult.OK Then
            Dim item As New ListViewItem
            item.SubItems(0).Text = authorform.Txtbox_Name.Text
            item.SubItems.Add(authorform.authorID)

            UserControl_DataViewer.ListViewer.Items.Add(item)
            UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        EditAuthor()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            MsgBox("Non Selected")
        Else
            Msg.SetContent("", "Are you sure you would want to Delete these author/s ?")
            If Msg.ShowDialog = DialogResult.OK Then
                Try
                    openCon()

                    For Each item As ListViewItem In UserControl_DataViewer.Get_SelectedItems
                        cmd.Parameters.Clear()
                        command("DELETE FROM tbl_authors WHERE (authorID = @id)")

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

    Public Sub Double_Click_Event()
        EditAuthor()
    End Sub
End Class
