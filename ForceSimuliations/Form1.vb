Public Class Form1

    Dim radiusBall As Integer = 5
    Dim g As Double = 9.8
    Dim x_ball As Double = 0
    Dim roadBallLength As Double = 0

    Dim w As Double = Math.PI * 2 / 10

    Dim bouciness As Double = 0.2

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'x_ball = 50
        'roadBallLength = Canvas.Height - 2 * radiusBall
        'DrawingBall(x_ball, 0)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnReset.PerformClick()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'Dim t As Threading.Thread = New Threading.Thread(AddressOf ThreadWork_G)

        Dim t As Threading.Thread = New Threading.Thread(AddressOf ThreadWork_Cos)

        'Dim t As Threading.Thread = New Threading.Thread(AddressOf ThreadWork_G2)

        t.Start()
    End Sub

    Private Sub DrawingBall(x As Integer, y As Integer)
        Dim bmp As Bitmap
        If Canvas.Image Is Nothing Then
            bmp = New Bitmap(Canvas.Width, Canvas.Height)
        Else
            bmp = Canvas.Image
        End If

        Dim grp As Graphics = Graphics.FromImage(bmp)

        'Dim random As Random = New Random()
        'Dim colorsArray As Array = [Enum].GetValues(GetType(KnownColor))
        'Dim allColors As KnownColor() = New KnownColor(colorsArray.Length) {}
        'Array.Copy(colorsArray, allColors, colorsArray.Length)
        'Dim Color As Color = Color.FromKnownColor(allColors(random.Next(colorsArray.Length)))
        'Dim Brush As SolidBrush = New SolidBrush(Color)

        grp.FillEllipse(Brushes.Black, New Rectangle(x, y, radiusBall * 2, radiusBall * 2))
        grp.Dispose()

        Canvas.Image = bmp
    End Sub

    Private Sub DrawingColorBall(x As Integer, y As Integer)
        Dim bmp As Bitmap
        If Canvas.Image Is Nothing Then
            bmp = New Bitmap(Canvas.Width, Canvas.Height)
        Else
            bmp = Canvas.Image
        End If

        Dim grp As Graphics = Graphics.FromImage(bmp)

        Dim random As Random = New Random()
        Dim colorsArray As Array = [Enum].GetValues(GetType(KnownColor))
        Dim allColors As KnownColor() = New KnownColor(colorsArray.Length) {}
        Array.Copy(colorsArray, allColors, colorsArray.Length)
        Dim Color As Color = Color.FromKnownColor(allColors(random.Next(colorsArray.Length)))
        Dim Brush As SolidBrush = New SolidBrush(Color)

        grp.FillEllipse(Brush, New Rectangle(x, y, radiusBall * 2, radiusBall * 2))
        grp.Dispose()

        Canvas.Image = bmp
    End Sub
    ''' <summary>
    ''' 重力モード
    ''' </summary>
    Private Sub ThreadWork_G()
        Dim s As Double = 0
        Dim t As Integer = 0

        Do Until s = roadBallLength

            DrawingBall(x_ball, s)

            t += 500

            s = g * Math.Pow(t / 1000, 2) * 0.5

            Threading.Thread.Sleep(10)

            Console.WriteLine(s)

            If s >= roadBallLength Then
                s = roadBallLength
                DrawingBall(x_ball, s)

                Console.WriteLine(s)
            End If
        Loop
    End Sub

    ''' <summary>
    '''角モード
    ''' </summary>
    Private Sub ThreadWork_Cos()
        Dim s As Double = 0
        Dim t As Integer = 0
        Dim h As Integer = 100
        Dim old_period As Integer = 0
        Dim period As Integer = 0

        'Do Until h = 0
        Do While True

            'Console.WriteLine("2π={0} wt={1} wt/2π={2} Cos(wt)={3}", Math.PI * 2, w * t, (w * t / 1000) / (Math.PI * 2), Math.Cos((w * t / 1000) Mod (Math.PI * 2)))


            period = Math.Ceiling((w * t / 1000) / (Math.PI * 2)) + 1

            If period <> old_period Then
                'h = h * Math.Pow(1 - bouciness, period)
                Console.WriteLine("Period={0} h={1} ", period, h)
                old_period = period
            End If

            s = h * Math.Cos((w * t / 1000) Mod (Math.PI * 2))

            'If s < 0 Then
            '    s = 0

            '    'h = h * bouciness
            'End If

            DrawingColorBall(x_ball + t / 100, 200 - s)
            'DrawingColorBall(x_ball, 200 - s)

            t += 200

            If t = 135000 Then
                t = 0
            End If


            Threading.Thread.Sleep(20)

            'Console.WriteLine(s)

            'If s >= roadBallLength Then
            '    s = roadBallLength
            '    DrawingBall(x_ball, s)

            '    Console.WriteLine(s)
            'End If
        Loop
    End Sub

    Private Sub ThreadWork_G2()
        Dim t_all As Double = 8.0
        Dim h As Double = g * Math.Pow(t_all, 2) * 0.5

        Dim t As Integer = 0  'Unit:ms
        Dim s As Double = 0

        Dim old_r As Integer = 0

        Do While True



            t = t Mod (t_all * 10000)


            Dim period As Integer = Math.Floor(t / t_all / 1000)
            Dim r As Integer = period Mod 2

            'If r <> old_r Then

            '    old_r = r

            '    If r = 1 Then
            '        h = g * Math.Pow(t_all, 2) * 0.5
            '    End If
            'End If

            'If t = 0 AndAlso period > 0 Then
            '    t_all = t_all * 0.5
            '    h = g * Math.Pow(t_all, 2) * 0.5
            'End If

            'If r = 1 Then

            'End If


            If r = 1 Then
                s = h - g * Math.Pow(t / 1000 Mod t_all, 2) * 0.5
            Else
                s = g * Math.Pow(t / 1000 Mod t_all, 2) * 0.5
            End If


            Console.WriteLine("period={0} r={1} t={2} s={3}", period, r, t, s)
            DrawingBall(x_ball + t / 100, s)

            Threading.Thread.Sleep(10)
            t += 100
        Loop
    End Sub
End Class
