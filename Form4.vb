Public Class Form4

    Dim conexion As Conexion = New Conexion()


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("Select * from Tarjetas", "Tarjetas")
        'DataGridView2.DataSource = conexion.ds.Tables("Tarjetas")
    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

        Dim agregar As String = "INSERT into Tarjetas values ('" + NumeroTarjeta.Text + "','" + NombreTarjeta.Text + "','" + TipoTarjeta.Text + "','" _
                                                                  + CVV.Text + "','" + VencimientoTarjeta.Text + "')"
        If (conexion.Insertar(agregar)) Then
            MessageBox.Show("El registro se hizo correctamente")
            MostrarDatos()
        Else
            MessageBox.Show("Error al regitrarse")
        End If



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class