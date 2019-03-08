Imports System.Data.SqlClient

Public Class FRM_EDITAR_USUARIO

    Dim isMoving As Boolean = False
    Dim pos As Point

    Private idUser As Int32

    Public Sub New(idUsuario As Int32)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        idUser = idUsuario
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim command As New SqlCommand("SELECT * FROM Usuario WHERE idUsuario = " + idUsuario.ToString() + " ", conn)
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(Data)
            conn.Close()
            TXT_EDIT_NOMBRE.Text = data.Rows(0).Item("nombreCompletoUsuario").ToString()
            TXT_EDIT_E_MAIL.Text = data.Rows(0).Item("correoElectronico").ToString()
            TXT_EDIT_TELEFONO.Text = data.Rows(0).Item("telefonoContacto").ToString()
            TXT_EDIT_PASSWORD.Text = data.Rows(0).Item("contrasenia").ToString()
            CB_EDIT_ACTIVO.Checked = data.Rows(0).Item("activo")
            CB_EDIT_ADMIN.Checked = data.Rows(0).Item("administrador")
        Catch ex As Exception
            CustomMessage.show("Aviso", "Sucedió un error al tratar de obtener" + vbCr + "la informacion de la bae de datos", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            conn.Close()
            Me.Close()
        End Try
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FRM_EDIT_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub BTN_EDIT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_EDIT_GUARDAR.Click

        Dim newNombre As String = TXT_EDIT_NOMBRE.Text.Trim()
        Dim newPhone As String = TXT_EDIT_TELEFONO.Text.Trim()
        Dim newMail As String = TXT_EDIT_E_MAIL.Text.Trim()
        Dim newPassword As String = TXT_EDIT_PASSWORD.Text.Trim()
        Dim confirmPass As String = TXT_EDIT_PASSWORD_C.Text.Trim()
        Dim isAdmin As Int32 ' = CB_EDIT_ADMIN.Checked
        Dim isActive As Int32 '= CB_EDIT_ACTIVO.Checked

        If CB_EDIT_ACTIVO.Checked Then
            isActive = 1
        Else
            isActive = 0
        End If
        If CB_EDIT_ADMIN.Checked Then
            isAdmin = 1
        Else
            isAdmin = 0
        End If
        If (newNombre <> "" And newPhone <> "" And newMail <> "" And newPassword <> "") Then
            If (confirmPass = newPassword) Then
                If Usuario.Update(newNombre, newMail, newPassword, newPhone, isAdmin, isActive, idUser) Then
                    CustomMessage.show("Exito", "El registro de actualizo satisfactoriamente", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Me.Close()
                Else
                    CustomMessage.show("Aviso", "El registro se pudo actualizar", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                CustomMessage.show("Aviso", "Asegurese de que las contraseñas sean correctas", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        Else
            CustomMessage.show("Aviso", "Asegurese de llenar todos los campos", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        isMoving = True
        pos.X = Cursor.Position.X - Me.Left
        pos.Y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If (isMoving) Then
            Me.Left = Cursor.Position.X - pos.X
            Me.Top = Cursor.Position.Y - pos.Y
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        isMoving = False
    End Sub
End Class