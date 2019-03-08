<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_PROYECTO
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TBP_PROYECTO = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_PROYECTO_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.CMB_PROYECTO_CLIENTE = New MetroFramework.Controls.MetroComboBox()
        Me.DTP_PROYECTO_FECHA_FIN = New MetroFramework.Controls.MetroDateTime()
        Me.DTP_PROYECTO_FECHA_INICIO = New MetroFramework.Controls.MetroDateTime()
        Me.BTN_SAVE_PROYECT = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_PROYECTO_NOMBRE = New System.Windows.Forms.TextBox()
        Me.DGV_PROYECTOS = New System.Windows.Forms.DataGridView()
        Me.GV_PROYECTO_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_PROYECTO_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_PROYECTO_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_PROYECTO_FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GV_PROYECTO_BORRAR = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GV_PROYECTO_DETALLES = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl2.SuspendLayout()
        Me.TBP_PROYECTO.SuspendLayout()
        CType(Me.DGV_PROYECTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TBP_PROYECTO)
        Me.TabControl2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(703, 515)
        Me.TabControl2.TabIndex = 0
        '
        'TBP_PROYECTO
        '
        Me.TBP_PROYECTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TBP_PROYECTO.Controls.Add(Me.Label13)
        Me.TBP_PROYECTO.Controls.Add(Me.TXT_PROYECTO_DESCRIPCION)
        Me.TBP_PROYECTO.Controls.Add(Me.CMB_PROYECTO_CLIENTE)
        Me.TBP_PROYECTO.Controls.Add(Me.DTP_PROYECTO_FECHA_FIN)
        Me.TBP_PROYECTO.Controls.Add(Me.DTP_PROYECTO_FECHA_INICIO)
        Me.TBP_PROYECTO.Controls.Add(Me.BTN_SAVE_PROYECT)
        Me.TBP_PROYECTO.Controls.Add(Me.Label15)
        Me.TBP_PROYECTO.Controls.Add(Me.Label14)
        Me.TBP_PROYECTO.Controls.Add(Me.Label12)
        Me.TBP_PROYECTO.Controls.Add(Me.Label11)
        Me.TBP_PROYECTO.Controls.Add(Me.TXT_PROYECTO_NOMBRE)
        Me.TBP_PROYECTO.Controls.Add(Me.DGV_PROYECTOS)
        Me.TBP_PROYECTO.Location = New System.Drawing.Point(4, 31)
        Me.TBP_PROYECTO.Name = "TBP_PROYECTO"
        Me.TBP_PROYECTO.Padding = New System.Windows.Forms.Padding(3)
        Me.TBP_PROYECTO.Size = New System.Drawing.Size(695, 480)
        Me.TBP_PROYECTO.TabIndex = 0
        Me.TBP_PROYECTO.Text = "Proyecto"
        Me.TBP_PROYECTO.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(50, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 22)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Descripción"
        '
        'TXT_PROYECTO_DESCRIPCION
        '
        Me.TXT_PROYECTO_DESCRIPCION.Location = New System.Drawing.Point(54, 144)
        Me.TXT_PROYECTO_DESCRIPCION.MaxLength = 500
        Me.TXT_PROYECTO_DESCRIPCION.Multiline = True
        Me.TXT_PROYECTO_DESCRIPCION.Name = "TXT_PROYECTO_DESCRIPCION"
        Me.TXT_PROYECTO_DESCRIPCION.Size = New System.Drawing.Size(276, 101)
        Me.TXT_PROYECTO_DESCRIPCION.TabIndex = 1
        '
        'CMB_PROYECTO_CLIENTE
        '
        Me.CMB_PROYECTO_CLIENTE.FormattingEnabled = True
        Me.CMB_PROYECTO_CLIENTE.ItemHeight = 24
        Me.CMB_PROYECTO_CLIENTE.Location = New System.Drawing.Point(390, 65)
        Me.CMB_PROYECTO_CLIENTE.Name = "CMB_PROYECTO_CLIENTE"
        Me.CMB_PROYECTO_CLIENTE.PromptText = "-Cliente que pidio el proyecto-"
        Me.CMB_PROYECTO_CLIENTE.Size = New System.Drawing.Size(276, 30)
        Me.CMB_PROYECTO_CLIENTE.TabIndex = 2
        Me.CMB_PROYECTO_CLIENTE.UseSelectable = True
        '
        'DTP_PROYECTO_FECHA_FIN
        '
        Me.DTP_PROYECTO_FECHA_FIN.Location = New System.Drawing.Point(390, 215)
        Me.DTP_PROYECTO_FECHA_FIN.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DTP_PROYECTO_FECHA_FIN.Name = "DTP_PROYECTO_FECHA_FIN"
        Me.DTP_PROYECTO_FECHA_FIN.Size = New System.Drawing.Size(252, 30)
        Me.DTP_PROYECTO_FECHA_FIN.TabIndex = 4
        '
        'DTP_PROYECTO_FECHA_INICIO
        '
        Me.DTP_PROYECTO_FECHA_INICIO.Location = New System.Drawing.Point(390, 144)
        Me.DTP_PROYECTO_FECHA_INICIO.MinimumSize = New System.Drawing.Size(0, 30)
        Me.DTP_PROYECTO_FECHA_INICIO.Name = "DTP_PROYECTO_FECHA_INICIO"
        Me.DTP_PROYECTO_FECHA_INICIO.Size = New System.Drawing.Size(252, 30)
        Me.DTP_PROYECTO_FECHA_INICIO.TabIndex = 3
        '
        'BTN_SAVE_PROYECT
        '
        Me.BTN_SAVE_PROYECT.ForeColor = System.Drawing.Color.Black
        Me.BTN_SAVE_PROYECT.Location = New System.Drawing.Point(519, 271)
        Me.BTN_SAVE_PROYECT.Name = "BTN_SAVE_PROYECT"
        Me.BTN_SAVE_PROYECT.Size = New System.Drawing.Size(125, 39)
        Me.BTN_SAVE_PROYECT.TabIndex = 5
        Me.BTN_SAVE_PROYECT.Text = "Guardar"
        Me.BTN_SAVE_PROYECT.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(386, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 22)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Fecha estimada de fin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(386, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(138, 22)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Fecha de inicio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(386, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Cliente"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(50, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Nombre"
        '
        'TXT_PROYECTO_NOMBRE
        '
        Me.TXT_PROYECTO_NOMBRE.Location = New System.Drawing.Point(54, 67)
        Me.TXT_PROYECTO_NOMBRE.Name = "TXT_PROYECTO_NOMBRE"
        Me.TXT_PROYECTO_NOMBRE.Size = New System.Drawing.Size(276, 28)
        Me.TXT_PROYECTO_NOMBRE.TabIndex = 0
        '
        'DGV_PROYECTOS
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_PROYECTOS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_PROYECTOS.BackgroundColor = System.Drawing.Color.White
        Me.DGV_PROYECTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PROYECTOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GV_PROYECTO_ID, Me.GV_PROYECTO_NOMBRE, Me.GV_PROYECTO_CLIENTE, Me.GV_PROYECTO_FECHA, Me.GV_PROYECTO_BORRAR, Me.GV_PROYECTO_DETALLES})
        Me.DGV_PROYECTOS.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_PROYECTOS.Location = New System.Drawing.Point(15, 332)
        Me.DGV_PROYECTOS.Name = "DGV_PROYECTOS"
        Me.DGV_PROYECTOS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGV_PROYECTOS.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("MS Reference Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_PROYECTOS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGV_PROYECTOS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_PROYECTOS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGV_PROYECTOS.RowTemplate.Height = 24
        Me.DGV_PROYECTOS.Size = New System.Drawing.Size(665, 142)
        Me.DGV_PROYECTOS.TabIndex = 0
        '
        'GV_PROYECTO_ID
        '
        Me.GV_PROYECTO_ID.DataPropertyName = "idProyecto"
        Me.GV_PROYECTO_ID.HeaderText = "idProyecto"
        Me.GV_PROYECTO_ID.Name = "GV_PROYECTO_ID"
        Me.GV_PROYECTO_ID.Visible = False
        '
        'GV_PROYECTO_NOMBRE
        '
        Me.GV_PROYECTO_NOMBRE.DataPropertyName = "nombreProyecto"
        Me.GV_PROYECTO_NOMBRE.HeaderText = "Nombre"
        Me.GV_PROYECTO_NOMBRE.Name = "GV_PROYECTO_NOMBRE"
        Me.GV_PROYECTO_NOMBRE.ReadOnly = True
        '
        'GV_PROYECTO_CLIENTE
        '
        Me.GV_PROYECTO_CLIENTE.DataPropertyName = "nombreCorto"
        Me.GV_PROYECTO_CLIENTE.HeaderText = "Cliente"
        Me.GV_PROYECTO_CLIENTE.Name = "GV_PROYECTO_CLIENTE"
        Me.GV_PROYECTO_CLIENTE.ReadOnly = True
        '
        'GV_PROYECTO_FECHA
        '
        Me.GV_PROYECTO_FECHA.DataPropertyName = "fechaInicio"
        Me.GV_PROYECTO_FECHA.HeaderText = "Fecha"
        Me.GV_PROYECTO_FECHA.Name = "GV_PROYECTO_FECHA"
        Me.GV_PROYECTO_FECHA.ReadOnly = True
        '
        'GV_PROYECTO_BORRAR
        '
        Me.GV_PROYECTO_BORRAR.HeaderText = "Borrar"
        Me.GV_PROYECTO_BORRAR.Name = "GV_PROYECTO_BORRAR"
        Me.GV_PROYECTO_BORRAR.ReadOnly = True
        Me.GV_PROYECTO_BORRAR.Text = "Borrar"
        Me.GV_PROYECTO_BORRAR.UseColumnTextForButtonValue = True
        '
        'GV_PROYECTO_DETALLES
        '
        Me.GV_PROYECTO_DETALLES.HeaderText = "Detalles"
        Me.GV_PROYECTO_DETALLES.Name = "GV_PROYECTO_DETALLES"
        Me.GV_PROYECTO_DETALLES.ReadOnly = True
        Me.GV_PROYECTO_DETALLES.Text = "Ver detalles"
        Me.GV_PROYECTO_DETALLES.UseColumnTextForButtonValue = True
        '
        'FRM_PROYECTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(727, 539)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_PROYECTO"
        Me.TabControl2.ResumeLayout(False)
        Me.TBP_PROYECTO.ResumeLayout(False)
        Me.TBP_PROYECTO.PerformLayout()
        CType(Me.DGV_PROYECTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DTP_DEADLINE As DateTimePicker
    Friend WithEvents DTP_START_DATE As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_ADD_PROJECT As Button
    Friend WithEvents DGV_BROWSE_PROJECTS As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CMB_PARAMETER As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TBP_PROYECTO As TabPage
    Friend WithEvents DTP_PROYECTO_FECHA_FIN As MetroFramework.Controls.MetroDateTime
    Friend WithEvents DTP_PROYECTO_FECHA_INICIO As MetroFramework.Controls.MetroDateTime
    Friend WithEvents BTN_SAVE_PROYECT As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_PROYECTO_NOMBRE As TextBox
    Friend WithEvents DGV_PROYECTOS As DataGridView
    Friend WithEvents CMB_PROYECTO_CLIENTE As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_PROYECTO_DESCRIPCION As TextBox
    Friend WithEvents GV_PROYECTO_ID As DataGridViewTextBoxColumn
    Friend WithEvents GV_PROYECTO_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents GV_PROYECTO_CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents GV_PROYECTO_FECHA As DataGridViewTextBoxColumn
    Friend WithEvents GV_PROYECTO_BORRAR As DataGridViewButtonColumn
    Friend WithEvents GV_PROYECTO_DETALLES As DataGridViewButtonColumn
End Class
