Imports System.Data.SqlClient


Public Class Modificacion
    Public Shared Function Add(idProyecto As Int32, fechaActual As Date, nuevaFechaFin As Date, idUsuario As Int32, motivo As String) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_ADD_MODIFICACION @idProyecto, @fecha, @nuevaFecha, @idUsuario, @motivo", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@fecha", fechaActual)
            command.Parameters.AddWithValue("@nuevaFecha", nuevaFechaFin)
            command.Parameters.AddWithValue("@idUsuario", idUsuario)
            command.Parameters.AddWithValue("@motivo", motivo)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            CustomMessage.show("Aviso", "Ocurrió un problema al ingresar el registro", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function FillDataGridView(DGV As DataGridView) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("SELECT * FROM VW_MODIFICACION_USUARIO", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            conn.Close()
            DGV.AutoGenerateColumns = False
            DGV.DataSource = data
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
End Class
