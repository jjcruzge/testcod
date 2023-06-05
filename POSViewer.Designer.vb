<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSViewer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSViewer))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Precio normal", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Promo 3x2 Pipas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"985488775859", "Producto con nombre un poco largo", "999,999.99", "99999.99", "9,999,999.99", "99,999.99", "9,999,999.99"}, 1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"52455875484", "Nuevo producto 1", "12.50", "10", "125.00", "16", "300.00"}, 0)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"123456789", "linea dos de promo"}, 2)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PosListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "label_sale yellow.png")
        Me.ImageList1.Images.SetKeyName(1, "wooden-box-label.png")
        Me.ImageList1.Images.SetKeyName(2, "iPhone On.png")
        '
        'PosListView1
        '
        Me.PosListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.PosListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.PosListView1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PosListView1.FullRowSelect = True
        Me.PosListView1.GridLines = True
        ListViewGroup1.Header = "Precio normal"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Promo 3x2 Pipas"
        ListViewGroup2.Name = "promo.3x2.1"
        Me.PosListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.PosListView1.HideSelection = False
        Me.PosListView1.HoverSelection = True
        ListViewItem1.Group = ListViewGroup2
        ListViewItem2.Group = ListViewGroup1
        ListViewItem3.Group = ListViewGroup2
        Me.PosListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.PosListView1.LargeImageList = Me.ImageList1
        Me.PosListView1.Location = New System.Drawing.Point(3, 3)
        Me.PosListView1.MultiSelect = False
        Me.PosListView1.Name = "PosListView1"
        Me.PosListView1.Size = New System.Drawing.Size(928, 345)
        Me.PosListView1.SmallImageList = Me.ImageList1
        Me.PosListView1.TabIndex = 1
        Me.PosListView1.UseCompatibleStateImageBehavior = False
        Me.PosListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Código"
        Me.ColumnHeader7.Width = 140
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Producto"
        Me.ColumnHeader6.Width = 280
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Precio"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cant"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "S. Total"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IVA"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Total"
        Me.ColumnHeader5.Width = 100
        '
        'POSViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PosListView1)
        Me.Name = "POSViewer"
        Me.Size = New System.Drawing.Size(935, 354)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PosListView1 As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
