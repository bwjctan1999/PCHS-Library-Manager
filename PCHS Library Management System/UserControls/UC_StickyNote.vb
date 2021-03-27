Public Class UC_StickyNote

    Private Sub UC_StickyNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_Body.Height = Panel_Body.Height + TaskBar.Height
        Panel_Body.Location = New Point(3, 22)
    End Sub

    Private ShowMore As Boolean = False
    Private Sub Btn_More_Click(sender As Object, e As EventArgs) Handles Btn_More.MouseDown
        Select Case ShowMore
            Case True
                ShowMore = False
                Panel_Body.Height = Panel_Body.Height + TaskBar.Height
                Panel_Body.Location = New Point(3, 22)
            Case False
                ShowMore = True
                Panel_Body.Height = Panel_Body.Height - TaskBar.Height
                Panel_Body.Location = New Point(3, Panel_Body.Location.Y + TaskBar.Height)
        End Select
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Parent.Controls.Remove(Me)
    End Sub


    'FORMATING FUNCTIONS
    Private BoldMode As Boolean = False
    Private ItalicMode As Boolean = False
    Private UnderlineMode As Boolean = False
    Private StrikeOutMode As Boolean = False

    Private Sub Btn_Bold_Click(sender As Object, e As EventArgs) Handles Btn_Bold.Click
        If BoldMode = True Then
            BoldMode = False
            Btn_Bold.BackColor = Color.FromArgb(0, 29, 38)
        Else
            BoldMode = True
            Btn_Bold.BackColor = Color.FromArgb(17, 181, 229)
        End If

        Set_Font_Style()
    End Sub


    Private Sub Btn_Italic_Click(sender As Object, e As EventArgs) Handles Btn_Italic.Click
        If ItalicMode = True Then
            ItalicMode = False
            Btn_Italic.BackColor = Color.FromArgb(0, 29, 38)
        Else
            ItalicMode = True
            Btn_Italic.BackColor = Color.FromArgb(17, 181, 229)
        End If

        Set_Font_Style()
    End Sub

    Private Sub Btn_Underline_Click(sender As Object, e As EventArgs) Handles Btn_Underline.Click
        If UnderlineMode = True Then
            UnderlineMode = False
            Btn_Underline.BackColor = Color.FromArgb(0, 29, 38)
        Else
            UnderlineMode = True
            Btn_Underline.BackColor = Color.FromArgb(17, 181, 229)
        End If

        Set_Font_Style()
    End Sub

    Private Sub Btn_StrikeOut_Click(sender As Object, e As EventArgs) Handles Btn_StrikeOut.Click
        If StrikeOutMode = True Then
            StrikeOutMode = False
            Btn_StrikeOut.BackColor = Color.FromArgb(0, 29, 38)
        Else
            StrikeOutMode = True
            Btn_StrikeOut.BackColor = Color.FromArgb(17, 181, 229)
        End If

        Set_Font_Style()
    End Sub

    Private Sub RTBox_SelectText(sender As Object, e As EventArgs) Handles RTBox.SelectionChanged, RTBox.Click
        If RTBox.SelectionFont.Bold = True Then
            BoldMode = True
            Btn_Bold.BackColor = Color.FromArgb(17, 181, 229)
        Else
            BoldMode = False
            Btn_Bold.BackColor = Color.FromArgb(0, 29, 38)
        End If

        If RTBox.SelectionFont.Italic = True Then
            ItalicMode = True
            Btn_Italic.BackColor = Color.FromArgb(17, 181, 229)
        Else
            ItalicMode = False
            Btn_Italic.BackColor = Color.FromArgb(0, 29, 38)
        End If

        If RTBox.SelectionFont.Underline = True Then
            UnderlineMode = True
            Btn_Underline.BackColor = Color.FromArgb(17, 181, 229)
        Else
            UnderlineMode = False
            Btn_Underline.BackColor = Color.FromArgb(0, 29, 38)
        End If
    End Sub

    Private Sub Set_Font_Style()
        Dim FStyle As FontStyle

        'If Bold Style is not selected then Turn off Bold Style
        If BoldMode = False Then
            FStyle = RTBox.SelectionFont.Style And Not FontStyle.Bold
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)

        Else 'If user selected Bold Style then Turn on Bold Style

            FStyle = RTBox.SelectionFont.Style Or FontStyle.Bold
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)
        End If

        'If Itallic Style is not selected then Turn off Itallic Style
        If ItalicMode = False Then
            FStyle = RTBox.SelectionFont.Style And Not FontStyle.Italic
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)

        Else 'If user selected Bold Style then Turn on Itallic Style

            FStyle = RTBox.SelectionFont.Style Or FontStyle.Italic
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)
        End If

        'If Underline Style is not selected then Turn off Underline Style
        If UnderlineMode = False Then
            FStyle = RTBox.SelectionFont.Style And Not FontStyle.Underline
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)

        Else 'If user selected Underline Style then Turn on Underline Style

            FStyle = RTBox.SelectionFont.Style Or FontStyle.Underline
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)
        End If

        'If StrikeOut Style is not selected then Turn off StrikeOut Style
        If StrikeOutMode = False Then
            FStyle = RTBox.SelectionFont.Style And Not FontStyle.Strikeout
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)

        Else 'If user selected StrikeOut Style then Turn on StrikeOut Style

            FStyle = RTBox.SelectionFont.Style Or FontStyle.Strikeout
            RTBox.SelectionFont = New Font(RTBox.SelectionFont, FStyle)
        End If

        'Give RichTextBox Focus.
        RTBox.Focus()
    End Sub

    'COLOR FUNCTIONS
    Private btncolor As Color
    Private btnhovercolor As Color

    Private Sub Btn_Red_Click(sender As Object, e As EventArgs) Handles Btn_Red.Click

        RTBox.BackColor = Color.MistyRose
        Panel_Body.BackColor = Color.MistyRose

        btncolor = Color.LightSalmon
        btnhovercolor = Color.FromArgb(229, 143, 109)
        Btn_Close.BackColor = Color.LightSalmon
        Btn_More.BackColor = Color.LightSalmon
        TaskBar.BackColor = Color.LightSalmon
        Panel_Left.BackColor = Color.LightSalmon
        Panel_Right.BackColor = Color.LightSalmon
        Panel_Bottom.BackColor = Color.LightSalmon
    End Sub

    Private Sub Btn_Green_Click(sender As Object, e As EventArgs) Handles Btn_Green.Click
        RTBox.BackColor = Color.PaleGreen
        Panel_Body.BackColor = Color.PaleGreen

        btncolor = Color.DarkSeaGreen
        btnhovercolor = Color.FromArgb(128, 169, 129)
        Btn_Close.BackColor = Color.DarkSeaGreen
        Btn_More.BackColor = Color.DarkSeaGreen
        TaskBar.BackColor = Color.DarkSeaGreen
        Panel_Left.BackColor = Color.DarkSeaGreen
        Panel_Right.BackColor = Color.DarkSeaGreen
        Panel_Bottom.BackColor = Color.DarkSeaGreen
    End Sub

    Private Sub Btn_Blue_Click(sender As Object, e As EventArgs) Handles Btn_Blue.Click
        RTBox.BackColor = Color.LightSkyBlue
        Panel_Body.BackColor = Color.LightSkyBlue

        btncolor = Color.MediumTurquoise
        btnhovercolor = Color.FromArgb(64, 188, 183)
        Btn_Close.BackColor = Color.MediumTurquoise
        Btn_More.BackColor = Color.MediumTurquoise
        TaskBar.BackColor = Color.MediumTurquoise
        Panel_Left.BackColor = Color.MediumTurquoise
        Panel_Right.BackColor = Color.MediumTurquoise
        Panel_Bottom.BackColor = Color.MediumTurquoise
    End Sub

    Private Sub Btn_Yellow_Click(sender As Object, e As EventArgs) Handles Btn_Yellow.Click
        RTBox.BackColor = Color.LemonChiffon
        Panel_Body.BackColor = Color.LemonChiffon

        btncolor = Color.Khaki
        btnhovercolor = Color.FromArgb(215, 205, 125)
        Btn_Close.BackColor = Color.Khaki
        Btn_More.BackColor = Color.Khaki
        TaskBar.BackColor = Color.Khaki
        Panel_Left.BackColor = Color.Khaki
        Panel_Right.BackColor = Color.Khaki
        Panel_Bottom.BackColor = Color.Khaki
    End Sub

    Public Sub Set_Container_Size(conSize)
        Me.containersize = conSize
    End Sub

    'STICKNOTE MOVEMENT FUNCTIONS
    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point
    Private containersize As New Size

    Private Sub TaskBar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TaskBar.MouseDown, Panel1.MouseDown
        Me.BringToFront()
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub TaskBar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TaskBar.MouseUp, Panel1.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TaskBar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TaskBar.MouseMove, Panel1.MouseMove
        If allowCoolMove = True Then
            'If StickyNote is within all borders = Allow Right, Left, Up, and Down dragging
            If (Me.Location.X + e.X - myCoolPoint.X) > 0 And ((Me.Location.X + e.X - myCoolPoint.X) + Me.Width) < containersize.Width And
               (Me.Location.Y + e.Y - myCoolPoint.Y) > 25 And (Me.Location.Y + e.Y - myCoolPoint.Y) + Me.Height < containersize.Height Then

                Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y + e.Y - myCoolPoint.Y)

                'If StickyNote touches left or right borders = Allow Up and Down - Left or Right dragging
            ElseIf (Me.Location.X + e.X - myCoolPoint.X) < 0 Or ((Me.Location.X + e.X - myCoolPoint.X) + Me.Width) > containersize.Width Then

                'If StickyNote touches Top and Bottom Borders = Stop Up or Down Dragging
                If (Me.Location.Y + e.Y - myCoolPoint.Y) > 25 And (Me.Location.Y + e.Y - myCoolPoint.Y) + Me.Height < containersize.Height Then
                    Me.Location = New Point(Me.Location.X, Me.Location.Y + e.Y - myCoolPoint.Y)
                End If

                'If StickyNote is whithin Top or Bottom borders = Allow Left and Right - Top or Bottom dragging
            ElseIf (Me.Location.Y + e.Y - myCoolPoint.Y) < 25 Or (Me.Location.Y + e.Y - myCoolPoint.Y) + Me.Height > containersize.Height Then

                'If StickyNote touches Left or Right Borders = Stop Left and Right dragging
                If (Me.Location.X + e.X - myCoolPoint.X) > 0 And ((Me.Location.X + e.X - myCoolPoint.X) + Me.Width) < containersize.Width Then
                    Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y)
                End If
            End If
        End If
    End Sub

    'STICKY NOTE RESIZE FUNCTIONS
    Private allowResize As Boolean = False
    Private Sub Edges_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Me.Cursor = Cursors.SizeNWSE
    End Sub

    Private Sub Edges_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Edges_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        allowResize = True
    End Sub

    Private Sub Edges_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        allowResize = False
    End Sub

    Private Sub Edges_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If allowResize = True Then
            If e.X > 50 And e.Y > 50 Then
                Me.Size = New Size(e.X, e.Y)
            End If
        End If
    End Sub

    'GUI DESIGN - NO NEED TO TOUCH
    Private Sub Btn_More_MouseEnter(sender As Object, e As EventArgs) Handles Btn_More.MouseEnter
        Btn_More.BackColor = btnhovercolor
    End Sub

    Private Sub Btn_More_MouseLeave(sender As Object, e As EventArgs) Handles Btn_More.MouseLeave
        Btn_More.BackColor = btncolor
    End Sub

    Private Sub Btn_Picture_Click(sender As Object, e As EventArgs) Handles Btn_Picture.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "Desktop"
        fd.Filter = "Files|*.jpg;*.jpeg;*.png;"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName

            Dim img As Image = Image.FromFile(strFileName)
            Clipboard.SetImage(img)
            RTBox.Paste()
        End If
    End Sub
    Private Sub Btn_Bullets_Click(sender As Object, e As EventArgs) Handles Btn_Bullets.Click
        RTBox.SelectionIndent = 10
        RTBox.BulletIndent = 5
        RTBox.SelectionBullet = True
    End Sub
End Class




