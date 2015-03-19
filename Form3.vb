Imports System.Net
Public Class Form3
    Dim APIUrl As String = "http://en.savefrom.net/"
    Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Form1.Visible = True
    End Sub

    Private Sub Form3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave
        Form1.Visible = True

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(APIUrl & Form1.TextBox1.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Label1.Visible = False
        WebBrowser1.Visible = True


    End Sub

    Private Sub WebBrowser1_FileDownload(ByVal sender As Object, ByVal e As System.EventArgs) Handles WebBrowser1.FileDownload

    End Sub

    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class