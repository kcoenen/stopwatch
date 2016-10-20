Public Class Start_Tijd

    Private Sub Start_Tijd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbHoursBewerken.Text = 0
        tbMinBewerken.Text = 0
        tbSecBewerken.Text = 0
        tbMsecBewerken.Text = 0

    End Sub

    Private Sub btOkBewerken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOkBewerken.Click
        Form1.tbHours.Text = tbHoursBewerken.Text
        Form1.tbMin.Text = tbMinBewerken.Text
        Form1.tbSec.Text = tbSecBewerken.Text
        Form1.tbMsec.Text = tbMsecBewerken.Text
        Form1.Show()
    End Sub
End Class