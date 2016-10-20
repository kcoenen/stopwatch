<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tbHours = New System.Windows.Forms.TextBox()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.tbSec = New System.Windows.Forms.TextBox()
        Me.tbMsec = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btStart = New System.Windows.Forms.Button()
        Me.btStop = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.btOk = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbMessege = New System.Windows.Forms.Label()
        Me.btBewerken = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbHours
        '
        Me.tbHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHours.Location = New System.Drawing.Point(70, 42)
        Me.tbHours.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbHours.Name = "tbHours"
        Me.tbHours.Size = New System.Drawing.Size(148, 121)
        Me.tbHours.TabIndex = 0
        '
        'tbMin
        '
        Me.tbMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMin.Location = New System.Drawing.Point(252, 42)
        Me.tbMin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(148, 121)
        Me.tbMin.TabIndex = 1
        '
        'tbSec
        '
        Me.tbSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSec.Location = New System.Drawing.Point(432, 42)
        Me.tbSec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbSec.Name = "tbSec"
        Me.tbSec.Size = New System.Drawing.Size(148, 121)
        Me.tbSec.TabIndex = 2
        '
        'tbMsec
        '
        Me.tbMsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMsec.Location = New System.Drawing.Point(621, 42)
        Me.tbMsec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbMsec.Name = "tbMsec"
        Me.tbMsec.Size = New System.Drawing.Size(148, 121)
        Me.tbMsec.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 191)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Uren"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minuten"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seconden"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Miliseconden"
        '
        'btStart
        '
        Me.btStart.Location = New System.Drawing.Point(70, 303)
        Me.btStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btStart.Name = "btStart"
        Me.btStart.Size = New System.Drawing.Size(112, 35)
        Me.btStart.TabIndex = 8
        Me.btStart.Text = "Start"
        Me.btStart.UseVisualStyleBackColor = True
        '
        'btStop
        '
        Me.btStop.Location = New System.Drawing.Point(262, 303)
        Me.btStop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btStop.Name = "btStop"
        Me.btStop.Size = New System.Drawing.Size(112, 35)
        Me.btStop.TabIndex = 9
        Me.btStop.Text = "Stop"
        Me.btStop.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(452, 303)
        Me.btReset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(112, 35)
        Me.btReset.TabIndex = 10
        Me.btReset.Text = "Reset"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'btOk
        '
        Me.btOk.Location = New System.Drawing.Point(621, 303)
        Me.btOk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btOk.Name = "btOk"
        Me.btOk.Size = New System.Drawing.Size(112, 35)
        Me.btOk.TabIndex = 11
        Me.btOk.Text = "ok"
        Me.btOk.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(813, 303)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(112, 35)
        Me.btCancel.TabIndex = 12
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'lbMessege
        '
        Me.lbMessege.AutoSize = True
        Me.lbMessege.Location = New System.Drawing.Point(258, 243)
        Me.lbMessege.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMessege.Name = "lbMessege"
        Me.lbMessege.Size = New System.Drawing.Size(289, 20)
        Me.lbMessege.TabIndex = 13
        Me.lbMessege.Text = "Are you sure you want to reset the timer"
        '
        'btBewerken
        '
        Me.btBewerken.Location = New System.Drawing.Point(837, 60)
        Me.btBewerken.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btBewerken.Name = "btBewerken"
        Me.btBewerken.Size = New System.Drawing.Size(112, 35)
        Me.btBewerken.TabIndex = 14
        Me.btBewerken.Text = "Bewerken"
        Me.btBewerken.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(990, 372)
        Me.Controls.Add(Me.btBewerken)
        Me.Controls.Add(Me.lbMessege)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOk)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btStop)
        Me.Controls.Add(Me.btStart)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMsec)
        Me.Controls.Add(Me.tbSec)
        Me.Controls.Add(Me.tbMin)
        Me.Controls.Add(Me.tbHours)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Stopwatch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbHours As System.Windows.Forms.TextBox
    Friend WithEvents tbMin As System.Windows.Forms.TextBox
    Friend WithEvents tbSec As System.Windows.Forms.TextBox
    Friend WithEvents tbMsec As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents btReset As System.Windows.Forms.Button
    Friend WithEvents btOk As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbMessege As System.Windows.Forms.Label
    Friend WithEvents btBewerken As System.Windows.Forms.Button

End Class
