<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestSerial2
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
		Me.components = New System.ComponentModel.Container()
		Me.cmbListPort = New System.Windows.Forms.ComboBox()
		Me.btnConnect = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.rtbListUID = New System.Windows.Forms.RichTextBox()
		Me.txtboxLatestUID = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblQty = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'cmbListPort
		'
		Me.cmbListPort.FormattingEnabled = True
		Me.cmbListPort.Location = New System.Drawing.Point(23, 12)
		Me.cmbListPort.Name = "cmbListPort"
		Me.cmbListPort.Size = New System.Drawing.Size(121, 21)
		Me.cmbListPort.TabIndex = 0
		'
		'btnConnect
		'
		Me.btnConnect.Location = New System.Drawing.Point(150, 12)
		Me.btnConnect.Name = "btnConnect"
		Me.btnConnect.Size = New System.Drawing.Size(75, 23)
		Me.btnConnect.TabIndex = 1
		Me.btnConnect.Text = "Connect"
		Me.btnConnect.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(23, 252)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 4
		Me.btnClear.Text = "clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		Me.Timer1.Interval = 500
		'
		'rtbListUID
		'
		Me.rtbListUID.Location = New System.Drawing.Point(23, 67)
		Me.rtbListUID.Name = "rtbListUID"
		Me.rtbListUID.Size = New System.Drawing.Size(202, 179)
		Me.rtbListUID.TabIndex = 5
		Me.rtbListUID.Text = ""
		'
		'txtboxLatestUID
		'
		Me.txtboxLatestUID.Location = New System.Drawing.Point(23, 41)
		Me.txtboxLatestUID.Name = "txtboxLatestUID"
		Me.txtboxLatestUID.Size = New System.Drawing.Size(121, 20)
		Me.txtboxLatestUID.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(151, 47)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 7
		Me.Label1.Text = "Qty :"
		'
		'lblQty
		'
		Me.lblQty.AutoSize = True
		Me.lblQty.Location = New System.Drawing.Point(186, 47)
		Me.lblQty.Name = "lblQty"
		Me.lblQty.Size = New System.Drawing.Size(13, 13)
		Me.lblQty.TabIndex = 8
		Me.lblQty.Text = "0"
		'
		'btnSave
		'
		Me.btnSave.Enabled = False
		Me.btnSave.Location = New System.Drawing.Point(105, 253)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(120, 23)
		Me.btnSave.TabIndex = 9
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'TestSerial2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(244, 287)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.lblQty)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtboxLatestUID)
		Me.Controls.Add(Me.rtbListUID)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnConnect)
		Me.Controls.Add(Me.cmbListPort)
		Me.Name = "TestSerial2"
		Me.Text = "TestSerial2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cmbListPort As ComboBox
	Friend WithEvents btnConnect As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents SerialPort1 As IO.Ports.SerialPort
	Friend WithEvents Timer1 As Timer
	Friend WithEvents rtbListUID As RichTextBox
	Friend WithEvents txtboxLatestUID As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents lblQty As Label
	Friend WithEvents btnSave As Button
End Class
