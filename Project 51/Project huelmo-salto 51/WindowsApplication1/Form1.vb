Public Class Calculator

    Dim Operacion As String
    Dim Num As Nullable(Of Double) = Nothing
    Dim Num2 As Nullable(Of Double) = Nothing
    Dim PresionaOperador As Boolean




    Private Sub TXT1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT1.TextChanged

    End Sub

    Private Sub BTN1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Concatena()
        TXT1.Text &= "1"
    End Sub

    Private Sub BTN2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Concatena()
        TXT1.Text &= "2"
    End Sub

    Private Sub BTN3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Concatena()
        TXT1.Text &= "3"
    End Sub

    Private Sub BTN4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        Concatena()
        TXT1.Text &= "4"
    End Sub

    Private Sub BTN5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Concatena()
        TXT1.Text &= "5"
    End Sub

    Private Sub BTN6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        Concatena()
        TXT1.Text &= "6"
    End Sub

    Private Sub BTN7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        Concatena()
        TXT1.Text &= "7"
    End Sub

    Private Sub BTN8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        Concatena()
        TXT1.Text &= "8"
    End Sub


    Private Sub BTN9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        Concatena()
        TXT1.Text &= "9"
    End Sub

    Private Sub BTN10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        Concatena()
        TXT1.Text &= "0"
    End Sub

    Private Sub sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sum.Click
        HaceOperacion()
        Operacion = "+"
    End Sub

    Private Sub res_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles res.Click
        HaceOperacion()
        Operacion = "-"
    End Sub

    Private Sub mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mul.Click
        HaceOperacion()
        Operacion = "*"
    End Sub

    Private Sub div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles div.Click
        HaceOperacion()
        Operacion = "/"
    End Sub

    Private Sub igual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles igual.Click
        HaceOperacion()
        Operacion = ""
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnborrar.Click

        Num = Nothing
        Num2 = Nothing
        TXT1.Text = ""

    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        Concatena()
        If InStr(TXT1.Text, ".", CompareMethod.Text) = 0 Then
            TXT1.Text &= "."
        End If
    End Sub

    Public Sub HaceOperacion()
        PresionaOperador = True
        Num2 = Val(TXT1.Text)
        If Num IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    Num += Num2
                Case "-"
                    Num -= Num2
                Case "*"
                    Num *= Num2
                Case "/"
                    Num /= Num2
            End Select
            TXT1.Text = Num
        Else
            Num = Num2
        End If

    End Sub

    Public Sub Concatena()
        If PresionaOperador = True Then
            TXT1.Text = ""
            PresionaOperador = False
        ElseIf TXT1.Text = "0" Then
            TXT1.Text = ""

        End If
    End Sub

End Class
