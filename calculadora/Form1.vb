Public Class Form1
    Dim vPrimeiro As Double
    Dim vSinal As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Tbn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn1.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub Tbn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn2.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub Tbn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn3.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub Tbn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn4.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub Tn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn5.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub Tbn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn6.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub Tbn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn7.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub Tbn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn8.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub Tbn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn9.Click
        txtDisplay.Text &= "9"
    End Sub

    Private Sub TbnPonto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnPonto.Click
        If Not txtDisplay.Text.Contains("."c) Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub Tbn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn0.Click
        txtDisplay.Text &= "0"
    End Sub

    Private Sub TbnVirgula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnVirgula.Click
        If Not txtDisplay.Text.Contains(","c) Then
            txtDisplay.Text &= ","
        End If
    End Sub

    Private Sub TbnSomar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSomar.Click
        If Double.TryParse(txtDisplay.Text, vPrimeiro) Then
            txtDisplay.Text = ""
            vSinal = "+"
        End If
    End Sub

    Private Sub TbnSubstrair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnSubtrair.Click
        If Double.TryParse(txtDisplay.Text, vPrimeiro) Then
            txtDisplay.Text = ""
            vSinal = "-"
        End If
    End Sub

    Private Sub TbnMultiplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnMultiplicar.Click
        If Double.TryParse(txtDisplay.Text, vPrimeiro) Then
            txtDisplay.Text = ""
            vSinal = "X"
        End If
    End Sub

    Private Sub TbnDividir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnDividir.Click
        If Double.TryParse(txtDisplay.Text, vPrimeiro) Then
            txtDisplay.Text = ""
            vSinal = "/"
        End If
    End Sub

    Private Sub TbnIgualdade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnIgualdade.Click
        Dim vSegundo As Double
        If Double.TryParse(txtDisplay.Text, vSegundo) Then
            Select Case vSinal
                Case "+"
                    txtDisplay.Text = (vPrimeiro + vSegundo).ToString()
                Case "-"
                    txtDisplay.Text = (vPrimeiro - vSegundo).ToString()
                Case "X"
                    txtDisplay.Text = (vPrimeiro * vSegundo).ToString()
                Case "/"
                    If vSegundo <> 0 Then
                        txtDisplay.Text = (vPrimeiro / vSegundo).ToString()
                    End If
            End Select
        End If
    End Sub

    Private Sub TbnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbnLimpar.Click
        txtDisplay.Text = ""
        vSinal = ""
        vPrimeiro = 0
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Add
                tbnSomar.PerformClick()
            Case Keys.Subtract
                tbnSubtrair.PerformClick()
            Case Keys.Multiply
                tbnMultiplicar.PerformClick()
            Case Keys.Divide
                tbnDividir.PerformClick()
            Case Keys.Enter
                e.Handled = True
                e.SuppressKeyPress = True
                tbnIgualdade.PerformClick()
            Case Keys.Escape
                tbnLimpar.PerformClick()
        End Select
    End Sub

    Private Sub TxtDisplay_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDisplay.KeyPress
        Dim charsPermitidos As String = "0123456789.,+-*/"

        If Not charsPermitidos.Contains(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class
