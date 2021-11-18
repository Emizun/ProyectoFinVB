<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.btRegistrarse = New System.Windows.Forms.Button()
        Me.lbRegistrar = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbContraseña = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btIngresar
        '
        Me.btIngresar.Location = New System.Drawing.Point(623, 409)
        Me.btIngresar.Margin = New System.Windows.Forms.Padding(6)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(169, 44)
        Me.btIngresar.TabIndex = 2
        Me.btIngresar.Text = "Ingresar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btIngresar.UseVisualStyleBackColor = True
        '
        'btRegistrarse
        '
        Me.btRegistrarse.Location = New System.Drawing.Point(623, 563)
        Me.btRegistrarse.Name = "btRegistrarse"
        Me.btRegistrarse.Size = New System.Drawing.Size(169, 43)
        Me.btRegistrarse.TabIndex = 3
        Me.btRegistrarse.Text = "Registrarse "
        Me.btRegistrarse.UseVisualStyleBackColor = True
        '
        'lbRegistrar
        '
        Me.lbRegistrar.AutoSize = True
        Me.lbRegistrar.Location = New System.Drawing.Point(585, 524)
        Me.lbRegistrar.Name = "lbRegistrar"
        Me.lbRegistrar.Size = New System.Drawing.Size(253, 25)
        Me.lbRegistrar.TabIndex = 4
        Me.lbRegistrar.Text = "¿Aún no está registrado?"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(570, 242)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(284, 31)
        Me.txtUsuario.TabIndex = 5
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(570, 345)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(284, 31)
        Me.txtContraseña.TabIndex = 6
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(667, 197)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(86, 25)
        Me.lbUsuario.TabIndex = 7
        Me.lbUsuario.Text = "Usuario"
        '
        'lbContraseña
        '
        Me.lbContraseña.AutoSize = True
        Me.lbContraseña.Location = New System.Drawing.Point(646, 298)
        Me.lbContraseña.Name = "lbContraseña"
        Me.lbContraseña.Size = New System.Drawing.Size(123, 25)
        Me.lbContraseña.TabIndex = 8
        Me.lbContraseña.Text = "Contraseña"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.lbContraseña)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbRegistrar)
        Me.Controls.Add(Me.btRegistrarse)
        Me.Controls.Add(Me.btIngresar)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btIngresar As Button
    Friend WithEvents btRegistrarse As Button
    Friend WithEvents lbRegistrar As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbContraseña As Label
End Class
