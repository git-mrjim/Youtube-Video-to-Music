Public Class MainForm
    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        LoginForm.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LoginForm.Show()
        Me.Close()
    End Sub


    ' When the MainForm is load the data stored in LoginForm is displayed in the MainForm
    ' Example of the Dictionary data:
    ' {
    '   "username": "admin123"
    '   "isMale": true
    ' }
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lb_username.Text = LoginForm.userData("username")

        If LoginForm.userData("isMale") = True Then
            pb_avatar.Image = My.Resources.AvatarMale
        Else
            pb_avatar.Image = My.Resources.AvatarFemale
        End If

    End Sub

    ' When the user click the Download button the system is going to 
    ' interact to the Converter class and start to convert the 
    ' url provided into music and download to the path provided
    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        SucessNotification.lb_title.Text = "Downloading..."
        SucessNotification.lb_description.Text = "Wait to be download complete one download at a time"
        SucessNotification.Show()

        Dim path As String = "C:\Users\ibayj\Downloads"
        Dim downloadResult As Dictionary(Of String, Object) = Converter.Convert(tb_url.Text, path)

        If downloadResult IsNot Nothing AndAlso downloadResult("failed") = False Then

            SucessNotification.lb_title.Text = "Downloaded"
            SucessNotification.lb_description.Text = downloadResult("message")
            SucessNotification.Show()

            MusicNotification.lb_title.Text = downloadResult("title")
            MusicNotification.musicPath = downloadResult("path")
            MusicNotification.Show()

        Else

            DangerNotification.lb_title.Text = "Download Failed"
            DangerNotification.lb_description.Text = "Check your internet connection"
            DangerNotification.Show()

        End If

    End Sub
End Class