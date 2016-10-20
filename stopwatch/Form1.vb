Public Class Form1
    Dim tmr1 As Integer
    Dim a, b, c, d As Integer

    Private Sub btStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click


        Timer1.Enabled = True

        btStop.Enabled = True

        btStart.Enabled = False
    End Sub

    Private Sub btStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStop.Click
        Timer1.Enabled = False

        btReset.Enabled = True

        btStop.Enabled = False

        btStart.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tmr1 = tmr1 + 1

        tbMsec.Text = tmr1
     
        If tmr1 = 10 Then

            a = a + 1

            tmr1 = 0

        End If

        If a = 60 Then

            b = b + 1

            a = 0

        End If

        If b = 60 Then

            c = c + 1

            b = 0

        End If

        tbSec.Text = a

        tbMin.Text = b

        tbHours.Text = c
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        a = Start_Tijd.tbSecBewerken.Text
        b = Start_Tijd.tbMinBewerken.Text
        c = Start_Tijd.tbHoursBewerken.Text

        tbHours.ReadOnly = True

        tbMin.ReadOnly = True

        tbSec.ReadOnly = True

        tbMsec.ReadOnly = True
    End Sub

    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click
        lbMessege.Visible = True

        btOk.Visible = True

        btCancel.Visible = True

        btReset.Enabled = False
    End Sub

    Private Sub btOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOk.Click
        tbMsec.Text = 0

        tbSec.Text = 0

        tbMin.Text = 0

        tbHours.Text = 0

        a = 0

        b = 0

        c = 0

        d = 0

        lbMessege.Visible = False

        btOk.Visible = False

        btCancel.Visible = False
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        lbMessege.Visible = False

        btOk.Visible = False

        btCancel.Visible = False

        btReset.Enabled = True
    End Sub

    Private Sub btBewerken_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBewerken.Click
        Start_Tijd.Show()

    End Sub
End Class
