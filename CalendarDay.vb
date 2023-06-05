Public Class CalendarDay
    Private Sub CalendarDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For hour As Integer = 0 To 23
            For minute As Integer = 0 To 30 Step 30
                Dim time As String = hour.ToString("D2") & ":" & minute.ToString("D2")
                Console.WriteLine(time)

                ' Add the time with appointment text to the ListView
                Dim losdatos As New ListViewItem(time)
                losdatos.SubItems.Add("Agregar una cita")
                ListView1.Items.Add(losdatos)

                ' Set the background color based on the hour
                If hour Mod 2 = 0 Then
                    losdatos.BackColor = Color.LightGray
                Else
                    losdatos.BackColor = Color.White
                End If
            Next
        Next





    End Sub
End Class