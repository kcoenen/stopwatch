<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Tijd
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
        Me.btCancelBewerken = New System.Windows.Forms.Button
        Me.btOkBewerken = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbMsecBewerken = New System.Windows.Forms.TextBox
        Me.tbSecBewerken = New System.Windows.Forms.TextBox
        Me.tbMinBewerken = New System.Windows.Forms.TextBox
        Me.tbHoursBewerken = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btCancelBewerken
        '
        Me.btCancelBewerken.Location = New System.Drawing.Point(131, 97)
        Me.btCancelBewerken.Name = "btCancelBewerken"
        Me.btCancelBewerken.Size = New System.Drawing.Size(75, 23)
        Me.btCancelBewerken.TabIndex = 32
        Me.btCancelBewerken.Text = "Cancel"
        Me.btCancelBewerken.UseVisualStyleBackColor = True
        '
        'btOkBewerken
        '
        Me.btOkBewerken.Location = New System.Drawing.Point(12, 97)
        Me.btOkBewerken.Name = "btOkBewerken"
        Me.btOkBewerken.Size = New System.Drawing.Size(75, 23)
        Me.btOkBewerken.TabIndex = 31
        Me.btOkBewerken.Text = "ok"
        Me.btOkBewerken.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Miliseconden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Seconden"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Minuten"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Uren"
        '
        'tbMsecBewerken
        '
        Me.tbMsecBewerken.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMsecBewerken.Location = New System.Drawing.Point(179, 33)
        Me.tbMsecBewerken.Name = "tbMsecBewerken"
        Me.tbMsecBewerken.Size = New System.Drawing.Size(38, 24)
        Me.tbMsecBewerken.TabIndex = 26
        '
        'tbSecBewerken
        '
        Me.tbSecBewerken.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSecBewerken.Location = New System.Drawing.Point(110, 33)
        Me.tbSecBewerken.Name = "tbSecBewerken"
        Me.tbSecBewerken.Size = New System.Drawing.Size(36, 24)
        Me.tbSecBewerken.TabIndex = 25
        '
        'tbMinBewerken
        '
        Me.tbMinBewerken.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMinBewerken.Location = New System.Drawing.Point(59, 33)
        Me.tbMinBewerken.Name = "tbMinBewerken"
        Me.tbMinBewerken.Size = New System.Drawing.Size(34, 24)
        Me.tbMinBewerken.TabIndex = 24
        '
        'tbHoursBewerken
        '
        Me.tbHoursBewerken.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHoursBewerken.Location = New System.Drawing.Point(16, 33)
        Me.tbHoursBewerken.Name = "tbHoursBewerken"
        Me.tbHoursBewerken.Size = New System.Drawing.Size(34, 24)
        Me.tbHoursBewerken.TabIndex = 23
        '
        'Start_Tijd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 150)
        Me.Controls.Add(Me.btCancelBewerken)
        Me.Controls.Add(Me.btOkBewerken)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMsecBewerken)
        Me.Controls.Add(Me.tbSecBewerken)
        Me.Controls.Add(Me.tbMinBewerken)
        Me.Controls.Add(Me.tbHoursBewerken)
        Me.Name = "Start_Tijd"
        Me.Text = "Start_Tijd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btCancelBewerken As System.Windows.Forms.Button
    Friend WithEvents btOkBewerken As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMsecBewerken As System.Windows.Forms.TextBox
    Friend WithEvents tbSecBewerken As System.Windows.Forms.TextBox
    Friend WithEvents tbMinBewerken As System.Windows.Forms.TextBox
    Friend WithEvents tbHoursBewerken As System.Windows.Forms.TextBox
End Class
