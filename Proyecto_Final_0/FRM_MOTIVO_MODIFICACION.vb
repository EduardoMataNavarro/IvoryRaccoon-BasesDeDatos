Imports System.Data.SqlClient

Public Class FRM_MOTIVO_MODIFICACION
    Private pressedKeys As Int16
    Private idProyecto As Int32
    Public Sub New(nuevaFechaFin As Date, idProyecto As Int32)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.idProyecto = idProyecto
        DTP_MDN_FECHA_ACTUAL.Value = DateTime.Now
        DTP_MDN_NUEVA_FECHA_FIN.Value = nuevaFechaFin
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pressedKeys = 0
    End Sub
    Private Sub FRM_MOTIVO_MODIFICACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MDN_MOTIVO.KeyPress
        pressedKeys += 1
        If (pressedKeys > 5) Then
            BTN_MDN_TERMINADO.Visible = True
        End If
    End Sub

    Private Sub BTN_MDN_TERMINADO_Click(sender As Object, e As EventArgs) Handles BTN_MDN_TERMINADO.Click
        Dim fechaActual As Date = DTP_MDN_FECHA_ACTUAL.Value.Date
        Dim fechaModificacion As Date = DTP_MDN_NUEVA_FECHA_FIN.Value.Date
        Dim motivo As String = TXT_MDN_MOTIVO.Text.Trim()
        Dim idUsuario As Int32 = FRM_LOGIN.idUsuario
        If Modificacion.Add(idProyecto, fechaActual, fechaModificacion, idUsuario, motivo) Then
            CustomMessage.show("Exito", "Se ha registrado la modificacion", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            Me.Close()
        End If
    End Sub
End Class