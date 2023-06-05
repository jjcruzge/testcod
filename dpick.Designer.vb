<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dpick
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.startTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.endTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSelectRange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(10, 10)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 0
        '
        'startTimePicker
        '
        Me.startTimePicker.CustomFormat = "HH:mm"
        Me.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startTimePicker.Location = New System.Drawing.Point(190, 190)
        Me.startTimePicker.Name = "startTimePicker"
        Me.startTimePicker.ShowUpDown = True
        Me.startTimePicker.Size = New System.Drawing.Size(70, 20)
        Me.startTimePicker.TabIndex = 1
        '
        'endTimePicker
        '
        Me.endTimePicker.CustomFormat = "HH:mm"
        Me.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endTimePicker.Location = New System.Drawing.Point(290, 190)
        Me.endTimePicker.Name = "endTimePicker"
        Me.endTimePicker.ShowUpDown = True
        Me.endTimePicker.Size = New System.Drawing.Size(70, 20)
        Me.endTimePicker.TabIndex = 2
        '
        'btnSelectRange
        '
        Me.btnSelectRange.Location = New System.Drawing.Point(10, 190)
        Me.btnSelectRange.Name = "btnSelectRange"
        Me.btnSelectRange.Size = New System.Drawing.Size(120, 23)
        Me.btnSelectRange.TabIndex = 3
        Me.btnSelectRange.Text = "Seleccionar Rango"
        Me.btnSelectRange.UseVisualStyleBackColor = True
        '
        'dpick
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 220)
        Me.Controls.Add(Me.btnSelectRange)
        Me.Controls.Add(Me.endTimePicker)
        Me.Controls.Add(Me.startTimePicker)
        Me.Controls.Add(Me.calendar)
        Me.Name = "dpick"
        Me.Text = "Selector de Fechas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents startTimePicker As DateTimePicker
    Friend WithEvents endTimePicker As DateTimePicker
    Friend WithEvents btnSelectRange As Button

End Class
