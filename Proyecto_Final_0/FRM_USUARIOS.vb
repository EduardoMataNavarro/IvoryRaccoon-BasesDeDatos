Imports System.Data.SqlClient


Public Class FRM_USUARIOS

    Dim usersTable As New DataTable
    Private Sub FRM_USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario.fillDataGrid(DGV_USERS_LIST)
    End Sub

    Private Sub DGV_USERS_LIST_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_USERS_LIST.CellContentDoubleClick
        '    Dim index As Int32 = e.RowIndex

        '    Dim frmEdit As New FRM_EDITAR_USUARIO(DGV_USERS_LIST.Rows.Item(index))
        '    frmEdit.ShowDialog()
        '  Dim frmEditUsuario As New FRM_EDITAR_USUARIO()
    End Sub

    Private Sub BTN_USER_ADD_Click(sender As Object, e As EventArgs) Handles BTN_USER_ADD.Click
        Dim nombre As String = TXT_USER_NOMBRE.Text.Trim()

        Dim mail As String = TXT_USER_E_MAIL.Text.Trim()
        Dim pass As String = TXT_USER_PASSWORD.Text.Trim()
        Dim confirmPass As String = TXT_USER_CONFIRM_PASS.Text.Trim()
        Dim phone As String = TXT_USER_PHONE.Text.Trim()
        Dim isAdmin As Int32

        If CB_IS_ADMIN.Checked Then
            isAdmin = 1
        Else
            isAdmin = 0
        End If

        If CustomMessage.show("Aviso", "Está seguro de que los datos son correctos?", MessageBoxButtons.YesNo, Color.FromArgb(46, 46, 46)) = DialogResult.Yes Then
            If pass = "" Or mail = "" Then
                CustomMessage.show("Aviso", "No deje campos vacíos", MessageBoxButtons.OK, Color.Black)
            Else
                If pass <> confirmPass Then
                    CustomMessage.show("Aviso", "Revise que las contraseñas" + vbLf + "sean correctas", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    If Usuario.Exists(nombre, mail) = False Then
                        If Usuario.Add(nombre, mail, confirmPass, phone, isAdmin) Then
                            CustomMessage.show("Exito", "El usuario se ha registrado correctamente", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                            FormActions.clearTextBoxes(TBP_ADD_USER)
                            CB_IS_ADMIN.Checked = False
                        Else
                            CustomMessage.show("Aviso", "El usuario no se ha registrado", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                        End If
                    Else
                        CustomMessage.show("Aviso", "El usuario ya se ha registrado", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                End If
            End If
        End If
        Usuario.fillDataGrid(DGV_USERS_LIST)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TC_USERS.SelectedIndexChanged
        If TC_USERS.SelectedIndex = 0 Then
            Usuario.fillDataGrid(DGV_USERS_LIST)
        End If
    End Sub

    Private Sub DGV_USERS_LIST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_USERS_LIST.CellContentClick
        If DGV_USERS_LIST.RowCount > 0 Then
            If TypeOf DGV_USERS_LIST.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
                Dim idU As Int32 = DGV_USERS_LIST.Rows(e.RowIndex).Cells("GV_USUARIO_ID_USUARIO").Value
                Dim editUserFRM As New FRM_EDITAR_USUARIO(idU)
                editUserFRM.ShowDialog()
                Usuario.fillDataGrid(DGV_USERS_LIST)
            End If
        End If
    End Sub

    Private Sub FRM_USUARIOS_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
    End Sub
End Class