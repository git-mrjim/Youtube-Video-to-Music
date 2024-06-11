Imports System.Windows.Forms

' This codes is for positioning the Form for the specific position in the
' working screen area.

Public Class Positioning

    ' ButtomRight function is positioned the specify Form in the parameter into Bottom Right 
    ' of the screen
    Public Shared Sub BottomRight(form As Form)
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Dim formWidth As Integer = form.Width
        Dim formHeight As Integer = form.Height
        Dim xPosition As Integer = workingArea.Right - formWidth
        Dim yPosition As Integer = workingArea.Bottom - formHeight
        form.Location = New Point(xPosition, yPosition)
    End Sub

End Class
