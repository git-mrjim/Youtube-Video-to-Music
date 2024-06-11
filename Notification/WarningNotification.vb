Imports System.Media

' The Notification Forms are responsible for showing a notif for the user
' It's have timer of 10s to disapear 
' It's positioned to the bottom right of the screen using Positioning Class

Public Class WarningNotification
    Private Sub Warning_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer.Start()

        SystemSounds.Exclamation.Play()
        Positioning.BottomRight(Me)

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Me.Close()
    End Sub
End Class