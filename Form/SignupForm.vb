Public Class SignupForm

    ' When the user is click the Submit button the system is check
    ' if the user is Agree to the Terms and Condition if is not 
    ' the user need to Agree and if the user password is not same
    ' to the re-entered password the system show Notification that
    ' Invalid Password
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim isMale As Boolean

        If rb_male.Checked Then
            isMale = True
        Else
            isMale = False
        End If

        If cb_iAgree.Checked Then
            If tb_password.Text = tb_reenteredPassword.Text Then

                Database.Connect()
                Dim addUser = Database.AddUser(Me.tb_username.Text, Me.tb_password.Text, isMale)

                If addUser Then
                    SucessNotification.lb_title.Text = "Succesfuly Signup"
                    SucessNotification.lb_description.Text = "You can now login to the login form"
                    SucessNotification.Show()
                    Me.Close()
                Else
                    DangerNotification.lb_title.Text = "Signup Failed"
                    DangerNotification.lb_description.Text = "Try again double check your credentials"
                    DangerNotification.Show()
                End If
            Else
                DangerNotification.lb_title.Text = "Invalid Password"
                DangerNotification.lb_description.Text = "Your password and re-entered password are not the same"
                DangerNotification.Show()
            End If
        Else
            WarningNotification.lb_title.Text = "You need to Agree"
            WarningNotification.lb_description.Text = "Agree to the Terms and Condition"
            WarningNotification.Show()
        End If

    End Sub
End Class