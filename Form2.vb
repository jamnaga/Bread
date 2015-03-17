Public Class Form2

    Private Sub SalvaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaToolStripButton.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub ApriToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriToolStripButton.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Button1.Text = "Importa"
            TextBox1.Text = (My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName))
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.TextBox1.Text = TextBox1.Text
        Me.Close()
    End Sub
End Class