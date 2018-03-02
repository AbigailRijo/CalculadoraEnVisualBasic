Public Class Form1
    Dim operacionInicializada As Boolean = False
    Dim operacion As String = ""
    Dim numero1 As String = ""
    Dim numero2 As String = ""
    Dim resultadoAsignado As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeroSeleccionado As String = "1"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numeroSeleccionado As String = "2"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim numeroSeleccionado As String = "3"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim numeroSeleccionado As String = "4"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim numeroSeleccionado As String = "5"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim numeroSeleccionado As String = "6"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim numeroSeleccionado As String = "7"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim numeroSeleccionado As String = "8"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim numeroSeleccionado As String = "9"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim numeroSeleccionado As String = "0"
        AsignarValor(numeroSeleccionado)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        operacion = "Sumar"
        AsignarOperacion()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        operacion = "Restar"
        AsignarOperacion()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        operacion = "Multiplicar"
        AsignarOperacion()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        operacion = "Dividir"
        AsignarOperacion()
    End Sub

    Private Sub AsignarValor(numero As String)
        If (operacionInicializada) Then
            numero2 += numero
            TextBox1.Text += numero
        Else
            If (resultadoAsignado) Then
                resultadoAsignado = False
                numero1 = numero
                TextBox1.Text = numero
            Else
                numero1 += numero
                TextBox1.Text += numero
            End If
        End If
    End Sub

    Private Sub AsignarOperacion()
        If (operacionInicializada) Then
            If (numero1 <> "") Then
                TextBox1.Text = numero1
                If (operacion = "Sumar") Then
                    TextBox1.Text += " + "
                ElseIf (operacion = "Restar") Then
                    TextBox1.Text += " - "
                ElseIf (operacion = "Multiplicar") Then
                    TextBox1.Text += " * "
                ElseIf (operacion = "Dividir") Then
                    TextBox1.Text += " / "
                End If
                If (numero2 <> "") Then
                    TextBox1.Text += numero2
                End If
            End If
        Else
            operacionInicializada = True
            If (numero1 <> "") Then
                TextBox1.Text = numero1
                If (operacion = "Sumar") Then
                    TextBox1.Text += " + "
                ElseIf (operacion = "Restar") Then
                    TextBox1.Text += " - "
                ElseIf (operacion = "Multiplicar") Then
                    TextBox1.Text += " * "
                ElseIf (operacion = "Dividir") Then
                    TextBox1.Text += " / "
                End If
            End If
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If (numero1 <> "") Then
            If (numero2 <> "") Then
                Dim resultado As Decimal
                Dim miNumero1 As Decimal = Convert.ToDecimal(numero1)
                Dim miNumero2 As Decimal = Convert.ToDecimal(numero2)

                If (operacion = "Sumar") Then
                    resultado = miNumero1 + numero2
                ElseIf (operacion = "Restar") Then
                    resultado = miNumero1 - numero2
                ElseIf (operacion = "Multiplicar") Then
                    resultado = miNumero1 * numero2
                ElseIf (operacion = "Dividir") Then
                    resultado = miNumero1 / numero2
                End If
                TextBox1.Text = resultado.ToString
                numero1 = resultado.ToString
                resultadoAsignado = True
            End If
        End If
        operacionInicializada = False
        operacion = ""
        numero2 = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        operacionInicializada = False
        resultadoAsignado = False
        operacion = ""
        numero1 = ""
        numero2 = ""
    End Sub
End Class
