'Imports System.Drawing.Drawing2D
'Imports System.Windows.Forms.DataVisualization.Charting

'Public Class Form1
'    Dim nombres(500000) As String
'    Dim codigos(500000) As String

'    Dim lacantidad As Integer = 0

'    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
'        MsgBox(My.Application.Info.DirectoryPath.ToString)
'    End Sub

'    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter

'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        'Dim cn As New ADODB.Connection
'        'Dim rs As New ADODB.Recordset
'        'cn.Open("Provider=Microsoft.jet.oledb.4.0;data source=C:\CS_Papeleria\SYS\cspcsys.csof; Jet OLEDB:Database Password=qOddSyqJp5tyFN6ZRCLT")
'        'Dim sql As String = "SELECT * FROM tblPRODUCTOS WHERE activo=1"
'        'rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
'        'Dim cantidad As Integer = 0
'        'lacantidad = 0
'        'While rs.EOF = False
'        '    nombres(cantidad) = UCase(rs.Fields("nombre").Value.ToString)
'        '    codigos(cantidad) = UCase(rs.Fields("codigo1").Value.ToString)
'        '    cantidad += 1
'        '    rs.MoveNext()
'        'End While
'        'cn.Close()
'        'lacantidad = cantidad
'        'For i As Integer = 0 To 7
'        '    Select Case i
'        '        Case 0
'        '            cd1.Text = codigos(i)
'        '            nm1.Text = nombres(i)
'        '        Case 1
'        '            cd2.Text = codigos(i)
'        '            nm2.Text = nombres(i)
'        '        Case 2
'        '            cd3.Text = codigos(i)
'        '            nm3.Text = nombres(i)
'        '        Case 3
'        '            cd4.Text = codigos(i)
'        '            nm4.Text = nombres(i)
'        '        Case 4
'        '            cd5.Text = codigos(i)
'        '            nm5.Text = nombres(i)
'        '        Case 5
'        '            cd6.Text = codigos(i)
'        '            nm6.Text = nombres(i)
'        '        Case 6
'        '            cd7.Text = codigos(i)
'        '            nm7.Text = nombres(i)
'        '        Case 7
'        '            cd8.Text = codigos(i)
'        '            nm8.Text = nombres(i)
'        '    End Select
'        'Next

'        'Chart2.Titles.Add("Ventas por fecha.")
'    End Sub

'    Dim v1 As Integer = 0
'    Dim v2 As Integer = 0
'    Dim v3 As Integer = 0
'    Dim v4 As Integer = 0
'    Dim v5 As Integer = 0
'    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
'        If v5 > 999 Then
'            Timer2.Enabled = False
'            Exit Sub
'        End If

'        v1 += 0
'        v2 += 0
'        v3 += 3
'        v4 += 7
'        v5 += 10
'        Me.Text = (v5)
'        Chart2.Series.Clear()



'        Dim s As New Series
'        s.Name = "Enero"

'        s.ChartType = SeriesChartType.Line
'        s.Points.AddXY("Enero", 0)
'        s.Points.AddXY("Febrero", 0)
'        s.Points.AddXY("Marzo", 2)
'        s.Points.AddXY("Abril", 7)
'        s.Points.AddXY("Mayo", 10)


'        'Add the series to the Chart1 control.
'        Chart2.Series.Add(s)
'        '     Timer2.Enabled = False
'    End Sub

'    Public Sub DrawLinePoint(ByVal e As PaintEventArgs)

'        ' Create pen.
'        Dim blackPen As New Pen(Color.Black, 3)

'        ' Create points that define line.
'        Dim point1 As New Point(100, 100)
'        Dim point2 As New Point(500, 1000)

'        ' Draw line to screen.
'        e.Graphics.DrawLine(blackPen, point1, point2)
'    End Sub

