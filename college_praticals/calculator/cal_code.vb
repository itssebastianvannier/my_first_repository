Public Class Form1
    Dim c As Double = 0
    Dim cn As Double = 0
    Dim ans As Double = 0
    Dim num(200) As String
    Dim ca As Integer = 0
    Dim cd As Double = 0
    Dim c0 As Double = 0
    Dim sc As Double = 0
    Dim k As String
    Dim l As String

    
    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click
        If (cd = 0 And (cn > 0 Or c0 > 0)) Then
            btna2.Text = btna2.Text & sender.Text
            cd = cd + 1
            If (c >= 1) Then
                num(ca) = num(ca) & "."
            ElseIf (c = 0) Then
                num(ca) = num(ca) & "."
            End If
        End If
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        btna.Text = ""
        c = 0
        ans = 0
        For i As Integer = 0 To 200
            num(i) = ""
        Next
        btna2.Text = ""
        ca = 0
        cd = 0
        c0 = 0
        cn = 0
        sc = 0
    End Sub

    Private Sub btnstar_Click(sender As Object, e As EventArgs) Handles btnstar.Click, btnplus.Click, btnminus.Click, btndiv.Click
        If (c >= 1) Then
            If (k = "+") Then
                ans = Val(ans + Val(num(ca)))
            ElseIf (k = "-") Then
                ans = Val(ans - Val(num(ca)))
            ElseIf (k = "*") Then
                ans = Val(ans * Val(num(ca)))
            ElseIf (k = "/") Then
                ans = Val(ans / Val(num(ca)))
            End If
            k = sender.text
            btna2.Text = btna2.Text & sender.Text
            ca = ca + 1
            num(ca) = sender.text
            ca = ca + 1
            btna.Text = ans
        End If
        If ((c0 > 0 Or cn > 0) And sc = 0) Then
            ans = Val(num(ca))
            btna2.Text = btna2.Text & sender.Text
            ca = ca + 1
            num(ca) = sender.text
            ca = ca + 1
            k = sender.text
            c = c + 1
            sc = 1
            cd = 0
            cn = 0
            c0 = 0
        End If
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        If (c > 0) Then
            c = 0
            sc = 0
            If (k = "+") Then
                ans = Val(ans + Val(num(ca)))
            ElseIf (k = "-") Then
                ans = Val(ans - Val(num(ca)))
            ElseIf (k = "*") Then
                ans = Val(ans * Val(num(ca)))
            ElseIf (k = "/") Then
                ans = Val(ans / Val(num(ca)))
            End If
            btna.Text = ans
            ca = ca + 1
        End If
        btna.Text = ans
        btna2.Text = ans
        For i As Integer = 1 To 200
            num(i) = ""
        Next
        num(0) = ans
        ca = 0
        cd = 0
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If (c >= 1) Then
            num(ca) = num(ca) & sender.text
        ElseIf (c = 0) Then
            num(ca) = num(ca) & sender.text
        End If
        btna2.Text = btna2.Text & sender.Text
        cn = cn + 1
    End Sub

    Private Sub btn0_Click_1(sender As Object, e As EventArgs) Handles btn0.Click
        If (c >= 1) Then
            num(ca) = num(ca) & sender.text
        ElseIf (c = 0) Then
            num(ca) = num(ca) & sender.text
        End If
        If (cn = 0 And c0 = 1) Then

        Else
            btna2.Text = btna2.Text & sender.Text
            c0 = c0 + 1
        End If
    End Sub

    Private Sub btn7_KeyDown(sender As Object, e As KeyEventArgs) Handles btn0.KeyDown, btn1.KeyDown, btn2.KeyDown, btn3.KeyDown, btn0.KeyDown, btn4.KeyDown, btn5.KeyDown, btn6.KeyDown, btn7.KeyDown, btn8.KeyDown, btn9.KeyDown, btnstar.KeyDown, btna.KeyDown, btna2.KeyDown, btndiv.KeyDown, btndot.KeyDown, btnequal.KeyDown, btnminus.KeyDown, btnplus.KeyDown
        If e.KeyCode = Keys.NumPad0 Then
            btn0.PerformClick()
        ElseIf e.KeyCode = Keys.Decimal Then
            btndot.PerformClick()
        ElseIf e.KeyCode = Keys.Multiply Then
            btnstar.PerformClick()
        ElseIf e.KeyCode = Keys.Subtract Then
            btnminus.PerformClick()
        ElseIf e.KeyCode = Keys.Divide Then
            btndiv.PerformClick()
        ElseIf e.KeyCode = Keys.Add Then
            btnplus.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnequal.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad1 Then
            btn1.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad2 Then
            btn2.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad3 Then
            btn3.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad4 Then
            btn4.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad5 Then
            btn5.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad6 Then
            btn6.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad7 Then
            btn7.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad8 Then
            btn8.PerformClick()
        ElseIf e.KeyCode = Keys.NumPad9 Then
            btn9.PerformClick()
        ElseIf e.KeyCode = Keys.Clear Then
            btnc.PerformClick()
        End If
    End Sub
End Class
