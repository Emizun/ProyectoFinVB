Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    Dim conexion As New SqlConnection
    Dim adaptador As New SqlDataAdapter
    Dim datos As New DataSet



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btRegistrarse.Click
        Form2.Show()

    End Sub

    Dim usuario As String
    Dim contra As String

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

        Dim conexion As SqlConnection = New SqlConnection("Data Source = DESKTOP-FRPTMCQ; initial catalog = ProyectoFinal; Integrated security = True")

        usuario = txtUsuario.Text
        contra = txtContraseña.Text
        Dim consulta As String
        Dim lista As Byte


        If txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
            consulta = "SELECT * FROM RegistroUS WHERE Nombre ='" & txtUsuario.Text & "' and Contrasena = '" & txtContraseña.Text & "'"
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "ProyectoFinal")
            lista = datos.Tables("ProyectoFinal").Rows.Count



        End If

        If lista <> 0 Then
            Form3.Show()
        Else
            MsgBox("El usuario no es valido, Intente nuevamente")

        End If



        ' Try
        ' If usuario = "moab" And contra = "1234" Then
        'MessageBox.Show("El usuario se hizo correctamente")
        'Form3.Show()
        ' Else
        '  MessageBox.Show("El usuario no es valido")

        'End If
        ' Catch ex As Exception


        ' End Try




    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class