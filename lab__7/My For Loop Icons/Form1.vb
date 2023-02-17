Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i As Integer
        For i = 1 To 4
            PictureBox1.Image = System.Drawing.Image.FromFile("\\Mac\Home\Desktop\My For Loop Icons\My For Loop Icons\icon" & i & ".ico")
            MsgBox("Щелкните здесь, чтобы посмотреть следующую рожицу.")
        Next

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
