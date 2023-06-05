Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class ReporteVenta
    Inherits Form




    Private connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\CS_Papeleria\SYS\cspcsys.csof;Persist Security Info=False;"

    Public Sub New()
        InitializeComponents()
    End Sub

    Private Sub InitializeComponents()
        datePicker.Location = New Point(10, 10)
        Controls.Add(datePicker)

        btnGenerarReporte.Location = New Point(150, 10)
        btnGenerarReporte.Text = "Generar Reporte"
        Controls.Add(btnGenerarReporte)

        reporteTable.Location = New Point(10, 50)
        reporteTable.Size = New Size(ClientSize.Width - 20, ClientSize.Height - 60)
        reporteTable.ReadOnly = True
        reporteTable.AllowUserToAddRows = False
        Controls.Add(reporteTable)

        Text = "Reporte de Ventas"
    End Sub

    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click
        Dim startDate As DateTime = datePicker.Value.Date
        Dim endDate As DateTime = datePicker.Value.Date

        Dim query As String = $"SELECT id, nventa, fecha, tventa FROM tblventa WHERE fecha >= #{startDate.ToShortDateString}# AND fecha <= #{endDate.ToShortDateString}# AND activo = 1"

        Using connection As New OleDbConnection(connectionString)
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            reporteTable.DataSource = table
        End Using
    End Sub
End Class
