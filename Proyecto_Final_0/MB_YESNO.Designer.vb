<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MB_YESNO
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
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.LBL_TITLE = New System.Windows.Forms.Label()
        Me.BTN_1 = New System.Windows.Forms.Button()
        Me.BTN_2 = New System.Windows.Forms.Button()
        Me.LBL_TEXT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Location = New System.Drawing.Point(378, 9)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(35, 35)
        Me.BTN_CLOSE.TabIndex = 2
        Me.BTN_CLOSE.Text = "X"
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'LBL_TITLE
        '
        Me.LBL_TITLE.AutoSize = True
        Me.LBL_TITLE.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TITLE.Location = New System.Drawing.Point(169, 15)
        Me.LBL_TITLE.Name = "LBL_TITLE"
        Me.LBL_TITLE.Size = New System.Drawing.Size(74, 19)
        Me.LBL_TITLE.TabIndex = 13
        Me.LBL_TITLE.Text = "Message"
        '
        'BTN_1
        '
        Me.BTN_1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BTN_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_1.Location = New System.Drawing.Point(318, 147)
        Me.BTN_1.Name = "BTN_1"
        Me.BTN_1.Size = New System.Drawing.Size(92, 32)
        Me.BTN_1.TabIndex = 0
        Me.BTN_1.Text = "Yes"
        Me.BTN_1.UseVisualStyleBackColor = True
        '
        'BTN_2
        '
        Me.BTN_2.DialogResult = System.Windows.Forms.DialogResult.No
        Me.BTN_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_2.Location = New System.Drawing.Point(220, 147)
        Me.BTN_2.Name = "BTN_2"
        Me.BTN_2.Size = New System.Drawing.Size(92, 32)
        Me.BTN_2.TabIndex = 1
        Me.BTN_2.Text = "No"
        Me.BTN_2.UseVisualStyleBackColor = True
        '
        'LBL_TEXT
        '
        Me.LBL_TEXT.AutoSize = True
        Me.LBL_TEXT.Location = New System.Drawing.Point(39, 69)
        Me.LBL_TEXT.Name = "LBL_TEXT"
        Me.LBL_TEXT.Size = New System.Drawing.Size(51, 17)
        Me.LBL_TEXT.TabIndex = 17
        Me.LBL_TEXT.Text = "Label1"
        '
        'MB_YESNO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(422, 191)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_TEXT)
        Me.Controls.Add(Me.BTN_2)
        Me.Controls.Add(Me.BTN_1)
        Me.Controls.Add(Me.LBL_TITLE)
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MB_YESNO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents LBL_TITLE As Label
    Friend WithEvents BTN_1 As Button
    Friend WithEvents BTN_2 As Button
    Friend WithEvents LBL_TEXT As Label
End Class
