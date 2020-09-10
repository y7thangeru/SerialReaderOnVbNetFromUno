<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialPortGetterControl
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.SerialPortGetter = New System.IO.Ports.SerialPort(Me.components)
		Me.TimerGetter = New System.Windows.Forms.Timer(Me.components)
		Me.txtboxSerialText = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'TimerGetter
		'
		'
		'txtboxSerialText
		'
		Me.txtboxSerialText.Location = New System.Drawing.Point(3, 4)
		Me.txtboxSerialText.Name = "txtboxSerialText"
		Me.txtboxSerialText.ReadOnly = True
		Me.txtboxSerialText.Size = New System.Drawing.Size(221, 20)
		Me.txtboxSerialText.TabIndex = 0
		Me.txtboxSerialText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'SerialPortGetterControl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.txtboxSerialText)
		Me.Name = "SerialPortGetterControl"
		Me.Size = New System.Drawing.Size(228, 30)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SerialPortGetter As IO.Ports.SerialPort
	Friend WithEvents TimerGetter As Timer
	Friend WithEvents txtboxSerialText As TextBox
End Class
