Imports System.IO

'================================
'TABLE OF CONTENTS
'   1. Form Load Event
'
'   2. Button Controls
'       2.1 Add Staff
'       2.2 Double Click Event
'
'   3. List View Subs
'       3.1 Populate List view
'       3.2 Create ListView Columns
'
'   4. Local Subs
'       4.1 Add Staff
'================================

Public Class UC_Staff

    '========================
    '  1. FORM LOAD EVENT 
    '========================
    Private Sub UC_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CMS As New ContextMenuStrip
        CMS.Items.Add("Add")

        AddHandler CMS.Items(0).Click, AddressOf Me.Btn_AddStaff_Click

        UserControl_DataViewer.ContextMenuStrip = CMS
    End Sub



    '======================
    '  2. BUTTON CONTROLS 
    '======================
    '== 2.1 Add Staff ==
    Private Sub Btn_AddStaff_Click(sender As Object, e As EventArgs) Handles Btn_AddStaff.Click
        Add_Staff()
    End Sub

    '== 2.1 Double Click Event ==
    Public Sub Double_Click_Event()
        Add_Staff()
    End Sub



    '======================
    '  2. LIST VIEW SUBS 
    '======================
    '== 2.1 ListView Data Loader ==
    Public Sub Load_Data()
        CreateListViewColumns()
        PopulateListView()
    End Sub

    '== 2.1 Create ListView Columns ==
    Private Sub CreateListViewColumns()
        UserControl_DataViewer.ListViewer.Clear()
        Dim HeaderText = New String() {"Username", "Name", "Address", "Email", "Contact Number", "Type", "ID"}
        Dim HeaderWidth = New Integer() {250, 250, 250, 150, 150, 100, 70}

        For i As Integer = 0 To HeaderText.Length - 1
            UserControl_DataViewer.ListViewer.Columns.Add(HeaderText(i), HeaderWidth(i), HorizontalAlignment.Left)
        Next
    End Sub

    '== 2.1 Populate List View ==
    Private Sub PopulateListView()
        UserControl_DataViewer.ListViewer.Items.Clear()
        Dim limages As New ImageList
        Dim simages As New ImageList
        limages.ColorDepth = ColorDepth.Depth32Bit
        simages.ColorDepth = ColorDepth.Depth32Bit
        limages.ImageSize = New Size(100, 100)
        simages.ImageSize = New Size(50, 50)

        Try
            openCon()
            command("SELECT * FROM tbl_librarians")
            reader = cmd.ExecuteReader()

            While reader.Read()
                With UserControl_DataViewer.ListViewer
                    .Items.Add(reader("username"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(reader("fname") & reader("lname"))
                        .Add(reader("address"))
                        .Add(reader("email"))
                        .Add(reader("contactnum"))
                        .Add(reader("type"))
                        .Add(reader("librarianID"))
                    End With
                End With

                If reader("libimg") IsNot System.DBNull.Value Then
                    Dim bytes() As Byte
                    bytes = (reader("libimg"))
                    Dim memStream As New MemoryStream(bytes)
                    limages.Images.Add(Drawing.Image.FromStream(memStream))
                    simages.Images.Add(Drawing.Image.FromStream(memStream))
                End If
            End While

            UserControl_DataViewer.SetData(limages, simages, Me)
            UserControl_DataViewer.Set_Mode("Staff")
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '========================
    '  4. Local Subs 
    '========================
    '== 4.1 Add Staff ==
    Private Sub Add_Staff()
        Dim FormStaff As New Form_AddLibrarian

        If FormStaff.ShowDialog() = DialogResult.OK Then
            UserControl_DataViewer.Add_Item(FormStaff.listviewItem, FormStaff.listimage)
        End If
    End Sub
End Class
