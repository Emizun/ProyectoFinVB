


Public Class Form2

    Dim conexion As Conexion = New Conexion()


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatos()
    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("Select * from RegistroUS", "RegistroUS")
        'DataGridView1.DataSource = conexion.ds.Tables("RegistroUS") ESTA LINEA SIRVE PARA CUANDO UNO NECESITE VER LA INFO ALMECENADA EN EL GRIDVIEW EN PANTALLA
    End Sub

    Private Sub btCrearNewUser_Click(sender As Object, e As EventArgs) Handles btCrearNewUser.Click

        Dim agregar As String = "insert into RegistroUS values ('" + Nombre.Text + "','" + Apellidos.Text + "','" + NumID.Text + "','" _
                                                                   + Email.Text + "','" + Telefono.Text + "','" + Contrasena.Text + "')"
        Try

            If (conexion.Insertar(agregar)) Then
                MessageBox.Show("El registro se hizo correctamente")
                Me.Close()
                MostrarDatos()

            Else
                MessageBox.Show("Error al regitrarse")

            End If

        Catch ex As Exception
            MessageBox.Show("Intentelo de nuevo")

        End Try



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Salir_Regristro()


    End Sub


End Class