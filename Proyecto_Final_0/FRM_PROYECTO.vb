Public Class FRM_PROYECTO

    Private isEditing As Boolean
    Private idProyectoAux As Int32

    Private Sub TBP_PROYECTO_Click(sender As Object, e As EventArgs) Handles TBP_PROYECTO.Click

    End Sub

    Private Sub BTN_AGREGAR_PROYECTO_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROYECTOS.CellContentClick
        Dim ColumnName As String = DGV_PROYECTOS.Columns(e.ColumnIndex).Name

        If DGV_PROYECTOS.RowCount > 1 Then
            idProyectoAux = DGV_PROYECTOS.Rows(e.RowIndex).Cells("GV_PROYECTO_ID").Value

            If ColumnName = "GV_PROYECTO_BORRAR" Then
                Dim msgRes As DialogResult = CustomMessage.show("Aviso", "¿Está seguro que quiere borrar este proyecto" + vbCr + "y todas sus dependencias?", MessageBoxButtons.YesNo, Color.FromArgb(46, 46, 46))
                If msgRes = DialogResult.Yes Then
                    If Proyecto.Eliminar(idProyectoAux) Then
                        CustomMessage.show("Proyecto Eliminado", "Se ha eliminado el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Else
                        CustomMessage.show("Error", "No se pudo eliminar el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                End If
                Proyecto.LoadProyectos(DGV_PROYECTOS)
            Else
                If ColumnName = "GV_PROYECTO_DETALLES" Then
                    Dim frmDetalleProyecto As New FRM_DETALLE_PROYECTO(idProyectoAux)
                    frmDetalleProyecto.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub BTN_SAVE_PROYECT_Click(sender As Object, e As EventArgs) Handles BTN_SAVE_PROYECT.Click
        Dim fechaInicio As Date = DTP_PROYECTO_FECHA_INICIO.Value
        Dim fechaFin As Date = DTP_PROYECTO_FECHA_FIN.Value
        Dim nombre As String = TXT_PROYECTO_NOMBRE.Text.Trim()
        Dim descripcion As String = TXT_PROYECTO_DESCRIPCION.Text.Trim()
        Dim idCliente As Int32 = CMB_PROYECTO_CLIENTE.SelectedValue

        If nombre <> "" And descripcion <> "" Then
            If fechaInicio < fechaFin Then
                If Proyecto.Add(nombre, idCliente, descripcion, fechaInicio, fechaFin) Then
                    CustomMessage.show("Exito", "Se ha registrado el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se pudo agregar el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
                Proyecto.LoadProyectos(DGV_PROYECTOS)
            Else
                CustomMessage.show("Aviso", "La fecha de fin debe de ser mayor a la de inicio", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        Else
                CustomMessage.show("Aviso", "No deje campos vacios", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    Private Sub FRM_PROYECTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cliente.FillComboBox(CMB_PROYECTO_CLIENTE)
        Proyecto.LoadProyectos(DGV_PROYECTOS)
    End Sub
End Class