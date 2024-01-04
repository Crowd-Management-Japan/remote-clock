<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblPort = New System.Windows.Forms.Label()
        Me.numPort = New System.Windows.Forms.NumericUpDown()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.txtLocalIP = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.btnIP = New System.Windows.Forms.Button()
        Me.grbSettings = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbColor = New System.Windows.Forms.GroupBox()
        Me.cmbTimeColor2 = New System.Windows.Forms.ComboBox()
        Me.lblColor2 = New System.Windows.Forms.Label()
        Me.lblColor1 = New System.Windows.Forms.Label()
        Me.cmbTimeColor1 = New System.Windows.Forms.ComboBox()
        Me.grbMode = New System.Windows.Forms.GroupBox()
        Me.chbSameColor = New System.Windows.Forms.CheckBox()
        Me.chbSimpleMode = New System.Windows.Forms.CheckBox()
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbSettings.SuspendLayout()
        Me.grbColor.SuspendLayout()
        Me.grbMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(17, 24)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(87, 16)
        Me.lblPort.TabIndex = 0
        Me.lblPort.Text = "Listening port"
        '
        'numPort
        '
        Me.numPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPort.Location = New System.Drawing.Point(154, 22)
        Me.numPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.numPort.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPort.Name = "numPort"
        Me.numPort.Size = New System.Drawing.Size(109, 22)
        Me.numPort.TabIndex = 11
        Me.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numPort.Value = New Decimal(New Integer() {5555, 0, 0, 0})
        '
        'btnStartStop
        '
        Me.btnStartStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartStop.Location = New System.Drawing.Point(12, 340)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(282, 34)
        Me.btnStartStop.TabIndex = 3
        Me.btnStartStop.Text = "START"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'txtLocalIP
        '
        Me.txtLocalIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalIP.Location = New System.Drawing.Point(154, 50)
        Me.txtLocalIP.Name = "txtLocalIP"
        Me.txtLocalIP.ReadOnly = True
        Me.txtLocalIP.Size = New System.Drawing.Size(109, 22)
        Me.txtLocalIP.TabIndex = 12
        Me.txtLocalIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(17, 53)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(56, 16)
        Me.lblIP.TabIndex = 6
        Me.lblIP.Text = "Local IP"
        '
        'btnIP
        '
        Me.btnIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIP.Location = New System.Drawing.Point(154, 78)
        Me.btnIP.Name = "btnIP"
        Me.btnIP.Size = New System.Drawing.Size(109, 31)
        Me.btnIP.TabIndex = 13
        Me.btnIP.Text = "Refresh"
        Me.btnIP.UseVisualStyleBackColor = True
        '
        'grbSettings
        '
        Me.grbSettings.Controls.Add(Me.lblPort)
        Me.grbSettings.Controls.Add(Me.numPort)
        Me.grbSettings.Controls.Add(Me.txtLocalIP)
        Me.grbSettings.Controls.Add(Me.btnIP)
        Me.grbSettings.Controls.Add(Me.lblIP)
        Me.grbSettings.Location = New System.Drawing.Point(12, 12)
        Me.grbSettings.Name = "grbSettings"
        Me.grbSettings.Size = New System.Drawing.Size(282, 125)
        Me.grbSettings.TabIndex = 0
        Me.grbSettings.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click Ctrl + S to stop the clock in fullscreen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grbColor
        '
        Me.grbColor.Controls.Add(Me.cmbTimeColor2)
        Me.grbColor.Controls.Add(Me.lblColor2)
        Me.grbColor.Controls.Add(Me.lblColor1)
        Me.grbColor.Controls.Add(Me.cmbTimeColor1)
        Me.grbColor.Location = New System.Drawing.Point(12, 143)
        Me.grbColor.Name = "grbColor"
        Me.grbColor.Size = New System.Drawing.Size(282, 90)
        Me.grbColor.TabIndex = 1
        Me.grbColor.TabStop = False
        '
        'cmbTimeColor2
        '
        Me.cmbTimeColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeColor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeColor2.FormattingEnabled = True
        Me.cmbTimeColor2.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue", "Yellow", "Orange", "Purple"})
        Me.cmbTimeColor2.Location = New System.Drawing.Point(127, 49)
        Me.cmbTimeColor2.Name = "cmbTimeColor2"
        Me.cmbTimeColor2.Size = New System.Drawing.Size(136, 24)
        Me.cmbTimeColor2.TabIndex = 22
        '
        'lblColor2
        '
        Me.lblColor2.AutoSize = True
        Me.lblColor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor2.Location = New System.Drawing.Point(17, 52)
        Me.lblColor2.Name = "lblColor2"
        Me.lblColor2.Size = New System.Drawing.Size(50, 16)
        Me.lblColor2.TabIndex = 9
        Me.lblColor2.Text = "Color 2"
        '
        'lblColor1
        '
        Me.lblColor1.AutoSize = True
        Me.lblColor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor1.Location = New System.Drawing.Point(17, 22)
        Me.lblColor1.Name = "lblColor1"
        Me.lblColor1.Size = New System.Drawing.Size(50, 16)
        Me.lblColor1.TabIndex = 7
        Me.lblColor1.Text = "Color 1"
        '
        'cmbTimeColor1
        '
        Me.cmbTimeColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTimeColor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimeColor1.FormattingEnabled = True
        Me.cmbTimeColor1.Items.AddRange(New Object() {"White", "Black", "Red", "Green", "Blue", "Yellow", "Orange", "Purple"})
        Me.cmbTimeColor1.Location = New System.Drawing.Point(127, 19)
        Me.cmbTimeColor1.Name = "cmbTimeColor1"
        Me.cmbTimeColor1.Size = New System.Drawing.Size(136, 24)
        Me.cmbTimeColor1.TabIndex = 21
        '
        'grbMode
        '
        Me.grbMode.Controls.Add(Me.chbSameColor)
        Me.grbMode.Controls.Add(Me.chbSimpleMode)
        Me.grbMode.Location = New System.Drawing.Point(12, 239)
        Me.grbMode.Name = "grbMode"
        Me.grbMode.Size = New System.Drawing.Size(282, 88)
        Me.grbMode.TabIndex = 2
        Me.grbMode.TabStop = False
        '
        'chbSameColor
        '
        Me.chbSameColor.AutoSize = True
        Me.chbSameColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSameColor.Location = New System.Drawing.Point(20, 24)
        Me.chbSameColor.Name = "chbSameColor"
        Me.chbSameColor.Size = New System.Drawing.Size(193, 20)
        Me.chbSameColor.TabIndex = 31
        Me.chbSameColor.Text = "Same color as main display"
        Me.chbSameColor.UseVisualStyleBackColor = True
        '
        'chbSimpleMode
        '
        Me.chbSimpleMode.AutoSize = True
        Me.chbSimpleMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbSimpleMode.Location = New System.Drawing.Point(20, 50)
        Me.chbSimpleMode.Name = "chbSimpleMode"
        Me.chbSimpleMode.Size = New System.Drawing.Size(222, 20)
        Me.chbSimpleMode.TabIndex = 32
        Me.chbSimpleMode.Text = "Simple visualization (for slow PC)"
        Me.chbSimpleMode.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 417)
        Me.Controls.Add(Me.grbMode)
        Me.Controls.Add(Me.grbColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grbSettings)
        Me.Controls.Add(Me.btnStartStop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.TopMost = True
        CType(Me.numPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbSettings.ResumeLayout(False)
        Me.grbSettings.PerformLayout()
        Me.grbColor.ResumeLayout(False)
        Me.grbColor.PerformLayout()
        Me.grbMode.ResumeLayout(False)
        Me.grbMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents numPort As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnStartStop As System.Windows.Forms.Button
    Friend WithEvents txtLocalIP As System.Windows.Forms.TextBox
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents btnIP As System.Windows.Forms.Button
    Friend WithEvents grbSettings As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grbColor As GroupBox
    Friend WithEvents cmbTimeColor2 As ComboBox
    Friend WithEvents lblColor2 As Label
    Friend WithEvents lblColor1 As Label
    Friend WithEvents cmbTimeColor1 As ComboBox
    Friend WithEvents grbMode As GroupBox
    Friend WithEvents chbSimpleMode As CheckBox
    Friend WithEvents chbSameColor As CheckBox
End Class
