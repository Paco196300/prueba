Public Class Form1
    Private Sub BttSalir_Click(sender As Object, e As EventArgs) Handles BttSalir.Click
        Me.Close()
    End Sub

    Private Sub BttInicio_Click(sender As Object, e As EventArgs) Handles BttInicio.Click
        MessageBox.Show("Hello Word", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
