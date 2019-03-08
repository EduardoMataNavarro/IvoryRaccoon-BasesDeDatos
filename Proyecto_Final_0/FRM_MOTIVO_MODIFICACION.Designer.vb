<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MOTIVO_MODIFICACION
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
        Me.LBL_NAME = New System.Windows.Forms.Label()
        Me.DTP_MDN_FECHA_ACTUAL = New MetroFramework.Controls.MetroDateTime()
        Me.DTP_MDN_NUEVA_FECHA_FIN = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_MDN_MOTIVO = New System.Windows.Forms.TextBox()
        Me.BTN_MDN_TERMINADO = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBL_NAME
        '
        Me.LBL_NAME.AutoSize = True
        Me.LBL_NAME.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.LBL_NAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LBL_NAME.Location = New System.Drawing.Point(141, 9)
        Me.LBL_NAME.Name = "LBL_NAME"
        Me.LBL_NAME.Size = New System.Drawing.Size(320, 20)
        Me.LBL_NAME.TabIndex = 12
        Me.LBL_NAME.Text = "Modificación de fecha de fin de proyecto"
        '
        'DTP_MDN_FECHA_ACTUAL
        '
        Me.DTP_MDN_FECHA_ACTUAL.Enabled = False
        Me.DTP_MDN_FECHA_ACTUAL.Location = New System.Drawing.Point(363, 88)
        Me.DTP_MDN_FECHA_ACTUAL.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DTP_MDN_FECHA_ACTUAL.Name = "DTP_MDN_FECHA_ACTUAL"
        Me.DTP_MDN_FECHA_ACTUAL.Size = New System.Drawing.Size(233, 30)
        Me.DTP_MDN_FECHA_ACTUAL.Style = MetroFramework.MetroColorStyle.Silver
        Me.DTP_MDN_FECHA_ACTUAL.TabIndex = 13
        '
        'DTP_MDN_NUEVA_FECHA_FIN
        '
        Me.DTP_MDN_NUEVA_FECHA_FIN.Enabled = False
        Me.DTP_MDN_NUEVA_FECHA_FIN.Location = New System.Drawing.Point(363, 165)
        Me.DTP_MDN_NUEVA_FECHA_FIN.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DTP_MDN_NUEVA_FECHA_FIN.Name = "DTP_MDN_NUEVA_FECHA_FIN"
        Me.DTP_MDN_NUEVA_FECHA_FIN.Size = New System.Drawing.Size(233, 30)
        Me.DTP_MDN_NUEVA_FECHA_FIN.Style = MetroFramework.MetroColorStyle.Silver
        Me.DTP_MDN_NUEVA_FECHA_FIN.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(359, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(359, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nueva fecha de fin:"
        '
        'TXT_MDN_MOTIVO
        '
        Me.TXT_MDN_MOTIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_MDN_MOTIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_MDN_MOTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_MDN_MOTIVO.Location = New System.Drawing.Point(26, 88)
        Me.TXT_MDN_MOTIVO.MaxLength = 500
        Me.TXT_MDN_MOTIVO.Multiline = True
        Me.TXT_MDN_MOTIVO.Name = "TXT_MDN_MOTIVO"
        Me.TXT_MDN_MOTIVO.Size = New System.Drawing.Size(313, 163)
        Me.TXT_MDN_MOTIVO.TabIndex = 18
        '
        'BTN_MDN_TERMINADO
        '
        Me.BTN_MDN_TERMINADO.FlatAppearance.BorderSize = 2
        Me.BTN_MDN_TERMINADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MDN_TERMINADO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_MDN_TERMINADO.Location = New System.Drawing.Point(392, 241)
        Me.BTN_MDN_TERMINADO.Name = "BTN_MDN_TERMINADO"
        Me.BTN_MDN_TERMINADO.Size = New System.Drawing.Size(140, 49)
        Me.BTN_MDN_TERMINADO.TabIndex = 19
        Me.BTN_MDN_TERMINADO.Text = "Terminado"
        Me.BTN_MDN_TERMINADO.UseVisualStyleBackColor = True
        Me.BTN_MDN_TERMINADO.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Proporcione un motivo:"
        '
        'FRM_MOTIVO_MODIFICACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(617, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTN_MDN_TERMINADO)
        Me.Controls.Add(Me.TXT_MDN_MOTIVO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_MDN_NUEVA_FECHA_FIN)
        Me.Controls.Add(Me.DTP_MDN_FECHA_ACTUAL)
        Me.Controls.Add(Me.LBL_NAME)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_MOTIVO_MODIFICACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MOTIVO_MODIFICACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_NAME As Label
    Friend WithEvents DTP_MDN_FECHA_ACTUAL As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DTP_MDN_NUEVA_FECHA_FIN As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_MDN_MOTIVO As TextBox
    Friend WithEvents BTN_MDN_TERMINADO As Button
    Friend WithEvents Label3 As Label
End Class
