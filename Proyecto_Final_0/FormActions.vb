Imports System.Windows.Forms

Public Class FormActions
    Public Shared Function clearTextBoxes(container As TabPage)
        For Each TXT_CTRL As TextBox In container.Controls.OfType(Of TextBox)
            TXT_CTRL.Text = ""
        Next
        Return 0
    End Function
    Public Shared Function resetButtonsBackColor(container As Control)
        For Each BTN_CTRL As Button In container.Controls.OfType(Of Button)
            BTN_CTRL.BackColor = Color.Transparent
        Next
        Return 0
    End Function
End Class
