Public Class MB_YESNO

    Dim isMoving As Boolean
    Dim pos As Point
    'Set y get del titublo del message box
    Public Property Title As String
        Get
            Return LBL_TITLE.Text
        End Get
        Set(value As String)
            LBL_TITLE.Text = value
        End Set
    End Property

    'Set y get del mensaje a mostrar en pantalla 
    Public Property Message As String
        Get
            Return LBL_TEXT.Text
        End Get
        Set(value As String)
            LBL_TEXT.Text = value
        End Set
    End Property


    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub LBL_NAME_MouseDown(sender As Object, e As MouseEventArgs) Handles LBL_TITLE.MouseDown
        isMoving = True
        pos.X = Cursor.Position.X - Me.Left
        pos.Y = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LBL_NAME_MouseMove(sender As Object, e As MouseEventArgs) Handles LBL_TITLE.MouseMove
        If (isMoving) Then
            Me.Left = Cursor.Position.X - pos.X
            Me.Top = Cursor.Position.Y - pos.Y
        End If
    End Sub

    Private Sub LBL_NAME_MouseUp(sender As Object, e As MouseEventArgs) Handles LBL_TITLE.MouseUp
        isMoving = False
    End Sub
End Class