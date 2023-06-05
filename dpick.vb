Imports System.Linq

Public Class Dpick
    Private selectedDates As New List(Of DateTime)()
    Private WithEvents btnClear As New Button()

    Private Sub calendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles calendar.DateSelected
        Dim selectedDate As DateTime = e.Start
        If Not selectedDates.Contains(selectedDate) Then
            selectedDates.Add(selectedDate)
            calendar.AddBoldedDate(selectedDate)
            calendar.UpdateBoldedDates()
        End If
    End Sub
    Private Sub Dpick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.Location = New Point(10, 10) ' Ajusta la ubicación del control
        calendar.Size = New Size(ClientSize.Width - 20, ClientSize.Height - 20) ' Ajusta el tamaño del control
        Controls.Add(calendar) ' Agrega el control al formulario
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        selectedDates.Clear()
        calendar.RemoveAllBoldedDates()
        calendar.UpdateBoldedDates()
    End Sub

    Private Sub btnSelectRange_Click(sender As Object, e As EventArgs) Handles btnSelectRange.Click
        If selectedDates.Count > 0 Then
            Dim startDate As DateTime = selectedDates.Min()
            Dim endDate As DateTime = selectedDates.Max()

            Dim startTime As TimeSpan = startTimePicker.Value.TimeOfDay
            Dim endTime As TimeSpan = endTimePicker.Value.TimeOfDay

            Dim startDateTime As DateTime = startDate.Date.Add(startTime)
            Dim endDateTime As DateTime = endDate.Date.Add(endTime)

            Dim selectedRange As New Tuple(Of DateTime, DateTime)(startDateTime, endDateTime)

            ' Realizar cualquier acción adicional con el rango de fechas y horas seleccionado
            MessageBox.Show("Selected Range: " & selectedRange.Item1.ToString() & " - " & selectedRange.Item2.ToString())
        Else
            MessageBox.Show("No dates selected.")
        End If
    End Sub
End Class
