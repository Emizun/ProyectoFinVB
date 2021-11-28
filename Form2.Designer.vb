<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.NumID = New System.Windows.Forms.TextBox()
        Me.Apellidos = New System.Windows.Forms.TextBox()
        Me.Contrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btCrearNewUser = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBoxConfirContra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(58, 165)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(6)
        Me.Nombre.Multiline = True
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(606, 56)
        Me.Nombre.TabIndex = 2
        '
        'Telefono
        '
        Me.Telefono.Location = New System.Drawing.Point(788, 248)
        Me.Telefono.Margin = New System.Windows.Forms.Padding(6)
        Me.Telefono.Multiline = True
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(606, 56)
        Me.Telefono.TabIndex = 3
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(58, 525)
        Me.Email.Margin = New System.Windows.Forms.Padding(6)
        Me.Email.Multiline = True
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(606, 56)
        Me.Email.TabIndex = 4
        '
        'NumID
        '
        Me.NumID.Location = New System.Drawing.Point(58, 410)
        Me.NumID.Margin = New System.Windows.Forms.Padding(6)
        Me.NumID.Multiline = True
        Me.NumID.Name = "NumID"
        Me.NumID.Size = New System.Drawing.Size(606, 56)
        Me.NumID.TabIndex = 5
        '
        'Apellidos
        '
        Me.Apellidos.Location = New System.Drawing.Point(58, 283)
        Me.Apellidos.Margin = New System.Windows.Forms.Padding(6)
        Me.Apellidos.Multiline = True
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.Size = New System.Drawing.Size(606, 56)
        Me.Apellidos.TabIndex = 6
        '
        'Contrasena
        '
        Me.Contrasena.Location = New System.Drawing.Point(788, 367)
        Me.Contrasena.Margin = New System.Windows.Forms.Padding(6)
        Me.Contrasena.Multiline = True
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.Size = New System.Drawing.Size(606, 56)
        Me.Contrasena.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumBlue
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumBlue
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 248)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.MediumBlue
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, 367)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Numero de ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.MediumBlue
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 494)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MediumBlue
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(782, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.MediumBlue
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(782, 337)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Contraseña"
        '
        'btCrearNewUser
        '
        Me.btCrearNewUser.BackColor = System.Drawing.Color.Transparent
        Me.btCrearNewUser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btCrearNewUser.FlatAppearance.BorderSize = 5
        Me.btCrearNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCrearNewUser.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCrearNewUser.ForeColor = System.Drawing.Color.Black
        Me.btCrearNewUser.Location = New System.Drawing.Point(164, 629)
        Me.btCrearNewUser.Margin = New System.Windows.Forms.Padding(6)
        Me.btCrearNewUser.Name = "btCrearNewUser"
        Me.btCrearNewUser.Size = New System.Drawing.Size(1142, 98)
        Me.btCrearNewUser.TabIndex = 16
        Me.btCrearNewUser.Text = "Crear Nuevo Usuario"
        Me.btCrearNewUser.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(396, 17)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(500, 52)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = " Registro de Usuario"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 25)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Label9"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(405, 772)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.Size = New System.Drawing.Size(552, 220)
        Me.DataGridView1.TabIndex = 19
        '
        'txtBoxConfirContra
        '
        Me.txtBoxConfirContra.Location = New System.Drawing.Point(788, 488)
        Me.txtBoxConfirContra.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBoxConfirContra.Multiline = True
        Me.txtBoxConfirContra.Name = "txtBoxConfirContra"
        Me.txtBoxConfirContra.Size = New System.Drawing.Size(606, 56)
        Me.txtBoxConfirContra.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.MediumBlue
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(782, 458)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirmar Contraseña"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(2062, 1038)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btCrearNewUser)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Contrasena)
        Me.Controls.Add(Me.txtBoxConfirContra)
        Me.Controls.Add(Me.Apellidos)
        Me.Controls.Add(Me.NumID)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.Label9)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nombre As TextBox
    Friend WithEvents Telefono As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents NumID As TextBox
    Friend WithEvents Apellidos As TextBox
    Friend WithEvents Contrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btCrearNewUser As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBoxConfirContra As TextBox
    Friend WithEvents Label7 As Label
End Class
