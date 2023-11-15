Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim c As Double
        c = CDbl(TextBox2.Text)
        TextBox3.Text = objConv.cToF(c)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim c As Double
        c = CDbl(TextBox2.Text)
        TextBox1.Text = objConv.cToR(c)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim c As Double
        c = CDbl(TextBox2.Text)
        TextBox4.Text = objConv.cToK(c)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim r As Double
        r = CDbl(TextBox6.Text)
        TextBox7.Text = objConv.rToC(r)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim r As Double
        r = CDbl(TextBox6.Text)
        TextBox5.Text = objConv.rToF(r)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim r As Double
        r = CDbl(TextBox6.Text)
        TextBox8.Text = objConv.rToK(r)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim f As Double
        f = CDbl(TextBox10.Text)
        TextBox11.Text = objConv.fToC(f)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim f As Double
        f = CDbl(TextBox10.Text)
        TextBox9.Text = objConv.fToR(f)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim f As Double
        f = CDbl(TextBox10.Text)
        TextBox12.Text = objConv.fToK(f)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim k As Double
        k = CDbl(TextBox14.Text)
        TextBox16.Text = objConv.fToK(k)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim k As Double
        k = CDbl(TextBox14.Text)
        TextBox15.Text = objConv.fToK(k)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim objConv As New TempConvComp.TempConvComp
        Dim k As Double
        k = CDbl(TextBox14.Text)
        TextBox13.Text = objConv.fToK(k)
    End Sub
End Class

