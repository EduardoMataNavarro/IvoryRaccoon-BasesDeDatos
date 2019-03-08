Imports System.Data.SqlClient

Public Class FRM_CLIENTE
    Private id As Int32
    Private isEditing As Boolean

    Private Sub FRM_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isEditing = False
        Cliente.FillGrid(DGV_CLIENTES)
    End Sub
    Private Sub BTN_ADD_CLIENT_Click(sender As Object, e As EventArgs) Handles BTN_ADD_CLIENT.Click

        Dim nombreCorto As String = TXT_CLIENT_SHORT_NAME.Text.Trim()
        Dim razonSocial As String = TXT_CLIENT_NAME.Text.Trim()
        Dim RFC As String = TXT_CLIENT_RFC.Text.Trim()
        Dim isActive As Int32
        If CB_CLIENTE_ACTIVO.Checked Then
            isActive = 1
        Else
            isActive = 0
        End If

        If nombreCorto <> "" And razonSocial <> "" And RFC <> "" Then
            If isEditing = False Then
                If Cliente.Exist(nombreCorto, razonSocial, RFC) = False Then
                    If Cliente.Add(nombreCorto, razonSocial, RFC, isActive) Then
                        CustomMessage.show("Exito", "Se ha registrado el cliente", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Else
                        CustomMessage.show("Aviso", "No se ha podido registrar el cliente", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                Else
                    CustomMessage.show("Aviso", "Ya existe un registro con esa información", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Cliente.Update(nombreCorto, razonSocial, RFC, isActive, id) Then
                    CustomMessage.show("Exito", "Datos actualizados con exito", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    BTN_ADD_CLIENT.Text = "Agregar"
                    isEditing = False
                End If
            End If
            Cliente.FillGrid(DGV_CLIENTES)
            FormActions.clearTextBoxes(TBP_CLIENTE)
        Else
            CustomMessage.show("Aviso", "No deje campos vacíos", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    Private Sub DGV_CLIENTES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CLIENTES.CellContentClick
        Dim ColumnName As String = DGV_CLIENTES.Columns(e.ColumnIndex).Name
        If ColumnName = "GV_CLIENTE_EDITAR" Then
            id = DGV_CLIENTES.Rows(e.RowIndex).Cells("GV_CLIENTE_ID").Value
            TXT_CLIENT_SHORT_NAME.Text = DGV_CLIENTES.Rows(e.RowIndex).Cells("GV_CLIENTE_NOMBRE").Value.ToString()
            TXT_CLIENT_NAME.Text = DGV_CLIENTES.Rows(e.RowIndex).Cells("GV_CLIENTE_RAZON_SOCIAL").Value.ToString()
            TXT_CLIENT_RFC.Text = DGV_CLIENTES.Rows(e.RowIndex).Cells("GV_CLIENTE_RFC").Value.ToString()
            BTN_ADD_CLIENT.Text = "Guardar"
            isEditing = True
        Else
            If ColumnName = "GV_CLIENTE_ELIMINAR" Then

            End If
        End If
    End Sub
End Class