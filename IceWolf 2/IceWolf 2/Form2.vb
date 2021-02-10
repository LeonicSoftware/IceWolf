Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Link = TextBox1.Text
        My.Settings.Save()
        MsgBox("settings saved successfully... restart the browser to apply the settings")

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Link
    End Sub
End Class