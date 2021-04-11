Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form_Manager
    Private coverpanel As New Panel

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
        ss.UpdateStatus(10, "LOADING SHOWCASES...")
        UserControl_ShowCase.LoadData()
        ss.UpdateStatus(20, "LOADING BORROWED DATA...")
        UserControl_Borrowed.Load_Data()
        ss.UpdateStatus(40, "LOADING INVENTORY DATA...")
        UserControl_Inventory.Load_Data()
        ss.UpdateStatus(60, "LOADING STAFF DATA...")
        UserControl_Staff.Load_Data()
        ss.UpdateStatus(80, "LOADING Reports DATA...")
        UserControl_Reports.Load_Data()
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

    'Suppliers Button
    Private Sub Btn_Staff_Click(sender As Object, e As EventArgs) Handles Btn_Staff.Click
        Select_MainPanel_Button(4, Btn_Staff, UserControl_Staff)
    End Sub

    'Function for selecting a Panel Button
    Private Sub Select_MainPanel_Button(pos As Integer, btn As Button, usercontrol As UserControl)
        Dim MainPanelBtns = New Button() {Btn_BookShowcase, Btn_Borrowed, Btn_Inventory, Btn_Dashboard, Btn_Staff}
        Dim highlights = New Point() {New Point(-3, 13), New Point(-3, 59), New Point(-3, 105), New Point(-3, 151),
                                      New Point(-3, 197)}

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

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class
