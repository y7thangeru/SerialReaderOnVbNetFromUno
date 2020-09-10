*SerialPortGetterControl*
->Custom User Control for getting Serial Input sent by Uno
1. Drag and Drop to the Form,(Form1 are used for testing)
2. Set the ComPort property to the Serial Port used by Uno
3. use runSerialGetter() Function to run the User Control
4. get the NewSerialInputDetected Event to access the latest Input received from the serial port
5. When you finished, use stopSerialGetter() Function to stop the User Control

ps: TimerGetterInterval property can be setup to set the delay for each time the Control check for new input
    the default is 100
