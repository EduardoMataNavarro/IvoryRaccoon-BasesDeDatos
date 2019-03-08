Imports System.Data.SqlClient

Public Class Usuario
    Public Shared Function Add(nombre As String, mail As String, pass As String, phone As String, isAdmin As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_ADD_USUARIO @nombre, @correo, @pass, @telefono, @isAdmin ", conn)
            command.Parameters.AddWithValue("@nombre", nombre)
            command.Parameters.AddWithValue("@correo", mail)
            command.Parameters.AddWithValue("@pass", pass)
            command.Parameters.AddWithValue("@telefono", phone)
            command.Parameters.AddWithValue("@isAdmin", isAdmin)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function LogIn(userMail As String, userPass As String, ByRef idUsuario As Int32) As Int16 ' 3 = administrador, 2 = usuario normal, 1 = existe pero no activo, 0 = error
        Dim connection As New SqlConnection(FRM_LOGIN.connstr)
        connection.Open()
        Try
            Dim command As New SqlCommand("SELECT * FROM Usuario WHERE correoElectronico = '" + userMail + "' AND contrasenia = '" + userPass + "' ", connection)
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(data)
            connection.Close()
            If data.Rows.Count = 1 Then
                Dim isActive As Boolean = data.Rows(0).Item("activo")
                Dim isAdmin As Boolean = data.Rows(0).Item("administrador")
                idUsuario = data.Rows(0).Item(idUsuario)
                If isActive Then
                    If isAdmin Then
                        Return 3
                    Else
                        Return 2
                    End If
                Else
                    Return 1
                End If
            Else
                Return 0
            End If

        Catch ex As Exception
            connection.Close()
            Return 0
        End Try
    End Function
    Public Shared Sub fillDataGrid(DGV As DataGridView)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM Usuario WHERE activo = 1", conn)

        Dim adapter As New SqlDataAdapter(command)
        Dim usersTable As New DataTable
        adapter.Fill(usersTable)

        DGV.AutoGenerateColumns = False
        DGV.DataSource = usersTable
        conn.Close()
    End Sub
    Public Shared Function Exists(nombreUsuario As String, correo As String) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.open()
            Dim command As New SqlCommand("SELECT * FROM Usuario WHERE nombreCompletoUsuario = '" + nombreUsuario + "', AND correo = '" + correo + "' ")
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
            If data.Rows.Count Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Update(nombre As String, mail As String, pass As String, phone As String, isAdmin As Int32, isActive As Int32, idUser As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_EDIT_USUARIO @idUser, @newNombre, @newCorreo, @newPass, @newTelefono, @isActivo, @isAdmin ", conn)
            command.Parameters.AddWithValue("@idUser", idUser)
            command.Parameters.AddWithValue("@newNombre", nombre)
            command.Parameters.AddWithValue("@newCorreo", mail)
            command.Parameters.AddWithValue("@newPass", pass)
            command.Parameters.AddWithValue("@newTelefono", phone)
            command.Parameters.AddWithValue("@isActivo", isActive)
            command.Parameters.AddWithValue("@isAdmin", isAdmin)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
