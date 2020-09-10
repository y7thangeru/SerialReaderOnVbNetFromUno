Imports System.IO
Imports System.IO.Ports
'pake Arduino Uno 
'code : ReadNUID_toSerial_UNO.uno
Public Class TestSerial2
	Dim comPORT As String
	Dim receivedData As String = ""

	Private Sub TestSerial2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Timer1.Enabled = False
		comPORT = ""
		For Each sp As String In My.Computer.Ports.SerialPortNames
			cmbListPort.Items.Add(sp)
		Next
	End Sub

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbListPort.SelectedIndexChanged
		If (cmbListPort.SelectedItem <> "") Then
			comPORT = cmbListPort.SelectedItem
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
		If (btnConnect.Text = "Connect") Then
			If (comPORT <> "") Then
				SerialPort1.Close()
				SerialPort1.PortName = comPORT
				SerialPort1.BaudRate = 9600
				SerialPort1.DataBits = 8
				SerialPort1.Parity = Parity.None
				SerialPort1.StopBits = StopBits.One
				SerialPort1.Handshake = Handshake.None
				SerialPort1.Encoding = System.Text.Encoding.Default
				SerialPort1.ReadTimeout = 10000

				SerialPort1.Open()
				btnConnect.Text = "Dis-connect"
				Timer1.Enabled = True

				clearText()
				btnSave.Enabled = True
			Else
				MsgBox("Select a COM port first")
			End If
		Else
			SerialPort1.Close()
			btnConnect.Text = "Connect"
			Timer1.Enabled = False
			clearText()
			btnSave.Enabled = False
		End If
	End Sub

	Private Sub clearText()
		rtbListUID.Text = ""
		txtboxLatestUID.Text = ""
		lblQty.Text = 0

	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		receivedData = ReceiveSerialData()

		If receivedData IsNot "" Then
			txtboxLatestUID.Text = receivedData.ToUpper()
			rtbListUID.Text &= receivedData.ToUpper()
			lblQty.Text = lblQty.Text + 1
		End If

	End Sub

	Function ReceiveSerialData() As String
		Dim Incoming As String
		Try
			Incoming = SerialPort1.ReadExisting()
			If Incoming Is Nothing Then
				Return "nothing" & vbCrLf
			Else
				Return Incoming
			End If
		Catch ex As TimeoutException
			Return "Error: Serial Port read timed out."
		End Try

	End Function

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		clearText()

	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		Dim path As String = Directory.GetCurrentDirectory()
		path = path + "\MIFARE_" + DateTime.Now.ToFileTime.ToString() + "_(" + lblQty.Text.ToString + ").txt"
		If rtbListUID.Text IsNot "" Then
			rtbListUID.SaveFile(path, RichTextBoxStreamType.PlainText)
			clearText()
		End If
	End Sub
End Class