<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(444, 245)
        Me.DataGridView1.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Total de Gastos en Dolares:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(173, 125)
        Me.TextBox4.MaxLength = 23456
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(194, 20)
        Me.TextBox4.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Total de Gastos en Colones:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(173, 93)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(194, 20)
        Me.TextBox5.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(59, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(337, 52)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Consultar Gastos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 5
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Showcard Gothic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(638, 387)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 51)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
End Class
