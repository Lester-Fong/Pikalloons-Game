Public Class Form1

    Dim Score As Integer = 0
    Dim y As Integer = 1
    Dim Ren As New Random
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PictureBox1.Top -= 8
        PictureBox2.Top -= 8
        PictureBox3.Top -= 8

        If (y = 1) Then
            Label7.Text = "Beginner"
            Label7.ForeColor = Color.AliceBlue
            PictureBox1.Top -= 8
            PictureBox2.Top -= 8
            PictureBox3.Top -= 8
        End If
        If (y = 2) Then
            Label7.Text = "Normal"
            Label7.ForeColor = Color.Blue
            PictureBox1.Top -= 12
            PictureBox2.Top -= 12
            PictureBox3.Top -= 12
        End If
        If (y = 3) Then
            Label7.Text = "Insane"
            Label7.ForeColor = Color.Red
            PictureBox1.Top -= 20
            PictureBox2.Top -= 20
            PictureBox3.Top -= 20
        End If
        If (y = 4) Then
            y = 1
        End If

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If (Zapdos.Bounds.IntersectsWith(PictureBox1.Bounds)) Then
            PictureBox1.Top = 560
            Dim x As Integer = Ren.Next(28, 349)
            PictureBox1.Left = x
            Score += 1
            Label2.Text = Score
        ElseIf (Zapdos.Bounds.IntersectsWith(PictureBox2.Bounds)) Then
            PictureBox2.Top = 560
            Dim x As Integer = Ren.Next(28, 370)
            PictureBox2.Left = x
            Score += 1
            Label2.Text = Score
        ElseIf (Zapdos.Bounds.IntersectsWith(PictureBox3.Bounds)) Then
            PictureBox3.Top = 560
            Dim x As Integer = Ren.Next(28, 275)
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
            Zapdos.Left = Zapdos.Left + 7
        End If

        If (e.KeyCode = Keys.Left) Then
            Zapdos.Left = Zapdos.Left - 7
        End If

        If (y = 1) Then
            If (e.KeyCode = Keys.Left) Then
                Zapdos.Left = Zapdos.Left - 7
            End If
            If (e.KeyCode = Keys.Right) Then
                Zapdos.Left = Zapdos.Left + 7
            End If
        End If
        If (y = 2) Then
            If (e.KeyCode = Keys.Left) Then
                Zapdos.Left = Zapdos.Left - 11
            End If
            If (e.KeyCode = Keys.Right) Then
                Zapdos.Left = Zapdos.Left + 11
            End If
        End If
        If (y = 3) Then
            If (e.KeyCode = Keys.Left) Then
                Zapdos.Left = Zapdos.Left - 18
            End If
            If (e.KeyCode = Keys.Right) Then
                Zapdos.Left = Zapdos.Left + 18
            End If
        End If


        If (e.KeyCode = Keys.Enter) Then
            Label2.Text = 0
            Score = 0
            PictureBox1.Top = 560
            PictureBox2.Top = 560
            PictureBox3.Top = 560
            PictureBox1.Left = 28
            PictureBox2.Left = 349
            PictureBox3.Left = 90

            Timer1.Enabled = True
            Timer2.Enabled = True
        End If

        If (e.KeyCode = Keys.Space) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
        End If
        If (e.KeyCode = Keys.R) Then
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If


        If (e.KeyCode = Keys.Up) Then
            y += 1
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome!")
        MessageBox.Show("Pop Pikachu's Balloons!")
    End Sub

End Class
