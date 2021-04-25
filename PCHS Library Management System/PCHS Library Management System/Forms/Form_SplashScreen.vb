Imports System.ComponentModel

Public Class Form_SplashScreen
    Private _worker As BackgroundWorker
    Private fm

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        _worker = New BackgroundWorker()
        _worker.WorkerReportsProgress = True

        AddHandler _worker.DoWork, AddressOf WorkerDoWork
        AddHandler _worker.RunWorkerCompleted, AddressOf WorkerCompleted

        _worker.RunWorkerAsync()
    End Sub

    Private Sub WorkerDoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled
        fm = New Form_Manager(Me)
        UpdateStatus(100, "FINISHING...")
        System.Threading.Thread.Sleep(1500)
        Application.VisualStyleState = VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled
    End Sub

    Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        fm.show()
        Me.Close()
    End Sub

    Public Sub UpdateStatus(ByVal progress As Integer, ByVal status As String)
        Try
            If Me.InvokeRequired Then
                Dim cb As New UpdateStatusCallback(AddressOf UpdateStatusDelegate)
                Me.Invoke(cb, New Object() {progress, status})
            Else
                UpdateStatusDelegate(progress, status)
            End If
        Catch ex As Exception
            MessageBox.Show("There was an error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Delegate Sub UpdateStatusCallback(ByVal progress As Integer, ByVal status As String)

    'This catually updates the control - modify the paramters and update to suit the control you are using
    Private Sub UpdateStatusDelegate(ByVal progress As Integer, ByVal status As String)
        ProgressBar1.Value = progress
        Lbl_Progress.Text = status
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams
End Class