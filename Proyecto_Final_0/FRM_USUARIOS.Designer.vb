<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_USUARIOS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TC_USERS = New System.Windows.Forms.TabControl()
        Me.TBP_ADD_USER = New System.Windows.Forms.TabPage()
        Me.DGV_USERS_LIST = New System.Windows.Forms.DataGridView()
        Me.GV_USUARIO_ID_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_PASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_ADMINISTRADOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_MAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_USUARIO_DELETE_EDIT = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CB_IS_ADMIN = New System.Windows.Forms.CheckBox()
        Me.TXT_USER_CONFIRM_PASS = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_USER_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BTN_USER_ADD = New System.Windows.Forms.Button()
        Me.TXT_USER_PHONE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_USER_PASSWORD = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_USER_E_MAIL = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TC_USERS.SuspendLayout()
        Me.TBP_ADD_USER.SuspendLayout()
        CType(Me.DGV_USERS_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TC_USERS
        '
        Me.TC_USERS.Controls.Add(Me.TBP_ADD_USER)
        Me.TC_USERS.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TC_USERS.Location = New System.Drawing.Point(12, 12)
        Me.TC_USERS.Name = "TC_USERS"
        Me.TC_USERS.SelectedIndex = 0
        Me.TC_USERS.Size = New System.Drawing.Size(736, 555)
        Me.TC_USERS.TabIndex = 0
        '
        'TBP_ADD_USER
        '
        Me.TBP_ADD_USER.Controls.Add(Me.DGV_USERS_LIST)
        Me.TBP_ADD_USER.Controls.Add(Me.CB_IS_ADMIN)
        Me.TBP_ADD_USER.Controls.Add(Me.TXT_USER_CONFIRM_PASS)
        Me.TBP_ADD_USER.Controls.Add(Me.Label10)
        Me.TBP_ADD_USER.Controls.Add(Me.TXT_USER_NOMBRE)
        Me.TBP_ADD_USER.Controls.Add(Me.Label11)
        Me.TBP_ADD_USER.Controls.Add(Me.BTN_USER_ADD)
        Me.TBP_ADD_USER.Controls.Add(Me.TXT_USER_PHONE)
        Me.TBP_ADD_USER.Controls.Add(Me.Label13)
        Me.TBP_ADD_USER.Controls.Add(Me.TXT_USER_PASSWORD)
        Me.TBP_ADD_USER.Controls.Add(Me.Label14)
        Me.TBP_ADD_USER.Controls.Add(Me.TXT_USER_E_MAIL)
        Me.TBP_ADD_USER.Controls.Add(Me.Label15)
        Me.TBP_ADD_USER.Location = New System.Drawing.Point(4, 31)
        Me.TBP_ADD_USER.Name = "TBP_ADD_USER"
        Me.TBP_ADD_USER.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_ADD_USER.Size = New System.Drawing.Size(728, 520)
        Me.TBP_ADD_USER.TabIndex = 1
        Me.TBP_ADD_USER.Text = "Usuarios"
        Me.TBP_ADD_USER.UseVisualStyleBackColor = True
        '
        'DGV_USERS_LIST
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_USERS_LIST.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_USERS_LIST.BackgroundColor = System.Drawing.Color.White
        Me.DGV_USERS_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_USERS_LIST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GV_USUARIO_ID_USUARIO, Me.GV_USUARIO_TELEFONO, Me.GV_USUARIO_PASS, Me.GV_USUARIO_ADMINISTRADOR, Me.GV_USUARIO_ACTIVO, Me.GV_USUARIO_NOMBRE, Me.GV_USUARIO_MAIL, Me.GV_USUARIO_DELETE_EDIT})
        Me.DGV_USERS_LIST.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_USERS_LIST.Location = New System.Drawing.Point(25, 360)
        Me.DGV_USERS_LIST.Name = "DGV_USERS_LIST"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_USERS_LIST.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_USERS_LIST.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGV_USERS_LIST.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_USERS_LIST.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_USERS_LIST.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_USERS_LIST.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_USERS_LIST.RowTemplate.Height = 24
        Me.DGV_USERS_LIST.Size = New System.Drawing.Size(679, 154)
        Me.DGV_USERS_LIST.TabIndex = 31
        '
        'GV_USUARIO_ID_USUARIO
        '
        Me.GV_USUARIO_ID_USUARIO.DataPropertyName = "idUsuario"
        Me.GV_USUARIO_ID_USUARIO.HeaderText = "idUser"
        Me.GV_USUARIO_ID_USUARIO.Name = "GV_USUARIO_ID_USUARIO"
        Me.GV_USUARIO_ID_USUARIO.Visible = False
        '
        'GV_USUARIO_TELEFONO
        '
        Me.GV_USUARIO_TELEFONO.DataPropertyName = "telefonoContacto"
        Me.GV_USUARIO_TELEFONO.HeaderText = "Telefono"
        Me.GV_USUARIO_TELEFONO.Name = "GV_USUARIO_TELEFONO"
        Me.GV_USUARIO_TELEFONO.Visible = False
        '
        'GV_USUARIO_PASS
        '
        Me.GV_USUARIO_PASS.DataPropertyName = "contrasenia"
        Me.GV_USUARIO_PASS.HeaderText = "Password"
        Me.GV_USUARIO_PASS.Name = "GV_USUARIO_PASS"
        Me.GV_USUARIO_PASS.Visible = False
        '
        'GV_USUARIO_ADMINISTRADOR
        '
        Me.GV_USUARIO_ADMINISTRADOR.DataPropertyName = "administrador"
        Me.GV_USUARIO_ADMINISTRADOR.HeaderText = "Administrador"
        Me.GV_USUARIO_ADMINISTRADOR.Name = "GV_USUARIO_ADMINISTRADOR"
        Me.GV_USUARIO_ADMINISTRADOR.Visible = False
        '
        'GV_USUARIO_ACTIVO
        '
        Me.GV_USUARIO_ACTIVO.DataPropertyName = "activo"
        Me.GV_USUARIO_ACTIVO.HeaderText = "Activo"
        Me.GV_USUARIO_ACTIVO.Name = "GV_USUARIO_ACTIVO"
        Me.GV_USUARIO_ACTIVO.Visible = False
        '
        'GV_USUARIO_NOMBRE
        '
        Me.GV_USUARIO_NOMBRE.DataPropertyName = "nombreCompletoUsuario"
        Me.GV_USUARIO_NOMBRE.HeaderText = "Nombre"
        Me.GV_USUARIO_NOMBRE.Name = "GV_USUARIO_NOMBRE"
        Me.GV_USUARIO_NOMBRE.Width = 200
        '
        'GV_USUARIO_MAIL
        '
        Me.GV_USUARIO_MAIL.DataPropertyName = "correoElectronico"
        Me.GV_USUARIO_MAIL.HeaderText = "Correo"
        Me.GV_USUARIO_MAIL.Name = "GV_USUARIO_MAIL"
        Me.GV_USUARIO_MAIL.Width = 250
        '
        'GV_USUARIO_DELETE_EDIT
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.GV_USUARIO_DELETE_EDIT.DefaultCellStyle = DataGridViewCellStyle2
        Me.GV_USUARIO_DELETE_EDIT.HeaderText = "Editar/Eliminar"
        Me.GV_USUARIO_DELETE_EDIT.Name = "GV_USUARIO_DELETE_EDIT"
        Me.GV_USUARIO_DELETE_EDIT.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GV_USUARIO_DELETE_EDIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.GV_USUARIO_DELETE_EDIT.Text = "Editar/Eliminar"
        Me.GV_USUARIO_DELETE_EDIT.UseColumnTextForButtonValue = True
        Me.GV_USUARIO_DELETE_EDIT.Width = 150
        '
        'CB_IS_ADMIN
        '
        Me.CB_IS_ADMIN.AutoSize = True
        Me.CB_IS_ADMIN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CB_IS_ADMIN.Location = New System.Drawing.Point(409, 146)
        Me.CB_IS_ADMIN.Name = "CB_IS_ADMIN"
        Me.CB_IS_ADMIN.Size = New System.Drawing.Size(154, 26)
        Me.CB_IS_ADMIN.TabIndex = 7
        Me.CB_IS_ADMIN.Text = "Administrador"
        Me.CB_IS_ADMIN.UseVisualStyleBackColor = True
        '
        'TXT_USER_CONFIRM_PASS
        '
        Me.TXT_USER_CONFIRM_PASS.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USER_CONFIRM_PASS.Location = New System.Drawing.Point(402, 239)
        Me.TXT_USER_CONFIRM_PASS.MaxLength = 50
        Me.TXT_USER_CONFIRM_PASS.Name = "TXT_USER_CONFIRM_PASS"
        Me.TXT_USER_CONFIRM_PASS.Size = New System.Drawing.Size(272, 32)
        Me.TXT_USER_CONFIRM_PASS.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(398, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 22)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Confirme contraseña"
        '
        'TXT_USER_NOMBRE
        '
        Me.TXT_USER_NOMBRE.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USER_NOMBRE.Location = New System.Drawing.Point(48, 83)
        Me.TXT_USER_NOMBRE.MaxLength = 200
        Me.TXT_USER_NOMBRE.Name = "TXT_USER_NOMBRE"
        Me.TXT_USER_NOMBRE.Size = New System.Drawing.Size(313, 32)
        Me.TXT_USER_NOMBRE.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(44, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 22)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre completo:"
        '
        'BTN_USER_ADD
        '
        Me.BTN_USER_ADD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BTN_USER_ADD.Location = New System.Drawing.Point(534, 306)
        Me.BTN_USER_ADD.Name = "BTN_USER_ADD"
        Me.BTN_USER_ADD.Size = New System.Drawing.Size(140, 38)
        Me.BTN_USER_ADD.TabIndex = 7
        Me.BTN_USER_ADD.Text = "Guardar"
        Me.BTN_USER_ADD.UseVisualStyleBackColor = True
        '
        'TXT_USER_PHONE
        '
        Me.TXT_USER_PHONE.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USER_PHONE.Location = New System.Drawing.Point(48, 155)
        Me.TXT_USER_PHONE.MaxLength = 20
        Me.TXT_USER_PHONE.Name = "TXT_USER_PHONE"
        Me.TXT_USER_PHONE.Size = New System.Drawing.Size(245, 32)
        Me.TXT_USER_PHONE.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(44, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 22)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Telefono:"
        '
        'TXT_USER_PASSWORD
        '
        Me.TXT_USER_PASSWORD.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USER_PASSWORD.Location = New System.Drawing.Point(48, 239)
        Me.TXT_USER_PASSWORD.MaxLength = 50
        Me.TXT_USER_PASSWORD.Name = "TXT_USER_PASSWORD"
        Me.TXT_USER_PASSWORD.Size = New System.Drawing.Size(297, 32)
        Me.TXT_USER_PASSWORD.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(44, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 22)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Contraseña"
        '
        'TXT_USER_E_MAIL
        '
        Me.TXT_USER_E_MAIL.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_USER_E_MAIL.Location = New System.Drawing.Point(402, 83)
        Me.TXT_USER_E_MAIL.MaxLength = 50
        Me.TXT_USER_E_MAIL.Name = "TXT_USER_E_MAIL"
        Me.TXT_USER_E_MAIL.Size = New System.Drawing.Size(272, 32)
        Me.TXT_USER_E_MAIL.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(398, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(165, 22)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Correo electrónico"
        '
        'FRM_USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.TC_USERS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_USUARIOS"
        Me.TC_USERS.ResumeLayout(False)
        Me.TBP_ADD_USER.ResumeLayout(False)
        Me.TBP_ADD_USER.PerformLayout()
        CType(Me.DGV_USERS_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC_USERS As TabControl
    Friend WithEvents TBP_ADD_USER As TabPage
    Friend WithEvents TXT_USER_CONFIRM_PASS As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_USER_NOMBRE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BTN_USER_ADD As Button
    Friend WithEvents TXT_USER_PHONE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_USER_PASSWORD As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_USER_E_MAIL As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CB_IS_ADMIN As CheckBox
    Friend WithEvents DGV_USERS_LIST As DataGridView
    Friend WithEvents GV_USUARIO_ID_USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_TELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_PASS As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_ADMINISTRADOR As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_ACTIVO As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_MAIL As DataGridViewTextBoxColumn
    Friend WithEvents GV_USUARIO_DELETE_EDIT As DataGridViewButtonColumn
End Class
