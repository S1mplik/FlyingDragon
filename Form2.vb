Public Class Form2
    Dim gravity As Integer = 0
    Dim speed As Integer = 2
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left += 1
        If PictureBox1.Left >= Me.Height Then
            PictureBox1.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox5.Height
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Left += 2
        If PictureBox2.Left >= Me.Height Then
            PictureBox2.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox4.Height
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()
        Timer8.Start()
        gravitys.Start()


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox3.Left += 3
        If PictureBox3.Left >= Me.Height Then
            PictureBox3.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox6.Height
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox4.Left += 4
        If PictureBox4.Left >= Me.Height Then
            PictureBox4.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox1.Height
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        PictureBox5.Left += 5
        If PictureBox5.Left >= Me.Height Then
            PictureBox5.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox2.Height
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        PictureBox6.Left += 6
        If PictureBox6.Left >= Me.Height Then
            PictureBox6.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox3.Height
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        PictureBox7.Left += 7
        If PictureBox7.Left >= Me.Height Then
            PictureBox7.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox8.Height
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        PictureBox8.Left += 8
        If PictureBox8.Left >= Me.Height Then
            PictureBox8.Left = CInt(Math.Ceiling(Rnd() * 150)) + PictureBox7.Height
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles Drak.Click

    End Sub

    Private Sub PictureBox9_KeyUp(sender As Object, e As KeyEventArgs) Handles Drak.KeyUp

    End Sub

    Private Sub UPMOVER_Tick(sender As Object, e As EventArgs) Handles UPMOVER.Tick

    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If e.KeyCode = Keys.Down Then
            Drak.Top += 5
        End If
        If e.KeyCode = Keys.Left Then
            Drak.Left -= 5
        End If
        If e.KeyCode = Keys.Right Then
            Drak.Left += 5
        End If

        If e.KeyCode = Keys.Space Then
            Drak.Top -= 5
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_Enter(sender As Object, e As EventArgs) Handles PictureBox5.Enter
        If Drak.Location = PictureBox5.Location Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Drak.Location = PictureBox5.Location Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub gameend_Tick(sender As Object, e As EventArgs) Handles gameend.Tick



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Drak_Move(sender As Object, e As EventArgs) Handles Drak.Move

    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If PictureBox1.Location = Drak.Location Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

    Private Sub gravitys_Tick(sender As Object, e As EventArgs) Handles gravitys.Tick
        speed += gravity
        Drak.Top += speed

    End Sub
End Class