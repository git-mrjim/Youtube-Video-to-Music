Public Class LoginForm

    ' The userData Dictionary is stored the data returned by LoadUser 
    ' in Database class
    Public Shared userData As Dictionary(Of String, Object)

    ' When the user click the Signup button the SignupForm is show
    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        SignupForm.Show()
    End Sub

    ' When the user click the login button the system is going to connect to the database
    ' and if the input of the user is correct the MainForm is show
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Database.Connect()
        userData = Database.LoadUser(tb_username.Text, tb_password.Text)

        If Not userData("username") = "" Then
            SucessNotification.lb_title.Text = "Welcome!"
            SucessNotification.lb_description.Text = "You can now convert video into music"
            SucessNotification.Show()
            MainForm.Show()
            Me.Hide()
        ElseIf userData("username") = "" Then
            DangerNotification.lb_title.Text = "Login Failed"
            DangerNotification.lb_description.Text = "Invalid username or password"
            DangerNotification.Show()
        End If

    End Sub
End Class
