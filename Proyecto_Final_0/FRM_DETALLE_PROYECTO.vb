Imports System.Data.SqlClient


Public Class FRM_DETALLE_PROYECTO
    Private idProyectoActual As Int32
    Private idArchivo As Int32
    Private idTransaccion As Int32
    Private idInv As Int32
    Private idContacto As Int32
    Private idTarea As Int32
    Private isEditing As Boolean
    Private isMoving As Boolean
    Private modificoFechaFin As Boolean
    Private pos As Point
    Public Sub New(idProyecto As Int32)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Cliente.FillComboBox(CB_DET_CLIENTE)

        idProyectoActual = idProyecto
        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("Select * FROM Proyecto WHERE idProyecto = " + idProyecto.ToString() + " ", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim data As New DataTable
        adapter.Fill(data)

        TXT_DET_NOMBRE.Text = data.Rows(0).Item("nombreProyecto").ToString()
        TXT_DET_DESCRIPCION.Text = data.Rows(0).Item("descripcionProyecto").ToString()
        CB_DET_CLIENTE.SelectedValue = data.Rows(0).Item("idCliente")
        DTP_DET_FECHA_INICIO.Value = data.Rows(0).Item("fechaInicio")
        DTP_DET_FECHA_FIN.Value = data.Rows(0).Item("fechaEstimadaFin")
        conn.Close()

        Dim conn2 As New SqlConnection(FRM_LOGIN.connstr)
        conn2.Open()
        Try
            Dim command2 As New SqlCommand("EXEC SP_GET_PROGRESO @idProyecto", conn2)
            command2.Parameters.AddWithValue("@idProyecto", idProyecto)
            Dim adapter2 As New SqlDataAdapter(command2)
            Dim data2 As New DataTable
            adapter2.Fill(data2)
            conn2.Close()

            PB_AVANCE_ACTUAL.Value = data2.Rows(0).Item("progresoReal")
            PB_AVANCE_ESPERADO.Value = data2.Rows(0).Item("progresoEsperado")
            LBL_RETRASO_DIAS.Text = data2.Rows(0).Item("retraso").ToString() + " días"
        Catch exc As Exception
            conn2.Close()
        End Try
        isMoving = False
        modificoFechaFin = False
    End Sub
    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)
        'Fecha final se mostrara en un label porque se debe calcular las fechas automaticamente de acuerdo a la fecha inicio y a la duracion puesta
        'CADA COMBOBOX DEBE INICIAR CON OPCION "SELECCIONA"
        'LA FECHA INICIAL EN EL DTP DE PLAN DE TRABAJO NO DEBE SER LA DEL DIA ACTUAL
        ' COMBOBOX DE TAREAS PREDECESORA DEBE REFRESCARSE CADA QUE SE AÑADA UNA NUEVA
        ' GRID DE PLAN DE TRABAJO DEBE MOSTRAR CATEGORIA, INICIO, FIN , DURACION, RESPONSABLE Y TENER UN CHECKBOX DE UNA COSA QUE NO RECUERDO
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TBP_PROYECTO_ARCHIVOS.Click
        'TEXTBOX DONDE ESTE LA UBICACION DEL ARCHIVO DEBE IR INHABILITADO
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TBP_BALANCE.Click
        'EN GRID DE GASTOS INGRESO,, VA CONCEPTO (ORDENADO DEL MAS RECIENTE AL MAS VIEJO),FECHA, REFERECIA, INGRESO, GASTO DEPENDIENDO DE LO QUE SEA
    End Sub
    'Esta es la parte de editar el proyectazo'
    Private Sub CHB_PROYECTO_EDITAR_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_PROYECTO_EDITAR.CheckedChanged
        If CHB_PROYECTO_EDITAR.Checked Then
            TXT_DET_NOMBRE.Enabled = True
            DTP_DET_FECHA_FIN.Enabled = True
            CB_DET_CLIENTE.Enabled = True
            BTN_DET_GUARDAR.Visible = True
            TXT_DET_DESCRIPCION.Enabled = True
        Else
            TXT_DET_NOMBRE.Enabled = False
            DTP_DET_FECHA_FIN.Enabled = False
            CB_DET_CLIENTE.Enabled = False
            TXT_DET_DESCRIPCION.Enabled = False
            BTN_DET_GUARDAR.Visible = False
        End If

    End Sub

    Private Sub BTN_DET_GUARDAR_Click(sender As Object, e As EventArgs) Handles BTN_DET_GUARDAR.Click
        Dim newNombre As String = TXT_DET_NOMBRE.Text.Trim()
        Dim descripcion As String = TXT_DET_DESCRIPCION.Text.Trim()
        Dim indexCliente As Int32 = CB_DET_CLIENTE.SelectedValue
        Dim fechaInicio As Date = DTP_DET_FECHA_INICIO.Value.Date
        Dim fechaFin As Date = DTP_DET_FECHA_FIN.Value.Date

        If newNombre <> "" Then
            If descripcion <> "" Then
                If fechaFin > fechaInicio Then
                    If Proyecto.EditarProyecto(idProyectoActual, newNombre, indexCliente, descripcion, fechaInicio, fechaFin) Then
                        CustomMessage.show("Exito", "Se ha modificado el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                        If modificoFechaFin Then
                            CustomMessage.show("Aviso", "Ha modificado la fecha fin del proyecto " + vbCr + "Por favor proporcione información", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                            Dim frmModificacion As New FRM_MOTIVO_MODIFICACION(fechaFin, idProyectoActual)
                            frmModificacion.ShowDialog()
                        End If
                    Else
                        CustomMessage.show("Exito", "No se ha modificado el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                Else
                    CustomMessage.show("Aviso", "La fecha fin no puede ser menor a la fecha inicio", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                CustomMessage.show("Aviso", "No deje el campo descripcion vacio", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        Else
            CustomMessage.show("Aviso", "No deje el campo nombre vacio", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    'Esta es la parte de archivos krnal'
    Private Sub DGV_PROYECTO_ARCHIVOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROYECTO_ARCHIVOS.CellContentClick
        If DGV_PROYECTO_ARCHIVOS.RowCount > 1 Then
            Dim ColumnName As String = DGV_PROYECTO_ARCHIVOS.Columns(e.ColumnIndex).Name
            idArchivo = DGV_PROYECTO_ARCHIVOS.Rows(e.RowIndex).Cells("GV_ARCHIVO_ID").Value.ToString()
            If ColumnName = "GV_ARCHIVO_ELIMINAR" Then
                If Archivo.Eliminar(idArchivo) Then
                    CustomMessage.show("Exito", "Se ha eliminado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Error", "No se pudo eliminar el proyecto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If ColumnName = "GV_ARCHIVO_EDITAR" Then
                    TXT_ARCHIVO_NOMBRE.Text = DGV_PROYECTO_ARCHIVOS.Rows(e.RowIndex).Cells("GV_ARCHIVO_NOMBRE").Value.ToString()
                    isEditing = True
                End If
            End If
            Archivo.FillDataGrid(DGV_PROYECTO_ARCHIVOS, idProyectoActual)
            FormActions.clearTextBoxes(TBP_PROYECTO_ARCHIVOS)
        End If
    End Sub

    Private Sub BTN_ARCHIVO_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_ARCHIVO_AGREGAR.Click
        Dim nameArchivo As String = TXT_ARCHIVO_NOMBRE.Text.Trim()
        If isEditing Then
            If nameArchivo <> "" Then
                Dim msgRes As DialogResult = CustomMessage.show("Aviso", "Intenta registrar un campo vacio" + vbCr + "¿Desea elminar el registro?", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                If msgRes = DialogResult.Yes Then
                    If Archivo.Eliminar(idArchivo) Then
                        CustomMessage.show("Exito", "Se ha borrado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                        Archivo.FillDataGrid(DGV_PROYECTO_ARCHIVOS, idProyectoActual)
                    Else
                        CustomMessage.show("Aviso", "No se ha borrado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                End If
            Else
                If Archivo.Editar(nameArchivo, idArchivo) Then
                    CustomMessage.show("Exito", "Se ha editado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Archivo.FillDataGrid(DGV_PROYECTO_ARCHIVOS, idProyectoActual)
                    isEditing = False
                Else
                    CustomMessage.show("Aviso", "No se ha registrado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
        Else
            If nameArchivo <> "" Then
                If Archivo.AgregarArchivo(nameArchivo, idProyectoActual) Then
                    CustomMessage.show("Exito", "Se ha registrado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Archivo.FillDataGrid(DGV_PROYECTO_ARCHIVOS, idProyectoActual)
                Else
                    CustomMessage.show("Aviso", "No se ha registrado el archivo", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                CustomMessage.show("Aviso", "No deje campos vacios", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        End If
    End Sub

    Private Sub BTN_ING_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_ING_SAVE.Click
        Dim concepto As String = TXT_ING_CONCEPTO.Text
        Dim referencia As String = TXT_ING_REFERENCIA.Text
        Dim fecha As Date = DTP_ING_INGRESO.Value.Date
        Dim monto As String = TXT_ING_MONTO.Text
        Dim tipo As Char
        Dim isAnyCheckBoxChecked As Boolean = False
        If RB_INGRESO.Checked Then
            tipo = "I"
            isAnyCheckBoxChecked = True
        End If
        If RB_GASTO.Checked Then
            tipo = "G"
            isAnyCheckBoxChecked = True
        End If

        If monto <> "" And referencia <> "" And monto <> "" And isAnyCheckBoxChecked = True Then
            If isEditing = False Then
                If Movimiento.Add(concepto, fecha, referencia, Int32.Parse(monto), tipo, idProyectoActual, 1) Then
                    CustomMessage.show("Exito", "Se he registado la transaccion", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se ha registrado la transaccion", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Movimiento.Edit(idTransaccion, concepto, fecha, referencia, Double.Parse(monto), tipo) Then
                    CustomMessage.show("Exito", "Se ha modificado la transaccion", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    isEditing = False
                Else
                    CustomMessage.show("Aviso", "No se ha modificado la transaccion", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
            Movimiento.FillDataGrid(DGV_TRANSACCIONES, idProyectoActual)
            FormActions.clearTextBoxes(TBP_BALANCE)

        Else
            CustomMessage.show("Aviso", "No deje campos vacios", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_TRANSACCIONES.CellContentClick
        If DGV_TRANSACCIONES.ColumnCount > 1 Then
            Dim ColumnName As String = DGV_TRANSACCIONES.Columns(e.ColumnIndex).Name
            idTransaccion = DGV_TRANSACCIONES.Rows(e.RowIndex).Cells("GV_TRANSACCION_ID").Value
            If ColumnName = "GV_TRANSACCION_EDITAR" Then
                TXT_ING_CONCEPTO.Text = DGV_TRANSACCIONES.Rows(e.RowIndex).Cells("GV_TRANSACCION_CONCEPTO").Value.ToString()
                TXT_ING_REFERENCIA.Text = DGV_TRANSACCIONES.Rows(e.RowIndex).Cells("GV_TRANSACCION_REFERENCIA").Value.ToString()
                TXT_ING_MONTO.Text = DGV_TRANSACCIONES.Rows(e.RowIndex).Cells("GV_TRANSACCION_MONTO").Value.ToString()
                Dim tipo As Char = DGV_TRANSACCIONES.Rows(e.RowIndex).Cells("GV_TRANSACCION_TIPO").Value
                If tipo = "I" Then
                    RB_INGRESO.Checked = True
                    RB_GASTO.Checked = False
                Else
                    RB_GASTO.Checked = True
                    RB_INGRESO.Checked = False
                End If
                isEditing = True
            End If
        End If
    End Sub

    Private Sub BTN_INV_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_INV_SAVE.Click
        Dim nombre As String = TXT_INV_NOMBRE.Text.Trim()
        Dim correo As String = TXT_INV_MAIL.Text.Trim()
        Dim idRole As Int32 = CMB_INV_ROL.SelectedValue
        Dim isActivo As Int32
        If CB_INV_ACTIVO.Checked Then
            isActivo = True
        Else
            isActivo = False
        End If
        If nombre <> "" And correo <> "" And idRole <> 0 Then
            If isEditing Then
                If Involucrado.Update(idInv, nombre, correo, idRole) Then
                    CustomMessage.show("Exito", "Se ha registrado con exito", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    FormActions.clearTextBoxes(TBP_PROYECTO_INVOLUCRADO)
                    isEditing = False
                Else
                    CustomMessage.show("Aviso", "No se ha pudo actualizar", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Involucrado.Add(idProyectoActual, nombre, correo, idRole) Then
                    CustomMessage.show("Exito", "Se ha registrado con exito", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se ha registrado", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
            Involucrado.FillDataGrid(DGV_PROYECTO_INVOLUCRADO, idProyectoActual)
            FormActions.clearTextBoxes(TBP_PROYECTO_INVOLUCRADO)
        End If
    End Sub

    Private Sub TBC_PROYECTO_TabIndexChanged(sender As Object, e As EventArgs) Handles TBC_PROYECTO.TabIndexChanged

    End Sub

    Private Sub BTN_ARCHIVO_EXAMINAR_Click(sender As Object, e As EventArgs) Handles BTN_ARCHIVO_EXAMINAR.Click
        OFD_PROYECTO.Title = "Seleccionar archivo"
        OFD_PROYECTO.ShowDialog()
        Dim direccion As String = OFD_PROYECTO.FileName
        Dim dirCompuesta() As String = direccion.Split("/")
        direccion = dirCompuesta.Last()
        TXT_ARCHIVO_NOMBRE.Text = direccion
    End Sub

    Private Sub TBP_PROYECTO_INVOLUCRADO_Click(sender As Object, e As EventArgs) Handles TBP_PROYECTO_INVOLUCRADO.Click

    End Sub

    Private Sub LBL_NAME_MouseDown(sender As Object, e As MouseEventArgs) Handles LBL_NAME.MouseDown
        isMoving = True
        pos.X = Cursor.Position.X - Me.Left
        pos.Y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LBL_NAME_MouseMove(sender As Object, e As MouseEventArgs) Handles LBL_NAME.MouseMove
        If (isMoving) Then
            Me.Left = Cursor.Position.X - pos.X
            Me.Top = Cursor.Position.Y - pos.Y
        End If
    End Sub

    Private Sub LBL_NAME_MouseUp(sender As Object, e As MouseEventArgs) Handles LBL_NAME.MouseUp
        isMoving = False
    End Sub

    Private Sub BTN_PDT_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_PDT_SAVE.Click
        Dim descripcion As String = TXT_PDT_DESCRIPCION_TAREA.Text.Trim()
        Dim idCat As Int32 = CMB_PDT_CATEGORIA.SelectedValue
        Dim duracionDias As Int32 = NUD_PDT_DURACION.Value
        Dim idTareaAnt As Int32 = CMB_PDT_TAREA_ANT.SelectedValue
        Dim idInvolucrado As Int32 = CMB_PDT_RESPONSABLE.SelectedValue
        Dim fechaInicio As Date = DTP_DET_FECHA_INICIO.Value.Date


        If descripcion <> "" Then
            If isEditing = False Then
                If Tarea.Add(descripcion, idCat, fechaInicio, duracionDias, idTareaAnt, idInvolucrado, idProyectoActual) Then
                    CustomMessage.show("Exito", "Se ha registrado la tarea", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    'DGV_PROYECTO_PLAN
                    Tarea.FillDataGrid(DGV_PROYECTO_PLAN, idProyectoActual)
                Else
                    CustomMessage.show("Aviso", "No se ha podido registrar la tarea", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Tarea.Update(idTarea, idProyectoActual, idCat, descripcion, duracionDias, fechaInicio, idTareaAnt, idInvolucrado) Then
                    CustomMessage.show("Exito", "Se ha editado con exito", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    isEditing = False
                    idTarea = 0 
                Else
                    CustomMessage.show("Aviso", "No ha podido editar", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            End If
        Else
            CustomMessage.show("Aviso", "No deje campos vacios", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub
    Private Sub TBC_PROYECTO_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TBC_PROYECTO.DrawItem
        Dim g As Graphics = e.Graphics
        Dim _textBrush As Brush

        'Get the item from the collection.
        Dim _tabPage As TabPage = TBC_PROYECTO.TabPages(e.Index) ' TabPages(e.Index)

        ' Get the real bounds for the tab rectangle.
        Dim _tabBounds As Rectangle = TBC_PROYECTO.GetTabRect(e.Index)

        If (e.State = DrawItemState.Selected) Then
            ' Draw a different background color, And don't paint a focus rectangle.
            _textBrush = New SolidBrush(Color.FromArgb(206, 206, 206))
            Dim _fillBrush As New SolidBrush(Color.FromArgb(26, 26, 26))
            g.FillRectangle(_fillBrush, e.Bounds)
        Else
            _textBrush = New System.Drawing.SolidBrush(e.ForeColor)
            e.DrawBackground()
        End If

        ' Use our own font.
        Dim _tabFont As New Font("MS Reference Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Pixel)

        ' Draw string. Center the text.
        Dim _stringFlags As New StringFormat()
        _stringFlags.Alignment = StringAlignment.Center
        _stringFlags.LineAlignment = StringAlignment.Center
        g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, New StringFormat(_stringFlags))
    End Sub

    Private Sub CB_PLAN_RESPONSABLE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_PDT_RESPONSABLE.SelectedIndexChanged

    End Sub
    Private Sub CMB_CNT_PAIS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_CNT_PAIS.SelectedIndexChanged
        Contacto.FillEstadoComboBox(CMB_CNT_ESTADO, CMB_CNT_PAIS.SelectedValue)
    End Sub

    Private Sub DGV_PROYECTO_PLAN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROYECTO_PLAN.CellContentClick
        If DGV_PROYECTO_PLAN.RowCount > 0 Then
            Dim columnName As String = DGV_PROYECTO_PLAN.Columns(e.ColumnIndex).Name
            idTarea = DGV_PROYECTO_PLAN.Rows(e.RowIndex).Cells("GV_TAREA_ID").Value
            If columnName = "eliminarTarea" Then
                If Tarea.CheckIfHasTareaPredecesora(idTarea) Then
                    Dim msgResultado As DialogResult
                    msgResultado = CustomMessage.show("Aviso", "La tarea actual es necesaria para otras tareas" + vbCr + "¿Desea continuar? Se eliminará junto con las demás", MessageBoxButtons.YesNo, Color.FromArgb(46, 46, 46))
                    If msgResultado = DialogResult.Yes Then
                        If Tarea.Delete(idTarea, idProyectoActual) Then
                            CustomMessage.show("Aviso", "Se ha eliminado correctamente la tarea", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                        End If
                    End If
                Else
                    If Tarea.Delete(idTarea, idProyectoActual) Then
                        CustomMessage.show("Aviso", "Se ha eliminado correctamente la tarea", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    Else
                        CustomMessage.show("Aviso", "No se ha eliminado correctamente la tarea", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End If
                End If
            Else
                If columnName = "editarTarea" Then
                    Dim conn As New SqlConnection(FRM_LOGIN.connstr)
                    Try
                        conn.Open()
                        Dim command As New SqlCommand("SELECT * FROM Tarea WHERE idTarea = " + idTarea.ToString() + " ", conn)
                        Dim dataTable As New DataTable
                        Dim adapter As New SqlDataAdapter(command)
                        adapter.Fill(dataTable)
                        conn.Close()
                        TXT_PDT_DESCRIPCION_TAREA.Text = dataTable.Rows(0).Item("descripcionTarea").ToString()
                        NUD_PDT_DURACION.Value = dataTable.Rows(0).Item("duracionDias")
                        CMB_PDT_CATEGORIA.SelectedValue = dataTable.Rows(0).Item("idCategoria")
                        CMB_PDT_RESPONSABLE.SelectedValue = dataTable.Rows(0).Item("idInvolucrado")
                        Dim tareaAnt As Int32
                        If IsDBNull(dataTable.Rows(0).Item("idTareaPredecesora")) Then
                            CMB_PDT_TAREA_ANT.SelectedValue = 0
                        Else
                            CMB_PDT_TAREA_ANT.SelectedValue = dataTable.Rows(0).Item("idTareaPredecesora")
                        End If
                        isEditing = True
                    Catch ex As Exception
                        conn.Close()
                        CustomMessage.show("Aviso", "Hubo un problema al tratar de obtener datos de la base", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub BTN_DIR_AGREGAR_Click(sender As Object, e As EventArgs) Handles BTN_DIR_AGREGAR.Click
        Dim nombre As String = TXT_DIR_NOMBRE.Text.Trim()
        Dim telefonoMovil As String = TXT_DIR_TELM.Text.Trim()
        Dim telefonoFijo As String = TXT_DIR_TELF.Text.Trim()
        Dim correo As String = TXT_DIR_MAIL.Text.Trim()
        Dim calle As String = TXT_DIR_CALLE.Text.Trim()
        Dim numero As String = TXT_DIR_NUMERO.Text.Trim()
        Dim colonia As String = TXT_DIR_COLONIA.Text.Trim()
        Dim codigoPostal As String = TXT_DIR_CP.Text.Trim()
        Dim idPais As Int32 = CMB_CNT_PAIS.SelectedValue
        Dim idEstado As Int32 = CMB_CNT_ESTADO.SelectedValue
        Dim idCiudad As Int32 = CMB_CNT_CIUDAD.SelectedValue

        If nombre <> "" And calle <> "" And colonia <> "" And codigoPostal <> "" And correo <> "" And numero <> "" And colonia <> "" And idEstado <> 0 And idCiudad <> 0 And idPais <> 0 Then
            If isEditing = False Then
                If Contacto.Add(idProyectoActual, nombre, correo, telefonoFijo, telefonoMovil, calle, numero, colonia, idCiudad, idEstado, idPais, codigoPostal) Then
                    CustomMessage.show("Exito", "Se ha registrado el contacto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se ha registrado el contacto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Else
                If Contacto.Update(idContacto, nombre, correo, telefonoFijo, telefonoMovil, calle, numero, colonia, idCiudad, idEstado, idPais, codigoPostal) Then
                    CustomMessage.show("Exito", "Se ha editado el contacto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se ha editado el contacto", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
                isEditing = False
            End If
        Else
            CustomMessage.show("Aviso", "No deje campos importantes vacios", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
        End If
    End Sub

    Private Sub CMB_CNT_ESTADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_CNT_ESTADO.SelectedIndexChanged
        Dim index As Int32 = CMB_CNT_ESTADO.SelectedValue
        Contacto.FillCiudadComboBox(CMB_CNT_CIUDAD, index)
    End Sub

    Private Sub BTN_PDT_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_PDT_CANCEL.Click
        FormActions.clearTextBoxes(TBP_PROYECTO_PLAN)
        NUD_PDT_DURACION.ResetText()
    End Sub

    Private Sub FRM_DETALLE_PROYECTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CMB_BLN_MES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_BLN_MES.SelectedIndexChanged
        If CMB_BLN_MES.SelectedIndex > 0 Then
            Movimiento.PorcentajeIngresoGasto(PB_PORCENTAJE_INGRESO, PB_PORCENTAJE_GASTOS, LBL_BLN_INGRESOS, LBL_BLN_GASTOS, LBL_BLN_BALANCE, CMB_BLN_MES.SelectedIndex, NUD_BLN_ANIO.Value, idProyectoActual)
        Else
            PB_PORCENTAJE_GASTOS.Value = 0
            PB_PORCENTAJE_GASTOS.Text = "0%"
            PB_PORCENTAJE_INGRESO.Value = 0
            PB_PORCENTAJE_INGRESO.Text = "0%"
        End If
    End Sub

    Private Sub DTP_DET_FECHA_FIN_ValueChanged(sender As Object, e As EventArgs) Handles DTP_DET_FECHA_FIN.ValueChanged
        modificoFechaFin = True
    End Sub

    Private Sub TBC_PROYECTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TBC_PROYECTO.SelectedIndexChanged
        Dim tabIndex As Int32 = TBC_PROYECTO.SelectedIndex
        Select Case tabIndex
            Case 0
            Case 1
                Involucrado.FillDataGrid(DGV_PROYECTO_INVOLUCRADO, idProyectoActual)
                Rol.FillComboBox(CMB_INV_ROL)
            Case 2
                Tarea.FillDataGrid(DGV_PROYECTO_PLAN, idProyectoActual)
                Tarea.FillComboBox(CMB_PDT_TAREA_ANT, idProyectoActual)
                Categoria.FillComboBox(CMB_PDT_CATEGORIA)
                Involucrado.FillComboBox(CMB_PDT_RESPONSABLE, idProyectoActual)
            Case 3
                Archivo.FillDataGrid(DGV_PROYECTO_ARCHIVOS, idProyectoActual)
            Case 4
                Dim anio As Int32 = NUD_BLN_ANIO.Value
                Dim mes As Int32 = CMB_BLN_MES.SelectedIndex
                Movimiento.FillDataGrid(DGV_TRANSACCIONES, idProyectoActual)
                If Movimiento.PorcentajeIngresoGasto(PB_PORCENTAJE_INGRESO, PB_PORCENTAJE_GASTOS, LBL_BLN_INGRESOS, LBL_BLN_GASTOS, LBL_BLN_BALANCE, mes, anio, idProyectoActual) = False Then
                    CustomMessage.show("Aviso", "No se pudo obtener el reporte de balance", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
            Case 5
                Contacto.FillDataGrid(DGV_PROYECTO_CONTACTOS, idProyectoActual)
                Contacto.FillPaisComboBox(CMB_CNT_PAIS)
            Case 6
                Modificacion.FillDataGridView(DGV_PROYECTO_MODIFICACION)
            Case 7
                GENERAR_LINEA_DE_TIEMPO()
        End Select
        isEditing = False
    End Sub

    Private Sub DGV_PROYECTO_INVOLUCRADO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_PROYECTO_INVOLUCRADO.CellContentClick
        If DGV_PROYECTO_INVOLUCRADO.RowCount > 1 Then
            Dim cellName As String = DGV_PROYECTO_INVOLUCRADO.Columns(e.ColumnIndex).Name
            idInv = DGV_PROYECTO_INVOLUCRADO.Rows(e.RowIndex).Cells("GV_INV_ID").Value
            If cellName = "eliminarInvolucrado" Then
                If Involucrado.Delete(idInv) Then
                    CustomMessage.show("Exito", "Se ha eliminado el involucrado", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                Else
                    CustomMessage.show("Aviso", "No se ha eliminado el involucrado", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
                End If
                Involucrado.FillDataGrid(DGV_PROYECTO_INVOLUCRADO, idProyectoActual)
            Else
                If cellName = "editarInvolucrado" Then
                    TXT_INV_NOMBRE.Text = DGV_PROYECTO_INVOLUCRADO.Rows(e.RowIndex).Cells("GV_INV_NOMBRE").Value.ToString()
                    TXT_INV_MAIL.Text = DGV_PROYECTO_INVOLUCRADO.Rows(e.RowIndex).Cells("GV_INV_CORREO").Value.ToString()
                    CMB_INV_ROL.SelectedValue = DGV_PROYECTO_INVOLUCRADO.Rows(e.RowIndex).Cells("GV_INV_IDROL").Value
                    GPB_INV_DESEMPENO.Visible = True
                    CB_INV_ACTIVO.Checked = DGV_PROYECTO_INVOLUCRADO.Rows(e.RowIndex).Cells("GV_INV_ACTIVO").Value
                    Involucrado.GetDesempenio(idInv, idProyectoActual, PB_INV_DESEMPEÑO, LBL_PORCENTAJE_DESEMPENIO)
                    isEditing = True
                End If
            End If
        End If
    End Sub

    Private Sub BTN_INV_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_INV_CANCEL.Click
        isEditing = False
        FormActions.clearTextBoxes(TBP_PROYECTO_INVOLUCRADO)
        GPB_INV_DESEMPENO.Visible = False
    End Sub

    Private Sub BTN_ARCH_CANCELAR_Click(sender As Object, e As EventArgs) Handles BTN_ARCH_CANCELAR.Click
        isEditing = False
        TXT_ARCHIVO_NOMBRE.Text = ""
    End Sub

    Private Sub GENERAR_LINEA_DE_TIEMPO()
        Dim indix As Int32
        Dim columnindix As Int32


        Dim conn As New SqlConnection(FRM_LOGIN.connstr)
        conn.Open()
        Dim command As New SqlCommand("SELECT T.fechaInicio 
                                    From Tarea T 
                                    WHERE T.idProyecto = '" + idProyectoActual.ToString() + "'
                                    UNION
                                    SELECT T.fechaFin 
                                    From Tarea T 
                                    WHERE T.idProyecto = '" + idProyectoActual.ToString() + "'", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable
        adapter.Fill(dataTable)
        conn.Close()

        indix = 0
        'generar columnas
        While (indix < dataTable.Rows.Count)
            Dim myDataCol As New DataGridViewImageColumn()
            myDataCol.HeaderText = dataTable.Rows(indix).Item(0)
            myDataCol.Width = 85
            myDataCol.Image = Proyecto_Final_0.My.Resources.Resources.white
            DGV_PROYECTO_LINEA_DE_TIEMPO.Columns.Add(myDataCol)
            indix = indix + 1
        End While

        'hacer los registros
        conn.Open()
        Dim command2 As New SqlCommand("SELECT T.descripcionTarea, 
                                        T.fechaInicio,
                                        T.fechaFin,
                                        T.idCategoria
                                        From Tarea T 
                                        WHERE T.idProyecto = '" + idProyectoActual.ToString() +
                                        "'ORDER BY T.idCategoria", conn)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim dataTable2 As New DataTable
        adapter2.Fill(dataTable2)
        conn.Close()
        indix = 0
        While (indix < dataTable2.Rows.Count)
            DGV_PROYECTO_LINEA_DE_TIEMPO.Rows.Add(dataTable2.Rows(indix).Item(0))
            indix = indix + 1
        End While
        'colorear registros

        indix = 0
        columnindix = 1
        Dim colorear As Boolean
        colorear = False
        While (indix < dataTable2.Rows.Count)
            colorear = False
            While (columnindix < DGV_PROYECTO_LINEA_DE_TIEMPO.Columns.Count)

                If (dataTable2.Rows(indix).Item(1) = DGV_PROYECTO_LINEA_DE_TIEMPO.Columns(columnindix).HeaderText) Then
                    colorear = True
                End If

                If (colorear = True) Then
                    Dim cell As New DataGridViewImageCell
                    cell = CType(DGV_PROYECTO_LINEA_DE_TIEMPO.Rows(indix).Cells(columnindix), DataGridViewImageCell)
                    cell.Value = Proyecto_Final_0.My.Resources.Resources.green
                End If

                If (dataTable2.Rows(indix).Item(2) = DGV_PROYECTO_LINEA_DE_TIEMPO.Columns(columnindix).HeaderText) Then
                    colorear = False
                End If

                columnindix = columnindix + 1
            End While
            columnindix = 1
            indix = indix + 1
        End While
        'agregar categorias
        Dim cate As Int16
        Dim categoriaAct As Int16
        categoriaAct = 0
        cate = 0
        Dim nuevorowcategoria As Int16
        nuevorowcategoria = 0
        Dim indexcategorias As Int16
        indexcategorias = 0
        Dim categoriasusadas As Int16
        categoriasusadas = 0
        While (indexcategorias < dataTable2.Rows.Count)
            cate = dataTable2.Rows(indexcategorias).Item(3)
            If (cate > categoriaAct) Then
                categoriaAct = cate
                nuevorowcategoria = indexcategorias + categoriasusadas
                DGV_PROYECTO_LINEA_DE_TIEMPO.Rows.Insert(nuevorowcategoria, "Categoria '" + categoriaAct.ToString() + "'")
                columnindix = 1
                While (columnindix < DGV_PROYECTO_LINEA_DE_TIEMPO.Columns.Count)
                    Dim cell As New DataGridViewImageCell
                    cell = CType(DGV_PROYECTO_LINEA_DE_TIEMPO.Rows(nuevorowcategoria).Cells(columnindix), DataGridViewImageCell)
                    cell.Value = Proyecto_Final_0.My.Resources.Resources.blue
                    columnindix = columnindix + 1
                End While
                categoriasusadas = categoriasusadas + 1
            End If
            indexcategorias = indexcategorias + 1
        End While
    End Sub

    Private Sub BTN_ING_CANCEL_Click(sender As Object, e As EventArgs) Handles BTN_ING_CANCEL.Click
        FormActions.clearTextBoxes(TBP_BALANCE)
        RB_GASTO.Checked = False
        RB_INGRESO.Checked = False
    End Sub
End Class