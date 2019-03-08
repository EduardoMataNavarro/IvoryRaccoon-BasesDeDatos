<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ROLES_CATEGORIA
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TBP_ROL_CATEGORIA = New System.Windows.Forms.TabPage()
        Me.CB_ROL_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.CB_CATEGORIA_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.BTN_CATEGORIA_CANCEL = New System.Windows.Forms.Button()
        Me.BTN_ROL_CANCEL = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_CATEGORIA = New System.Windows.Forms.DataGridView()
        Me.BTN_ADD_CAT = New System.Windows.Forms.Button()
        Me.TXT_CAT_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV_ROL = New System.Windows.Forms.DataGridView()
        Me.BTN_ADD_ROLE = New System.Windows.Forms.Button()
        Me.TXT_ROL_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GV_ROL_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_ROL_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_ROL_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_ROL_EDITAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GV_CATEGORIA_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CATEGORIA_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CATEGORIA_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CATEGORIA_EDITAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TBP_ROL_CATEGORIA.SuspendLayout()
        CType(Me.DGV_CATEGORIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBP_ROL_CATEGORIA
        '
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.CB_ROL_ACTIVO)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.CB_CATEGORIA_ACTIVO)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.BTN_CATEGORIA_CANCEL)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.BTN_ROL_CANCEL)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.Label3)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.Label1)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.DGV_CATEGORIA)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.BTN_ADD_CAT)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.TXT_CAT_NOMBRE)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.Label4)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.DGV_ROL)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.BTN_ADD_ROLE)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.TXT_ROL_NOMBRE)
        Me.TBP_ROL_CATEGORIA.Controls.Add(Me.Label2)
        Me.TBP_ROL_CATEGORIA.Location = New System.Drawing.Point(4, 31)
        Me.TBP_ROL_CATEGORIA.Name = "TBP_ROL_CATEGORIA"
        Me.TBP_ROL_CATEGORIA.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_ROL_CATEGORIA.Size = New System.Drawing.Size(728, 520)
        Me.TBP_ROL_CATEGORIA.TabIndex = 0
        Me.TBP_ROL_CATEGORIA.Text = "Roles y Categorías"
        Me.TBP_ROL_CATEGORIA.UseVisualStyleBackColor = True
        '
        'CB_ROL_ACTIVO
        '
        Me.CB_ROL_ACTIVO.AutoSize = True
        Me.CB_ROL_ACTIVO.ForeColor = System.Drawing.Color.Black
        Me.CB_ROL_ACTIVO.Location = New System.Drawing.Point(333, 66)
        Me.CB_ROL_ACTIVO.Name = "CB_ROL_ACTIVO"
        Me.CB_ROL_ACTIVO.Size = New System.Drawing.Size(85, 26)
        Me.CB_ROL_ACTIVO.TabIndex = 27
        Me.CB_ROL_ACTIVO.Text = "Activo"
        Me.CB_ROL_ACTIVO.UseVisualStyleBackColor = True
        '
        'CB_CATEGORIA_ACTIVO
        '
        Me.CB_CATEGORIA_ACTIVO.AutoSize = True
        Me.CB_CATEGORIA_ACTIVO.ForeColor = System.Drawing.Color.Black
        Me.CB_CATEGORIA_ACTIVO.Location = New System.Drawing.Point(333, 325)
        Me.CB_CATEGORIA_ACTIVO.Name = "CB_CATEGORIA_ACTIVO"
        Me.CB_CATEGORIA_ACTIVO.Size = New System.Drawing.Size(85, 26)
        Me.CB_CATEGORIA_ACTIVO.TabIndex = 26
        Me.CB_CATEGORIA_ACTIVO.Text = "Activo"
        Me.CB_CATEGORIA_ACTIVO.UseVisualStyleBackColor = True
        '
        'BTN_CATEGORIA_CANCEL
        '
        Me.BTN_CATEGORIA_CANCEL.FlatAppearance.BorderSize = 3
        Me.BTN_CATEGORIA_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_CATEGORIA_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_CATEGORIA_CANCEL.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CATEGORIA_CANCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BTN_CATEGORIA_CANCEL.Location = New System.Drawing.Point(489, 311)
        Me.BTN_CATEGORIA_CANCEL.Name = "BTN_CATEGORIA_CANCEL"
        Me.BTN_CATEGORIA_CANCEL.Size = New System.Drawing.Size(67, 41)
        Me.BTN_CATEGORIA_CANCEL.TabIndex = 25
        Me.BTN_CATEGORIA_CANCEL.Text = "Cancelar"
        Me.BTN_CATEGORIA_CANCEL.UseVisualStyleBackColor = True
        '
        'BTN_ROL_CANCEL
        '
        Me.BTN_ROL_CANCEL.FlatAppearance.BorderSize = 3
        Me.BTN_ROL_CANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_ROL_CANCEL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_ROL_CANCEL.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ROL_CANCEL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BTN_ROL_CANCEL.Location = New System.Drawing.Point(489, 60)
        Me.BTN_ROL_CANCEL.Name = "BTN_ROL_CANCEL"
        Me.BTN_ROL_CANCEL.Size = New System.Drawing.Size(67, 41)
        Me.BTN_ROL_CANCEL.TabIndex = 24
        Me.BTN_ROL_CANCEL.Text = "Cancelar"
        Me.BTN_ROL_CANCEL.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Categoría"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Rol"
        '
        'DGV_CATEGORIA
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_CATEGORIA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_CATEGORIA.BackgroundColor = System.Drawing.Color.White
        Me.DGV_CATEGORIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CATEGORIA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GV_CATEGORIA_ID, Me.GV_CATEGORIA_NOMBRE, Me.GV_CATEGORIA_ACTIVO, Me.GV_CATEGORIA_EDITAR})
        Me.DGV_CATEGORIA.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_CATEGORIA.Location = New System.Drawing.Point(27, 358)
        Me.DGV_CATEGORIA.Name = "DGV_CATEGORIA"
        Me.DGV_CATEGORIA.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGV_CATEGORIA.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_CATEGORIA.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_CATEGORIA.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_CATEGORIA.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_CATEGORIA.RowTemplate.Height = 24
        Me.DGV_CATEGORIA.Size = New System.Drawing.Size(664, 141)
        Me.DGV_CATEGORIA.TabIndex = 21
        '
        'BTN_ADD_CAT
        '
        Me.BTN_ADD_CAT.FlatAppearance.BorderSize = 3
        Me.BTN_ADD_CAT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_ADD_CAT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_ADD_CAT.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_CAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BTN_ADD_CAT.Location = New System.Drawing.Point(578, 311)
        Me.BTN_ADD_CAT.Name = "BTN_ADD_CAT"
        Me.BTN_ADD_CAT.Size = New System.Drawing.Size(113, 41)
        Me.BTN_ADD_CAT.TabIndex = 20
        Me.BTN_ADD_CAT.Text = "Guardar"
        Me.BTN_ADD_CAT.UseVisualStyleBackColor = True
        '
        'TXT_CAT_NOMBRE
        '
        Me.TXT_CAT_NOMBRE.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CAT_NOMBRE.Location = New System.Drawing.Point(27, 320)
        Me.TXT_CAT_NOMBRE.Name = "TXT_CAT_NOMBRE"
        Me.TXT_CAT_NOMBRE.Size = New System.Drawing.Size(288, 32)
        Me.TXT_CAT_NOMBRE.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombre:"
        '
        'DGV_ROL
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_ROL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ROL.BackgroundColor = System.Drawing.Color.White
        Me.DGV_ROL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ROL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GV_ROL_ID, Me.GV_ROL_NOMBRE, Me.GV_ROL_ACTIVO, Me.GV_ROL_EDITAR})
        Me.DGV_ROL.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_ROL.Location = New System.Drawing.Point(27, 109)
        Me.DGV_ROL.Name = "DGV_ROL"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_ROL.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_ROL.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGV_ROL.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_ROL.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_ROL.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_ROL.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_ROL.RowTemplate.Height = 24
        Me.DGV_ROL.Size = New System.Drawing.Size(664, 145)
        Me.DGV_ROL.TabIndex = 16
        '
        'BTN_ADD_ROLE
        '
        Me.BTN_ADD_ROLE.FlatAppearance.BorderSize = 3
        Me.BTN_ADD_ROLE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_ADD_ROLE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTN_ADD_ROLE.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ADD_ROLE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.BTN_ADD_ROLE.Location = New System.Drawing.Point(578, 60)
        Me.BTN_ADD_ROLE.Name = "BTN_ADD_ROLE"
        Me.BTN_ADD_ROLE.Size = New System.Drawing.Size(113, 41)
        Me.BTN_ADD_ROLE.TabIndex = 15
        Me.BTN_ADD_ROLE.Text = "Guardar"
        Me.BTN_ADD_ROLE.UseVisualStyleBackColor = True
        '
        'TXT_ROL_NOMBRE
        '
        Me.TXT_ROL_NOMBRE.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ROL_NOMBRE.Location = New System.Drawing.Point(27, 61)
        Me.TXT_ROL_NOMBRE.Name = "TXT_ROL_NOMBRE"
        Me.TXT_ROL_NOMBRE.Size = New System.Drawing.Size(288, 32)
        Me.TXT_ROL_NOMBRE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TBP_ROL_CATEGORIA)
        Me.TabControl1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 555)
        Me.TabControl1.TabIndex = 0
        '
        'GV_ROL_ID
        '
        Me.GV_ROL_ID.DataPropertyName = "idRol"
        Me.GV_ROL_ID.HeaderText = "idRol"
        Me.GV_ROL_ID.Name = "GV_ROL_ID"
        Me.GV_ROL_ID.Visible = False
        '
        'GV_ROL_NOMBRE
        '
        Me.GV_ROL_NOMBRE.DataPropertyName = "nombreRol"
        Me.GV_ROL_NOMBRE.HeaderText = "Nombre"
        Me.GV_ROL_NOMBRE.Name = "GV_ROL_NOMBRE"
        Me.GV_ROL_NOMBRE.Width = 250
        '
        'GV_ROL_ACTIVO
        '
        Me.GV_ROL_ACTIVO.DataPropertyName = "activo"
        Me.GV_ROL_ACTIVO.HeaderText = "Activo"
        Me.GV_ROL_ACTIVO.Name = "GV_ROL_ACTIVO"
        Me.GV_ROL_ACTIVO.Visible = False
        '
        'GV_ROL_EDITAR
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.GV_ROL_EDITAR.DefaultCellStyle = DataGridViewCellStyle4
        Me.GV_ROL_EDITAR.HeaderText = "Editar"
        Me.GV_ROL_EDITAR.Name = "GV_ROL_EDITAR"
        Me.GV_ROL_EDITAR.Text = "Editar"
        Me.GV_ROL_EDITAR.UseColumnTextForButtonValue = True
        '
        'GV_CATEGORIA_ID
        '
        Me.GV_CATEGORIA_ID.DataPropertyName = "idCategoria"
        Me.GV_CATEGORIA_ID.HeaderText = "idCategoria"
        Me.GV_CATEGORIA_ID.Name = "GV_CATEGORIA_ID"
        Me.GV_CATEGORIA_ID.Visible = False
        '
        'GV_CATEGORIA_NOMBRE
        '
        Me.GV_CATEGORIA_NOMBRE.DataPropertyName = "nombreCategoria"
        Me.GV_CATEGORIA_NOMBRE.HeaderText = "Nombre"
        Me.GV_CATEGORIA_NOMBRE.Name = "GV_CATEGORIA_NOMBRE"
        Me.GV_CATEGORIA_NOMBRE.Width = 250
        '
        'GV_CATEGORIA_ACTIVO
        '
        Me.GV_CATEGORIA_ACTIVO.DataPropertyName = "activoCategoria"
        Me.GV_CATEGORIA_ACTIVO.HeaderText = "Activo"
        Me.GV_CATEGORIA_ACTIVO.Name = "GV_CATEGORIA_ACTIVO"
        Me.GV_CATEGORIA_ACTIVO.Visible = False
        '
        'GV_CATEGORIA_EDITAR
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.GV_CATEGORIA_EDITAR.DefaultCellStyle = DataGridViewCellStyle2
        Me.GV_CATEGORIA_EDITAR.HeaderText = "Editar"
        Me.GV_CATEGORIA_EDITAR.Name = "GV_CATEGORIA_EDITAR"
        '
        'FRM_ROLES_CATEGORIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_ROLES_CATEGORIA"
        Me.TBP_ROL_CATEGORIA.ResumeLayout(False)
        Me.TBP_ROL_CATEGORIA.PerformLayout()
        CType(Me.DGV_CATEGORIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBP_ROL_CATEGORIA As TabPage
    Friend WithEvents DGV_ROL As DataGridView
    Friend WithEvents BTN_ADD_ROLE As Button
    Friend WithEvents TXT_ROL_NOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DGV_CATEGORIA As DataGridView
    Friend WithEvents BTN_ADD_CAT As Button
    Friend WithEvents TXT_CAT_NOMBRE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_CATEGORIA_CANCEL As Button
    Friend WithEvents BTN_ROL_CANCEL As Button
    Friend WithEvents CB_ROL_ACTIVO As CheckBox
    Friend WithEvents CB_CATEGORIA_ACTIVO As CheckBox
    Friend WithEvents GV_ROL_ID As DataGridViewTextBoxColumn
    Friend WithEvents GV_ROL_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents GV_ROL_ACTIVO As DataGridViewTextBoxColumn
    Friend WithEvents GV_ROL_EDITAR As DataGridViewButtonColumn
    Friend WithEvents GV_CATEGORIA_ID As DataGridViewTextBoxColumn
    Friend WithEvents GV_CATEGORIA_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents GV_CATEGORIA_ACTIVO As DataGridViewTextBoxColumn
    Friend WithEvents GV_CATEGORIA_EDITAR As DataGridViewButtonColumn
End Class
