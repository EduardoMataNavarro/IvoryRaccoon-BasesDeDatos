<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_EDITAR_USUARIO
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        Me.TXT_EDIT_PASSWORD_C = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_EDIT_GUARDAR = New System.Windows.Forms.Button()
        Me.CB_EDIT_ADMIN = New System.Windows.Forms.CheckBox()
        Me.CB_EDIT_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.TXT_EDIT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_EDIT_TELEFONO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_EDIT_E_MAIL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_EDIT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(244, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Usuario"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_CLOSE.Location = New System.Drawing.Point(579, 9)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(35, 35)
        Me.BTN_CLOSE.TabIndex = 14
        Me.BTN_CLOSE.Text = "X"
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'TXT_EDIT_PASSWORD_C
        '
        Me.TXT_EDIT_PASSWORD_C.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_EDIT_PASSWORD_C.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EDIT_PASSWORD_C.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDIT_PASSWORD_C.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_EDIT_PASSWORD_C.Location = New System.Drawing.Point(294, 331)
        Me.TXT_EDIT_PASSWORD_C.MaxLength = 50
        Me.TXT_EDIT_PASSWORD_C.Name = "TXT_EDIT_PASSWORD_C"
        Me.TXT_EDIT_PASSWORD_C.Size = New System.Drawing.Size(224, 21)
        Me.TXT_EDIT_PASSWORD_C.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(291, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Confirmar contraseña:"
        '
        'BTN_EDIT_GUARDAR
        '
        Me.BTN_EDIT_GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_EDIT_GUARDAR.FlatAppearance.BorderSize = 2
        Me.BTN_EDIT_GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EDIT_GUARDAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_EDIT_GUARDAR.Location = New System.Drawing.Point(394, 400)
        Me.BTN_EDIT_GUARDAR.Name = "BTN_EDIT_GUARDAR"
        Me.BTN_EDIT_GUARDAR.Size = New System.Drawing.Size(154, 44)
        Me.BTN_EDIT_GUARDAR.TabIndex = 8
        Me.BTN_EDIT_GUARDAR.Text = "Guardar"
        Me.BTN_EDIT_GUARDAR.UseVisualStyleBackColor = True
        '
        'CB_EDIT_ADMIN
        '
        Me.CB_EDIT_ADMIN.AutoSize = True
        Me.CB_EDIT_ADMIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CB_EDIT_ADMIN.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_EDIT_ADMIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.CB_EDIT_ADMIN.Location = New System.Drawing.Point(419, 167)
        Me.CB_EDIT_ADMIN.Name = "CB_EDIT_ADMIN"
        Me.CB_EDIT_ADMIN.Size = New System.Drawing.Size(129, 22)
        Me.CB_EDIT_ADMIN.TabIndex = 4
        Me.CB_EDIT_ADMIN.Text = "Administrador"
        Me.CB_EDIT_ADMIN.UseVisualStyleBackColor = False
        '
        'CB_EDIT_ACTIVO
        '
        Me.CB_EDIT_ACTIVO.AutoSize = True
        Me.CB_EDIT_ACTIVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.CB_EDIT_ACTIVO.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_EDIT_ACTIVO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.CB_EDIT_ACTIVO.Location = New System.Drawing.Point(419, 208)
        Me.CB_EDIT_ACTIVO.Name = "CB_EDIT_ACTIVO"
        Me.CB_EDIT_ACTIVO.Size = New System.Drawing.Size(73, 22)
        Me.CB_EDIT_ACTIVO.TabIndex = 5
        Me.CB_EDIT_ACTIVO.Text = "Activo"
        Me.CB_EDIT_ACTIVO.UseVisualStyleBackColor = False
        '
        'TXT_EDIT_PASSWORD
        '
        Me.TXT_EDIT_PASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_EDIT_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EDIT_PASSWORD.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDIT_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_EDIT_PASSWORD.Location = New System.Drawing.Point(46, 331)
        Me.TXT_EDIT_PASSWORD.MaxLength = 50
        Me.TXT_EDIT_PASSWORD.Name = "TXT_EDIT_PASSWORD"
        Me.TXT_EDIT_PASSWORD.Size = New System.Drawing.Size(224, 21)
        Me.TXT_EDIT_PASSWORD.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(43, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Contraseña:"
        '
        'TXT_EDIT_TELEFONO
        '
        Me.TXT_EDIT_TELEFONO.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_EDIT_TELEFONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EDIT_TELEFONO.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDIT_TELEFONO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_EDIT_TELEFONO.Location = New System.Drawing.Point(46, 181)
        Me.TXT_EDIT_TELEFONO.MaxLength = 20
        Me.TXT_EDIT_TELEFONO.Name = "TXT_EDIT_TELEFONO"
        Me.TXT_EDIT_TELEFONO.Size = New System.Drawing.Size(224, 21)
        Me.TXT_EDIT_TELEFONO.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Telefono:"
        '
        'TXT_EDIT_E_MAIL
        '
        Me.TXT_EDIT_E_MAIL.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_EDIT_E_MAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EDIT_E_MAIL.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDIT_E_MAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_EDIT_E_MAIL.Location = New System.Drawing.Point(46, 254)
        Me.TXT_EDIT_E_MAIL.MaxLength = 50
        Me.TXT_EDIT_E_MAIL.Name = "TXT_EDIT_E_MAIL"
        Me.TXT_EDIT_E_MAIL.Size = New System.Drawing.Size(336, 21)
        Me.TXT_EDIT_E_MAIL.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(43, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Correo:"
        '
        'TXT_EDIT_NOMBRE
        '
        Me.TXT_EDIT_NOMBRE.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_EDIT_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_EDIT_NOMBRE.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EDIT_NOMBRE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_EDIT_NOMBRE.Location = New System.Drawing.Point(46, 105)
        Me.TXT_EDIT_NOMBRE.MaxLength = 200
        Me.TXT_EDIT_NOMBRE.Name = "TXT_EDIT_NOMBRE"
        Me.TXT_EDIT_NOMBRE.Size = New System.Drawing.Size(336, 21)
        Me.TXT_EDIT_NOMBRE.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(43, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(46, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 5)
        Me.Panel1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(46, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 5)
        Me.Panel2.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(46, 281)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(337, 5)
        Me.Panel3.TabIndex = 32
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(46, 358)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 5)
        Me.Panel4.TabIndex = 33
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(294, 358)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(224, 5)
        Me.Panel5.TabIndex = 34
        '
        'FRM_EDITAR_USUARIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TXT_EDIT_PASSWORD_C)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_EDIT_GUARDAR)
        Me.Controls.Add(Me.CB_EDIT_ADMIN)
        Me.Controls.Add(Me.CB_EDIT_ACTIVO)
        Me.Controls.Add(Me.TXT_EDIT_PASSWORD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_EDIT_TELEFONO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_EDIT_E_MAIL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT_EDIT_NOMBRE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_EDITAR_USUARIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents TXT_EDIT_PASSWORD_C As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_EDIT_GUARDAR As Button
    Friend WithEvents CB_EDIT_ADMIN As CheckBox
    Friend WithEvents CB_EDIT_ACTIVO As CheckBox
    Friend WithEvents TXT_EDIT_PASSWORD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_EDIT_TELEFONO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_EDIT_E_MAIL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_EDIT_NOMBRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
