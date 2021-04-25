Public Class UC_Borrowers
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
        UserControl_DataViewer.ListViewer.Clear()
        Dim HeaderText = New String() {"Name", "Section", "Email", "Contact Number", "Address", "ID"}
        Dim HeaderWidth = New Integer() {200, 200, 200, 200, 200, 100}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    '== 2.1 Populate List View ==
    Public Sub PopulateListView()
        UserControl_DataViewer.ListViewer.Items.Clear()
        UserControl_DataViewer.ListViewer.Items.Clear()
        Dim limages As New ImageList
        Dim simages As New ImageList
        limages.ColorDepth = ColorDepth.Depth32Bit
        simages.ColorDepth = ColorDepth.Depth32Bit
        limages.ImageSize = New Size(100, 100)
        simages.ImageSize = New Size(50, 50)

        Try
            openCon()
            command("SELECT fname, lname, section, email, contactnum, address, borrowerIMG, borrowerID FROM tbl_borrowers")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("fname") & " " & reader("lname"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("section"))
                        .Add(reader("email"))
                        .Add(reader("contactnum"))
                        .Add(reader("address"))
                        .Add(reader("borrowerID"))
                    End With
                End With

                Dim bytes() As Byte

                bytes = (reader("borrowerIMG"))
                Dim memStream As New IO.MemoryStream(bytes)
                limages.Images.Add(Drawing.Image.FromStream(memStream))
                simages.Images.Add(Drawing.Image.FromStream(memStream))
            End While

            closeCon()

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Borrower")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AddBorrower()
        Dim subForm As New Form_Borrowers

        If subForm.ShowDialog = DialogResult.OK Then
            Dim publisher As New ListViewItem
            publisher.SubItems(0).Text = subForm.Txtbox_Fname.Text & " " & subForm.Txtbox_Lname.Text
            publisher.SubItems.Add(subForm.Txtbox_Section.Text)
            publisher.SubItems.Add(subForm.Txtbox_Email.Text)
            publisher.SubItems.Add(subForm.Txtbox_ContactNum.Text)
            publisher.SubItems.Add(subForm.Txtbox_HomeAdd.Text)
            publisher.SubItems.Add(subForm.addedID)

            UserControl_DataViewer.Add_Item(publisher, subForm.listimage)
        End If
    End Sub

    Private Sub UpdateBorrower()
        Dim pubForm As New Form_Borrowers

        If UserControl_DataViewer.Get_SelectedItems().count = 0 Then
            Msg.SetContent("", "None Selected")
            Msg.ShowDialog()
        Else
            pubForm.largeimage = UserControl_DataViewer.ListViewer.LargeImageList
            pubForm.smallimage = UserControl_DataViewer.ListViewer.SmallImageList
            pubForm.UpdateItems(UserControl_DataViewer.Get_SelectedItems())
            pubForm.ShowDialog()
        End If
    End Sub

    Private Sub DeleteBorrower()
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
                        command("DELETE FROM tbl_borrowers WHERE (borrowerID = @id)")

                        cmd.Parameters.AddWithValue("@id", item.SubItems(5).Text)
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
        AddBorrower()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        UpdateBorrower()
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        DeleteBorrower()
    End Sub
    Public Sub Double_Click_Event()
        UpdateBorrower()
    End Sub
End Class