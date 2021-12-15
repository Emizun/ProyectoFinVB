Imports System.Data
Imports System.Data.SqlClient


Public Class Form5
    Dim conexion As SqlConnection
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    Private Sub CargarDatos()
        Try
            AbrirConexion()
            Dim cadena As String = "Select codigo, servicio, precio from Servicios"
            Dim DA As New SqlDataAdapter(cadena, conexion)
            Dim DT As New DataTable()
            DA.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox("Error: " And ex.Message)
        End Try
    End Sub

    Public Function AbrirConexion() As Boolean
        Try
            conexion = New SqlConnection("server=DESKTOP-FRPTMCQ;database=ProyectoFinal; integrated security = true ")
            conexion.Open()
            If conexion.State = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If AbrirConexion() = True Then
                Dim cadena As String = "Insert into Servicios(servicio,precio) values ('" & TextBox3.Text & "', " & TextBox2.Text & " )"
                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, conexion)
                Dim resultado As Integer
                resultado = comando.ExecuteNonQuery()
                If resultado = 1 Then
                    MsgBox("Se agrego con exito")
                Else
                    MsgBox("No se pudo agregar")
                End If
                CargarDatos()
            Else
                MsgBox("No hay conexion xon el servidor, no se pudo agregar.")
            End If
        Catch ex As Exception
            MsgBox("Error," And ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cadena As String = "Select servicio, precio from Servicios where codigo=" & TextBox1.Text
            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, conexion)
            Dim registro As SqlDataReader
            registro = comando.ExecuteReader()
            If registro.Read() = True Then
                'registro.Close()
                'Dim DA As New SqlDataAdapter(cadena,conexion)
                'Dim DT As New DataTable()
                'DA.Fill(DT)
                'DataGridView1.DataSource = DT
                MsgBox("Descripcion:" & registro("servicio") & "Precio: " & registro("precio"))
            Else
                MsgBox("Error: No hay registro con ese codigo")

            End If
            registro.Close()
        Catch ex As Exception
            MsgBox("Error," And ex.Message)
        End Try
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            If AbrirConexion() = True Then
                CargarDatos()
            Else
                MsgBox("No Hay conexion con el servidor.")
            End If
        Catch ex As Exception
            MsgBox("Error," And ex.Message)
        End Try
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cadena As String = "Update Servicios set servicio = '" & TextBox3.Text & "', precio=" & TextBox2.Text & "where codigo=" & TextBox1.Text
            Dim comando As SqlCommand
            comando = New SqlCommand(cadena, conexion)
            Dim resultado As Integer
            resultado = comando.ExecuteNonQuery()
            If resultado = 1 Then
                MsgBox("Se actualizo con exito")
                TextBox1.Text = ""
                TextBox3.Text = ""
                TextBox2.Text = ""
            Else
                MsgBox("No se pudo actualizar")
            End If
            CargarDatos()
        Catch ex As Exception
            MsgBox("Error," And ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim Cadena As String = "Delete from Servicios where codigo = " & TextBox1.Text
            Dim comando As New SqlCommand
            comando = New SqlCommand(Cadena, conexion)
            Dim resultado As Integer
            resultado = comando.ExecuteNonQuery()
            If resultado = 1 Then
                MsgBox("Se elimino con exito")
                MsgBox("Se actualizo con exito")
                TextBox1.Text = ""
                TextBox3.Text = ""
                TextBox2.Text = ""
            Else
                MsgBox("No se pudo eliminar")
            End If
            CargarDatos()
        Catch ex As Exception
            MsgBox("Error," And ex.Message)
        End Try
    End Sub
End Class