Public Class Form1
    Sub red()
        Me.btn1.BackColor = Color.Red

        Me.btn2.BackColor = Color.DarkGray
        Me.btn3.BackColor = Color.DarkGray
    End Sub
    Sub yellow()
        Me.btn2.BackColor = Color.Yellow
        Me.btn1.BackColor = Color.DarkGray
        Me.btn3.BackColor = Color.DarkGray
    End Sub
    Sub blue()
        Me.btn1.BackColor = Color.DarkGray
        Me.btn2.BackColor = Color.DarkGray
        Me.btn3.BackColor = Color.Blue
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        Me.timer1.Start()
        Me.timer1.Interval = 1000
        Me.lbltext.Text = Microsoft.VisualBasic.Right(Me.lbltext.Text, Len(Me.lbltext.Text) - 1)
        If Len(Me.lbltext.Text) >= 39 Then
            Call blue()
            Me.button1.Text = Len(Me.lbltext.Text) - 9
        ElseIf Len(Me.lbltext.Text) >= 10 Then
            Call blue()
            Me.button1.Text = Len(Me.lbltext.Text) - 9
        ElseIf Len(Me.lbltext.Text) >= 5 Then
            Call yellow()
            Me.button1.Text = Len(Me.lbltext.Text) - 4
        ElseIf Len(Me.lbltext.Text) >= 1 Then
            Call red()
            Me.button1.Text = Len(Me.lbltext.Text)
        ElseIf Me.lbltext.Text = "" Then
            Me.lbltext.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btn1.BackColor = Color.DarkGray
        Me.btn2.BackColor = Color.DarkGray
        Me.btn3.BackColor = Color.DarkGray
        Me.lbltext.Visible = True
    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
    End Sub
    Private Sub lbltext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltext.Click
        Me.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub
End Class
