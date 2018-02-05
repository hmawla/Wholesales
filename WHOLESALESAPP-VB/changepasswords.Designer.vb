<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepasswords
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_logapply = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_logrep = New System.Windows.Forms.TextBox()
        Me.txt_lognew = New System.Windows.Forms.TextBox()
        Me.txt_logold = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_admapply = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_admold = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_admnew = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_admrep = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_logapply)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_logrep)
        Me.GroupBox1.Controls.Add(Me.txt_lognew)
        Me.GroupBox1.Controls.Add(Me.txt_logold)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN PASSWORD"
        '
        'btn_logapply
        '
        Me.btn_logapply.Location = New System.Drawing.Point(230, 112)
        Me.btn_logapply.Name = "btn_logapply"
        Me.btn_logapply.Size = New System.Drawing.Size(87, 27)
        Me.btn_logapply.TabIndex = 3
        Me.btn_logapply.Text = "Apply"
        Me.btn_logapply.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Repeat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Old"
        '
        'txt_logrep
        '
        Me.txt_logrep.Location = New System.Drawing.Point(73, 82)
        Me.txt_logrep.Name = "txt_logrep"
        Me.txt_logrep.Size = New System.Drawing.Size(243, 24)
        Me.txt_logrep.TabIndex = 2
        Me.txt_logrep.UseSystemPasswordChar = True
        '
        'txt_lognew
        '
        Me.txt_lognew.Location = New System.Drawing.Point(73, 52)
        Me.txt_lognew.Name = "txt_lognew"
        Me.txt_lognew.Size = New System.Drawing.Size(243, 24)
        Me.txt_lognew.TabIndex = 1
        Me.txt_lognew.UseSystemPasswordChar = True
        '
        'txt_logold
        '
        Me.txt_logold.Location = New System.Drawing.Point(73, 22)
        Me.txt_logold.Name = "txt_logold"
        Me.txt_logold.Size = New System.Drawing.Size(243, 24)
        Me.txt_logold.TabIndex = 0
        Me.txt_logold.UseSystemPasswordChar = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_admapply)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_admold)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_admnew)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_admrep)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADMIN PASSWORD"
        '
        'btn_admapply
        '
        Me.btn_admapply.Location = New System.Drawing.Point(230, 112)
        Me.btn_admapply.Name = "btn_admapply"
        Me.btn_admapply.Size = New System.Drawing.Size(87, 27)
        Me.btn_admapply.TabIndex = 7
        Me.btn_admapply.Text = "Apply"
        Me.btn_admapply.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Repeat"
        '
        'txt_admold
        '
        Me.txt_admold.Location = New System.Drawing.Point(73, 22)
        Me.txt_admold.Name = "txt_admold"
        Me.txt_admold.Size = New System.Drawing.Size(243, 24)
        Me.txt_admold.TabIndex = 4
        Me.txt_admold.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "New"
        '
        'txt_admnew
        '
        Me.txt_admnew.Location = New System.Drawing.Point(73, 52)
        Me.txt_admnew.Name = "txt_admnew"
        Me.txt_admnew.Size = New System.Drawing.Size(243, 24)
        Me.txt_admnew.TabIndex = 5
        Me.txt_admnew.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Old"
        '
        'txt_admrep
        '
        Me.txt_admrep.Location = New System.Drawing.Point(73, 82)
        Me.txt_admrep.Name = "txt_admrep"
        Me.txt_admrep.Size = New System.Drawing.Size(243, 24)
        Me.txt_admrep.TabIndex = 6
        Me.txt_admrep.UseSystemPasswordChar = True
        '
        'changepasswords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 344)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "changepasswords"
        Me.Text = "Password Changer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_logapply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_logrep As TextBox
    Friend WithEvents txt_lognew As TextBox
    Friend WithEvents txt_logold As TextBox
    Friend WithEvents btn_admapply As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_admold As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_admnew As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_admrep As TextBox
End Class