'    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
'        cd1.Visible = False
'        cd2.Visible = False
'        cd3.Visible = False
'        cd4.Visible = False
'        cd5.Visible = False
'        cd6.Visible = False
'        cd7.Visible = False
'        cd8.Visible = False
'        nm1.Visible = False
'        nm2.Visible = False
'        nm3.Visible = False
'        nm4.Visible = False
'        nm5.Visible = False
'        nm6.Visible = False
'        nm7.Visible = False
'        nm8.Visible = False
'        cd1.Text = ""
'        nm1.Text = ""
'        cd2.Text = ""
'        nm2.Text = ""
'        cd3.Text = ""
'        nm3.Text = ""
'        cd4.Text = ""
'        nm4.Text = ""
'        cd5.Text = ""
'        nm5.Text = ""
'        cd6.Text = ""
'        nm6.Text = ""
'        cd7.Text = ""
'        nm7.Text = ""
'        cd8.Text = ""
'        nm8.Text = ""
'        Dim agregados As Integer = 0
'        For i As Integer = 0 To lacantidad - 1
'            '
'            If (nombres(i).IndexOf(UCase(TextBox1.Text)) = 0) Or (codigos(i).IndexOf(UCase(TextBox1.Text)) = 0) Then

'                Select Case agregados
'                    Case 0

'                        cd1.Text = codigos(i)
'                        cd1.Visible = True
'                        nm1.Visible = True
'                        nm1.Text = nombres(i)
'                    Case 1
'                        cd2.Visible = True
'                        nm2.Visible = True
'                        cd2.Text = codigos(i)
'                        nm2.Text = nombres(i)
'                    Case 2
'                        cd3.Text = codigos(i)
'                        nm3.Text = nombres(i)
'                        cd3.Visible = True
'                        nm3.Visible = True
'                    Case 3
'                        cd4.Text = codigos(i)
'                        nm4.Text = nombres(i)
'                        cd4.Visible = True
'                        nm4.Visible = True
'                    Case 4
'                        cd5.Text = codigos(i)
'                        nm5.Text = nombres(i)
'                        cd5.Visible = True
'                        nm5.Visible = True
'                    Case 5
'                        cd6.Text = codigos(i)
'                        nm6.Text = nombres(i)
'                        cd6.Visible = True
'                        nm6.Visible = True
'                    Case 6
'                        cd7.Text = codigos(i)
'                        nm7.Text = nombres(i)
'                        cd7.Visible = True
'                        nm7.Visible = True
'                    Case 7
'                        cd8.Text = codigos(i)
'                        nm8.Text = nombres(i)
'                        cd8.Visible = True
'                        nm8.Visible = True
'                End Select
'                agregados += 1
'            End If
'        Next i
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        '   Timer1.Enabled = True
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        For i As Integer = 0 To TextBox1.Text.Length - 1
'            SendKeys.Send(TextBox1.Text.Substring(i, 1))
'        Next i
'        SendKeys.Send("{Enter}")
'        Timer1.Enabled = False
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Try
'            Dim valor As Integer = "A"
'        Catch ex As Exception
'            MsgBox(ex.Message)
'            MsgBox(ex.StackTrace)
'        Finally

'        End Try
'        Try
'            IO.File.Open("c:\loco.com", IO.FileMode.Open)
'        Catch ex As Exception
'            MsgBox(ex.Message)
'            MsgBox(ex.StackTrace)
'        Finally

'        End Try


'    End Sub

'    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
'        'Dim greenpen As New Pen(Color.FromArgb(0, 0, 0))
'        'greenpen.Width = 6.0F

'        '' Set the DashCap to round.
'        'greenpen.DashCap = Drawing2D.DashCap.Round

'        '' Create a custom dash pattern.
'        'greenpen.DashPattern = New Single() {4.0F, 2.0F, 1.0F, 3.0F}
'        'e.Graphics.DrawLine(greenpen, New Point(50, 101), New Point(70, 101))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 102), New Point(70, 102))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 103), New Point(70, 103))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 104), New Point(70, 104))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 105), New Point(70, 105))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 106), New Point(70, 106))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 107), New Point(70, 107))
'        'e.Graphics.DrawLine(greenpen, New Point(50, 108), New Point(70, 108))
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        MsgBox(5 Mod 1)
'    End Sub

'    Private Sub Form1_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed

'    End Sub

'    Private Sub Form1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel

'    End Sub
'End Class
