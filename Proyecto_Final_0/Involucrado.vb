Imports System.Data.SqlClient
Imports MetroFramework.Controls

Public Class Involucrado
    Public Shared Function Add(idProyecto As Int32, nombre As String, correo As String, idRol As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_ADD_INVOLUCRADO @idProyecto, @nombreCompleto, @correo, @idRol", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@nombreCompleto", nombre)
            command.Parameters.AddWithValue("@correo", correo)
            command.Parameters.AddWithValue("@idRol", idRol)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Delete(idInvolucrado As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_DELETE_INVOLUCRADO @idInvolucrado ", conn)
            command.Parameters.AddWithValue("@idInvolucrado", idInvolucrado)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Update(idInvolucrado As Int32, nombre As String, correo As String, idRol As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_EDIT_INVOLUCRADO @idInvolucrado, @nombreCompleto, @correo, @idRol", conn)
            command.Parameters.AddWithValue("@idInvolucrado", idInvolucrado)
            command.Parameters.AddWithValue("@nombreCompleto", nombre)
            command.Parameters.AddWithValue("@correo", correo)
            command.Parameters.AddWithValue("@idRol", idRol)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Exist(correoElectronico As String) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("SELECT idInvolucrado FROM Involucrado WHERE correoElectronico =  '" + correoElectronico + "' ", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            conn.Close()
            If data.Rows.Count = 1 Then
                Return True
            End If
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
        Return False
    End Function
    Public Shared Function GetDesempenio(idInvolucrado As Int32, idProyecto As Int32, progressBar As MetroProgressSpinner, label As Label) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_GET_DESEMPENO @INVOLUCRADO, @IDPROYECTO ", conn)
            command.Parameters.AddWithValue("@INVOLUCRADO", idInvolucrado)
            command.Parameters.AddWithValue("@IDPROYECTO", idProyecto)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            progressBar.Value = data.Rows(0).Item("porcentaje")
            label.Text = data.Rows(0).Item("porcentaje").ToString() + "%"
            conn.Close()
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Sub FillDataGrid(DGV As DataGridView, idProyecto As Int32)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM Involucrado WHERE idProyecto = " + idProyecto.ToString() + " AND activo = 1", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = dataTable
        conn.Close()
    End Sub

    Public Shared Sub FillComboBox(combo As ComboBox, idProyecto As Int32)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT idInvolucrado, nombreCompletoInvolucrado FROM Involucrado WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)

        combo.DisplayMember = "nombreCompletoInvolucrado"
        combo.ValueMember = "idInvolucrado"
        combo.DataSource = dataTable
        conn.Close()
    End Sub
End Class
