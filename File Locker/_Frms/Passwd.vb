Public Class Passwd

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Application.Passwd Then
            If TextBox2.Text = TextBox3.Text Then
                Try
                    Dim RegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\eGUARD\FileLocker", True)
                    RegKey.SetValue("Passwd", TextBox2.Text)
                    My.Application.Passwd = TextBox2.Text
                    MsgBox("Password Updated successfully..", MsgBoxStyle.Information)
                    RegKey.Close()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                    Application.Exit()
                End Try
            Else
                MsgBox("Please Check your New Password..")
            End If
        Else
            MsgBox("Incorrect Current Password..", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub

    Private Sub _Passwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Select()
    End Sub
End Class