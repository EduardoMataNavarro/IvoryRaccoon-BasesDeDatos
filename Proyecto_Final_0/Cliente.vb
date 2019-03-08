Imports System.Data.SqlClient

Public Class Cliente
    Public Shared Function Add(nombreCorto As String, razonSocial As String, RFC As String, activo As Int32) As Boolean

        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim command As New SqlCommand("EXEC SP_ADD_CLIENTE @nombreCorto, @razonSocial, @RFC, @activo", conn)
            command.Parameters.AddWithValue("@nombreCorto", nombreCorto)
            command.Parameters.AddWithValue("@razonSocial", razonSocial)
            command.Parameters.AddWithValue("@RFC", RFC)
            command.Parameters.AddWithValue("@activo", activo)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
            conn.Close()
        End Try
    End Function
    Public Shared Sub FillGrid(DGV As DataGridView)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM Cliente", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = dataTable
        conn.Close()
    End Sub
    Public Shared Function Update(nombreCorto As String, razonSocial As String, RFC As String, activo As Int32, idCliente As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_EDIT_CLIENTE @nombreCorto, @razonSocial, @RFC, @activo, @idCliente", conn)
            command.Parameters.AddWithValue("@nombreCorto", nombreCorto)
            command.Parameters.AddWithValue("@razonSocial", razonSocial)
            command.Parameters.AddWithValue("@RFC", RFC)
            command.Parameters.AddWithValue("@activo", activo)
            command.Parameters.AddWithValue("@idCliente", idCliente)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Exist(nombreCorto As String, razonSocial As String, RFC As String) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim command As New SqlCommand("SELECT * FROM Cliente WHERE nombreCorto = '" + nombreCorto + "' OR razonSocial = '" + razonSocial + "' OR RFC = '" + RFC + "' ", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            conn.Close()
            If data.Rows.Count = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function

    Public Shared Sub FillComboBox(combo As ComboBox)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT idCliente, nombreCorto FROM Cliente WHERE activo = 1", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        combo.DisplayMember = "nombreCorto"
        combo.ValueMember = "idCliente"
        'Dim nRow As DataRow = dataTable.NewRow
        'nRow("idCliente") = 0
        'nRow("nombreCorto") = "-Cliente que pidió el proyecto-"
        'dataTable.Rows.InsertAt(nRow, 0)
        combo.DataSource = dataTable
        conn.Close()
    End Sub
End Class
