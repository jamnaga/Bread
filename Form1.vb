Imports System.Net
Public Class Form1

    Dim WithEvents downloader As New WebClient
    Dim WithEvents downloader_mult As New WebClient

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        End
    End Sub

    Private Sub EsciToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem1.Click
        End
    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        StatoToolStripMenuItem.Enabled = True
        TextBox1.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = True
        Button3.Enabled = False
        Status1.Text = "Operazione in corso..."
        If CheckBox1.Checked Then
            Me.Visible = False
            NotifyIcon1.BalloonTipText = "E' possibile controllare lo stato del download facendo clic con il tasto destro e selezionando stato, sull'icona qui sotto!"
            NotifyIcon1.ShowBalloonTip(4000)
            RipristinaToolStripMenuItem.Enabled = True

        End If
        

        downloader.DownloadFileAsync(New Uri(TextBox1.Text), SaveFileDialog1.FileName)

    End Sub

    Private Sub downloader_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        If Me.Visible = False Then
        End If
        StatoToolStripMenuItem.Enabled = False
        Status1.Text = "Download completato"
        NotifyIcon1.BalloonTipText = "Download da " & TextBox1.Text & " completato e salvato in " & SaveFileDialog1.FileName & " ."
        NotifyIcon1.BalloonTipTitle = "Download info"
        NotifyIcon1.ShowBalloonTip(8000)
        Button1.Enabled = False
        InterrompiToolStripMenuItem.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub downloader_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        InterrompiToolStripMenuItem.Enabled = True
        NotifyIcon1.BalloonTipText = "[" & Status2.Text & "]" & " di " & SaveFileDialog1.FileName
        NotifyIcon1.BalloonTipTitle = "Stato download"
        StatusBar.Visible = True
        Status2.Visible = True
        StatusBar.Value = e.ProgressPercentage
        Status2.Text = StatusBar.Value & "%"
        If StatusBar.Value = "91" Then
            Status1.Text = "Ultimando..."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Status1.Text = "Download annullato dall'utente"
        downloader.CancelAsync()
        downloader_mult.CancelAsync()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Status1.Text = "Pronto"
        StatusBar.Visible = False
        Status2.Visible = False
        TextBox1.Enabled = True
        Button4.Enabled = True
        Button1.Enabled = False
        Button3.Enabled = True
        StatusBar.Value = 0
        Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SaveFileDialog1.Filter = "File eseguibile EXE|*.exe|Musica MP3|*.mp3|Musica WAV|*.wav|Musica WMA|*.wma|Film AVI|*.avi|Film/Musica MP4|*.mp4|Immagine JPG|*.jpg|Immagine PNG|*.png|Immagine Bitmap BMP|*.bmp|Immagine GIF|*.gif|Film FLV|*.flv|Altro (Inserire l'estensione manualmente)|*.*"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label3.Text = SaveFileDialog1.FileName
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.TextBox1.Text = TextBox1.Text
        Form2.Show()
    End Sub

    Private Sub NotifyIcon1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Visible = False
        RipristinaToolStripMenuItem.Enabled = True
    End Sub

    Private Sub RipristinaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RipristinaToolStripMenuItem.Click
        RipristinaToolStripMenuItem.Enabled = False
        Me.Visible = True
    End Sub

    Private Sub StatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatoToolStripMenuItem.Click
        NotifyIcon1.ShowBalloonTip(3000)
    End Sub

    Private Sub InterrompiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterrompiToolStripMenuItem.Click
        InterrompiToolStripMenuItem.Enabled = False
        Status1.Text = "Download annullato dall'utente"
        NotifyIcon1.BalloonTipText = Status1.Text
        NotifyIcon1.ShowBalloonTip(3000)
        downloader.CancelAsync()
        Timer1.Enabled = True
    End Sub


    Private Sub GestioneURLsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestioneURLsToolStripMenuItem.Click
        Form2.TextBox1.Text = TextBox1.Text
        Form2.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.ShowDialog()

        StatoToolStripMenuItem.Enabled = True
        TextBox1.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = True
        Button3.Enabled = False
        Status1.Text = "Operazione in corso..."
        If CheckBox1.Checked Then
            Me.Visible = False
            NotifyIcon1.BalloonTipText = "E' possibile controllare lo stato del download facendo clic con il tasto destro e selezionando stato, sull'icona qui sotto!"
            NotifyIcon1.ShowBalloonTip(4000)
            RipristinaToolStripMenuItem.Enabled = True

        End If

    End Sub

    Private Sub downloader_mult_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader_mult.DownloadFileCompleted
        If Me.Visible = False Then
        End If

        StatoToolStripMenuItem.Enabled = False
        Status1.Text = "Download completato"
        NotifyIcon1.BalloonTipText = "Download da " & TextBox1.Text & " completato e salvato in " & FolderBrowserDialog1.SelectedPath & " ."
        NotifyIcon1.BalloonTipTitle = "Download info"
        NotifyIcon1.ShowBalloonTip(8000)
        Button1.Enabled = False
        InterrompiToolStripMenuItem.Enabled = False
       
close_async:
        Timer1.Enabled = True
    End Sub

    Private Sub downloader_mult_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles downloader_mult.DownloadProgressChanged
        InterrompiToolStripMenuItem.Enabled = True
        NotifyIcon1.BalloonTipText = "[" & Status2.Text & "]" & " di " & SaveFileDialog1.FileName
        NotifyIcon1.BalloonTipTitle = "Stato download"
        StatusBar.Visible = True
        Status2.Visible = True
        StatusBar.Value = e.ProgressPercentage
        Status2.Text = StatusBar.Value & "%"
        If StatusBar.Value = "91" Then
            Status1.Text = "Ultimando..."
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then
            RadioButton2.Checked = False
            RadioButton1.Checked = True
        End If
        If RadioButton2.Checked = True Then
            Button7.Visible = True

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
        If RadioButton2.Checked = True Then
            Button7.Visible = True
        Else
            Button7.Visible = False
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Visible = False
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Label1.Text = "URL VIDEO"
        TextBox1.Text = ""
        Button1.Enabled = False
        Button4.Enabled = False
        CheckBox1.Enabled = False


    End Sub

    Private Sub RadioButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Label1.Text = "URL"
        TextBox1.Text = "http://"
        Button4.Enabled = True
        CheckBox1.Enabled = True


    End Sub
End Class

