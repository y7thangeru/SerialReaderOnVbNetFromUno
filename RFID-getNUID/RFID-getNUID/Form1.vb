Public Class Form1
	Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
		If btnTest.Text = "Connect" Then
			'set the port manually
			'serialControl.ComPORT = 13 'ini bisa dr Property
			If serialControl.runSerialGetter() Then
				'MessageBox.Show("Ready for Reading serial")
				btnTest.Text = "DisConnect"
				RichTextBox1.Text = ""
			End If
		Else
			If serialControl.stopSerialGetter() Then
				'MessageBox.Show("STOP Reading serial")
				btnTest.Text = "Connect"
				RichTextBox1.Text = ""
			End If
		End If


	End Sub

	Private Sub SerialPortGetterControl1_NewSerialInputDetected(newSerialString As String) Handles serialControl.NewSerialInputDetected
		RichTextBox1.Text &= newSerialString
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
