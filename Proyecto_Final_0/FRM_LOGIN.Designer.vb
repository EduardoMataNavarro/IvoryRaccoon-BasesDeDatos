<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_LOGIN))
        Me.TXT_LOG_MAIL = New System.Windows.Forms.TextBox()
        Me.TXT_LOG_PASSWORD = New System.Windows.Forms.TextBox()
        Me.BTN_LOG_IN = New System.Windows.Forms.Button()
        Me.LBL_NAME = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_CLOSE = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_LOG_MAIL
        '
        Me.TXT_LOG_MAIL.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_LOG_MAIL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_LOG_MAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LOG_MAIL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_LOG_MAIL.Location = New System.Drawing.Point(157, 302)
        Me.TXT_LOG_MAIL.MaxLength = 50
        Me.TXT_LOG_MAIL.Name = "TXT_LOG_MAIL"
        Me.TXT_LOG_MAIL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_LOG_MAIL.Size = New System.Drawing.Size(288, 21)
        Me.TXT_LOG_MAIL.TabIndex = 0
        '
        'TXT_LOG_PASSWORD
        '
        Me.TXT_LOG_PASSWORD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.TXT_LOG_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_LOG_PASSWORD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LOG_PASSWORD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.TXT_LOG_PASSWORD.Location = New System.Drawing.Point(161, 406)
        Me.TXT_LOG_PASSWORD.Margin = New System.Windows.Forms.Padding(5)
        Me.TXT_LOG_PASSWORD.MaxLength = 50
        Me.TXT_LOG_PASSWORD.Name = "TXT_LOG_PASSWORD"
        Me.TXT_LOG_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_LOG_PASSWORD.Size = New System.Drawing.Size(288, 21)
        Me.TXT_LOG_PASSWORD.TabIndex = 1
        '
        'BTN_LOG_IN
        '
        Me.BTN_LOG_IN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.BTN_LOG_IN.FlatAppearance.BorderSize = 2
        Me.BTN_LOG_IN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_LOG_IN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_LOG_IN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_LOG_IN.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LOG_IN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BTN_LOG_IN.Location = New System.Drawing.Point(158, 550)
        Me.BTN_LOG_IN.Name = "BTN_LOG_IN"
        Me.BTN_LOG_IN.Size = New System.Drawing.Size(290, 51)
        Me.BTN_LOG_IN.TabIndex = 2
        Me.BTN_LOG_IN.Text = "Entrar"
        Me.BTN_LOG_IN.UseVisualStyleBackColor = True
        '
        'LBL_NAME
        '
        Me.LBL_NAME.AutoSize = True
        Me.LBL_NAME.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NAME.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.LBL_NAME.Location = New System.Drawing.Point(203, 19)
        Me.LBL_NAME.Name = "LBL_NAME"
        Me.LBL_NAME.Size = New System.Drawing.Size(173, 20)
        Me.LBL_NAME.TabIndex = 9
        Me.LBL_NAME.Text = "Ivory Raccoon - LogIn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(157, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(157, 435)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 5)
        Me.Panel3.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(153, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Contraseña:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(158, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 5)
        Me.Panel1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_Final_0.My.Resources.Resources.logoMapache1
        Me.PictureBox1.Location = New System.Drawing.Point(255, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.FlatAppearance.BorderSize = 0
        Me.BTN_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BTN_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_CLOSE.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Image = Global.Proyecto_Final_0.My.Resources.Resources._006_close
        Me.BTN_CLOSE.Location = New System.Drawing.Point(554, 9)
        Me.BTN_CLOSE.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(35, 35)
        Me.BTN_CLOSE.TabIndex = 8
        Me.BTN_CLOSE.UseVisualStyleBackColor = True
        '
        'FRM_LOGIN
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBL_NAME)
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.Controls.Add(Me.BTN_LOG_IN)
        Me.Controls.Add(Me.TXT_LOG_MAIL)
        Me.Controls.Add(Me.TXT_LOG_PASSWORD)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 550)
        Me.Name = "FRM_LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_LOG_MAIL As TextBox
    Friend WithEvents TXT_LOG_PASSWORD As TextBox
    Friend WithEvents BTN_LOG_IN As Button
    Friend WithEvents BTN_CLOSE As Button
    Friend WithEvents LBL_NAME As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
