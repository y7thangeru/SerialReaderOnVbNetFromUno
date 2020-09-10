<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.btnTest = New System.Windows.Forms.Button()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.serialControl = New RFID_getNUID.SerialPortGetterControl()
		Me.SuspendLayout()
		'
		'btnTest
		'
		Me.btnTest.Location = New System.Drawing.Point(13, 51)
		Me.btnTest.Name = "btnTest"
		Me.btnTest.Size = New System.Drawing.Size(228, 23)
		Me.btnTest.TabIndex = 1
		Me.btnTest.Text = "Connect"
		Me.btnTest.UseVisualStyleBackColor = True
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Location = New System.Drawing.Point(12, 81)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(228, 162)
		Me.RichTextBox1.TabIndex = 3
		Me.RichTextBox1.Text = ""
		'
		'serialControl
		'
		Me.serialControl.ComPORT = "13"
		Me.serialControl.Location = New System.Drawing.Point(12, 15)
		Me.serialControl.Name = "serialControl"
		Me.serialControl.Size = New System.Drawing.Size(228, 30)
		Me.serialControl.TabIndex = 5
		Me.serialControl.TimerGetterInterval = 100
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(254, 317)
		Me.Controls.Add(Me.serialControl)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.btnTest)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents btnTest As Button
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents serialControl As SerialPortGetterControl
End Class
