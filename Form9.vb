Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class Form9
    Dim Conexion As New SqlConnection
    Dim comandos As New SqlCommand
    Private Sub CargarDatos()
        Try
            AbrirConexion()
            Dim cadena As String = "Select GastoTarjeta,Tipo_Negocio from Gastos"
            Dim DA As New SqlDataAdapter(cadena, Conexion)
            Dim DT As New DataTable()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox("Error: " And ex.Message)
        End Try
    End Sub
    Public Function AbrirConexion() As Boolean
        Try
            Conexion = New SqlConnection("server=DESKTOP-FRPTMCQ;database=ProyectoFinal; integrated security = true ")
            Conexion.Open()
            If Conexion.State = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()


        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("GastoTarjeta").Value)
        Next
        TextBox5.Text = Convert.ToString(total)
        TextBox4.Text = Convert.ToString(total / 645)
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub
End Class