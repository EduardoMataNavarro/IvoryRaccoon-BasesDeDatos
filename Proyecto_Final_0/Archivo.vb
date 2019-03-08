Imports System.Data.SqlClient

Public Class Archivo
    Public Shared Function FillDataGrid(DGV As DataGridView, idProyecto As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("SELECT * FROM Archivo WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            DGV.AutoGenerateColumns = False
            DGV.DataSource = data
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function AgregarArchivo(nombre As String, idProyecto As Int32) As Boolean
        Try
            'Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            'query que mandamos al sql 
            Dim command As New SqlCommand("EXEC SP_ADD_ARCHIVO @nombreArchivo, @idProyecto ", conn)
            command.Parameters.AddWithValue("@nombreArchivo", nombre)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            'Deja ejecutar lo que no es query y lo que no es una consulta
            command.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function Editar(newName As String, IdArchivo As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim Command As New SqlCommand("EXEC SP_EDIT_ARCHIVO @idArchivo, @nombre", conn)
            Command.Parameters.AddWithValue("@idArchivo", IdArchivo)
            Command.Parameters.AddWithValue("@nombre", newName)
            Command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Eliminar(IdArchivo As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim Command As New SqlCommand("EXEC SP_DELETE_ARCHIVO @idArchivo ", conn)
            Command.Parameters.AddWithValue("@idArchivo", IdArchivo)
            Command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
