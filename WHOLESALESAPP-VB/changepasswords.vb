Imports WHOLESALESAPP_VB.functions
Public Class changepasswords
    Private Sub btn_logapply_Click(sender As Object, e As EventArgs) Handles btn_logapply.Click
        Dim therow As SalesDataSet.CredentialsRow
        therow = MAIN.SalesDataSet.Credentials.FindBytype("login")
        If txt_logold.Text = getpass("login") Then

            If txt_lognew.Text = txt_logrep.Text Then
                setpass("login", txt_lognew.Text)
                MsgBox("Success!")
            Else
                MsgBox("The new password does not match!")
            End If

        Else
            MsgBox("Wrong Old Password!")
        End If
        refreshall()
    End Sub

    Private Sub btn_admapply_Click(sender As Object, e As EventArgs) Handles btn_admapply.Click
        Dim therow As SalesDataSet.CredentialsRow
        therow = MAIN.SalesDataSet.Credentials.FindBytype("admin")
        If txt_admold.Text = getpass("admin") Then
            If txt_admnew.Text = txt_admrep.Text Then
                setpass("admin", txt_admnew.Text)
                MsgBox("Success!")
            Else
                MsgBox("The new password does not match!")
            End If

        Else
            MsgBox("Wrong Old Password!")
        End If
        refreshall()
    End Sub
End Class