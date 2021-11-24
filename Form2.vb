

Imports System.Data
Imports System.Data.SqlClient


Public Class Form2

    Dim stringConnection As String = "Data Source = GABRIELZUMBBC33; initial catalog = ProyectoFinal; Integrated security = True"
    Dim stringSelect As String = "SELECT * FROM RegistroUS"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CargarGrid()

    End Sub

    Private Sub CargarGrid()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable

        Try
            da = New SqlDataAdapter(stringSelect, stringConnection)
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            Label9.Text = String.Format("Total de datos en la tabla{0}", dt.Rows.Count)
        Catch ex As Exception
            Label9.Text = "Error:" & ex.Message
        End Try


    End Sub

    Private Sub btCrearNewUser_Click(sender As Object, e As EventArgs) Handles btCrearNewUser.Click

        If txtBoxNombre.Text <> " " And txtBoxApellidos.Text <> " " And txtBoxNumID.Text <> " " And txtBoxEmail.Text <> " " And txtBoxTelefono.Text <> " " And txtBoxContrasena.Text <> " " And txtBoxConfirContra.Text <> " " Then

            Dim InsertSql As String


            InsertSql = "INSERT INTO RegistroUS (Nombre, Apellidos, NumID, Email, Telefono, Contrasena, ConfirContra) VALUES (@Nombre, @Apellidos, @NumID, @Email, @Telefono, @Contrasena, @ConfirContra)"

            Using con As New SqlConnection(stringConnection)

                Dim cmd As New SqlCommand(InsertSql, con)

                cmd.Parameters.AddWithValue("@Nombre", txtBoxNombre)
                cmd.Parameters.AddWithValue("@Apellidos", txtBoxApellidos)
                cmd.Parameters.AddWithValue("@NumID", txtBoxNumID)
                cmd.Parameters.AddWithValue("@Email", txtBoxEmail)
                cmd.Parameters.AddWithValue("@Telefono", txtBoxTelefono)
                cmd.Parameters.AddWithValue("@Contrasena", txtBoxContrasena)
                cmd.Parameters.AddWithValue("@ConfirContra", txtBoxConfirContra)

                'con.Open()
                'Dim t As Integer = CInt(cmd.ExecuteScalar())
                'con.Close()

            End Using
            Call CargarGrid()
            MsgBox("Ha creado un usuario satisfactoriamente")

        End If


    End Sub
End Class