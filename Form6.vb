Imports System.Data
Imports System.Data.SqlClient

Public Class Form6
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Show()
        Label1.Show()
        TextBox2.Show()
        Label2.Show()

        ' Dim stringConnecion As String = "Data Source = DESKTOP-FRPTMCQ; initial catalog = ProyectoFinal; Integrated security = True"
        'Dim stringSelect As String = "SELECT * FROM Gastos"


        'Dim da As SqlDataAdapter
        'Dim tb As New TextBox
        'Try
        'da = New SqlDataAdapter(stringConnecion, stringSelect)
        'da.Fill(tb)
        'Me.TextBox1.DataSource = tb


        'Catch ex As Exception

        'End Try




    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class