Imports System.Data.SqlClient
Imports MetroFramework.Controls

Public Class Movimiento
    Public Shared Function FillDataGrid(DGV As DataGridView, idProyecto As Int32) As Boolean
        Try
            Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            conn.Open()
            Dim command As New SqlCommand("SELECT * FROM Movimiento WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
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
    Public Shared Function Add(concepto As String, fecha As Date, referencia As String, monto As Int32, tipo As Char, idProyecto As Int32, Activo As Boolean)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            'Dim conn As New SqlConnection(FRM_LOGIN.connstr)
            'query que mandamos al sql 
            Dim command As New SqlCommand("EXEC SP_ADD_MOVIMIENTO @idProyecto, @tipo, @concepto, @fecha, @monto, @referencia", conn)
            command.Parameters.AddWithValue("@idProyecto", idProyecto)
            command.Parameters.AddWithValue("@tipo", tipo)
            command.Parameters.AddWithValue("@concepto", concepto)
            command.Parameters.AddWithValue("@fecha", fecha)
            command.Parameters.AddWithValue("@monto", monto)
            command.Parameters.AddWithValue("@referencia", referencia)
            'Deja ejecutar lo que no es query y lo que no es una consulta
            command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try

    End Function
    Public Shared Function Edit(idTransaccion As Int32, nuevoConcepto As String, nuevaFecha As Date, nuevaReferencia As String, nuevoMonto As Double, nuevoTipo As Char)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim Command As New SqlCommand("EXEC SP_EDIT_MOVIMIENTO @idMovimiento, @tipoMovimiento, @concepto, @fechaMovimiento, @monto, @referencia", conn)
            Command.Parameters.AddWithValue("@idMovimiento", idTransaccion)
            Command.Parameters.AddWithValue("@tipoMovimiento", nuevoTipo)
            Command.Parameters.AddWithValue("@concepto", nuevoConcepto)
            Command.Parameters.AddWithValue("@fechaMovimiento", nuevaFecha)
            Command.Parameters.AddWithValue("@monto", nuevoMonto)
            Command.Parameters.AddWithValue("@referencia", nuevaReferencia)
            Command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try

    End Function
    Public Shared Function PorcentajeIngresoGasto(progressBarIngreso As MetroProgressSpinner, progressBarGasto As MetroProgressSpinner,
                                                  labelIngresos As Label, labelGastos As Label, labelBalance As Label, mes As Int32, anio As Int32, idProyecto As Int32) As Boolean
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        Try
            conn.Open()
            Dim Command As New SqlCommand("SP_GET_PORCENTAJE_INGRESOS_GASTOS @anio, @mes, @idProyecto", conn)
            Command.Parameters.AddWithValue("@anio", anio)
            Command.Parameters.AddWithValue("@mes", mes)
            Command.Parameters.AddWithValue("@idProyecto", idProyecto)
            Command.ExecuteNonQuery()
            Dim adapter As New SqlDataAdapter(Command)
            Dim dataTable As New DataTable
            adapter.Fill(dataTable)
            conn.Close()
            progressBarGasto.Value = dataTable(0).Item("porcentajeGastos").ToString()
            progressBarGasto.Text = dataTable(0).Item("porcentajeGastos").ToString() + " %"
            progressBarIngreso.Value = dataTable(0).Item("porcentajeIngresos").ToString()
            progressBarGasto.Text = dataTable(0).Item("porcentajeIngresos").ToString() + " %"
            labelIngresos.Text = dataTable(0).Item("ingresos").ToString()
            labelGastos.Text = dataTable(0).Item("gastos").ToString()
            labelBalance.Text = "Balance: " + dataTable(0).Item("balance").ToString()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
    Public Shared Function EliminarTransaccion(idTransaccion As Int32)
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Try
            Dim Command As New SqlCommand("Update Proyecto SET activoGastoIngreso =  0 where idTransaccion = " + idTransaccion.ToString() + " ", conn)
            Command.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            conn.Close()
            Return False
        End Try
    End Function
End Class
