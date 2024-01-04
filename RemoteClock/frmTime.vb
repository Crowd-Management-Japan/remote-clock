
Public Class frmTime

    Public Const intShift As Integer = 50
    Public btmUp, btmDown As Bitmap
    Public imgUp, imgDown As Graphics

    Private Sub frmTime_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim objCurrentScreen As Screen
        ' Determine whether this screen of the second screen should be used
        If Screen.AllScreens.Length = 2 Then
            objCurrentScreen = Screen.AllScreens(1)
        Else
            objCurrentScreen = Screen.AllScreens(0)
        End If
        ' Define border and maximized prorperty
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Location = objCurrentScreen.Bounds.Location + New Point(100, 100)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmTime_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            frmMain.btnStartStop_Click(Me, Nothing)
        End If
    End Sub

    Private Sub frmTime_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        ' Modify visibility
        lblUp.Visible = Not frmMain.chbSimpleMode.Checked
        lblDown.Visible = Not frmMain.chbSimpleMode.Checked
        picUp.Visible = frmMain.chbSimpleMode.Checked
        picDown.Visible = frmMain.chbSimpleMode.Checked
        ' Change size of elements
        If frmMain.chbSimpleMode.Checked = True Then
            ' Upper image
            picUp.Size = New Size(Me.Width, Convert.ToInt32(Me.Height / 2))
            btmUp = New Bitmap(Me.Width, Convert.ToInt32(Me.Height / 2))
            imgUp = Graphics.FromImage(btmUp)
            picUp.Location = New Point(0, Convert.ToInt32(Me.Height / 2))
            ' Lower image
            picDown.Size = New Size(Me.Width, Convert.ToInt32(Me.Height / 2))
            btmDown = New Bitmap(Me.Width, Convert.ToInt32(Me.Height / 2))
            imgDown = Graphics.FromImage(btmDown)
            picDown.Location = New Point(0, 0)
        Else
            ' Upper image
            lblUp.Height = Me.Size.Height / 2
            lblUp.Width = Me.Size.Width
            lblUp.Location = New Point(0, Me.Size.Height / 2)
            ' Lower image
            lblDown.Height = Me.Size.Height / 2
            lblDown.Width = Me.Size.Width
            lblDown.Location = New Point(0, 0)
        End If
    End Sub

End Class