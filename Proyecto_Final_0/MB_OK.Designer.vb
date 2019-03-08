<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MB_OK
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LBL_TITLE = New System.Windows.Forms.Label()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.BTN_1 = New System.Windows.Forms.Button()
        Me.LBL_TEXT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL_TITLE
        '
        Me.LBL_TITLE.AutoSize = True
        Me.LBL_TITLE.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TITLE.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_TITLE.Location = New System.Drawing.Point(171, 15)
        Me.LBL_TITLE.Name = "LBL_TITLE"
        Me.LBL_TITLE.Size = New System.Drawing.Size(74, 19)
        Me.LBL_TITLE.TabIndex = 14
        Me.LBL_TITLE.Text = "Message"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Location = New System.Drawing.Point(378, 9)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(35, 35)
        Me.BTN_CLOSE.TabIndex = 1
        Me.BTN_CLOSE.Text = "X"
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'BTN_1
        '
        Me.BTN_1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTN_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_1.Location = New System.Drawing.Point(163, 147)
        Me.BTN_1.Name = "BTN_1"
        Me.BTN_1.Size = New System.Drawing.Size(92, 32)
        Me.BTN_1.TabIndex = 0
        Me.BTN_1.Text = "Ok"
        Me.BTN_1.UseVisualStyleBackColor = True
        '
        'LBL_TEXT
        '
        Me.LBL_TEXT.AutoSize = True
        Me.LBL_TEXT.Location = New System.Drawing.Point(70, 63)
        Me.LBL_TEXT.Name = "LBL_TEXT"
        Me.LBL_TEXT.Size = New System.Drawing.Size(51, 17)
        Me.LBL_TEXT.TabIndex = 18
        Me.LBL_TEXT.Text = "Label1"
        '
        'MB_OK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_TEXT)
        Me.Controls.Add(Me.BTN_1)
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.Controls.Add(Me.LBL_TITLE)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MB_OK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_TITLE As Label
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents BTN_1 As Button
    Friend WithEvents LBL_TEXT As Label
End Class
