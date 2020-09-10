Imports System.IO
Imports System.IO.Ports
Public Class SerialPortGetterControl
	Private _comPORT As String = ""
	Dim receivedData As String = ""

	'ini buat bikin Event Baru
	'Event ketika Ada Input baru di Serial Port
	Public Event NewSerialInputDetected(ByVal newSerialString As String)

	Public Property ComPORT As String
		Get
			Return _comPORT
		End Get
		Set(value As String)
			_comPORT = value
		End Set
	End Property
	Public Property TimerGetterInterval() As Integer
		Get
			Return TimerGetter.Interval
		End Get
		Set(value As Integer)
			TimerGetter.Interval = value
		End Set
	End Property

	Private Sub SerialPortGetterControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TimerGetter.Enabled = False
		txtboxSerialText.Enabled = False
	End Sub

	Public Function runSerialGetter()
		If _comPORT = "" Then 'cek dulu apakah Com Port udah disetup atau belum
			MessageBox.Show("comPort Property not setup") 'KAsih tau kalau Com Port masih kosong
			Return False
		Else
			'jalanin baca Serial Port tapi test apakah bisa baca port atau tidak
			Try
				SerialPortGetter.Close()
				SerialPortGetter.PortName = "COM" + ComPORT
				SerialPortGetter.BaudRate = 9600
				SerialPortGetter.DataBits = 8
				SerialPortGetter.Parity = Parity.None
				SerialPortGetter.StopBits = StopBits.One
				SerialPortGetter.Handshake = Handshake.None
				SerialPortGetter.Encoding = System.Text.Encoding.Default
				SerialPortGetter.ReadTimeout = 10000

				SerialPortGetter.Open()
				TimerGetter.Enabled = True

				clearText()
			Catch
				MsgBox("something wrong with that serial port")
				Return False
			End Try

			txtboxSerialText.Enabled = True
			Return True
		End If
	End Function

	Private Sub clearText()
		txtboxSerialText.Text = ""
		receivedData = ""
	End Sub

	Public Function stopSerialGetter()
		'buat matiin port serialnya
		Try
			txtboxSerialText.Enabled = False
			SerialPortGetter.Close()
			TimerGetter.Enabled = False
			clearText()
			Return True
		Catch
			MsgBox("Cannot Stop that serial port")
			Return False
		End Try

	End Function

	Private Sub TimerGetter_Tick(sender As Object, e As EventArgs) Handles TimerGetter.Tick
		receivedData = ReceiveSerialData()
		If receivedData IsNot "" Then
			txtboxSerialText.Text = receivedData.ToUpper()

			'Jalankan event disini buat ditangkap form lain
			RaiseEvent NewSerialInputDetected(receivedData.ToUpper())
		End If
	End Sub

	Private Function ReceiveSerialData() As String
		Dim Incoming As String
		Try
			Incoming = SerialPortGetter.ReadExisting()
			If Incoming Is Nothing Then
				Return "nothing" & vbCrLf
			Else
				Return Incoming
			End If
		Catch ex As TimeoutException
			Return "Error: Serial Port read timed out."
		End Try
	End Function
End Class
