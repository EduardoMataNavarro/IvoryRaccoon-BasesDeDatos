<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_DASHBOARD
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DASHBOARD))
        Me.BTN_MINIMIZE = New System.Windows.Forms.Button()
        Me.PNL_MAIN = New System.Windows.Forms.Panel()
        Me.LBL_NAME = New System.Windows.Forms.Label()
        Me.LBL_USER_NAME = New System.Windows.Forms.Label()
        Me.LBL_USER_SURNAME = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_ROLES = New System.Windows.Forms.Button()
        Me.BTN_USERS = New System.Windows.Forms.Button()
        Me.BTN_CLIENTES = New System.Windows.Forms.Button()
        Me.BTN_PROYECTO = New System.Windows.Forms.Button()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_MINIMIZE
        '
        Me.BTN_MINIMIZE.FlatAppearance.BorderSize = 0
        Me.BTN_MINIMIZE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_MINIMIZE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MINIMIZE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MINIMIZE.Location = New System.Drawing.Point(907, 9)
        Me.BTN_MINIMIZE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_MINIMIZE.Name = "BTN_MINIMIZE"
        Me.BTN_MINIMIZE.Size = New System.Drawing.Size(35, 25)
        Me.BTN_MINIMIZE.TabIndex = 13
        Me.BTN_MINIMIZE.Text = "_"
        Me.BTN_MINIMIZE.UseVisualStyleBackColor = True
        '
        'PNL_MAIN
        '
        Me.PNL_MAIN.BackColor = System.Drawing.Color.White
        Me.PNL_MAIN.Location = New System.Drawing.Point(236, 47)
        Me.PNL_MAIN.Name = "PNL_MAIN"
        Me.PNL_MAIN.Size = New System.Drawing.Size(762, 581)
        Me.PNL_MAIN.TabIndex = 15
        '
        'LBL_NAME
        '
        Me.LBL_NAME.AutoSize = True
        Me.LBL_NAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LBL_NAME.Location = New System.Drawing.Point(542, 14)
        Me.LBL_NAME.Name = "LBL_NAME"
        Me.LBL_NAME.Size = New System.Drawing.Size(119, 20)
        Me.LBL_NAME.TabIndex = 16
        Me.LBL_NAME.Text = "Ivory Raccoon"
        '
        'LBL_USER_NAME
        '
        Me.LBL_USER_NAME.AutoSize = True
        Me.LBL_USER_NAME.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USER_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LBL_USER_NAME.Location = New System.Drawing.Point(91, 93)
        Me.LBL_USER_NAME.Name = "LBL_USER_NAME"
        Me.LBL_USER_NAME.Size = New System.Drawing.Size(0, 19)
        Me.LBL_USER_NAME.TabIndex = 24
        '
        'LBL_USER_SURNAME
        '
        Me.LBL_USER_SURNAME.AutoSize = True
        Me.LBL_USER_SURNAME.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USER_SURNAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LBL_USER_SURNAME.Location = New System.Drawing.Point(91, 119)
        Me.LBL_USER_SURNAME.Name = "LBL_USER_SURNAME"
        Me.LBL_USER_SURNAME.Size = New System.Drawing.Size(0, 19)
        Me.LBL_USER_SURNAME.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Final_0.My.Resources.Resources.logoMapache1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'BTN_ROLES
        '
        Me.BTN_ROLES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_ROLES.FlatAppearance.BorderSize = 0
        Me.BTN_ROLES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_ROLES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_ROLES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ROLES.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ROLES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_ROLES.Image = Global.Proyecto_Final_0.My.Resources.Resources._008_id_card
        Me.BTN_ROLES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ROLES.Location = New System.Drawing.Point(-2, 204)
        Me.BTN_ROLES.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_ROLES.Name = "BTN_ROLES"
        Me.BTN_ROLES.Size = New System.Drawing.Size(235, 52)
        Me.BTN_ROLES.TabIndex = 22
        Me.BTN_ROLES.Text = "      Roles y Categorias"
        Me.BTN_ROLES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ROLES.UseVisualStyleBackColor = False
        '
        'BTN_USERS
        '
        Me.BTN_USERS.BackColor = System.Drawing.Color.Transparent
        Me.BTN_USERS.FlatAppearance.BorderSize = 0
        Me.BTN_USERS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_USERS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_USERS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_USERS.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_USERS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_USERS.Image = Global.Proyecto_Final_0.My.Resources.Resources._012_team
        Me.BTN_USERS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_USERS.Location = New System.Drawing.Point(-2, 319)
        Me.BTN_USERS.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_USERS.Name = "BTN_USERS"
        Me.BTN_USERS.Size = New System.Drawing.Size(235, 52)
        Me.BTN_USERS.TabIndex = 20
        Me.BTN_USERS.Text = "      Usuarios"
        Me.BTN_USERS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_USERS.UseVisualStyleBackColor = False
        '
        'BTN_CLIENTES
        '
        Me.BTN_CLIENTES.BackColor = System.Drawing.Color.Transparent
        Me.BTN_CLIENTES.FlatAppearance.BorderSize = 0
        Me.BTN_CLIENTES.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_CLIENTES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_CLIENTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLIENTES.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLIENTES.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_CLIENTES.Image = Global.Proyecto_Final_0.My.Resources.Resources._010_brainstorming
        Me.BTN_CLIENTES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CLIENTES.Location = New System.Drawing.Point(-2, 261)
        Me.BTN_CLIENTES.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLIENTES.Name = "BTN_CLIENTES"
        Me.BTN_CLIENTES.Size = New System.Drawing.Size(235, 52)
        Me.BTN_CLIENTES.TabIndex = 19
        Me.BTN_CLIENTES.Text = "      Clientes"
        Me.BTN_CLIENTES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CLIENTES.UseVisualStyleBackColor = False
        '
        'BTN_PROYECTO
        '
        Me.BTN_PROYECTO.BackColor = System.Drawing.Color.Transparent
        Me.BTN_PROYECTO.FlatAppearance.BorderSize = 0
        Me.BTN_PROYECTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_PROYECTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_PROYECTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_PROYECTO.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PROYECTO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_PROYECTO.Image = Global.Proyecto_Final_0.My.Resources.Resources._013_teamwork_1
        Me.BTN_PROYECTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_PROYECTO.Location = New System.Drawing.Point(-2, 152)
        Me.BTN_PROYECTO.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_PROYECTO.Name = "BTN_PROYECTO"
        Me.BTN_PROYECTO.Size = New System.Drawing.Size(235, 52)
        Me.BTN_PROYECTO.TabIndex = 17
        Me.BTN_PROYECTO.Text = "      Proyectos"
        Me.BTN_PROYECTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_PROYECTO.UseVisualStyleBackColor = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 0
        Me.BTN_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Image = Global.Proyecto_Final_0.My.Resources.Resources._005_power_button
        Me.BTN_CLOSE.Location = New System.Drawing.Point(955, 9)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(35, 25)
        Me.BTN_CLOSE.TabIndex = 11
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'FRM_DASHBOARD
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_USER_SURNAME)
        Me.Controls.Add(Me.LBL_USER_NAME)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTN_ROLES)
        Me.Controls.Add(Me.BTN_USERS)
        Me.Controls.Add(Me.BTN_CLIENTES)
        Me.Controls.Add(Me.BTN_PROYECTO)
        Me.Controls.Add(Me.LBL_NAME)
        Me.Controls.Add(Me.PNL_MAIN)
        Me.Controls.Add(Me.BTN_MINIMIZE)
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_DASHBOARD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_MINIMIZE As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents PNL_MAIN As Panel
    Friend WithEvents LBL_NAME As Label
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents BTN_ROLES As Button
    Friend WithEvents BTN_USERS As Button
    Friend WithEvents BTN_CLIENTES As Button
    Friend WithEvents BTN_PROYECTO As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBL_USER_NAME As Label
    Friend WithEvents LBL_USER_SURNAME As Label
End Class
