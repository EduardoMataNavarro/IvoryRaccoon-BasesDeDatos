Imports System.Data.SqlClient

Public Class Categoria
    Public Shared Sub fillDataGrid(DGV As DataGridView)

        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Dim cmd As New SqlCommand("SELECT * FROM Categoria", conn)
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
        Dim cmd As New SqlCommand("SELECT * FROM Categoria", connection)
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
    Public Shared Function Edit(newName As String, idCategoria As Int32, activo As Int32) As Boolean
        Try
            Dim connection As New SqlConnection(FRM_LOGIN.connstr)
            connection.Open()
            Dim cmd As New SqlCommand("EXEC SP_EDIT_CATEGORIA @idCategoria, @nombre, @activo ", connection)
            cmd.Parameters.AddWithValue("@idCategoria", idCategoria)
            cmd.Parameters.AddWithValue("@nombre", newName)
            cmd.Parameters.AddWithValue("@activo", activo)
            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Delete(id As String) As Boolean
        Try
            Dim connection As New SqlConnection(FRM_LOGIN.connstr)
            connection.Open()
            Dim cmd As New SqlCommand("EXEC SP_DELETE_CATEGORIA @idCategoria ", connection)
            cmd.Parameters.AddWithValue("@idCategoria", id)
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
            Dim cmd As New SqlCommand("EXEC SP_ADD_CATEGORIA @nombre", connection)
            cmd.Parameters.AddWithValue("@nombre", name)
            cmd.ExecuteNonQuery()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function FillComboBox(combo As ComboBox) As Boolean
        Dim connection As New SqlConnection(FRM_LOGIN.connstr)
        Try
            connection.Open()
            Dim cmd As New SqlCommand("SELECT idCategoria, nombreCategoria FROM Categoria WHERE activo = 1", connection)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            connection.Close()
            combo.ValueMember = "idCategoria"
            combo.DisplayMember = "nombreCategoria"
            combo.DataSource = dataTable
        Catch ex As Exception
            connection.Close()
            Return False
        End Try
    End Function
End Class


