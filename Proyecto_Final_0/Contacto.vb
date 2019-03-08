Imports System.Data.SqlClient

Public Class Contacto
    Public Shared Function Add(idProyecto As Int32, nombre As String, correo As String, telefonoFijo As String, telefonoMovil As String,
                               calle As String, numeroCasa As String, colonia As String, idCiudad As Int32, idEstado As Int32, idPais As Int32, codigoPostal As String) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_ADD_CONTACTO @idProyecto, @nombreCompleto, @correo, @telefonoFijo, @telefonoMovil,
                                          @calle, @numeroCasa, @colonia, @idCiudad, @idEstado, @idPais, @codigoPostal", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@nombreCompleto", nombre)
            command.Parameters.AddWithValue("@correo", correo)
            command.Parameters.AddWithValue("@telefonoFijo", telefonoFijo)
            command.Parameters.AddWithValue("@telefonoMovil", telefonoMovil)
            command.Parameters.AddWithValue("@calle", calle)
            command.Parameters.AddWithValue("@numeroCasa", numeroCasa)
            command.Parameters.AddWithValue("@colonia", colonia)
            command.Parameters.AddWithValue("@idCiudad", idCiudad)
            command.Parameters.AddWithValue("@idEstado", idEstado)
            command.Parameters.AddWithValue("@idPais", idPais)
            command.Parameters.AddWithValue("@codigoPostal", codigoPostal)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function Update(idContacto As Int32, nombre As String, correo As Int32, telefonoFijo As String, telefonoMovil As String,
                                  calle As String, numeroCasa As String, colonia As String, idCiudad As Int32, idEstado As Int32, idPais As Int32, codigoPostal As String) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("EXEC SP_EDIT_CONTACTO @idContacto, @nombreCompleto, @correo, @telefonoFijo, @telefonoMovil,
                                          @calle, @numeroCasa, @colonia, @idCiudad, @idEstado, @idPais, @codigoPostal", conn)
            command.Parameters.AddWithValue("@idContacto", idContacto)
            command.Parameters.AddWithValue("@nombreCompleto", nombre)
            command.Parameters.AddWithValue("@correo", correo)
            command.Parameters.AddWithValue("@telefonoFijo", telefonoFijo)
            command.Parameters.AddWithValue("@telefonoMovil", telefonoMovil)
            command.Parameters.AddWithValue("@calle", calle)
            command.Parameters.AddWithValue("@numeroCasa", numeroCasa)
            command.Parameters.AddWithValue("@colonia", colonia)
            command.Parameters.AddWithValue("@idCiudad", idCiudad)
            command.Parameters.AddWithValue("@idEstado", idEstado)
            command.Parameters.AddWithValue("@idPais", idPais)
            command.Parameters.AddWithValue("@codigoPostal", codigoPostal)
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function Exist(correo As String) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT idContacto FROM Contacto WHERE correoElectronico = '" + correo + "' ")
        Dim adapter As New SqlDataAdapter(command)
        Dim data As New DataTable
        adapter.Fill(data)
        conn.Close()
        If data.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
    Public Shared Sub FillDataGrid(DGV As DataGridView, idProyecto As Int32)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT * FROM Contacto WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = dataTable
        conn.Close()
    End Sub
    Public Shared Function FillEstadoComboBox(combo As ComboBox, idPais As Int32) As Boolean
        combo.Refresh()
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("SELECT idEstado, nombreEstado FROM Estado WHERE idPais = " + idPais.ToString() + " ", conn)
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
            combo.DisplayMember = "nombreEstado"
            combo.ValueMember = "idEstado"
            combo.DataSource = data
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function FillCiudadComboBox(combo As ComboBox, idEstado As Int32) As Boolean
        combo.Refresh()
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("SELECT idCiudad, nombreCiudad FROM Ciudad WHERE idEstado = " + idEstado.ToString() + " ", conn)
            Dim data As New DataTable
            Dim adapter As New SqlDataAdapter(command)
            adapter.Fill(data)
            conn.Close()
            combo.DisplayMember = "nombreCiudad"
            combo.ValueMember = "idCiudad"
            combo.DataSource = data
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function FillPaisComboBox(combo As ComboBox) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim command As New SqlCommand("SELECT * FROM Pais", conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim data As New DataTable
            adapter.Fill(data)
            conn.Close()
            combo.DisplayMember = "nombrePais"
            combo.ValueMember = "idPais"
            combo.DataSource = data
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    'Public Shared Sub FillComboBox(combo As ComboBox)
    '    Dim conn As New SqlConnection(FRM_LOGIN.connstr)
    '    conn.Open()
    '    Dim command As New SqlCommand("SELECT idInvolucrado, nombreInvolucrado FROM Involucrado", conn)
    '    Dim adapter As New SqlDataAdapter(command)
    '    Dim dataTable As New DataTable

    '    combo.DataSource = dataTable
    '    combo.DisplayMember = "nombreInvolucrado"
    '    combo.ValueMember = "idInvolucrado"
    '    conn.Close()
    'End Sub
End Class
