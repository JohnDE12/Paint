Public Class Form1
    Dim down As Boolean
    Dim brush As New SolidBrush(Color.White)
    Dim shape As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics
        Dim orangePen As New Pen(Color.Orange, 3)
        Dim bluePen As New Pen(Color.Blue, 3)


        draw.DrawEllipse(bluePen, 100, 100, 100, 100)
        draw.DrawLine(bluePen, 155, 200, 165, 350)
        draw.DrawLine(bluePen, 165, 350, 73, 493)
        draw.DrawLine(bluePen, 165, 350, 273, 493)
        draw.DrawLine(bluePen, 157, 237, 67, 419)
        draw.DrawLine(bluePen, 158, 242, 305, 282)
        draw.DrawEllipse(orangePen, 1000, 75, 100, 100)
        draw.DrawLine(orangePen, 1050, 175, 1050, 380)
        draw.DrawLine(orangePen, 1050, 380, 920, 530)
        draw.DrawLine(orangePen, 1050, 380, 1160, 550)
        draw.DrawLine(orangePen, 1050, 215, 880, 265)
        draw.DrawLine(orangePen, 1050, 215, 1145, 390)
        draw.FillEllipse(Brushes.Orange, 700, 230, 100, 100)
        draw.FillEllipse(Brushes.Blue, 390, 275, 100, 100)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = MousePosition.X
        Label2.Text = MousePosition.Y
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        Dim X As Integer = Form1.MousePosition.X - Me.Location.X - 10
        Dim Y As Integer = Form1.MousePosition.Y - Me.Location.Y - 35

        If down Then

            If shape = "ellipse" Then
                draw.FillEllipse(brush, X, Y, 10, 10)
            End If

            If shape = "rectangle" Then
                draw.FillRectangle(brush, X, Y, 10, 10)
            End If
            draw.FillEllipse(brush, X, Y, 10, 10)
            End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        down = False
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        down = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Black.Click
        brush.Color = Color.Black
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Red.Click
        brush.Color = Color.Red
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        brush.Color = Color.OrangeRed
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        brush.Color = Color.Gold
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        brush.Color = Color.ForestGreen
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        brush.Color = Color.Lime
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        brush.Color = Color.DarkBlue
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        brush.Color = Color.Aqua
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        brush.Color = Color.SaddleBrown
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        brush.Color = Color.DeepPink
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim draw As System.Drawing.Graphics
        draw = Me.CreateGraphics

        draw.FillRectangle(Brushes.White, 0, 0, 100000, 100000)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        brush.Color = Color.White
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        shape = "ellipse"
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        shape = "rectangle"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Panel1.Visible = Not Panel1.Visible
    End Sub
End Class
