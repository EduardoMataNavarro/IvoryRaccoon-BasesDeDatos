Imports System.Windows.Forms

Public Class CustomMessage
    Public Shared Function show(title As String, text As String, buttons As MessageBoxButtons, color As Color) As DialogResult
        Dim dlgRes As DialogResult = DialogResult.None
        Select Case buttons
            Case MessageBoxButtons.OK
                Dim mbOk As New MB_OK
                mbOk.Message = text
                mbOk.Title = title
                mbOk.BackColor = color
                dlgRes = mbOk.ShowDialog()
            Case MessageBoxButtons.YesNo
                Dim mbYesNo As New MB_YESNO
                mbYesNo.Message = text
                mbYesNo.Title = title
                mbYesNo.BackColor = color
                dlgRes = mbYesNo.ShowDialog()
        End Select
        Return dlgRes
    End Function
End Class
