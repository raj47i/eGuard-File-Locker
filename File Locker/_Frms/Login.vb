Public Class Login
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Application.Passwd Then
            My.Forms.Main.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Password..", MsgBoxStyle.Critical)
            Me.Close()
        End If
    End Sub
End Class