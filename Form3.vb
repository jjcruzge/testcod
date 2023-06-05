Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Exit Sub
        With PosViewer1
            .Limpiar_POS()
            .Crear_Grupo("Grupo1", "Grupo 1")
            .Crear_Grupo("Grupo2", "Grupo 2")
            .Crear_Columna("uno")
            .Crear_Columna("dos")
            .Crear_Columna("tres")
            .Crear_Columna("cuatro")
            .Crear_Columna("cinco")
            .Agregar_Reg_Array_Line({"DOS", "TRES", "CUATRO", "CINCO", "SEIS"}, .PosListView1.Groups(0), 2)


        End With


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedIndices.Count = 0 Then
            Exit Sub

        End If
        '  MsgBox(ListView1.SelectedIndices(0).ToString())
        ListView1.Items(0).Group = ListView1.Groups.Item("promo.3x2.1")
        ListView1.Items(1).Group = ListView1.Groups.Item("promo.3x2.1")
        ListView1.Items(2).Group = ListView1.Groups.Item("promo.3x2.1")
    End Sub
End Class