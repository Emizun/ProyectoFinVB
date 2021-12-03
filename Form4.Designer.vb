<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroTarjeta = New System.Windows.Forms.TextBox()
        Me.NombreTarjeta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoTarjeta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CVV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VencimientoTarjeta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btIngresar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Aqua
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(158, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Tarjeta"
        '
        'NumeroTarjeta
        '
        Me.NumeroTarjeta.Location = New System.Drawing.Point(164, 271)
        Me.NumeroTarjeta.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NumeroTarjeta.Name = "NumeroTarjeta"
        Me.NumeroTarjeta.Size = New System.Drawing.Size(400, 31)
        Me.NumeroTarjeta.TabIndex = 2
        '
        'NombreTarjeta
        '
        Me.NombreTarjeta.Location = New System.Drawing.Point(164, 377)
        Me.NombreTarjeta.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.NombreTarjeta.Name = "NombreTarjeta"
        Me.NombreTarjeta.Size = New System.Drawing.Size(400, 31)
        Me.NombreTarjeta.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(158, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Completo"
        '
        'TipoTarjeta
        '
        Me.TipoTarjeta.Location = New System.Drawing.Point(164, 494)
        Me.TipoTarjeta.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TipoTarjeta.Name = "TipoTarjeta"
        Me.TipoTarjeta.Size = New System.Drawing.Size(400, 31)
        Me.TipoTarjeta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(158, 463)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo de Tarjeta"
        '
        'CVV
        '
        Me.CVV.Location = New System.Drawing.Point(934, 271)
        Me.CVV.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CVV.Name = "CVV"
        Me.CVV.Size = New System.Drawing.Size(400, 31)
        Me.CVV.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(928, 240)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CVV"
        '
        'VencimientoTarjeta
        '
        Me.VencimientoTarjeta.Location = New System.Drawing.Point(934, 377)
        Me.VencimientoTarjeta.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.VencimientoTarjeta.Name = "VencimientoTarjeta"
        Me.VencimientoTarjeta.Size = New System.Drawing.Size(400, 31)
        Me.VencimientoTarjeta.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(928, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'btIngresar
        '
        Me.btIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btIngresar.FlatAppearance.BorderSize = 5
        Me.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btIngresar.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btIngresar.ForeColor = System.Drawing.Color.Black
        Me.btIngresar.Location = New System.Drawing.Point(158, 627)
        Me.btIngresar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btIngresar.Name = "btIngresar"
        Me.btIngresar.Size = New System.Drawing.Size(1180, 98)
        Me.btIngresar.TabIndex = 17
        Me.btIngresar.Text = "Agregar Tarjeta"
        Me.btIngresar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(474, 75)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(488, 52)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = " Registre Su Tarjeta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 5
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1276, 744)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(300, 98)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btIngresar)
        Me.Controls.Add(Me.VencimientoTarjeta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CVV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TipoTarjeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NombreTarjeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumeroTarjeta)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumeroTarjeta As TextBox
    Friend WithEvents NombreTarjeta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TipoTarjeta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CVV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VencimientoTarjeta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btIngresar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button6 As Button
End Class
