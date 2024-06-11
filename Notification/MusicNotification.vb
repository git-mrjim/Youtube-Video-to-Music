Imports System.Media

' The Notification Forms are responsible for showing a notif for the user
' It's have timer of 20s to disapear 
' It's have ability to play a music when it's Clicked

Public Class MusicNotification

    Public Shared musicPath As String


    Private Sub Music_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SystemSounds.Exclamation.Play()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub pb_thumbnail_Click(sender As Object, e As EventArgs) Handles pb_thumbnail.Click
        PlayMusic()
    End Sub

    Private Sub lb_title_Click(sender As Object, e As EventArgs) Handles lb_title.Click
        PlayMusic()
    End Sub

    Private Sub MusicPanel_Click(sender As Object, e As EventArgs) Handles MusicPanel.Click
        PlayMusic()
    End Sub


    Private Sub PlayMusic()
        Process.Start(musicPath)
    End Sub

End Class