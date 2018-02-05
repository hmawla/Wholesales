<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edititemapge
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
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_buy = New System.Windows.Forms.TextBox()
        Me.lbl_buy = New System.Windows.Forms.Label()
        Me.txt_sell = New System.Windows.Forms.TextBox()
        Me.lbl_sell = New System.Windows.Forms.Label()
        Me.txt_oldbarcode = New System.Windows.Forms.TextBox()
        Me.lbl_barcode = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_barcode
        '
        Me.txt_barcode.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_barcode.Location = New System.Drawing.Point(96, 5)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(126, 24)
        Me.txt_barcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BARCODE"
        '
        'btn_check
        '
        Me.btn_check.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btn_check.Location = New System.Drawing.Point(230, 5)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(87, 30)
        Me.btn_check.TabIndex = 6
        Me.btn_check.Text = "CHECK"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Enabled = False
        Me.txt_name.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_name.Location = New System.Drawing.Point(96, 74)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(221, 24)
        Me.txt_name.TabIndex = 2
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Enabled = False
        Me.lbl_name.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lbl_name.Location = New System.Drawing.Point(14, 77)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(42, 17)
        Me.lbl_name.TabIndex = 1
        Me.lbl_name.Text = "Name"
        '
        'txt_buy
        '
        Me.txt_buy.Enabled = False
        Me.txt_buy.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_buy.Location = New System.Drawing.Point(96, 108)
        Me.txt_buy.Name = "txt_buy"
        Me.txt_buy.Size = New System.Drawing.Size(221, 24)
        Me.txt_buy.TabIndex = 3
        '
        'lbl_buy
        '
        Me.lbl_buy.AutoSize = True
        Me.lbl_buy.Enabled = False
        Me.lbl_buy.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lbl_buy.Location = New System.Drawing.Point(14, 112)
        Me.lbl_buy.Name = "lbl_buy"
        Me.lbl_buy.Size = New System.Drawing.Size(60, 17)
        Me.lbl_buy.TabIndex = 1
        Me.lbl_buy.Text = "Buy Price"
        '
        'txt_sell
        '
        Me.txt_sell.Enabled = False
        Me.txt_sell.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_sell.Location = New System.Drawing.Point(96, 143)
        Me.txt_sell.Name = "txt_sell"
        Me.txt_sell.Size = New System.Drawing.Size(221, 24)
        Me.txt_sell.TabIndex = 4
        '
        'lbl_sell
        '
        Me.lbl_sell.AutoSize = True
        Me.lbl_sell.Enabled = False
        Me.lbl_sell.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lbl_sell.Location = New System.Drawing.Point(14, 147)
        Me.lbl_sell.Name = "lbl_sell"
        Me.lbl_sell.Size = New System.Drawing.Size(58, 17)
        Me.lbl_sell.TabIndex = 1
        Me.lbl_sell.Text = "Sell Price"
        '
        'txt_oldbarcode
        '
        Me.txt_oldbarcode.Enabled = False
        Me.txt_oldbarcode.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_oldbarcode.Location = New System.Drawing.Point(96, 39)
        Me.txt_oldbarcode.Name = "txt_oldbarcode"
        Me.txt_oldbarcode.Size = New System.Drawing.Size(221, 24)
        Me.txt_oldbarcode.TabIndex = 1
        '
        'lbl_barcode
        '
        Me.lbl_barcode.AutoSize = True
        Me.lbl_barcode.Enabled = False
        Me.lbl_barcode.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.lbl_barcode.Location = New System.Drawing.Point(14, 43)
        Me.lbl_barcode.Name = "lbl_barcode"
        Me.lbl_barcode.Size = New System.Drawing.Size(55, 17)
        Me.lbl_barcode.TabIndex = 1
        Me.lbl_barcode.Text = "Barcode"
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btn_edit.Location = New System.Drawing.Point(96, 178)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(222, 30)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "EDIT"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'edititemapge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 212)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.lbl_sell)
        Me.Controls.Add(Me.lbl_buy)
        Me.Controls.Add(Me.lbl_barcode)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_sell)
        Me.Controls.Add(Me.txt_buy)
        Me.Controls.Add(Me.txt_oldbarcode)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_barcode)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "edititemapge"
        Me.Text = "Edit Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_check As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_buy As TextBox
    Friend WithEvents lbl_buy As Label
    Friend WithEvents txt_sell As TextBox
    Friend WithEvents lbl_sell As Label
    Friend WithEvents txt_oldbarcode As TextBox
    Friend WithEvents lbl_barcode As Label
    Friend WithEvents btn_edit As Button
End Class
