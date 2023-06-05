Public Class Schedule
    'Private Sub Schedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ' Configurar el DataGridView para mostrar los intervalos de tiempo
    '    Dim timeIntervals As New List(Of String)()
    '    Dim startTime As DateTime = DateTime.Today.AddHours(8) ' Hora de inicio: 8:00 AM
    '    Dim endTime As DateTime = DateTime.Today.AddHours(17) ' Hora de finalización: 5:00 PM

    '    While startTime <= endTime
    '        timeIntervals.Add(startTime.ToString("hh:mm tt"))
    '        startTime = startTime.AddMinutes(30) ' Incrementar en intervalos de 30 minutos
    '    End While

    '    dataGridViewSchedule.ColumnCount = 1
    '    dataGridViewSchedule.Columns(0).HeaderText = "Hora"
    '    dataGridViewSchedule.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    dataGridViewSchedule.Rows.Add(timeIntervals.Count)

    '    For i As Integer = 0 To timeIntervals.Count - 1
    '        dataGridViewSchedule.Rows(i).Cells(0).Value = timeIntervals(i)
    '    Next i
    'End Sub

    '' Evento de clic para programar la cita
    'Private Sub buttonSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim selectedDate As DateTime = dateTimePicker.Value

    '    ' Obtener la hora seleccionada
    '    Dim selectedRow As DataGridViewRow = dataGridViewSchedule.SelectedRows(0)
    '    Dim selectedTime As String = selectedRow.Cells(0).Value.ToString()

    '    ' Aquí puedes agregar el código para programar la cita en la fecha y hora seleccionadas
    '    ' Por ejemplo, puedes mostrar un mensaje con los detalles de la cita programada

    '    MessageBox.Show("Cita programada para el " & selectedDate.ToString("dd/MM/yyyy") & " a las " & selectedTime)
    'End Sub
End Class