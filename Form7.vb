﻿Public Class Form7





    Private Sub btIngresar_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        Button6.Hide()
        Button7.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button6.Show()
        Button7.Show()
        Button2.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()

    End Sub
End Class