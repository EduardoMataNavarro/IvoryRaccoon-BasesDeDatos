Public Class FRM_DASHBOARD

    Dim pos As Point
    Dim isMoving As Boolean

    Public Sub New(mode As Int16)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        If mode = 3 Then
            BTN_USERS.Visible = True
        End If

        ' LBL_USER_NAME.Text = userInfo.Item("nombreCompletoUsuario").ToString()

        ' BTN_USERS.Visible = userInfo.Item("administrador")

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_MINIMIZE.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Dim dlgRes As DialogResult = CustomMessage.show("Aviso", "Desea realmente salir de la aplicaciòn?", MessageBoxButtons.YesNo, Me.BackColor)
        If dlgRes = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FRM_DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmMain As New FRM_PROYECTO
        frmMain.TopLevel = False
        frmMain.Show()
        PNL_MAIN.Controls.Add(frmMain)

        BTN_PROYECTO.BackColor = BTN_PROYECTO.FlatAppearance.MouseOverBackColor
    End Sub

    Private Sub BTN_PROYECTO_Click(sender As Object, e As EventArgs) Handles BTN_PROYECTO.Click

        PNL_MAIN.Controls.Clear()
        Dim frmProject As New FRM_PROYECTO
        frmProject.TopLevel = False
        frmProject.Show()
        PNL_MAIN.Controls.Add(frmProject)

        FormActions.resetButtonsBackColor(Me)
        BTN_PROYECTO.BackColor = BTN_PROYECTO.FlatAppearance.MouseOverBackColor
    End Sub


    Private Sub BTN_USERS_Click(sender As Object, e As EventArgs) Handles BTN_USERS.Click

        PNL_MAIN.Controls.Clear()
        Dim frmUsers As New FRM_USUARIOS
        frmUsers.TopLevel = False
        frmUsers.Show()
        PNL_MAIN.Controls.Add(frmUsers)

        FormActions.resetButtonsBackColor(Me)
        BTN_USERS.BackColor = BTN_USERS.FlatAppearance.MouseOverBackColor
    End Sub

    'Private Sub BTN_CATEGORIA_Click(sender As Object, e As EventArgs) Handles BTN_CATEGORIA.Click
    '    PNL_MAIN.Controls.Clear()
    '    Dim frmCats As New FRM_CATEGORIA
    '    frmCats.TopLevel = False
    '    frmCats.Show()
    '    PNL_MAIN.Controls.Add(frmCats)

    '    FormActions.resetButtonsBackColor(Me)
    '    BTN_CATEGORIA.BackColor = BTN_CATEGORIA.FlatAppearance.MouseOverBackColor
    'End Sub

    Private Sub BTN_ROLES_Click(sender As Object, e As EventArgs) Handles BTN_ROLES.Click
        PNL_MAIN.Controls.Clear()
        Dim frmRoles As New FRM_ROLES_CATEGORIA
        frmRoles.TopLevel = False
        frmRoles.Show()
        PNL_MAIN.Controls.Add(frmRoles)

        FormActions.resetButtonsBackColor(Me)
        BTN_ROLES.BackColor = BTN_ROLES.FlatAppearance.MouseOverBackColor
    End Sub

    Private Sub BTN_CLIENTES_Click(sender As Object, e As EventArgs) Handles BTN_CLIENTES.Click
        PNL_MAIN.Controls.Clear()
        Dim frmClients As New FRM_CLIENTE
        frmClients.TopLevel = False
        frmClients.Show()
        PNL_MAIN.Controls.Add(frmClients)

        FormActions.resetButtonsBackColor(Me)
        BTN_CLIENTES.BackColor = BTN_CLIENTES.FlatAppearance.MouseOverBackColor
    End Sub

    Private Sub PNL_MAIN_Paint(sender As Object, e As PaintEventArgs) Handles PNL_MAIN.Paint

    End Sub
End Class