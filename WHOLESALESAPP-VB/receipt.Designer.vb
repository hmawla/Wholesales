<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class receipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_totalitems = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_totalpriced = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lvl_totalpricel = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barcode, Me.itemname, Me.qty, Me.price})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(462, 498)
        Me.DataGridView1.TabIndex = 1
        '
        'barcode
        '
        Me.barcode.FillWeight = 119.797!
        Me.barcode.HeaderText = "Barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        '
        'itemname
        '
        Me.itemname.FillWeight = 119.797!
        Me.itemname.HeaderText = "Item Name"
        Me.itemname.Name = "itemname"
        Me.itemname.ReadOnly = True
        '
        'qty
        '
        Me.qty.FillWeight = 40.60914!
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'price
        '
        Me.price.FillWeight = 119.797!
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'lbl_totalitems
        '
        Me.lbl_totalitems.AutoSize = True
        Me.lbl_totalitems.Location = New System.Drawing.Point(12, 507)
        Me.lbl_totalitems.Name = "lbl_totalitems"
        Me.lbl_totalitems.Size = New System.Drawing.Size(69, 13)
        Me.lbl_totalitems.TabIndex = 2
        Me.lbl_totalitems.Text = "Total Items #"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 504)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(33, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Check In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_totalpriced
        '
        Me.lbl_totalpriced.AutoSize = True
        Me.lbl_totalpriced.Location = New System.Drawing.Point(12, 536)
        Me.lbl_totalpriced.Name = "lbl_totalpriced"
        Me.lbl_totalpriced.Size = New System.Drawing.Size(67, 13)
        Me.lbl_totalpriced.TabIndex = 2
        Me.lbl_totalpriced.Text = "Total Price $"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(99, 533)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 3
        '
        'lvl_totalpricel
        '
        Me.lvl_totalpricel.AutoSize = True
        Me.lvl_totalpricel.Location = New System.Drawing.Point(12, 562)
        Me.lvl_totalpricel.Name = "lvl_totalpricel"
        Me.lvl_totalpricel.Size = New System.Drawing.Size(81, 13)
        Me.lvl_totalpricel.TabIndex = 2
        Me.lvl_totalpricel.Text = "Total Price LBP"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 559)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(147, 20)
        Me.TextBox3.TabIndex = 3
        '
        'receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 598)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lvl_totalpricel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_totalpriced)
        Me.Controls.Add(Me.lbl_totalitems)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "receipt"
        Me.Text = "Receipt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_totalitems As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_totalpriced As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents barcode As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents lvl_totalpricel As Label
    Friend WithEvents TextBox3 As TextBox
End Class
