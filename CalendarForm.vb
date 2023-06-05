Imports System.Windows.Forms

Public Class CalendarForm
    Inherits Form
    Private GroupBoxes As List(Of GroupBox)

    Private Sub CalendarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hide_con()
        cbMes.SelectedIndex = Now.Month - 1
        cbAno.Text = Now.Year
        GroupBoxes = New List(Of GroupBox) From
                                        {g11, g12, g13, g14, g15,
                                         g16, g17, g21, g22, g23,
                                         g24, g25, g26, g27, g31,
                                         g32, g33, g34, g35, g36,
                                         g37, g41, g42, g43, g44,
                                         g45, g46, g47, g51, g52,
                                         g53, g54, g55, g56, g57,
                                         g61, g62, g63, g64, g65,
                                         g66, g67}
        Set_Day(Now.Month - 1, Now.Year)




    End Sub



    Private Sub Set_Day(ByVal mon As Integer, ByVal yea As Integer)
        hide_con()
        Dim year As Integer = yea ' Reemplaza con el año deseado
        Dim month As Integer = mon + 1 ' Reemplaza con el mes deseado
        Dim firstDayOfMonth As New DateTime(year, month, 1)
        Dim dayOfWeekNumber As Integer = firstDayOfMonth.DayOfWeek
        Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month) '  MsgBox(firstDayOfMonth.DayOfWeek.ToString() + "  Day of the week:  " & dayOfWeekNumber.ToString() & " - " & daysInMonth.ToString())
        For i As Integer = dayOfWeekNumber To dayOfWeekNumber + daysInMonth - 1
            Dim day As Integer = i - dayOfWeekNumber + 1
            Set_Btn(i, day)
        Next i


    End Sub

    Private Sub Set_Btn(ByVal pos As Integer, ByVal dia As Integer)
        If pos < GroupBoxes.Count Then
            Dim gb As GroupBox = GroupBoxes(pos)
            Show_Con(gb, dia.ToString())
        End If
    End Sub

    Private Sub Show_Con(ByVal gb As GroupBox, ByVal text As String)
        gb.Text = text
    End Sub

    Private Sub hide_con()
        Try
            For Each igb As GroupBox In GroupBoxes
                igb.Text = ""
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMes.SelectedIndexChanged
        On Error Resume Next
        Set_Day(CInt(cbMes.SelectedIndex), CInt(cbAno.Text))
    End Sub

    Private Sub cbAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAno.SelectedIndexChanged
        On Error Resume Next
        Set_Day(CInt(cbMes.SelectedIndex), CInt(cbAno.Text))
    End Sub


End Class