Imports System.Data.SqlClient

Public Class Tarea
    Public Shared Function Add(descripcionTarea As String, categoria As Int32, fechaInicio As Date, duracion As Int32,
                               idTareaAnt As Int32, idResposable As Int32, idProyecto As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_ADD_TAREA @idProyecto, @idCategoria, @idTareaAnt, @descripcion, @duracion, @fechaInicio, @idResponsable", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@idCategoria", categoria)
            command.Parameters.AddWithValue("@idTareaAnt", idTareaAnt)
            command.Parameters.AddWithValue("@descripcion", descripcionTarea)
            command.Parameters.AddWithValue("@duracion", duracion)
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            command.Parameters.AddWithValue("@idResponsable", idResposable)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            conn.Close()
            Dim result As Int32 = data.Rows(0).Item("Result")
            If result = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Update(idTarea As Int32, idProyecto As Int32, idCategoria As Int32, descripcion As String, duracion As Int32, fechaInicio As Date, idTareaAnt As Int32, idResponsable As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_EDIT_TAREA @idTarea, @idProyecto, @idCategoria, @descripcion, @duracion, @fechaInicio, @idTareaAnt, @idResponsable", conn)
            command.Parameters.AddWithValue("@idTarea", idTarea)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@idCategoria", idCategoria)
            command.Parameters.AddWithValue("@descripcion", descripcion)
            command.Parameters.AddWithValue("@duracion", duracion)
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio)
            command.Parameters.AddWithValue("@idTareaAnt", idTareaAnt)
            command.Parameters.AddWithValue("@idResponsable", idResponsable)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Delete(idTarea As Int32, idProyecto As Int32 ) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim command As New SqlCommand("EXEC SP_DELETE_TAREA @idTarea, @idProyecto", conn)
            command.Parameters.AddWithValue("@idTarea", idTarea)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function Exist(nombreTarea As String, idProyecto As Int32) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("Select * FROM Tarea WHERE nombreTarea = '" + nombreTarea + "' AND idProyecto = " + idProyecto.ToString() + " ", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim data As New DataTable
        adapter.Fill(data)
        conn.Close()
        If data.Rows.Count = 1 Then
            Return True
        End If
        Return False
    End Function
    Public Shared Sub FillDataGrid(DGV As DataGridView, idProyecto As Int32)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM VW_TAREA_PROYECTO WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = dataTable
        conn.Close()
    End Sub

    Public Shared Function FillComboBox(combo As ComboBox, idProyecto As Int32) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try

            Dim command As New SqlCommand("SELECT idTarea, descripcionTarea FROM Tarea WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)

            combo.DisplayMember = "descripcionTarea"
            combo.ValueMember = "idTarea"
            combo.DataSource = dataTable
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function CheckIfHasTareaPredecesora(idTarea As Int32) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT idTareaPredecesora FROM Tarea WHERE idTareaPredecesora = " + idTarea.ToString() + " ", conn)
        Dim data As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(data)
        If data.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
