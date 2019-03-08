Public Class FRM_ROLES_CATEGORIA

    Private isEditing As Boolean
    Private idRole As Int32
    Private idCategoria As Int32

    Private Sub BTN_ADD_ROLE_Click(sender As Object, e As EventArgs) Handles BTN_ADD_ROLE.Click
        Dim nombre As String = TXT_ROL_NOMBRE.Text.Trim()
        Dim isRolActive As Int32
        If CB_ROL_ACTIVO.Checked Then
            isRolActive = 1
        Else
            isRolActive = 0
        End If
        If isEditing Then
            If nombre = "" Then
                Dim msgRes As DialogResult = CustomMessage.show("Aviso", "Està tratando de registar un campo vacio" + vbCr + "¡Desea borrar el registro?", MessageBoxButtons.YesNo, Color.FromArgb(46, 46, 46))
                If msgRes = DialogResult.Yes Then
                    If Rol.Delete(idRole) Then
                        CustomMessage.show("Exito", "Se pudo eliminar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Else
                        CustomMessage.show("Aviso", "No se pudo eliminar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                End If
            Else
                If Rol.Edit(nombre, idRole, isRolActive) Then
                    CustomMessage.show("Exito", "Se pudo editar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se pudo editar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
        Else
            If Rol.Add(nombre) Then
                CustomMessage.show("Exito", "Se pudo registrar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))

            Else
                CustomMessage.show("Aviso", "No se pudo registrar el rol", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        End If

        Rol.fillDataGrid(DGV_ROL)
        idRole = 0
        TXT_ROL_NOMBRE.Text = ""
    End Sub

    Private Sub FRM_ROLES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rol.fillDataGrid(DGV_ROL)
        Categoria.fillDataGrid(DGV_CATEGORIA)
    End Sub

    Private Sub DGV_ROL_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ROL.CellContentClick
        Dim ColumnName As String = DGV_ROL.Columns(e.ColumnIndex).Name
        If DGV_ROL.RowCount > 0 Then
            idRole = DGV_ROL.Rows(e.RowIndex).Cells("GV_ROL_ID").Value
            If ColumnName = "GV_ROL_EDITAR" Then
                idRole = DGV_ROL.Rows(e.RowIndex).Cells("GV_ROL_ID").Value
                TXT_ROL_NOMBRE.Text = DGV_ROL.Rows(e.RowIndex).Cells("GV_ROL_NOMBRE").Value.ToString()
                CB_ROL_ACTIVO.Checked = DGV_ROL.Rows(e.RowIndex).Cells("GV_ROL_ACTIVO").Value
                isEditing = True
            End If
        End If
    End Sub

    Private Sub DGV_CATEGORIA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CATEGORIA.CellContentClick
        Dim ColumnName As String = DGV_CATEGORIA.Columns(e.ColumnIndex).Name
        If DGV_CATEGORIA.RowCount > 0 Then
            idCategoria = DGV_CATEGORIA.Rows(e.RowIndex).Cells("GV_CATEGORIA_ID").Value
            If ColumnName = "GV_CATEGORIA_EDITAR" Then
                idCategoria = DGV_CATEGORIA.Rows(e.RowIndex).Cells("GV_CATEGORIA_ID").Value
                TXT_CAT_NOMBRE.Text = DGV_CATEGORIA.Rows(e.RowIndex).Cells("GV_CATEGORIA_NOMBRE").Value.ToString()
                CB_CATEGORIA_ACTIVO.Checked = DGV_CATEGORIA.Rows(e.RowIndex).Cells("GV_CATEGORIA_ACTIVO").Value
                isEditing = True
            End If
        End If
    End Sub

    Private Sub BTN_ADD_CAT_Click(sender As Object, e As EventArgs) Handles BTN_ADD_CAT.Click
        Dim nombre As String = TXT_CAT_NOMBRE.Text.Trim()
        Dim isCategoriaActive As Int32
        If CB_CATEGORIA_ACTIVO.Checked Then
            isCategoriaActive = 1
        Else
            isCategoriaActive = 0
        End If
        If nombre <> "" Then
            If isEditing Then
                If Categoria.Edit(nombre, idCategoria, isCategoriaActive) Then
                    CustomMessage.show("Exito", "Se pudo editar la categoria", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se pudo editar la categoria", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Categoria.Add(nombre) Then
                    CustomMessage.show("Exito", "Se pudo registrar la categoria", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
               
                Else
                    CustomMessage.show("Aviso", "No se pudo registrar la categoria", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
        Else
            Dim msgRes As DialogResult = CustomMessage.show("Aviso", "Está tratando de registar un campo vacio", MessageBoxButtons.YesNo, Color.FromArgb(46, 46, 46))
        End If

        Categoria.fillDataGrid(DGV_CATEGORIA)
        idCategoria = 0
        TXT_CAT_NOMBRE.Text = ""
    End Sub
End Class