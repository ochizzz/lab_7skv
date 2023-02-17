Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox2.Visible = False 'сделать 1 картинку невидимой
        Timer2.Enabled = False      'вюкл. первый таймер
        PictureBox3.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox4.Visible = False 'сделать 1 картинку невидимой
        Timer4.Enabled = False      'вюкл. первый таймер
        PictureBox5.Visible = False 'сделать 1 картинку невидимой
        Timer5.Enabled = False      'вюкл. первый таймер
        PictureBox6.Visible = False 'сделать 2 картинку невидимой
        Timer6.Enabled = False      'вюкл. второй таймер
        PictureBox2.Visible = True  'сделать  2 картинку видимой 
        Timer2.Enabled = True       'включить второй таймер
        Timer2.Interval = 400
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Visible = False 'сделать 2 картинку невидимой
        Timer2.Enabled = False      'вюкл. второй таймер
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox4.Visible = False 'сделать 1 картинку невидимой
        Timer4.Enabled = False      'вюкл. первый таймер
        PictureBox5.Visible = False 'сделать 1 картинку невидимой
        Timer5.Enabled = False      'вюкл. первый таймер
        PictureBox6.Visible = False 'сделать 2 картинку невидимой
        Timer6.Enabled = False      'вюкл. второй таймер
        PictureBox3.Visible = True  'сделать 1 картинку невидимой
        Timer3.Enabled = True       'включить первый таймер
        Timer3.Interval = 400
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox2.Visible = False 'сделать 2 картинку невидимой
        Timer2.Enabled = False      'вюкл. второй таймер
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox3.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox5.Visible = False 'сделать 1 картинку невидимой
        Timer5.Enabled = False      'вюкл. первый таймер
        PictureBox6.Visible = False 'сделать 2 картинку невидимой
        Timer6.Enabled = False      'вюкл. второй таймер
        PictureBox4.Visible = True  'сделать 1 картинку невидимой
        Timer4.Enabled = True       'включить первый таймер
        Timer4.Interval = 400
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox2.Visible = False 'сделать 2 картинку невидимой
        Timer2.Enabled = False      'вюкл. второй таймер
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox3.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox4.Visible = False 'сделать 1 картинку невидимой
        Timer4.Enabled = False      'вюкл. первый таймер
        PictureBox6.Visible = False 'сделать 2 картинку невидимой
        Timer6.Enabled = False      'вюкл. второй таймер
        PictureBox5.Visible = True  'сделать 1 картинку невидимой
        Timer5.Enabled = True       'включить первый таймер
        Timer5.Interval = 400
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox2.Visible = False 'сделать 2 картинку невидимой
        Timer2.Enabled = False      'вюкл. второй таймер
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False      'вюкл. первый таймер
        PictureBox3.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox4.Visible = False 'сделать 1 картинку невидимой
        Timer4.Enabled = False      'вюкл. первый таймер
        PictureBox5.Visible = False 'сделать 2 картинку невидимой
        Timer5.Enabled = False      'вюкл. второй таймер
        PictureBox6.Visible = True  'сделать 1 картинку невидимой
        Timer6.Enabled = True       'включить первый таймер
        Timer6.Interval = 400
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        PictureBox2.Visible = False 'сделать 2 картинку невидимой
        Timer2.Enabled = False      'вюкл. второй таймер
        PictureBox6.Visible = False 'сделать 1 картинку невидимой
        Timer6.Enabled = False      'вюкл. первый таймер
        PictureBox3.Visible = False 'сделать 1 картинку невидимой
        Timer3.Enabled = False      'вюкл. первый таймер
        PictureBox4.Visible = False 'сделать 1 картинку невидимой
        Timer4.Enabled = False      'вюкл. первый таймер
        PictureBox5.Visible = False 'сделать 2 картинку невидимой
        Timer5.Enabled = False      'вюкл. второй таймер
        PictureBox1.Visible = True  'сделать 1 картинку невидимой
        Timer1.Enabled = True       'включить первый таймер
        Timer1.Interval = 400
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub
End Class