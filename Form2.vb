Public Class Form2

    Dim tap As Double = 2
    Dim cant As Double = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' MsgBox(((cant / tap) Mod 1))



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim monto As Double = 96
        Dim medio As Double = 5.0


        Dim a1 As Integer

        a1 = monto / 0.5
        If CInt(a1) Mod 2 = 0 Then
            monto = ((a1 + 1) * 0.5)
        Else
            monto = ((a1) * 0.5)
        End If


        MsgBox(monto)
        '  MsgBox(Math.Round(monto, 2, MidpointRounding.ToEven))




        '  tmpmonto = tmpmonto * ptdec
        'Dim tt As Double = Math.Round(to_round, 2)
        'Dim dec As Double = tt - Int(tt)
        'dec = dec * 100
        'Select Case dec
        '    Case 0 To 10
        '        Return Int(to_round)
        '    Case 10 To 60
        '        Return Int(to_round) + 0.5
        '    Case 60 To 99
        '        Return Int(to_round) + 1
        '    Case Else
        '        Return to_round
        'End Select
        ' Dim indexOfPuntoDecimal As Integer = numeroAsString.IndexOf(System.Globalization.CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator)

    End Sub
End Class