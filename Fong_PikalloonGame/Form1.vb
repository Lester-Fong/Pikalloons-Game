Public Class Form1

    Dim Score As Integer = 0
    Dim Ren As New Random
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PictureBox1.Top -= 15
        PictureBox2.Top -= 15
        PictureBox3.Top -= 15

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Zapdos.Bounds.IntersectsWith(PictureBox1.Bounds)) Then
            PictureBox1.Top = 560
            Dim x As Integer = Ren.Next(28, 290)
            PictureBox1.Left = x
            Score += 1
            Label2.Text = Score
        ElseIf (Zapdos.Bounds.IntersectsWith(PictureBox2.Bounds)) Then
            PictureBox2.Top = 560
            Dim x As Integer = Ren.Next(28, 290)
            PictureBox2.Left = x
            Score += 1
            Label2.Text = Score
        ElseIf (Zapdos.Bounds.IntersectsWith(PictureBox3.Bounds)) Then
            PictureBox3.Top = 560
            Dim x As Integer = Ren.Next(28, 290)
            PictureBox3.Left = x
            Score += 1
            Label2.Text = Score
        End If

        If PictureBox1.Location.Y < -60 Or PictureBox2.Location.Y < -60 Or PictureBox3.Location.Y < -60 Then

            Timer1.Enabled = False
            Timer2.Enabled = False
            MessageBox.Show("Game Over, You suck!")

        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Right) Then
            Zapdos.Left = Zapdos.Left + 5
        End If

        If (e.KeyCode = Keys.Left) Then
            Zapdos.Left = Zapdos.Left - 5
        End If

    End Sub

End Class
