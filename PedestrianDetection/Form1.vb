Option Strict

Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class Form1

' member variables ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Dim blnFirstTimeInResizeEvent As Boolean = True
Dim intOrigFormWidth As Integer = 0
Dim intOrigFormHeight As Integer = 0
Dim intOrigImageBoxWidth As Integer = 0
Dim intOrigImageBoxHeight As Integer = 0

' constructor '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub New()
	InitializeComponent					'always call this in a visual basic form constructor, necessary to init form

	intOrigFormWidth = Me.Width
	intOrigFormHeight = Me.Height
	intOrigImageBoxWidth = ibImage.Width
	intOrigImageBoxHeight = ibImage.Height
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub Form1_Resize( sender As System.Object,  e As System.EventArgs) Handles MyBase.Resize
	'This If Else statement is necessary to throw out the first time the Form1_Resize event is called.
	'For some reason, in VB.NET the Resize event is called once before the constructor, then the constructor is called,
	'then the Resize event is called each time the form is resized.  The first time the Resize event is called
	'(i.e. before the constructor is called) the coordinates of the components on the form all read zero,
	'therefore we have to throw out this first call, then the constructor will run and get the correct initial
	'component location data, then every time after that we can let the Resize event run as expected
	If(blnFirstTimeInResizeEvent = True) Then
		blnFirstTimeInResizeEvent = False
	Else
		ibImage.Width = Me.Width - (intOrigFormWidth - intOrigImageBoxWidth)
		ibImage.Height = Me.Height - (intOrigFormHeight - intOrigImageBoxHeight)
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub btnFile_Click( sender As System.Object,  e As System.EventArgs) Handles btnFile.Click
	Dim drDialogResult As DialogResult = ofdFile.ShowDialog()

	If(drDialogResult = Windows.Forms.DialogResult.OK Or drDialogResult = Windows.Forms.DialogResult.Yes) Then
		txtFile.Text = ofdFile.FileName
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Private Sub txtFile_TextChanged( sender As System.Object,  e As System.EventArgs) Handles txtFile.TextChanged
	If(txtFile.Text <> String.Empty) Then
		ProcessImageAndUpdateGUI
	End If
End Sub

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Sub ProcessImageAndUpdateGUI()
	Dim imgImage As Image(Of Bgr, Byte) = New Image(Of Bgr, Byte)(txtFile.Text)
	Dim imgBlank As Image(Of Bgr, Byte) = Nothing
	Dim hogd As HOGDescriptor = New HOGDescriptor()
	Dim rectPedestrians() As Rectangle

	Me.Text = "processing, please wait . . ."
	ibImage.Image = imgBlank
	Application.DoEvents()

	hogd.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector())
	rectPedestrians = hogd.DetectMultiScale(imgImage)

	For Each rectPedestrian As Rectangle In rectPedestrians
		imgImage.Draw(rectPedestrian, New Bgr(Color.Red), 2)
	Next
	
	ibImage.Image = imgImage

	Me.Text = "done processing, choose another image if desired"

End Sub

End Class
