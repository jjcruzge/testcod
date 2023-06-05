Public Class POSViewer
    Private Sub POSViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Adjust()
        PosListView1.Top = 0
        PosListView1.Left = 0
        PosListView1.Width = Me.Width
        PosListView1.Height = Me.Height
    End Sub

    Private Sub PosListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PosListView1.SelectedIndexChanged

    End Sub

    Public Sub Limpiar_POS()
        With PosListView1
            .Items.Clear()
            .Columns.Clear()
            .Groups.Clear()
        End With
    End Sub

    Public Sub Crear_Grupo(ByVal nombre As String, ByVal text As String)
        PosListView1.Groups.Add(nombre, text)
    End Sub

    Public Sub Eliminar_Grupo(ByVal nombre As String)
        For i As Integer = 0 To PosListView1.Groups.Count - 1
            If PosListView1.Groups(i).Name = nombre Then
                PosListView1.Groups.RemoveAt(i)
            End If
        Next
    End Sub

    Public Sub Crear_Columna(ByVal nombre As String)
        PosListView1.Columns.Add(nombre, 100)
    End Sub

    Public Sub Agregar_Reg_Array_Line(ByVal texto() As String, ByVal grupo As ListViewGroup, ByVal imageindex As Integer)
        If texto.Length = 0 Then
            Exit Sub
        End If

        Dim losdatos As New ListViewItem(texto(0))
        For i As Integer = 1 To texto.Length - 1
            losdatos.SubItems.Add(texto(i))
        Next
        losdatos.Group = grupo
        losdatos.ImageIndex = imageindex
        PosListView1.Items.Add(losdatos)
    End Sub


End Class
