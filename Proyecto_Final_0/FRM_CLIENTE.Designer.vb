<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CLIENTE
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TBP_CLIENTE = New System.Windows.Forms.TabPage()
        Me.CB_CLIENTE_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_CLIENTES = New System.Windows.Forms.DataGridView()
        Me.BTN_ADD_CLIENT = New System.Windows.Forms.Button()
        Me.TXT_CLIENT_RFC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_CLIENT_NAME = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_CLIENT_SHORT_NAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GV_CLIENTE_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CLIENTE_RFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CLIENTE_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CLIENTE_RAZON_SOCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CLIENTE_ACTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_CLIENTE_EDITAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GV_CLIENTE_ELIMINAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1.SuspendLayout()
        Me.TBP_CLIENTE.SuspendLayout()
        CType(Me.DGV_CLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TBP_CLIENTE)
        Me.TabControl1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(736, 555)
        Me.TabControl1.TabIndex = 0
        '
        'TBP_CLIENTE
        '
        Me.TBP_CLIENTE.Controls.Add(Me.CB_CLIENTE_ACTIVO)
        Me.TBP_CLIENTE.Controls.Add(Me.Label1)
        Me.TBP_CLIENTE.Controls.Add(Me.DGV_CLIENTES)
        Me.TBP_CLIENTE.Controls.Add(Me.BTN_ADD_CLIENT)
        Me.TBP_CLIENTE.Controls.Add(Me.TXT_CLIENT_RFC)
        Me.TBP_CLIENTE.Controls.Add(Me.Label6)
        Me.TBP_CLIENTE.Controls.Add(Me.TXT_CLIENT_NAME)
        Me.TBP_CLIENTE.Controls.Add(Me.Label5)
        Me.TBP_CLIENTE.Controls.Add(Me.TXT_CLIENT_SHORT_NAME)
        Me.TBP_CLIENTE.Controls.Add(Me.Label4)
        Me.TBP_CLIENTE.Location = New System.Drawing.Point(4, 31)
        Me.TBP_CLIENTE.Name = "TBP_CLIENTE"
        Me.TBP_CLIENTE.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_CLIENTE.Size = New System.Drawing.Size(728, 520)
        Me.TBP_CLIENTE.TabIndex = 0
        Me.TBP_CLIENTE.Text = "Cientes"
        Me.TBP_CLIENTE.UseVisualStyleBackColor = True
        '
        'CB_CLIENTE_ACTIVO
        '
        Me.CB_CLIENTE_ACTIVO.AutoSize = True
        Me.CB_CLIENTE_ACTIVO.ForeColor = System.Drawing.Color.Black
        Me.CB_CLIENTE_ACTIVO.Location = New System.Drawing.Point(372, 215)
        Me.CB_CLIENTE_ACTIVO.Name = "CB_CLIENTE_ACTIVO"
        Me.CB_CLIENTE_ACTIVO.Size = New System.Drawing.Size(85, 26)
        Me.CB_CLIENTE_ACTIVO.TabIndex = 24
        Me.CB_CLIENTE_ACTIVO.Text = "Activo"
        Me.CB_CLIENTE_ACTIVO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Lista de clientes"
        '
        'DGV_CLIENTES
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_CLIENTES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_CLIENTES.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_CLIENTES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CLIENTES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GV_CLIENTE_NOMBRE, Me.GV_CLIENTE_RFC, Me.GV_CLIENTE_ID, Me.GV_CLIENTE_RAZON_SOCIAL, Me.GV_CLIENTE_ACTIVO, Me.GV_CLIENTE_EDITAR, Me.GV_CLIENTE_ELIMINAR})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_CLIENTES.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_CLIENTES.Location = New System.Drawing.Point(30, 304)
        Me.DGV_CLIENTES.Name = "DGV_CLIENTES"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DGV_CLIENTES.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.DGV_CLIENTES.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_CLIENTES.RowTemplate.Height = 24
        Me.DGV_CLIENTES.Size = New System.Drawing.Size(666, 210)
        Me.DGV_CLIENTES.TabIndex = 22
        '
        'BTN_ADD_CLIENT
        '
        Me.BTN_ADD_CLIENT.ForeColor = System.Drawing.Color.Black
        Me.BTN_ADD_CLIENT.Location = New System.Drawing.Point(545, 208)
        Me.BTN_ADD_CLIENT.Name = "BTN_ADD_CLIENT"
        Me.BTN_ADD_CLIENT.Size = New System.Drawing.Size(133, 43)
        Me.BTN_ADD_CLIENT.TabIndex = 21
        Me.BTN_ADD_CLIENT.Text = "Guardar"
        Me.BTN_ADD_CLIENT.UseVisualStyleBackColor = True
        '
        'TXT_CLIENT_RFC
        '
        Me.TXT_CLIENT_RFC.Location = New System.Drawing.Point(30, 215)
        Me.TXT_CLIENT_RFC.MaxLength = 16
        Me.TXT_CLIENT_RFC.Name = "TXT_CLIENT_RFC"
        Me.TXT_CLIENT_RFC.Size = New System.Drawing.Size(277, 28)
        Me.TXT_CLIENT_RFC.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 22)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "RFC:"
        '
        'TXT_CLIENT_NAME
        '
        Me.TXT_CLIENT_NAME.Location = New System.Drawing.Point(372, 96)
        Me.TXT_CLIENT_NAME.MaxLength = 100
        Me.TXT_CLIENT_NAME.Name = "TXT_CLIENT_NAME"
        Me.TXT_CLIENT_NAME.Size = New System.Drawing.Size(306, 28)
        Me.TXT_CLIENT_NAME.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(368, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Razón social:"
        '
        'TXT_CLIENT_SHORT_NAME
        '
        Me.TXT_CLIENT_SHORT_NAME.Location = New System.Drawing.Point(30, 96)
        Me.TXT_CLIENT_SHORT_NAME.Name = "TXT_CLIENT_SHORT_NAME"
        Me.TXT_CLIENT_SHORT_NAME.Size = New System.Drawing.Size(306, 28)
        Me.TXT_CLIENT_SHORT_NAME.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre corto:"
        '
        'GV_CLIENTE_NOMBRE
        '
        Me.GV_CLIENTE_NOMBRE.DataPropertyName = "nombreCorto"
        Me.GV_CLIENTE_NOMBRE.HeaderText = "Nombre"
        Me.GV_CLIENTE_NOMBRE.Name = "GV_CLIENTE_NOMBRE"
        Me.GV_CLIENTE_NOMBRE.ReadOnly = True
        Me.GV_CLIENTE_NOMBRE.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GV_CLIENTE_NOMBRE.Width = 200
        '
        'GV_CLIENTE_RFC
        '
        Me.GV_CLIENTE_RFC.DataPropertyName = "RFC"
        Me.GV_CLIENTE_RFC.HeaderText = "RFCCliente"
        Me.GV_CLIENTE_RFC.Name = "GV_CLIENTE_RFC"
        Me.GV_CLIENTE_RFC.Visible = False
        '
        'GV_CLIENTE_ID
        '
        Me.GV_CLIENTE_ID.DataPropertyName = "idCliente"
        Me.GV_CLIENTE_ID.HeaderText = "idCliente"
        Me.GV_CLIENTE_ID.Name = "GV_CLIENTE_ID"
        Me.GV_CLIENTE_ID.Visible = False
        '
        'GV_CLIENTE_RAZON_SOCIAL
        '
        Me.GV_CLIENTE_RAZON_SOCIAL.DataPropertyName = "razonSocial"
        Me.GV_CLIENTE_RAZON_SOCIAL.HeaderText = "Razón Social"
        Me.GV_CLIENTE_RAZON_SOCIAL.Name = "GV_CLIENTE_RAZON_SOCIAL"
        Me.GV_CLIENTE_RAZON_SOCIAL.ReadOnly = True
        Me.GV_CLIENTE_RAZON_SOCIAL.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GV_CLIENTE_RAZON_SOCIAL.Width = 200
        '
        'GV_CLIENTE_ACTIVO
        '
        Me.GV_CLIENTE_ACTIVO.DataPropertyName = "activo"
        Me.GV_CLIENTE_ACTIVO.HeaderText = "Activo"
        Me.GV_CLIENTE_ACTIVO.Name = "GV_CLIENTE_ACTIVO"
        Me.GV_CLIENTE_ACTIVO.Visible = False
        '
        'GV_CLIENTE_EDITAR
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GV_CLIENTE_EDITAR.DefaultCellStyle = DataGridViewCellStyle3
        Me.GV_CLIENTE_EDITAR.HeaderText = "Editar"
        Me.GV_CLIENTE_EDITAR.Name = "GV_CLIENTE_EDITAR"
        Me.GV_CLIENTE_EDITAR.ReadOnly = True
        Me.GV_CLIENTE_EDITAR.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GV_CLIENTE_EDITAR.Text = "Editar"
        Me.GV_CLIENTE_EDITAR.UseColumnTextForButtonValue = True
        '
        'GV_CLIENTE_ELIMINAR
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.GV_CLIENTE_ELIMINAR.DefaultCellStyle = DataGridViewCellStyle4
        Me.GV_CLIENTE_ELIMINAR.HeaderText = "Eliminar"
        Me.GV_CLIENTE_ELIMINAR.Name = "GV_CLIENTE_ELIMINAR"
        Me.GV_CLIENTE_ELIMINAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GV_CLIENTE_ELIMINAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FRM_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRM_CLIENTE"
        Me.TabControl1.ResumeLayout(False)
        Me.TBP_CLIENTE.ResumeLayout(False)
        Me.TBP_CLIENTE.PerformLayout()
        CType(Me.DGV_CLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TBP_CLIENTE As TabPage
    Friend WithEvents DGV_CLIENTES As DataGridView
    Friend WithEvents BTN_ADD_CLIENT As Button
    Friend WithEvents TXT_CLIENT_RFC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_CLIENT_NAME As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_CLIENT_SHORT_NAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_CLIENTE_ACTIVO As CheckBox
    Friend WithEvents GV_CLIENTE_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents GV_CLIENTE_RFC As DataGridViewTextBoxColumn
    Friend WithEvents GV_CLIENTE_ID As DataGridViewTextBoxColumn
    Friend WithEvents GV_CLIENTE_RAZON_SOCIAL As DataGridViewTextBoxColumn
    Friend WithEvents GV_CLIENTE_ACTIVO As DataGridViewTextBoxColumn
    Friend WithEvents GV_CLIENTE_EDITAR As DataGridViewButtonColumn
    Friend WithEvents GV_CLIENTE_ELIMINAR As DataGridViewButtonColumn
End Class
