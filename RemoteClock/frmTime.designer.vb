<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTime))
        Me.lblDown = New System.Windows.Forms.Label()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.picDown = New System.Windows.Forms.PictureBox()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDown
        '
        Me.lblDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDown.Location = New System.Drawing.Point(9, 109)
        Me.lblDown.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDown.Name = "lblDown"
        Me.lblDown.Size = New System.Drawing.Size(150, 100)
        Me.lblDown.TabIndex = 9
        Me.lblDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUp
        '
        Me.lblUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUp.Location = New System.Drawing.Point(9, 9)
        Me.lblUp.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(150, 100)
        Me.lblUp.TabIndex = 10
        Me.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picUp
        '
        Me.picUp.Location = New System.Drawing.Point(162, 9)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(150, 100)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUp.TabIndex = 11
        Me.picUp.TabStop = False
        '
        'picDown
        '
        Me.picDown.Location = New System.Drawing.Point(162, 109)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(150, 100)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDown.TabIndex = 12
        Me.picDown.TabStop = False
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.picDown)
        Me.Controls.Add(Me.picUp)
        Me.Controls.Add(Me.lblUp)
        Me.Controls.Add(Me.lblDown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTime"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Information"
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDown As Label
    Friend WithEvents lblUp As Label
    Friend WithEvents picUp As PictureBox
    Friend WithEvents picDown As PictureBox
End Class
