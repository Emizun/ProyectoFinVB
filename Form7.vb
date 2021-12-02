Public Class Form7




    Private Sub btIngresar_Click(sender As Object, e As EventArgs) Handles btIngresar.Click

        TextBox1.Show()
        Label1.Show()
        TextBox2.Show()
        Label2.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Hide()
        Label1.Hide()
        TextBox2.Hide()
        Label2.Hide()
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
End Class