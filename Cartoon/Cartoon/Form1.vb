Public Class frmMain
    Dim g As Graphics
    Dim p As Pen
    Dim b As SolidBrush

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick

        b = New SolidBrush(Color.FromArgb(44, 64, 88))

        g = picbox1.CreateGraphics
        'dashline
        p = New Pen(Color.FromArgb(125, 128, 121), 3)
        p.DashStyle = Drawing2D.DashStyle.Dash
        g.DrawLine(p, 280, 280, picbox1.Width, 280)
        'body
        p = New Pen(Color.FromArgb(196, 220, 206), 1)

        b = New SolidBrush(Color.FromArgb(196, 220, 206))

        g.FillRectangle(b, 0, 234, 50, 295)

        Dim p1, p2, p3, p4, p5 As Point

        p1 = New Point(0, 224)

        p2 = New Point(25, 234)

        p3 = New Point(0, 234)

        p4 = New Point(50, 529)

        p5 = New Point(0, 529)

        Dim curve As Point()

        curve = New Point() {p1, p2, p3, p1}

        g.FillClosedCurve(b, curve)

        Dim r As Rectangle

        r = New Rectangle(25, 180, 110, 115)

        g.FillPie(b, r, 0, -180)

        g.FillPie(b, 100, 220, 200, 260, 100, -200)

        p2 = New Point(134, 237)

        p1 = New Point(189, 220)

        p3 = New Point(189, 237)

        curve = New Point() {p1, p2, p3, p1}

        g.FillClosedCurve(b, curve)

        g.FillPie(b, -20, 345, 300, 150, 0, 180)

        g.FillRectangle(b, 50, 234, 150, 200)

        'ears
        g.FillPie(b, 35, 160, 40, 80, -90, -130)
        g.FillPie(b, 35, 160, 40, 80, -90, 130)
        g.FillPie(b, 85, 160, 40, 80, -90, -130)
        g.FillPie(b, 85, 160, 40, 80, -90, 130)


        b = New SolidBrush(Color.FromArgb(72, 90, 110))
        p = New Pen(Color.FromArgb(72, 90, 110))
        'eye

        g.DrawEllipse(p, 72, 283, 11, 11)

        g.FillEllipse(b, 72, 283, 11, 11)

        'nostrills

        g.DrawEllipse(p, 215, 255, 14, 14)

        g.FillEllipse(b, 215, 255, 14, 14)

        g.DrawEllipse(p, 190, 255, 14, 14)

        g.FillEllipse(b, 190, 255, 14, 14)

        'mouth
        p.Width = 4
        g.DrawArc(p, 230, 417, 50, 35, 190, -130)

        'cheek
        p = New Pen(Color.FromArgb(149, 171, 158))
        b = New SolidBrush(Color.FromArgb(149, 171, 158))
        g.DrawEllipse(p, 70, 311, 19, 19)
        g.FillEllipse(b, 70, 311, 19, 19)

        'yellowbird 
        p = New Pen(Color.FromArgb(126, 131, 135), 2.5)
        g.DrawLine(p, 189, 209, 189, 222)
        g.DrawLine(p, 197, 209, 197, 222)
        b = New SolidBrush(Color.FromArgb(126, 131, 135))
        p1 = New Point(217, 189)
        p2 = New Point(228, 193)
        p3 = New Point(217, 198)
        curve = New Point() {p1, p2, p3}
        g.FillPolygon(b, curve)

        b = New SolidBrush(Color.FromArgb(241, 222, 130))

        g.FillEllipse(b, 170, 175, 50, 40)
        p1 = New Point(150, 190)
        p2 = New Point(168, 205)
        p3 = New Point(185, 211)
        p4 = New Point(185, 178)
        p5 = New Point(163, 193)
        curve = New Point() {p1, p2, p3, p4, p5, p1}
        p = New Pen(Color.FromArgb(241, 222, 130), 2)
        g.DrawCurve(p, curve)
        g.FillClosedCurve(b, curve)

        b = New SolidBrush(Color.FromArgb(126, 131, 135))
        g.FillEllipse(b, 204, 185, 5, 5)


        '     wing
        b = New SolidBrush(Color.FromArgb(205, 205, 203))
        g.FillEllipse(b, 177, 193, 20, 14)
        p1 = New Point(171, 193)
        p2 = New Point(176, 201)
        p3 = New Point(180, 203)
        p4 = New Point(182, 195)
        p5 = New Point(178, 196)
        curve = New Point() {p1, p2, p3, p4, p5, p1}
        p = New Pen(Color.FromArgb(205, 205, 203), 2)
        g.DrawCurve(p, curve)
        g.FillClosedCurve(b, curve)


        'greybird
        p = New Pen(Color.FromArgb(126, 131, 135), 2.5)
        g.DrawLine(p, 307, 523, 300, 537)
        g.DrawLine(p, 300, 537, 293, 533)
        g.DrawLine(p, 318, 522, 323, 540)
        g.DrawLine(p, 323, 540, 314, 537)



        b = New SolidBrush(Color.FromArgb(178, 175, 166))

        g.FillEllipse(b, 280, 485, 50, 40)
        p1 = New Point(355, 502)
        p2 = New Point(337, 514)
        p3 = New Point(315, 521)
        p4 = New Point(319, 490)
        p5 = New Point(342, 505)
        curve = New Point() {p1, p2, p3, p4, p5, p1}
        p = New Pen(Color.FromArgb(178, 175, 166), 2)
        g.DrawCurve(p, curve)
        g.FillClosedCurve(b, curve)


        b = New SolidBrush(Color.FromArgb(126, 131, 135))
        p1 = New Point(282, 499)
        p2 = New Point(270, 503)
        p3 = New Point(282, 508)
        curve = New Point() {p1, p2, p3}
        g.FillPolygon(b, curve)
        g.FillEllipse(b, 289, 495, 5, 5)

        '     wing slow en easy
        b = New SolidBrush(Color.FromArgb(252, 223, 183))
        g.FillEllipse(b, 305, 502, 20, 14)
        p1 = New Point(332, 502)
        p2 = New Point(324, 512)
        p3 = New Point(318, 512)
        p4 = New Point(319, 504)
        p5 = New Point(325, 506)
        curve = New Point() {p1, p2, p3, p4, p5, p1}
        p = New Pen(Color.FromArgb(252, 223, 183), 2)
        g.DrawCurve(p, curve)
        g.FillClosedCurve(b, curve)

        'birds
        p = New Pen(Color.FromArgb(86, 90, 91), 2.5)
        g.DrawArc(p, 160, 70, 40, 40, -110, 115)
        g.DrawArc(p, 200, 70, 40, 40, 180, 115)

        g.DrawArc(p, 210, 50, 40, 40, -110, 115)
        g.DrawArc(p, 250, 50, 40, 40, 180, 115)

        'coral cloud
        b = New SolidBrush(Color.FromArgb(244, 121, 116))
        g.FillEllipse(b, -10, 50, 60, 30)
        g.FillEllipse(b, 10, 30, 50, 50)
        g.FillEllipse(b, 15, 75, 30, 30)
        g.FillEllipse(b, 35, 45, 75, 40)
        g.FillEllipse(b, 40, 60, 30, 50)
        g.FillEllipse(b, 50, 30, 45, 60)
        g.FillPie(b, 65, 70, 40, 40, -50, 360)

        'pink cloud
        b = New SolidBrush(Color.FromArgb(254, 222, 184))

        g.FillEllipse(b, 307, 80, 75, 50)
        g.FillPie(b, 300, 107, 60, 40, 70, 360)
        g.FillPie(b, 270, 90, 40, 40, 50, 360)
        g.FillPie(b, 285, 75, 30, 30, 25, 330)
        g.FillEllipse(b, 299, 70, 40, 50)
        g.FillPie(b, 330, 70, 30, 30, 25, 330)


        tmr.Enabled = False

    End Sub

End Class
