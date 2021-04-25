Imports System.IO

Public Class Form_Manager
    Private coverpanel As New Panel
    Private accountform As New Form_AddLibrarian
    'Constructor, argument is connected to the Form_SplashScreen Subs
    Public Sub New(ss)
        ' This call is required by the designer.
        InitializeComponent()

        coverpanel.Location = New Point(0, 0)
        coverpanel.Size = New Size(Me.Width, Me.Height)
        coverpanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        coverpanel.Visible = True
        coverpanel.SendToBack()
        Me.Controls.Add(coverpanel)

        Dim shader As New Panel
        shader.Size = New Size(Me.Width, Me.Height)
        shader.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        shader.Visible = True
        shader.BackColor = Color.FromArgb(150, 0, 0, 0)
        Me.coverpanel.Controls.Add(shader)

        'Loads the database
        ss.UpdateStatus(0, "LOADING ACCOUNT INFORMATION...")
        LoadAccount()

        ss.UpdateStatus(8, "LOADING AUTHORS...")
        UserControl_Authors.Load_Data()

        ss.UpdateStatus(16, "LOADING PUBLISHERS...")
        UserControl_Publisher.Load_Data()

        ss.UpdateStatus(24, "LOADING SUBJECTS...")
        UserControl_Subjects.Load_Data()

        ss.UpdateStatus(32, "LOADING BORROWERS...")
        UserControl_Borrowers.Load_Data()

        ss.UpdateStatus(40, "LOADING SHOWCASES...")
        UserControl_ShowCase.LoadData()

        ss.UpdateStatus(48, "LOADING BORROWED DATA...")
        UserControl_Borrowed.Load_Data()

        ss.UpdateStatus(56, "LOADING STAFF DATA...")
        UserControl_Staff.Load_Data()

        ss.UpdateStatus(64, "LOADING Reports DATA...")
        UserControl_Reports.Load_Data()

        ss.UpdateStatus(72, "LOADING INVENTORY DATA...")
        UserControl_Inventory.Load_Data()
    End Sub

    'MAIN PANEL BUTTONS AND FUNCTIONS'

    'Logout button
    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        Form_Login.Show()
        Me.Close()
    End Sub

    'Book Showcase Button
    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        Select_MainPanel_Button(0, Btn_Dashboard, UserControl_Reports)
        UserControl_Reports.Load_Data()
    End Sub

    Private Sub Btn_BookShowcase_Click(sender As Object, e As EventArgs) Handles Btn_BookShowcase.Click
        Select_MainPanel_Button(1, Btn_BookShowcase, UserControl_ShowCase)
    End Sub


    'Borrowed Button
    Private Sub Btn_Borrowed_Click(sender As Object, e As EventArgs) Handles Btn_Borrowed.Click
        Select_MainPanel_Button(2, Btn_Borrowed, UserControl_Borrowed)
    End Sub

    'Inventory Button
    Private Sub Btn_Inventory_Click(sender As Object, e As EventArgs) Handles Btn_Inventory.Click
        Select_MainPanel_Button(3, Btn_Inventory, UserControl_Inventory)
    End Sub

    Private Sub Btn_Authors_Click(sender As Object, e As EventArgs) Handles Btn_Authors.Click
        Select_MainPanel_Button(4, Btn_Authors, UserControl_Authors)
    End Sub

    Private Sub Btnn_Subjects_Click(sender As Object, e As EventArgs) Handles Btn_Subjects.Click
        Select_MainPanel_Button(5, Btn_Subjects, UserControl_Subjects)
    End Sub

    Private Sub Btn_Publishers_Click(sender As Object, e As EventArgs) Handles Btn_Publishers.Click
        Select_MainPanel_Button(6, Btn_Publishers, UserControl_Publisher)
    End Sub

    Private Sub Btn_Borrowers_Click(sender As Object, e As EventArgs) Handles Btn_Borrowers.Click
        Select_MainPanel_Button(7, Btn_Borrowers, UserControl_Borrowers)
    End Sub

    'Suppliers Button
    Private Sub Btn_Staff_Click(sender As Object, e As EventArgs) Handles Btn_Staff.Click
        Select_MainPanel_Button(8, Btn_Staff, UserControl_Staff)
    End Sub

    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        Select_MainPanel_Button(9, Btn_Settings, UserControl_Settings)
    End Sub

    'Function for selecting a Panel Button
    Private Sub Select_MainPanel_Button(pos As Integer, btn As Button, usercontrol As UserControl)
        Dim MainPanelBtns = New Button() {Btn_BookShowcase, Btn_Borrowed, Btn_Inventory, Btn_Dashboard, Btn_Authors,
                                        Btn_Publishers, Btn_Borrowers, Btn_Staff, Btn_Subjects, Btn_Settings}
        Dim highlights = New Point() {New Point(-3, 13), New Point(-3, 59), New Point(-3, 105), New Point(-3, 151),
                                      New Point(-3, 197), New Point(-3, 243), New Point(-3, 289), New Point(-3, 335),
                                      New Point(-3, 381), New Point(-3, 427)}

        For Each button In MainPanelBtns
            button.BackColor = Color.FromArgb(0, 29, 38)
            button.ForeColor = Color.White
        Next
        Panel_Highlight.Location = highlights(pos)
        btn.BackColor = Color.FromArgb(13, 42, 51)
        usercontrol.BringToFront()
    End Sub

    Private Sub Form_Deactivate() Handles Me.Deactivate
        Dim tmpImg As New Bitmap(Me.Width, Me.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Me.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Me.Width, Me.Height))
        End Using

        coverpanel.BackgroundImage = tmpImg
        coverpanel.BringToFront()
    End Sub

    Private Sub Form_Activated() Handles Me.Activated
        coverpanel.SendToBack()
    End Sub

    Private Sub Form_Closing() Handles Me.FormClosing
        UserControl_Reports.SaveNotes()
    End Sub

    Private Sub LoadAccount()
        Try
            openCon()
            cmd.Parameters.Clear()
            command("Select username, fname, lname, address, email, contactnum, type, libimg FROM tbl_librarians
                    WHERE (`librarianID` = @libID)")
            cmd.Parameters.AddWithValue("@libID", GetCurrentUser)

            reader = cmd.ExecuteReader

            While reader.Read
                accountform.Lbl_mode.Text = "Edit Account"
                accountform.Lbl_Password.Text = "Change Password"
                accountform.Txtbox_Username.Text = reader("username")
                accountform.Txtbox_Fname.Text = reader("fname")
                accountform.Txtbox_Lname.Text = reader("lname")
                accountform.Txtbox_HomeAdd.Text = reader("address")
                accountform.Txtbox_EmailAdd.Text = reader("email")
                accountform.Txtbox_ContactNum.Text = reader("contactnum")
                accountform.tempUsername = reader("username")

                Select Case reader("type")
                    Case "Librarian"
                        accountform.Cbox_Type.SelectedIndex = 0
                    Case "Student Assistant"
                        accountform.Cbox_Type.SelectedIndex = 1
                    Case "Admin"
                        accountform.Cbox_Type.Items.Add("Admin")
                        accountform.Cbox_Type.SelectedIndex = 2
                End Select


                Dim bytes() As Byte
                bytes = (reader("libimg"))
                Dim memStream As New MemoryStream(bytes)
                accountform.Panel_Image.BackgroundImage = Drawing.Image.FromStream(memStream)

                Lbl_Name.Text = (reader("fname") & " " & reader("lname"))
                Lbl_Type.Text = (reader("type"))

                bytes = (reader("libimg"))
                memStream = New MemoryStream(bytes)
                Picbox_ProfilePic.Image = Drawing.Image.FromStream(memStream)
            End While

            accountform.EditMode()
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams

    Private Sub Btn_More_Click(sender As Object, e As EventArgs) Handles Btn_More.Click
        If Panel_More.Visible Then
            Panel_More.Hide()
        Else
            Panel_More.Show()
            Panel_More.BringToFront()
        End If
    End Sub

    Private Sub Btn_GenerateReports_Click(sender As Object, e As EventArgs) Handles Btn_GenerateReports.Click
        Dim filebrowser As New FolderBrowserDialog

        If (filebrowser.ShowDialog() = DialogResult.OK) Then
            Dim dir = filebrowser.SelectedPath

            Dim repgen As New ReportsGenerator
            repgen.SetLocation(dir)
            repgen.SetName("PCHSLIBRARY_REPORTS.xls")
            repgen.Generate()
        End If
    End Sub

    Private Sub Btn_AccInfo_Click(sender As Object, e As EventArgs) Handles Btn_AccInfo.Click
        If accountform.ShowDialog() = DialogResult.OK Then
            Picbox_ProfilePic.Image = accountform.Panel_Image.BackgroundImage
            Lbl_Name.Text = accountform.Txtbox_Fname.Text & accountform.Txtbox_Lname.Text
            Lbl_Type.Text = accountform.Cbox_Type.Text


            UserControl_Staff.Load_Data()
            UserControl_Staff.UserControl_DataViewer.RecolorDivisions()
        End If
    End Sub

    Private Sub Panel_More_Unfocused() Handles Panel_More.LostFocus
        Panel_More.Hide()
    End Sub
End Class
