Public NotInheritable Class SplashScreen1

    'TODO: questo form può essere facilmente impostato come schermata iniziale per l'applicazione dalla scheda "Applicazione"
    '  di Progettazione progetti (scegliere "Proprietà" dal menu "Progetto").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
    End Sub

    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click

    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
    End Sub

    Private Sub ApplicationTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class
