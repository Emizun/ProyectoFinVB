Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form8
    Dim Conexion As New SqlConnection
    Dim comandos As New SqlCommand

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click



    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "Data Source = DESKTOP-FRPTMCQ; initial catalog = ProyectoFinal; Integrated security = True"
            Conexion.Open()
            MsgBox("Conectado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click
        Try
            Dim ENTRADA As String = "INSERT INTO RegistroCuenta(NombreCuenta,IdCuenta,BancoEmisor) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')"
            Dim DT As New DataTable
            Dim ADAPTADOR As New SqlDataAdapter(ENTRADA, Conexion)

            ADAPTADOR.Fill(DT)
            Conexion.Close()
            MsgBox("Registro Exitoso")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conexion.Dispose()


    End Sub
End Class