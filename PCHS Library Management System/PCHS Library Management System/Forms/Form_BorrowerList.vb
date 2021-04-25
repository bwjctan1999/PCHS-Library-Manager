Imports System.IO

Public Class Form_BorrowerList
    Public selectedname As String
    Public selectedID As String

    Private Sub Form_BorrowerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip

        CMS.Items.Add("Select")
        CMS.Items.Add("Cancel")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_Select_Click
        AddHandler CMS.Items(1).Click, AddressOf Me.Btn_Cancel_Click
        UserControl_DataViewer.ContextMenuStrip = CMS

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


    Private Sub SelectStudent()
        Dim item As ListViewItem = UserControl_DataViewer.Get_SelectedItems(0)
        selectedname = item.Text
        selectedID = item.SubItems(5).Text

        Me.DialogResult = DialogResult.OK
    End Sub

    Public Sub Double_Click_Event()
        SelectStudent()
    End Sub

    Private Sub Btn_Select_Click(sender As Object, e As EventArgs) Handles Btn_Select.Click
        SelectStudent()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class
