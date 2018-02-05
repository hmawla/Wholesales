<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BalanceManager
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
        Me.txt_balance = New System.Windows.Forms.GroupBox()
        Me.btn_apply = New System.Windows.Forms.Button()
        Me.txt_alfayear = New System.Windows.Forms.TextBox()
        Me.txt_touchyear = New System.Windows.Forms.TextBox()
        Me.combx_alfamon = New System.Windows.Forms.ComboBox()
        Me.combx_alfaday = New System.Windows.Forms.ComboBox()
        Me.combx_touchmon = New System.Windows.Forms.ComboBox()
        Me.combx_touchday = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_alfabal = New System.Windows.Forms.TextBox()
        Me.txt_touchbal = New System.Windows.Forms.TextBox()
        Me.txt_balance.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_balance
        '
        Me.txt_balance.Controls.Add(Me.btn_apply)
        Me.txt_balance.Controls.Add(Me.txt_alfayear)
        Me.txt_balance.Controls.Add(Me.txt_touchyear)
        Me.txt_balance.Controls.Add(Me.combx_alfamon)
        Me.txt_balance.Controls.Add(Me.combx_alfaday)
        Me.txt_balance.Controls.Add(Me.combx_touchmon)
        Me.txt_balance.Controls.Add(Me.combx_touchday)
        Me.txt_balance.Controls.Add(Me.Label2)
        Me.txt_balance.Controls.Add(Me.Label1)
        Me.txt_balance.Controls.Add(Me.txt_alfabal)
        Me.txt_balance.Controls.Add(Me.txt_touchbal)
        Me.txt_balance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_balance.Location = New System.Drawing.Point(0, 0)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(502, 174)
        Me.txt_balance.TabIndex = 0
        Me.txt_balance.TabStop = False
        Me.txt_balance.Text = "Balance"
        '
        'btn_apply
        '
        Me.btn_apply.Location = New System.Drawing.Point(383, 134)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(96, 27)
        Me.btn_apply.TabIndex = 6
        Me.btn_apply.Text = "APPLY"
        Me.btn_apply.UseVisualStyleBackColor = True
        '
        'txt_alfayear
        '
        Me.txt_alfayear.Location = New System.Drawing.Point(383, 82)
        Me.txt_alfayear.Name = "txt_alfayear"
        Me.txt_alfayear.Size = New System.Drawing.Size(96, 24)
        Me.txt_alfayear.TabIndex = 5
        '
        'txt_touchyear
        '
        Me.txt_touchyear.Location = New System.Drawing.Point(383, 37)
        Me.txt_touchyear.Name = "txt_touchyear"
        Me.txt_touchyear.Size = New System.Drawing.Size(96, 24)
        Me.txt_touchyear.TabIndex = 5
        '
        'combx_alfamon
        '
        Me.combx_alfamon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_alfamon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_alfamon.FormattingEnabled = True
        Me.combx_alfamon.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.combx_alfamon.Location = New System.Drawing.Point(259, 82)
        Me.combx_alfamon.Name = "combx_alfamon"
        Me.combx_alfamon.Size = New System.Drawing.Size(116, 23)
        Me.combx_alfamon.TabIndex = 4
        '
        'combx_alfaday
        '
        Me.combx_alfaday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_alfaday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_alfaday.FormattingEnabled = True
        Me.combx_alfaday.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.combx_alfaday.Location = New System.Drawing.Point(190, 82)
        Me.combx_alfaday.Name = "combx_alfaday"
        Me.combx_alfaday.Size = New System.Drawing.Size(59, 23)
        Me.combx_alfaday.TabIndex = 3
        '
        'combx_touchmon
        '
        Me.combx_touchmon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_touchmon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_touchmon.FormattingEnabled = True
        Me.combx_touchmon.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.combx_touchmon.Location = New System.Drawing.Point(259, 37)
        Me.combx_touchmon.Name = "combx_touchmon"
        Me.combx_touchmon.Size = New System.Drawing.Size(116, 23)
        Me.combx_touchmon.TabIndex = 4
        '
        'combx_touchday
        '
        Me.combx_touchday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_touchday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_touchday.FormattingEnabled = True
        Me.combx_touchday.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.combx_touchday.Location = New System.Drawing.Point(190, 37)
        Me.combx_touchday.Name = "combx_touchday"
        Me.combx_touchday.Size = New System.Drawing.Size(59, 23)
        Me.combx_touchday.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alfa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Touch"
        '
        'txt_alfabal
        '
        Me.txt_alfabal.Location = New System.Drawing.Point(17, 82)
        Me.txt_alfabal.Name = "txt_alfabal"
        Me.txt_alfabal.Size = New System.Drawing.Size(116, 24)
        Me.txt_alfabal.TabIndex = 0
        '
        'txt_touchbal
        '
        Me.txt_touchbal.Location = New System.Drawing.Point(17, 37)
        Me.txt_touchbal.Name = "txt_touchbal"
        Me.txt_touchbal.Size = New System.Drawing.Size(116, 24)
        Me.txt_touchbal.TabIndex = 0
        '
        'BalanceManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 174)
        Me.Controls.Add(Me.txt_balance)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "BalanceManager"
        Me.Text = "BalanceManager"
        Me.txt_balance.ResumeLayout(False)
        Me.txt_balance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt_balance As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_alfabal As TextBox
    Friend WithEvents txt_touchbal As TextBox
    Friend WithEvents txt_alfayear As TextBox
    Friend WithEvents txt_touchyear As TextBox
    Friend WithEvents combx_alfamon As ComboBox
    Friend WithEvents combx_alfaday As ComboBox
    Friend WithEvents combx_touchmon As ComboBox
    Friend WithEvents combx_touchday As ComboBox
    Friend WithEvents btn_apply As Button
End Class
