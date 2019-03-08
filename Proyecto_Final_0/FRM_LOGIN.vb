Imports System.Data.SqlClient


Public Class FRM_LOGIN

    Public Shared user As String = "SP00RDO-2\SQLEXPRESS"
    Public Shared connstr As String = "Data Source =" + user + "; Initial Catalog = ProyectoBD ;Integrated Security= True"
    Public Shared idUsuario As Int32
    Dim pos As Point
    Dim isMoving As Boolean

    Private Sub FRM_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub BTN_LOG_IN_Click(sender As Object, e As EventArgs) Handles BTN_LOG_IN.Click

        Dim mail As String = TXT_LOG_MAIL.Text.Trim()
        Dim pass As String = TXT_LOG_PASSWORD.Text.Trim()
        Dim queryResult As Int16 = Usuario.LogIn(mail, pass, idUsuario)
        If queryResult > 1 Then
            Dim mainWindow As New FRM_DASHBOARD(queryResult)
            mainWindow.Show()
            Me.Hide()
        Else
            If queryResult = 1 Then
                CustomMessage.show("Aviso", "El usuario no tiene permiso para ingresar", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            Else
                CustomMessage.show("Error", "Asegurese que las credenciales " + vbCr + "ingresadas sean correctas", MessageBoxButtons.OK, Color.FromArgb(46, 46, 46))
            End If
        End If
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
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

    Private Sub BTN_MINIMIZE_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LBL_NAME_Click(sender As Object, e As EventArgs) Handles LBL_NAME.Click

    End Sub


End Class