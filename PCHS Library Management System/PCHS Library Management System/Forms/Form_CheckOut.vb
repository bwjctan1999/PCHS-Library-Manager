

'====================================
'TABLE OF CONTENTS
'   1. Form Loader
'
'   2. Button Controls
'       2.1 Button: Checkout
'       2.2 Button: Cancel
'
'   3. Local Functions
'       3.1 Adds Book to Shelf
'       3.2 Remove Book from Shelf
'       3.3 Duration Combobox Change
'
'   4. Insert to Database Function
'====================================


Public Class Form_CheckOut
    Public addedIDs As New List(Of Integer)


    '===================
    '  1. FORM LOADER  
    '===================
    Private Sub Form_CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_Name.Text = ""
        Txtbox_ID.Text = ""

        Cbox_Duration.Items.Clear()
        For Each item In My.Settings.BorrowDuration
            Cbox_Duration.Items.Add(item)
        Next

        Lbl_Info.Text = "An amount of ₱ " & My.Settings.BorrowFine & " per hour will be charged if you go past your due date."

        Cbox_Duration.SelectedIndex = 3
        Me.UserControl_BookShelf.Set_Panel_Color(Color.FromArgb(19, 97, 170))
    End Sub

    '======================
    '  2. BUTTON CONTROLS  
    '======================
    '== 2.1 Button: Checkout ==
    Private Sub Btn_CheckOut_Click(sender As Object, e As EventArgs) Handles Btn_CheckOut.Click
        If ErrorChecker() = True Then
            Insert_BorrowRecords_To_DB()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    '== 2.1 Button: Cancel ==
    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.UserControl_BookShelf.Clear_Books()
        Me.Close()
    End Sub

    '== 2.2 Populate List View ==
    Private Sub Btn_QRReader_Click(sender As Object, e As EventArgs) Handles Btn_QRReader.Click
        If UserControl_BookShelf.GetBooks().Count = 5 Then
            Msg.SetContent("", "You have already Reached The Limit per Record.")
            Msg.ShowDialog()
        Else
            Form_BookList.ShowDialog()
            'Form_QRReader.ShowDialog()
        End If
    End Sub


    '=======================
    '  3. LOCAL FUNCTIONS  
    '=======================
    '== 3.1 Adds Book to Shelf ==
    Public Sub Add_Book(book)
        UserControl_BookShelf.Add_Book(book)
    End Sub

    '== 3.2 Remove Book from Shelf ==
    Public Sub Remove_Book(book)
        UserControl_BookShelf.Remove_Book(book)
    End Sub

    '== 3.3 Duration Combobox Change ==
    Private Sub Cbox_Duration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbox_Duration.SelectedIndexChanged
        Dim duration() As String = Split(Cbox_Duration.SelectedItem, " - ")
        Dim interval As String = "d"

        If duration(1) = "Month" Or duration(1) = "Months" Then
            interval = "m"
        End If

        Lbl_BorrowDate.Text = DateTime.Now.ToShortDateString
        Lbl_DueDate.Text = DateAdd(interval, Convert.ToInt32(duration(0)), DateTime.Now.ToShortDateString)
    End Sub



    '====================================
    '  4. INSERT TO DATABASE FUNCTION  
    '====================================
    Private Sub Insert_BorrowRecords_To_DB()
        Try
            openCon()
            addedIDs.Clear()
            cmd.Parameters.Clear()
            command("INSERT INTO tbl_borrowers_record (`borrowerID`, `dateBorrowed`, `dueDate`) 
                     VALUES (@id, @borrowdate, @duedate); 
                     Select @@identity")

            cmd.Parameters.AddWithValue("@id", Txtbox_ID.Text)
            cmd.Parameters.AddWithValue("@borrowdate", Lbl_BorrowDate.Text)
            cmd.Parameters.AddWithValue("@duedate", Lbl_DueDate.Text)
            Dim brID = cmd.ExecuteScalar()

            For Each book As UC_Book In UserControl_BookShelf.GetBooks
                cmd.Parameters.Clear()
                command("INSERT INTO tbl_borrowed_books (`brID`, `bookID`)
                    VALUE (@brID, @bookID); SELECT @@identity")

                cmd.Parameters.AddWithValue("@brID", brID)
                cmd.Parameters.AddWithValue("@bookID", book.BookID)

                addedIDs.Add(cmd.ExecuteScalar())
            Next
            closeCon()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function ErrorChecker()
        Dim pass As Boolean = True

        If Txtbox_ID.Text = "" Then
            Msg.SetContent("", "ID is Empty")
            Msg.ShowDialog()
            pass = False
        Else
            Try
                openCon()
                cmd.Parameters.Clear()
                command("SELECT * FROM tbl_borrowers WHERE (`borrowerID` = @ID)")
                cmd.Parameters.AddWithValue("@ID", Txtbox_ID.Text)

                Dim temp As String = cmd.ExecuteScalar

                If temp = "" Then
                    pass = False

                    Msg.SetContent("", "This User does Not exist")
                    Msg.ShowDialog()
                End If

                closeCon()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

        If UserControl_BookShelf.GetBooks.Count = 0 Then
            pass = False
            Msg.SetContent("", "You have not picked a Book.")
            Msg.ShowDialog()
        End If

        Return pass
    End Function

    Private Sub Btn_Select_Click(sender As Object, e As EventArgs) Handles Btn_Select.Click
        If Form_BorrowerList.ShowDialog = DialogResult.OK Then
            Txtbox_ID.Text = Form_BorrowerList.selectedID
            Lbl_Name.Text = Form_BorrowerList.selectedname
        End If
    End Sub
End Class