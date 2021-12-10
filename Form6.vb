Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms




Public Class Form6
    Dim Conexion As New SqlConnection
    Dim comandos As New SqlCommand




    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Data Source = DESKTOP-FRPTMCQ; initial catalog = ProyectoFinal; Integrated security = True"
            'Dim As SqlConnection = New SqlConnection("Data Source = DESKTOP-FRPTMCQ; initial catalog = ProyectoFinal; Integrated security = True")
            'Conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form6_Load()



    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Try
            comandos = New SqlCommand("INSERT INTO Gastos(GastoTarjeta,Tipo_Negocio)" & Chr(13) &
                                      "VALUES(@GastoTarjeta,@Tipo_Negocio)", Conexion)
            comandos.Parameters.AddWithValue("@GastoTarjeta", TextBox1.Text)
            comandos.Parameters.AddWithValue("@Tipo_Negocio", TextBox3.Text)
            Conexion.Open()
            comandos.ExecuteNonQuery()
            MsgBox("Datos Guardados ")
        Catch ex As Exception
            MsgBox(ex.Message)
            ' Conexion.Close()
        End Try


        ' Conexion.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
