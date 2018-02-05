<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class additempage
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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_buy = New System.Windows.Forms.TextBox()
        Me.txt_sell = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_barcode
        '
        Me.txt_barcode.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_barcode.Location = New System.Drawing.Point(102, 7)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(196, 24)
        Me.txt_barcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.btn_add.Location = New System.Drawing.Point(102, 145)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(197, 47)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_name.Location = New System.Drawing.Point(102, 42)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(196, 24)
        Me.txt_name.TabIndex = 1
        '
        'txt_buy
        '
        Me.txt_buy.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_buy.Location = New System.Drawing.Point(102, 76)
        Me.txt_buy.Name = "txt_buy"
        Me.txt_buy.Size = New System.Drawing.Size(196, 24)
        Me.txt_buy.TabIndex = 2
        '
        'txt_sell
        '
        Me.txt_sell.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.txt_sell.Location = New System.Drawing.Point(102, 111)
        Me.txt_sell.Name = "txt_sell"
        Me.txt_sell.Size = New System.Drawing.Size(196, 24)
        Me.txt_sell.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Buy Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Sell Price"
        '
        'additempage
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 204)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_sell)
        Me.Controls.Add(Me.txt_buy)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_barcode)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "additempage"
        Me.Text = "Add Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_barcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_buy As TextBox
    Friend WithEvents txt_sell As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
