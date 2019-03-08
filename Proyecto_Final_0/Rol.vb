Imports System.Data.SqlClient

Public Class Rol
    Public Shared Sub fillDataGrid(DGV As DataGridView)

        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Dim cmd As New SqlCommand("SELECT * FROM Rol", conn)
        ' Dim dr As SqlDataReader
        ' Dim ds As New DataSet
        conn.Open()
        Dim adapater As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapater.Fill(table)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = table
        conn.Close()
    End Sub
    Public Shared Function Exists(name As String) As Boolean

        Dim connection As New SqlConnection(FRM_LOGIN.connstr)
        Dim cmd As New SqlCommand("SELECT * FROM Rol", connection)
        connection.Open()
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        connection.Close()
        If dataTable.Rows.Count = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function FillComboBox(combo As ComboBox) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim command As New SqlCommand("SELECT idRol, nombreRol FROM Rol WHERE activo = 1", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            combo.ValueMember = "idRol"
            combo.DisplayMember = "nombreRol"
            combo.DataSource = data
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function Edit(newName As String, idRol As Int32, activo As Int32) As Boolean
        Try
            Dim connection As New SqlConnection(FRM_LOGIN.connstr)
            connection.Open()
            Dim cmd As New SqlCommand("EXEC SP_EDIT_ROL @idRol, @nombre, @activo ", connection)
            cmd.Parameters.AddWithValue("@idRol", idRol)
            cmd.Parameters.AddWithValue("@nombre", newName)
            cmd.Parameters.AddWithValue("@activo", activo)
            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Delete(id As Int32) As Boolean
        Try
            Dim connection As New SqlConnection(FRM_LOGIN.connstr)
            Dim cmd As New SqlCommand("EXEC SP_DELETE_ROL @idRol ", connection)
            cmd.Parameters.AddWithValue("@idRol", id)
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Add(name As String) As Boolean
        Try
            Dim connection As New SqlConnection(FRM_LOGIN.connstr)
            connection.Open()
            Dim cmd As New SqlCommand("SP_ADD_ROL @nombreRol", connection)
            cmd.Parameters.AddWithValue("@nombreRol", name)
            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
