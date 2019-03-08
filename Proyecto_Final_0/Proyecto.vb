Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Proyecto
    Public Shared Function Add(Nombre As String, Cliente As Int32, Descripcion As String, FechaInicio As Date, FechaFin As Date) As Boolean
        Try
            'Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            'query que mandamos al sql 
            Dim command As New SqlCommand("EXEC SP_ADD_PROYECTO @nombreProyecto, @idCliente, @descripcion, @fechaInicio, @fechaEstimadaFin", conn)
            command.Parameters.AddWithValue("@nombreProyecto", Nombre)
            command.Parameters.AddWithValue("@idCliente", Cliente)
            command.Parameters.AddWithValue("@descripcion", Descripcion)
            command.Parameters.AddWithValue("@fechaInicio", FechaInicio)
            command.Parameters.AddWithValue("@fechaEstimadaFin", FechaFin)
            'Deja ejecutar lo que no es query y lo que no es una consulta
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function EditarProyecto(IdProyecto As Int32, Nombre As String, Cliente As Int32, descripcion As String, FechaInicio As Date,
                            FechaFin As Date) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            'Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            'query que mandamos al sql 
            Dim command As New SqlCommand("EXEC SP_EDIT_PROYECTO @idProyecto, @nombreProyecto, @idCliente, @descripcion, @fechaEstimadaFin", conn)
            command.Parameters.AddWithValue("@idProyecto", IdProyecto)
            command.Parameters.AddWithValue("@nombreProyecto", Nombre)
            command.Parameters.AddWithValue("@idCliente", Cliente)
            command.Parameters.AddWithValue("@descripcion", descripcion)
            command.Parameters.AddWithValue("@fechaEstimadaFin", FechaFin)
            'Deja ejecutar lo que no es query y lo que no es una consulta
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function

    Public Shared Sub LoadProyectos(DGV As DataGridView)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM VW_PROYECTO_CLIENTE", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim TablaP As New DataTable
        adapter.Fill(TablaP)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = TablaP

        conn.Close()

    End Sub

    'Update Proyecto SET
    Public Shared Function Eliminar(idProyecto As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_DELETE_PROYECTO @idProyecto", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
