Imports System.Windows.Forms

Public Class TestWindows
    Inherits System.Windows.Forms.Form

    ' Declaración de los componentes visuales
    Private components As System.ComponentModel.IContainer = Nothing
    '   Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    '   Private dataGridViewSchedule As System.Windows.Forms.DataGridView
    Private buttonSchedule As System.Windows.Forms.Button

    ' Constructor de la clase
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Liberar recursos utilizados por los componentes
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Inicialización de los componentes visuales
    Private Sub InitializeComponent()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dataGridViewSchedule = New System.Windows.Forms.DataGridView()
        Me.buttonSchedule = New System.Windows.Forms.Button()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.dataGridViewSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.dataGridViewSchedule, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.buttonSchedule, 1, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'dataGridViewSchedule
        '
        Me.dataGridViewSchedule.AllowUserToAddRows = False
        Me.dataGridViewSchedule.AllowUserToDeleteRows = False
        Me.dataGridViewSchedule.AllowUserToResizeColumns = False
        Me.dataGridViewSchedule.AllowUserToResizeRows = False
        Me.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewSchedule.ColumnHeadersVisible = False
        Me.dataGridViewSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewSchedule.Location = New System.Drawing.Point(163, 48)
        Me.dataGridViewSchedule.MultiSelect = False
        Me.dataGridViewSchedule.Name = "dataGridViewSchedule"
        Me.dataGridViewSchedule.RowHeadersVisible = False
        Me.dataGridViewSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dataGridViewSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataGridViewSchedule.Size = New System.Drawing.Size(634, 354)
        Me.dataGridViewSchedule.TabIndex = 0
        '
        'buttonSchedule
        '
        Me.buttonSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonSchedule.Location = New System.Drawing.Point(163, 408)
        Me.buttonSchedule.Name = "buttonSchedule"
        Me.buttonSchedule.Size = New System.Drawing.Size(634, 39)
        Me.buttonSchedule.TabIndex = 1
        Me.buttonSchedule.Text = "Programar Cita"
        Me.buttonSchedule.UseVisualStyleBackColor = True
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "Schedule"
        Me.Text = "Programación de Citas"
        Me.tableLayoutPanel1.ResumeLayout(False)
        CType(Me.dataGridViewSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Private WithEvents dataGridViewSchedule As DataGridView
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents dateTimePicker As DateTimePicker
    Private WithEvents label1 As Label
    Friend WithEvents Button1 As Button

End Class