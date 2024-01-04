Imports System.Net.Sockets
Imports System.Net
Imports System.Text

Public Class frmMain

    Private Const strKeyLocation As String = "HKEY_CURRENT_USER\"
    Private Const strKeyName As String = "Software\RemoteClock"
    Private bolListening As Boolean, intCounter As Integer
    Private objColor1, objColor2, objBackColor, objFontColor As Color
    Private netUDPListener As UdpClient, netReceiveGroupEP As IPEndPoint
    Private netUDPIPEndPoint As IPEndPoint, UDPThread As CallbackThread

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Load settings from system registry
        If Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strKeyName) Is Nothing Then
            My.Computer.Registry.CurrentUser.CreateSubKey(strKeyName)
            cmbTimeColor1.SelectedIndex = 0
            cmbTimeColor2.SelectedIndex = 1
        Else
            ReadFromRegistry()
        End If
        ' Get local IP
        btnIP_Click(Me, Nothing)
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As System.EventArgs) Handles Me.Closed
        If btnStartStop.Text = "STOP" Then btnStartStop_Click(Me, Nothing)
        WriteToRegistry()
    End Sub

    Private Sub ReadFromRegistry()
        numPort.Value = CDec(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "numPort", 5555))
        cmbTimeColor1.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbTimeColor1", 0))
        cmbTimeColor2.SelectedIndex = CInt(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "cmbTimeColor2", 1))
        chbSameColor.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbSameColor", False))
        chbSimpleMode.Checked = CBool(My.Computer.Registry.GetValue(strKeyLocation + strKeyName, "chbSimpleMode", False))
    End Sub

    Private Sub WriteToRegistry()
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "numPort", numPort.Value)
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbTimeColor1", CDec(cmbTimeColor1.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "cmbTimeColor2", CDec(cmbTimeColor2.SelectedIndex))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbSameColor", CDec(chbSameColor.Checked))
        My.Computer.Registry.SetValue(strKeyLocation + strKeyName, "chbSimpleMode", CDec(chbSimpleMode.Checked))
    End Sub

    Private Sub cmbTimeColor1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTimeColor1.SelectedIndexChanged
        objColor1 = SetColor(cmbTimeColor1.SelectedIndex)
    End Sub

    Private Sub cmbTimeColor2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTimeColor2.SelectedIndexChanged
        objColor2 = SetColor(cmbTimeColor2.SelectedIndex)
    End Sub

    Private Sub chbSameColor_CheckedChanged(sender As Object, e As EventArgs) Handles chbSameColor.CheckedChanged
        If chbSameColor.Checked = False Then
            objColor1 = SetColor(cmbTimeColor1.SelectedIndex)
            objColor2 = SetColor(cmbTimeColor2.SelectedIndex)
        End If
    End Sub

    Private Function SetColor(ByVal intValue As Integer) As Color
        Dim objColor As Color
        Select Case intValue
            Case 0
                objColor = Color.White
            Case 1
                objColor = Color.Black
            Case 2
                objColor = Color.Red
            Case 3
                objColor = Color.Green
            Case 4
                objColor = Color.Blue
            Case 5
                objColor = Color.Yellow
            Case 6
                objColor = Color.Orange
            Case 7
                objColor = Color.Purple
        End Select
        Return objColor
    End Function

    Private Sub frmMain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then
            btnStartStop_Click(Me, Nothing)
        End If
    End Sub

    Private Sub btnIP_Click(sender As System.Object, e As System.EventArgs) Handles btnIP.Click
        Dim strIPAddress As String
        strIPAddress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.Where(Function(a As IPAddress) Not a.IsIPv6LinkLocal AndAlso Not a.IsIPv6Multicast AndAlso Not a.IsIPv6SiteLocal).First().ToString()
        txtLocalIP.Text = strIPAddress
    End Sub

    Private Sub UDPListening()
        Dim strReading As String, bytes As Byte() = Nothing
        ' Open port and initialize UDP client
        netUDPListener = New UdpClient(CInt(numPort.Value))
        netReceiveGroupEP = New IPEndPoint(IPAddress.Any, CInt(numPort.Value))
        ' Loop for data streaming
        While bolListening
            ' Read data stream
            bytes = netUDPListener.Receive(netUDPIPEndPoint)
            ' Pass data to analyzer
            If IsNothing(bytes) = False Then
                strReading = Encoding.ASCII.GetString(bytes, 0, bytes.Length)
                UDPThread.UpdateUI(strReading)
            End If
        End While
    End Sub

    Public Sub btnStartStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStartStop.Click
        If btnStartStop.Text = "START" Then
            ' Start thread
            bolListening = True
            UDPThread = New CallbackThread(Me, AddressOf UDPListening, AddressOf DataReceived)
            UDPThread.Start()
            ' Load display
            frmTime.Show()
            ' Change appearance
            chbSimpleMode.Enabled = False
            btnStartStop.Text = "STOP"
            grbSettings.Enabled = False
            ' Make form invisible if one screen used
            If Screen.AllScreens.Length = 1 Then Me.Visible = False
        Else
            ' Stop listening
            bolListening = False
            UDPThread.Dispose()
            netUDPListener.Close()
            ' Close display
            frmTime.Close()
            ' Change appearance
            chbSimpleMode.Enabled = True
            btnStartStop.Text = "START"
            grbSettings.Enabled = True
            Me.Visible = True
        End If
    End Sub

    Private Sub DataReceived(ByVal strMessage As String)
        Dim strUp, strDown As String, objFont As Font, objBrush As Brush
        Dim intCode, intTextSize, intTimeChange, intColor(0 To 1) As Integer, dblTime As Double
        ' Process message
        intCode = Convert.ToInt32(Strings.Left(strMessage, InStr(strMessage, ",") - 1))
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        strUp = Strings.Left(strMessage, InStr(strMessage, ",") - 1)
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        strDown = Strings.Left(strMessage, InStr(strMessage, ",") - 1)
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        intTextSize = Convert.ToInt32(Strings.Left(strMessage, InStr(strMessage, ",") - 1))
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        intTimeChange = Convert.ToInt32(Strings.Left(strMessage, InStr(strMessage, ",") - 1))
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        intColor(0) = Convert.ToInt32(Strings.Left(strMessage, InStr(strMessage, ",") - 1))
        strMessage = Strings.Right(strMessage, Len(strMessage) - InStr(strMessage, ","))
        intColor(1) = Convert.ToInt32(strMessage)
        ' Define general font
        objFont = New Font(New FontFamily("Microsoft Sans Serif"), intTextSize, FontStyle.Bold)
        ' Prepare color
        If intCode = 0 Then dblTime = Convert.ToDouble(Strings.Right(strDown, 5))
        If intCode = 1 Then dblTime = Convert.ToDouble(strDown)
        If Int(dblTime) Mod intTimeChange = 0 Then
            If intCounter = 0 Then
                If objBackColor = objColor2 Then
                    objBackColor = objColor1
                    objFontColor = objColor2
                Else
                    objBackColor = objColor2
                    objFontColor = objColor1
                End If
            End If
            intCounter = intCounter + 1
        Else
            intCounter = 0
        End If
        ' Change color if needed
        If chbSameColor.Checked = True Then
            objBackColor = SetColor(intColor(0))
            objFontColor = SetColor(intColor(1))
        Else
            If objBackColor = objColor2 Then
                objBackColor = objColor2
                objFontColor = objColor1
            Else
                objBackColor = objColor1
                objFontColor = objColor2
            End If
        End If
        ' Show text
        If chbSimpleMode.Checked = True Then
            objBrush = New SolidBrush(objFontColor)
            frmTime.imgUp.Clear(objBackColor)
            frmTime.imgUp.DrawString(" " + strUp, objFont, objBrush, New Point(0 + intCode * 100, frmTime.intShift))
            frmTime.picUp.Image = frmTime.btmUp
            frmTime.imgDown.Clear(objBackColor)
            frmTime.imgDown.DrawString(" " + strDown, objFont, objBrush, New Point(0 + intCode * 100, frmTime.intShift))
            frmTime.picDown.Image = frmTime.btmDown
        Else
            frmTime.lblUp.BackColor = objBackColor
            frmTime.lblUp.ForeColor = objFontColor
            frmTime.lblUp.Text = strUp
            frmTime.lblUp.Font = objFont
            frmTime.lblDown.BackColor = objBackColor
            frmTime.lblDown.ForeColor = objFontColor
            frmTime.lblDown.Text = strDown
            frmTime.lblDown.Font = objFont
        End If
    End Sub

End Class