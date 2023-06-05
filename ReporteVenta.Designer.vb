<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteVenta
    Inherits System.Windows.Forms.Form

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.datePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.reporteTable = New System.Windows.Forms.DataGridView()
        CType(Me.reporteTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datePicker
        '
        Me.datePicker.Location = New System.Drawing.Point(10, 10)
        Me.datePicker.Name = "datePicker"
        Me.datePicker.Size = New System.Drawing.Size(200, 20)
        Me.datePicker.TabIndex = 0
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(230, 10)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(100, 23)
        Me.btnGenerarReporte.TabIndex = 1
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'reporteTable
        '
        Me.reporteTable.AllowUserToAddRows = False
        Me.reporteTable.AllowUserToDeleteRows = False
        Me.reporteTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reporteTable.Location = New System.Drawing.Point(10, 50)
        Me.reporteTable.Name = "reporteTable"
        Me.reporteTable.ReadOnly = True
        Me.reporteTable.Size = New System.Drawing.Size(320, 200)
        Me.reporteTable.TabIndex = 2
        '
        'ReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 262)
        Me.Controls.Add(Me.reporteTable)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Controls.Add(Me.datePicker)
        Me.Name = "ReporteVenta"
        Me.Text = "Reporte de Ventas"
        CType(Me.reporteTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents reporteTable As DataGridView

End Class
