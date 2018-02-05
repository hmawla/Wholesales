<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tab_sell = New System.Windows.Forms.TabPage()
        Me.grp_sell = New System.Windows.Forms.GroupBox()
        Me.txt_totalprice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_sellexe = New System.Windows.Forms.Button()
        Me.txt_sellname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_sellbarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_selladdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_selleditdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buyprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_sellprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_sellqtt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_sellsearch = New System.Windows.Forms.Button()
        Me.txt_sellsearch = New System.Windows.Forms.TextBox()
        Me.tab_items = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataSet = New WHOLESALESAPP_VB.SalesDataSet()
        Me.tab_report = New System.Windows.Forms.TabPage()
        Me.btn_repprint = New System.Windows.Forms.Button()
        Me.btn_repsearch = New System.Windows.Forms.Button()
        Me.grp_bycode = New System.Windows.Forms.GroupBox()
        Me.txt_repbarcode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grp_bydate = New System.Windows.Forms.GroupBox()
        Me.txt_toyear = New System.Windows.Forms.TextBox()
        Me.btn_reptoday = New System.Windows.Forms.Button()
        Me.combx_tomon = New System.Windows.Forms.ComboBox()
        Me.txt_frmyear = New System.Windows.Forms.TextBox()
        Me.combx_today = New System.Windows.Forms.ComboBox()
        Me.combx_frmmon = New System.Windows.Forms.ComboBox()
        Me.combx_frmday = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rdb_bycode = New System.Windows.Forms.RadioButton()
        Me.rdb_bydate = New System.Windows.Forms.RadioButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.paymentid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.barcode1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soldprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalprice1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateofpayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab_balance = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_baladd = New System.Windows.Forms.Button()
        Me.rdb_baladdalfa = New System.Windows.Forms.RadioButton()
        Me.txt_baladd = New System.Windows.Forms.TextBox()
        Me.rdb_baladdtouch = New System.Windows.Forms.RadioButton()
        Me.Sell = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_balsell = New System.Windows.Forms.Button()
        Me.rdb_balsellalfa = New System.Windows.Forms.RadioButton()
        Me.rdb_balselltouch = New System.Windows.Forms.RadioButton()
        Me.txt_balprice = New System.Windows.Forms.TextBox()
        Me.txt_balsell = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_balremalfa = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_baldatealfa = New System.Windows.Forms.Label()
        Me.lbl_balalfa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_balremtouch = New System.Windows.Forms.Label()
        Me.lbl_baldatetouch = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_baltouch = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOnlineGuidesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ItemsTableAdapter = New WHOLESALESAPP_VB.SalesDataSetTableAdapters.ItemsTableAdapter()
        Me.ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTableAdapter = New WHOLESALESAPP_VB.SalesDataSetTableAdapters.ReportTableAdapter()
        Me.BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BalanceTableAdapter = New WHOLESALESAPP_VB.SalesDataSetTableAdapters.BalanceTableAdapter()
        Me.RechSellBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RechSellTableAdapter = New WHOLESALESAPP_VB.SalesDataSetTableAdapters.RechSellTableAdapter()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CredentialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CredentialsTableAdapter = New WHOLESALESAPP_VB.SalesDataSetTableAdapters.CredentialsTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TabControl.SuspendLayout()
        Me.tab_sell.SuspendLayout()
        Me.grp_sell.SuspendLayout()
        Me.tab_items.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_report.SuspendLayout()
        Me.grp_bycode.SuspendLayout()
        Me.grp_bydate.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_balance.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Sell.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RechSellBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CredentialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tab_sell)
        Me.TabControl.Controls.Add(Me.tab_items)
        Me.TabControl.Controls.Add(Me.tab_report)
        Me.TabControl.Controls.Add(Me.tab_balance)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TabControl.Location = New System.Drawing.Point(0, 24)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(915, 623)
        Me.TabControl.TabIndex = 1
        '
        'tab_sell
        '
        Me.tab_sell.Controls.Add(Me.grp_sell)
        Me.tab_sell.Controls.Add(Me.Label1)
        Me.tab_sell.Controls.Add(Me.btn_sellsearch)
        Me.tab_sell.Controls.Add(Me.txt_sellsearch)
        Me.tab_sell.Location = New System.Drawing.Point(4, 24)
        Me.tab_sell.Name = "tab_sell"
        Me.tab_sell.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_sell.Size = New System.Drawing.Size(907, 595)
        Me.tab_sell.TabIndex = 1
        Me.tab_sell.Text = "Sell"
        Me.tab_sell.UseVisualStyleBackColor = True
        '
        'grp_sell
        '
        Me.grp_sell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_sell.Controls.Add(Me.txt_totalprice)
        Me.grp_sell.Controls.Add(Me.Label9)
        Me.grp_sell.Controls.Add(Me.btn_sellexe)
        Me.grp_sell.Controls.Add(Me.txt_sellname)
        Me.grp_sell.Controls.Add(Me.Label8)
        Me.grp_sell.Controls.Add(Me.txt_sellbarcode)
        Me.grp_sell.Controls.Add(Me.Label4)
        Me.grp_sell.Controls.Add(Me.txt_selladdate)
        Me.grp_sell.Controls.Add(Me.Label7)
        Me.grp_sell.Controls.Add(Me.txt_selleditdate)
        Me.grp_sell.Controls.Add(Me.Label5)
        Me.grp_sell.Controls.Add(Me.txt_buyprice)
        Me.grp_sell.Controls.Add(Me.Label3)
        Me.grp_sell.Controls.Add(Me.txt_sellprice)
        Me.grp_sell.Controls.Add(Me.Label6)
        Me.grp_sell.Controls.Add(Me.txt_sellqtt)
        Me.grp_sell.Controls.Add(Me.Label2)
        Me.grp_sell.Enabled = False
        Me.grp_sell.Location = New System.Drawing.Point(13, 77)
        Me.grp_sell.Name = "grp_sell"
        Me.grp_sell.Size = New System.Drawing.Size(883, 495)
        Me.grp_sell.TabIndex = 3
        Me.grp_sell.TabStop = False
        '
        'txt_totalprice
        '
        Me.txt_totalprice.Location = New System.Drawing.Point(150, 299)
        Me.txt_totalprice.Name = "txt_totalprice"
        Me.txt_totalprice.ReadOnly = True
        Me.txt_totalprice.Size = New System.Drawing.Size(131, 24)
        Me.txt_totalprice.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(7, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Price:"
        '
        'btn_sellexe
        '
        Me.btn_sellexe.Location = New System.Drawing.Point(293, 299)
        Me.btn_sellexe.Name = "btn_sellexe"
        Me.btn_sellexe.Size = New System.Drawing.Size(132, 28)
        Me.btn_sellexe.TabIndex = 1
        Me.btn_sellexe.Text = "SELL ITEM"
        Me.btn_sellexe.UseVisualStyleBackColor = True
        '
        'txt_sellname
        '
        Me.txt_sellname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sellname.Location = New System.Drawing.Point(150, 87)
        Me.txt_sellname.Name = "txt_sellname"
        Me.txt_sellname.ReadOnly = True
        Me.txt_sellname.Size = New System.Drawing.Size(273, 24)
        Me.txt_sellname.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(7, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Quantity To Sell:"
        '
        'txt_sellbarcode
        '
        Me.txt_sellbarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sellbarcode.Location = New System.Drawing.Point(150, 33)
        Me.txt_sellbarcode.Name = "txt_sellbarcode"
        Me.txt_sellbarcode.ReadOnly = True
        Me.txt_sellbarcode.Size = New System.Drawing.Size(273, 24)
        Me.txt_sellbarcode.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(7, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Sell Price:"
        '
        'txt_selladdate
        '
        Me.txt_selladdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_selladdate.Location = New System.Drawing.Point(573, 33)
        Me.txt_selladdate.Name = "txt_selladdate"
        Me.txt_selladdate.ReadOnly = True
        Me.txt_selladdate.Size = New System.Drawing.Size(273, 24)
        Me.txt_selladdate.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(461, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Last Edit Date:"
        '
        'txt_selleditdate
        '
        Me.txt_selleditdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_selleditdate.Location = New System.Drawing.Point(573, 87)
        Me.txt_selleditdate.Name = "txt_selleditdate"
        Me.txt_selleditdate.ReadOnly = True
        Me.txt_selleditdate.Size = New System.Drawing.Size(273, 24)
        Me.txt_selleditdate.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Added Date:"
        '
        'txt_buyprice
        '
        Me.txt_buyprice.Location = New System.Drawing.Point(150, 140)
        Me.txt_buyprice.Name = "txt_buyprice"
        Me.txt_buyprice.ReadOnly = True
        Me.txt_buyprice.Size = New System.Drawing.Size(131, 24)
        Me.txt_buyprice.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Original Price:"
        '
        'txt_sellprice
        '
        Me.txt_sellprice.Location = New System.Drawing.Point(150, 193)
        Me.txt_sellprice.Name = "txt_sellprice"
        Me.txt_sellprice.ReadOnly = True
        Me.txt_sellprice.Size = New System.Drawing.Size(131, 24)
        Me.txt_sellprice.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Item Barcode:"
        '
        'txt_sellqtt
        '
        Me.txt_sellqtt.Location = New System.Drawing.Point(150, 246)
        Me.txt_sellqtt.MaxLength = 3
        Me.txt_sellqtt.Name = "txt_sellqtt"
        Me.txt_sellqtt.Size = New System.Drawing.Size(41, 24)
        Me.txt_sellqtt.TabIndex = 0
        Me.txt_sellqtt.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Barcode"
        '
        'btn_sellsearch
        '
        Me.btn_sellsearch.Location = New System.Drawing.Point(287, 7)
        Me.btn_sellsearch.Name = "btn_sellsearch"
        Me.btn_sellsearch.Size = New System.Drawing.Size(87, 28)
        Me.btn_sellsearch.TabIndex = 1
        Me.btn_sellsearch.Text = "SEARCH"
        Me.btn_sellsearch.UseVisualStyleBackColor = True
        '
        'txt_sellsearch
        '
        Me.txt_sellsearch.Location = New System.Drawing.Point(80, 7)
        Me.txt_sellsearch.Name = "txt_sellsearch"
        Me.txt_sellsearch.Size = New System.Drawing.Size(199, 24)
        Me.txt_sellsearch.TabIndex = 0
        '
        'tab_items
        '
        Me.tab_items.Controls.Add(Me.DataGridView1)
        Me.tab_items.Location = New System.Drawing.Point(4, 24)
        Me.tab_items.Name = "tab_items"
        Me.tab_items.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_items.Size = New System.Drawing.Size(907, 595)
        Me.tab_items.TabIndex = 0
        Me.tab_items.Text = "Items"
        Me.tab_items.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(901, 589)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Barcode"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Item"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Buyprice"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Buyprice"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Sellprice"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Sellprice"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ADDED DATE"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ADDED DATE"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "EDIT DATE"
        Me.DataGridViewTextBoxColumn16.HeaderText = "EDIT DATE"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.SalesDataSet
        '
        'SalesDataSet
        '
        Me.SalesDataSet.DataSetName = "SalesDataSet"
        Me.SalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tab_report
        '
        Me.tab_report.Controls.Add(Me.btn_repprint)
        Me.tab_report.Controls.Add(Me.btn_repsearch)
        Me.tab_report.Controls.Add(Me.grp_bycode)
        Me.tab_report.Controls.Add(Me.grp_bydate)
        Me.tab_report.Controls.Add(Me.rdb_bycode)
        Me.tab_report.Controls.Add(Me.rdb_bydate)
        Me.tab_report.Controls.Add(Me.DataGridView2)
        Me.tab_report.Location = New System.Drawing.Point(4, 24)
        Me.tab_report.Name = "tab_report"
        Me.tab_report.Size = New System.Drawing.Size(907, 595)
        Me.tab_report.TabIndex = 2
        Me.tab_report.Text = "Report"
        Me.tab_report.UseVisualStyleBackColor = True
        '
        'btn_repprint
        '
        Me.btn_repprint.Enabled = False
        Me.btn_repprint.Location = New System.Drawing.Point(707, 115)
        Me.btn_repprint.Name = "btn_repprint"
        Me.btn_repprint.Size = New System.Drawing.Size(189, 53)
        Me.btn_repprint.TabIndex = 8
        Me.btn_repprint.Text = "PRINT"
        Me.btn_repprint.UseVisualStyleBackColor = True
        '
        'btn_repsearch
        '
        Me.btn_repsearch.Enabled = False
        Me.btn_repsearch.Location = New System.Drawing.Point(707, 55)
        Me.btn_repsearch.Name = "btn_repsearch"
        Me.btn_repsearch.Size = New System.Drawing.Size(189, 53)
        Me.btn_repsearch.TabIndex = 8
        Me.btn_repsearch.Text = "SEARCH"
        Me.btn_repsearch.UseVisualStyleBackColor = True
        '
        'grp_bycode
        '
        Me.grp_bycode.Controls.Add(Me.txt_repbarcode)
        Me.grp_bycode.Controls.Add(Me.Label13)
        Me.grp_bycode.Enabled = False
        Me.grp_bycode.Location = New System.Drawing.Point(356, 40)
        Me.grp_bycode.Name = "grp_bycode"
        Me.grp_bycode.Size = New System.Drawing.Size(344, 144)
        Me.grp_bycode.TabIndex = 7
        Me.grp_bycode.TabStop = False
        Me.grp_bycode.Text = "BY BARCODE"
        '
        'txt_repbarcode
        '
        Me.txt_repbarcode.Location = New System.Drawing.Point(7, 65)
        Me.txt_repbarcode.Name = "txt_repbarcode"
        Me.txt_repbarcode.Size = New System.Drawing.Size(329, 24)
        Me.txt_repbarcode.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Barcode"
        '
        'grp_bydate
        '
        Me.grp_bydate.Controls.Add(Me.txt_toyear)
        Me.grp_bydate.Controls.Add(Me.btn_reptoday)
        Me.grp_bydate.Controls.Add(Me.combx_tomon)
        Me.grp_bydate.Controls.Add(Me.txt_frmyear)
        Me.grp_bydate.Controls.Add(Me.combx_today)
        Me.grp_bydate.Controls.Add(Me.combx_frmmon)
        Me.grp_bydate.Controls.Add(Me.combx_frmday)
        Me.grp_bydate.Controls.Add(Me.Label11)
        Me.grp_bydate.Controls.Add(Me.Label10)
        Me.grp_bydate.Enabled = False
        Me.grp_bydate.Location = New System.Drawing.Point(5, 40)
        Me.grp_bydate.Name = "grp_bydate"
        Me.grp_bydate.Size = New System.Drawing.Size(344, 144)
        Me.grp_bydate.TabIndex = 7
        Me.grp_bydate.TabStop = False
        Me.grp_bydate.Text = "BY DATE"
        '
        'txt_toyear
        '
        Me.txt_toyear.Location = New System.Drawing.Point(238, 66)
        Me.txt_toyear.Name = "txt_toyear"
        Me.txt_toyear.Size = New System.Drawing.Size(83, 24)
        Me.txt_toyear.TabIndex = 5
        '
        'btn_reptoday
        '
        Me.btn_reptoday.Location = New System.Drawing.Point(10, 99)
        Me.btn_reptoday.Name = "btn_reptoday"
        Me.btn_reptoday.Size = New System.Drawing.Size(114, 38)
        Me.btn_reptoday.TabIndex = 8
        Me.btn_reptoday.Text = "TODAY"
        Me.btn_reptoday.UseVisualStyleBackColor = True
        '
        'combx_tomon
        '
        Me.combx_tomon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_tomon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_tomon.FormattingEnabled = True
        Me.combx_tomon.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.combx_tomon.Location = New System.Drawing.Point(132, 66)
        Me.combx_tomon.Name = "combx_tomon"
        Me.combx_tomon.Size = New System.Drawing.Size(100, 23)
        Me.combx_tomon.TabIndex = 4
        '
        'txt_frmyear
        '
        Me.txt_frmyear.Location = New System.Drawing.Point(238, 27)
        Me.txt_frmyear.Name = "txt_frmyear"
        Me.txt_frmyear.Size = New System.Drawing.Size(83, 24)
        Me.txt_frmyear.TabIndex = 2
        '
        'combx_today
        '
        Me.combx_today.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_today.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_today.FormattingEnabled = True
        Me.combx_today.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.combx_today.Location = New System.Drawing.Point(73, 66)
        Me.combx_today.Name = "combx_today"
        Me.combx_today.Size = New System.Drawing.Size(51, 23)
        Me.combx_today.TabIndex = 3
        '
        'combx_frmmon
        '
        Me.combx_frmmon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_frmmon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_frmmon.FormattingEnabled = True
        Me.combx_frmmon.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.combx_frmmon.Location = New System.Drawing.Point(132, 27)
        Me.combx_frmmon.Name = "combx_frmmon"
        Me.combx_frmmon.Size = New System.Drawing.Size(100, 23)
        Me.combx_frmmon.TabIndex = 1
        '
        'combx_frmday
        '
        Me.combx_frmday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.combx_frmday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combx_frmday.FormattingEnabled = True
        Me.combx_frmday.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.combx_frmday.Location = New System.Drawing.Point(73, 27)
        Me.combx_frmday.Name = "combx_frmday"
        Me.combx_frmday.Size = New System.Drawing.Size(51, 23)
        Me.combx_frmday.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "From"
        '
        'rdb_bycode
        '
        Me.rdb_bycode.AutoSize = True
        Me.rdb_bycode.Location = New System.Drawing.Point(356, 9)
        Me.rdb_bycode.Name = "rdb_bycode"
        Me.rdb_bycode.Size = New System.Drawing.Size(82, 21)
        Me.rdb_bycode.TabIndex = 5
        Me.rdb_bycode.TabStop = True
        Me.rdb_bycode.Text = "BARCODE"
        Me.rdb_bycode.UseVisualStyleBackColor = True
        '
        'rdb_bydate
        '
        Me.rdb_bydate.AutoSize = True
        Me.rdb_bydate.Location = New System.Drawing.Point(15, 9)
        Me.rdb_bydate.Name = "rdb_bydate"
        Me.rdb_bydate.Size = New System.Drawing.Size(56, 21)
        Me.rdb_bydate.TabIndex = 5
        Me.rdb_bydate.TabStop = True
        Me.rdb_bydate.Text = "DATE"
        Me.rdb_bydate.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paymentid, Me.barcode1, Me.itemname, Me.soldprice, Me.qty, Me.totalprice1, Me.dateofpayment})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(0, 199)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(907, 396)
        Me.DataGridView2.TabIndex = 1
        '
        'paymentid
        '
        Me.paymentid.HeaderText = "Payment ID"
        Me.paymentid.Name = "paymentid"
        Me.paymentid.ReadOnly = True
        '
        'barcode1
        '
        Me.barcode1.HeaderText = "Bardcode"
        Me.barcode1.Name = "barcode1"
        Me.barcode1.ReadOnly = True
        '
        'itemname
        '
        Me.itemname.HeaderText = "Item"
        Me.itemname.Name = "itemname"
        Me.itemname.ReadOnly = True
        '
        'soldprice
        '
        Me.soldprice.HeaderText = "Sold Price"
        Me.soldprice.Name = "soldprice"
        Me.soldprice.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'totalprice1
        '
        Me.totalprice1.HeaderText = "Total Price"
        Me.totalprice1.Name = "totalprice1"
        Me.totalprice1.ReadOnly = True
        '
        'dateofpayment
        '
        Me.dateofpayment.HeaderText = "Date Of Payment"
        Me.dateofpayment.Name = "dateofpayment"
        Me.dateofpayment.ReadOnly = True
        '
        'tab_balance
        '
        Me.tab_balance.Controls.Add(Me.GroupBox4)
        Me.tab_balance.Controls.Add(Me.Sell)
        Me.tab_balance.Controls.Add(Me.GroupBox2)
        Me.tab_balance.Controls.Add(Me.GroupBox1)
        Me.tab_balance.Controls.Add(Me.DataGridView3)
        Me.tab_balance.Location = New System.Drawing.Point(4, 24)
        Me.tab_balance.Name = "tab_balance"
        Me.tab_balance.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_balance.Size = New System.Drawing.Size(907, 595)
        Me.tab_balance.TabIndex = 3
        Me.tab_balance.Text = "Balance"
        Me.tab_balance.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_baladd)
        Me.GroupBox4.Controls.Add(Me.rdb_baladdalfa)
        Me.GroupBox4.Controls.Add(Me.txt_baladd)
        Me.GroupBox4.Controls.Add(Me.rdb_baladdtouch)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 107)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(383, 93)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Add"
        '
        'btn_baladd
        '
        Me.btn_baladd.Enabled = False
        Me.btn_baladd.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_baladd.Location = New System.Drawing.Point(302, 56)
        Me.btn_baladd.Name = "btn_baladd"
        Me.btn_baladd.Size = New System.Drawing.Size(75, 23)
        Me.btn_baladd.TabIndex = 7
        Me.btn_baladd.Text = "ADD"
        Me.btn_baladd.UseVisualStyleBackColor = True
        '
        'rdb_baladdalfa
        '
        Me.rdb_baladdalfa.AutoSize = True
        Me.rdb_baladdalfa.Location = New System.Drawing.Point(198, 23)
        Me.rdb_baladdalfa.Name = "rdb_baladdalfa"
        Me.rdb_baladdalfa.Size = New System.Drawing.Size(53, 21)
        Me.rdb_baladdalfa.TabIndex = 6
        Me.rdb_baladdalfa.TabStop = True
        Me.rdb_baladdalfa.Text = "ALFA"
        Me.rdb_baladdalfa.UseVisualStyleBackColor = True
        '
        'txt_baladd
        '
        Me.txt_baladd.Enabled = False
        Me.txt_baladd.Location = New System.Drawing.Point(6, 23)
        Me.txt_baladd.Name = "txt_baladd"
        Me.txt_baladd.Size = New System.Drawing.Size(77, 24)
        Me.txt_baladd.TabIndex = 5
        '
        'rdb_baladdtouch
        '
        Me.rdb_baladdtouch.AutoSize = True
        Me.rdb_baladdtouch.Location = New System.Drawing.Point(89, 23)
        Me.rdb_baladdtouch.Name = "rdb_baladdtouch"
        Me.rdb_baladdtouch.Size = New System.Drawing.Size(67, 21)
        Me.rdb_baladdtouch.TabIndex = 6
        Me.rdb_baladdtouch.TabStop = True
        Me.rdb_baladdtouch.Text = "TOUCH"
        Me.rdb_baladdtouch.UseVisualStyleBackColor = True
        '
        'Sell
        '
        Me.Sell.Controls.Add(Me.Label23)
        Me.Sell.Controls.Add(Me.btn_balsell)
        Me.Sell.Controls.Add(Me.rdb_balsellalfa)
        Me.Sell.Controls.Add(Me.rdb_balselltouch)
        Me.Sell.Controls.Add(Me.txt_balprice)
        Me.Sell.Controls.Add(Me.txt_balsell)
        Me.Sell.Location = New System.Drawing.Point(8, 8)
        Me.Sell.Name = "Sell"
        Me.Sell.Size = New System.Drawing.Size(383, 93)
        Me.Sell.TabIndex = 4
        Me.Sell.TabStop = False
        Me.Sell.Text = "Sell"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(172, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 17)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "PRICE"
        '
        'btn_balsell
        '
        Me.btn_balsell.Enabled = False
        Me.btn_balsell.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_balsell.Location = New System.Drawing.Point(302, 56)
        Me.btn_balsell.Name = "btn_balsell"
        Me.btn_balsell.Size = New System.Drawing.Size(75, 23)
        Me.btn_balsell.TabIndex = 7
        Me.btn_balsell.Text = "SELL"
        Me.btn_balsell.UseVisualStyleBackColor = True
        '
        'rdb_balsellalfa
        '
        Me.rdb_balsellalfa.AutoSize = True
        Me.rdb_balsellalfa.Location = New System.Drawing.Point(198, 23)
        Me.rdb_balsellalfa.Name = "rdb_balsellalfa"
        Me.rdb_balsellalfa.Size = New System.Drawing.Size(53, 21)
        Me.rdb_balsellalfa.TabIndex = 6
        Me.rdb_balsellalfa.TabStop = True
        Me.rdb_balsellalfa.Text = "ALFA"
        Me.rdb_balsellalfa.UseVisualStyleBackColor = True
        '
        'rdb_balselltouch
        '
        Me.rdb_balselltouch.AutoSize = True
        Me.rdb_balselltouch.Location = New System.Drawing.Point(89, 23)
        Me.rdb_balselltouch.Name = "rdb_balselltouch"
        Me.rdb_balselltouch.Size = New System.Drawing.Size(67, 21)
        Me.rdb_balselltouch.TabIndex = 6
        Me.rdb_balselltouch.TabStop = True
        Me.rdb_balselltouch.Text = "TOUCH"
        Me.rdb_balselltouch.UseVisualStyleBackColor = True
        '
        'txt_balprice
        '
        Me.txt_balprice.Location = New System.Drawing.Point(219, 55)
        Me.txt_balprice.Name = "txt_balprice"
        Me.txt_balprice.ReadOnly = True
        Me.txt_balprice.Size = New System.Drawing.Size(77, 24)
        Me.txt_balprice.TabIndex = 5
        '
        'txt_balsell
        '
        Me.txt_balsell.Enabled = False
        Me.txt_balsell.Location = New System.Drawing.Point(6, 23)
        Me.txt_balsell.Name = "txt_balsell"
        Me.txt_balsell.Size = New System.Drawing.Size(77, 24)
        Me.txt_balsell.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_balremalfa)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lbl_baldatealfa)
        Me.GroupBox2.Controls.Add(Me.lbl_balalfa)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(397, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 93)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ALFA"
        '
        'lbl_balremalfa
        '
        Me.lbl_balremalfa.AutoSize = True
        Me.lbl_balremalfa.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_balremalfa.ForeColor = System.Drawing.Color.Black
        Me.lbl_balremalfa.Location = New System.Drawing.Point(437, 50)
        Me.lbl_balremalfa.Name = "lbl_balremalfa"
        Me.lbl_balremalfa.Size = New System.Drawing.Size(63, 36)
        Me.lbl_balremalfa.TabIndex = 3
        Me.lbl_balremalfa.Text = "NaN"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(256, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(191, 36)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Remaining: "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(205, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 17)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "USD"
        '
        'lbl_baldatealfa
        '
        Me.lbl_baldatealfa.AutoSize = True
        Me.lbl_baldatealfa.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_baldatealfa.ForeColor = System.Drawing.Color.Red
        Me.lbl_baldatealfa.Location = New System.Drawing.Point(256, 20)
        Me.lbl_baldatealfa.Name = "lbl_baldatealfa"
        Me.lbl_baldatealfa.Size = New System.Drawing.Size(63, 36)
        Me.lbl_baldatealfa.TabIndex = 3
        Me.lbl_baldatealfa.Text = "NaN"
        '
        'lbl_balalfa
        '
        Me.lbl_balalfa.AutoSize = True
        Me.lbl_balalfa.Font = New System.Drawing.Font("Consolas", 42.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_balalfa.ForeColor = System.Drawing.Color.Red
        Me.lbl_balalfa.Location = New System.Drawing.Point(6, 20)
        Me.lbl_balalfa.Name = "lbl_balalfa"
        Me.lbl_balalfa.Size = New System.Drawing.Size(121, 66)
        Me.lbl_balalfa.TabIndex = 3
        Me.lbl_balalfa.Text = "NaN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_balremtouch)
        Me.GroupBox1.Controls.Add(Me.lbl_baldatetouch)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.lbl_baltouch)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(397, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 93)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOUCH"
        '
        'lbl_balremtouch
        '
        Me.lbl_balremtouch.AutoSize = True
        Me.lbl_balremtouch.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_balremtouch.ForeColor = System.Drawing.Color.Black
        Me.lbl_balremtouch.Location = New System.Drawing.Point(437, 50)
        Me.lbl_balremtouch.Name = "lbl_balremtouch"
        Me.lbl_balremtouch.Size = New System.Drawing.Size(63, 36)
        Me.lbl_balremtouch.TabIndex = 3
        Me.lbl_balremtouch.Text = "NaN"
        '
        'lbl_baldatetouch
        '
        Me.lbl_baldatetouch.AutoSize = True
        Me.lbl_baldatetouch.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_baldatetouch.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_baldatetouch.Location = New System.Drawing.Point(256, 20)
        Me.lbl_baldatetouch.Name = "lbl_baldatetouch"
        Me.lbl_baldatetouch.Size = New System.Drawing.Size(63, 36)
        Me.lbl_baldatetouch.TabIndex = 3
        Me.lbl_baldatetouch.Text = "NaN"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(205, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 17)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "USD"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(256, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(191, 36)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Remaining: "
        '
        'lbl_baltouch
        '
        Me.lbl_baltouch.AutoSize = True
        Me.lbl_baltouch.Font = New System.Drawing.Font("Consolas", 42.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_baltouch.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lbl_baltouch.Location = New System.Drawing.Point(6, 20)
        Me.lbl_baltouch.Name = "lbl_baltouch"
        Me.lbl_baltouch.Size = New System.Drawing.Size(121, 66)
        Me.lbl_baltouch.TabIndex = 3
        Me.lbl_baltouch.Text = "NaN"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn23})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView3.Location = New System.Drawing.Point(3, 206)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(901, 386)
        Me.DataGridView3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Payment ID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Bardcode"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "Sold Price"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Date Of Payment"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettignsToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettignsToolStripMenuItem
        '
        Me.SettignsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.ChangeThemeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SettignsToolStripMenuItem.Name = "SettignsToolStripMenuItem"
        Me.SettignsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettignsToolStripMenuItem.Text = "Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ChangeThemeToolStripMenuItem
        '
        Me.ChangeThemeToolStripMenuItem.Name = "ChangeThemeToolStripMenuItem"
        Me.ChangeThemeToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangeThemeToolStripMenuItem.Text = "Change Theme"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemToolStripMenuItem, Me.EditItemToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.EDITToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'EditItemToolStripMenuItem
        '
        Me.EditItemToolStripMenuItem.Name = "EditItemToolStripMenuItem"
        Me.EditItemToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EditItemToolStripMenuItem.Text = "Edit Item"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EDITToolStripMenuItem.Text = "Edit Balance"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOnlineGuidesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ShowOnlineGuidesToolStripMenuItem
        '
        Me.ShowOnlineGuidesToolStripMenuItem.Name = "ShowOnlineGuidesToolStripMenuItem"
        Me.ShowOnlineGuidesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShowOnlineGuidesToolStripMenuItem.Text = "Show Online Guides"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'ReportBindingSource
        '
        Me.ReportBindingSource.DataMember = "Report"
        Me.ReportBindingSource.DataSource = Me.SalesDataSet
        '
        'ReportTableAdapter
        '
        Me.ReportTableAdapter.ClearBeforeFill = True
        '
        'BalanceBindingSource
        '
        Me.BalanceBindingSource.DataMember = "Balance"
        Me.BalanceBindingSource.DataSource = Me.SalesDataSet
        '
        'BalanceTableAdapter
        '
        Me.BalanceTableAdapter.ClearBeforeFill = True
        '
        'RechSellBindingSource
        '
        Me.RechSellBindingSource.DataMember = "RechSell"
        Me.RechSellBindingSource.DataSource = Me.SalesDataSet
        '
        'RechSellTableAdapter
        '
        Me.RechSellTableAdapter.ClearBeforeFill = True
        '
        'CredentialsBindingSource
        '
        Me.CredentialsBindingSource.DataMember = "Credentials"
        Me.CredentialsBindingSource.DataSource = Me.SalesDataSet
        '
        'CredentialsTableAdapter
        '
        Me.CredentialsTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument1
        '
        '
        'MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 647)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MAIN"
        Me.Text = "Whole Sales Application"
        Me.TabControl.ResumeLayout(False)
        Me.tab_sell.ResumeLayout(False)
        Me.tab_sell.PerformLayout()
        Me.grp_sell.ResumeLayout(False)
        Me.grp_sell.PerformLayout()
        Me.tab_items.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_report.ResumeLayout(False)
        Me.tab_report.PerformLayout()
        Me.grp_bycode.ResumeLayout(False)
        Me.grp_bycode.PerformLayout()
        Me.grp_bydate.ResumeLayout(False)
        Me.grp_bydate.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_balance.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Sell.ResumeLayout(False)
        Me.Sell.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RechSellBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CredentialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents tab_items As TabPage
    Friend WithEvents tab_sell As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettignsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BarcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuypriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ADDEDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents EDITDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_sellsearch As Button
    Friend WithEvents txt_sellsearch As TextBox
    Friend WithEvents txt_sellname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_sellprice As TextBox
    Friend WithEvents txt_buyprice As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_sellqtt As TextBox
    Friend WithEvents txt_selleditdate As TextBox
    Friend WithEvents txt_selladdate As TextBox
    Friend WithEvents txt_sellbarcode As TextBox
    Friend WithEvents grp_sell As GroupBox
    Friend WithEvents txt_totalprice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_sellexe As Button
    Friend WithEvents tab_report As TabPage
    Friend WithEvents grp_bydate As GroupBox
    Friend WithEvents txt_toyear As TextBox
    Friend WithEvents combx_tomon As ComboBox
    Friend WithEvents txt_frmyear As TextBox
    Friend WithEvents combx_today As ComboBox
    Friend WithEvents combx_frmmon As ComboBox
    Friend WithEvents combx_frmday As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents rdb_bydate As RadioButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btn_repsearch As Button
    Friend WithEvents grp_bycode As GroupBox
    Friend WithEvents txt_repbarcode As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents rdb_bycode As RadioButton
    Friend WithEvents btn_repprint As Button
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowOnlineGuidesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents paymentid As DataGridViewTextBoxColumn
    Friend WithEvents barcode1 As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents soldprice As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents totalprice1 As DataGridViewTextBoxColumn
    Friend WithEvents dateofpayment As DataGridViewTextBoxColumn
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_reptoday As Button
    Friend WithEvents tab_balance As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_balremalfa As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_baldatealfa As Label
    Friend WithEvents lbl_balalfa As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_balremtouch As Label
    Friend WithEvents lbl_baldatetouch As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_baltouch As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_baladd As Button
    Friend WithEvents rdb_baladdalfa As RadioButton
    Friend WithEvents txt_baladd As TextBox
    Friend WithEvents rdb_baladdtouch As RadioButton
    Friend WithEvents Sell As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_balsell As Button
    Friend WithEvents rdb_balsellalfa As RadioButton
    Friend WithEvents rdb_balselltouch As RadioButton
    Friend WithEvents txt_balprice As TextBox
    Friend WithEvents txt_balsell As TextBox
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesDataSet As SalesDataSet
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As SalesDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents ReportBindingSource As BindingSource
    Friend WithEvents ReportTableAdapter As SalesDataSetTableAdapters.ReportTableAdapter
    Friend WithEvents BalanceBindingSource As BindingSource
    Friend WithEvents BalanceTableAdapter As SalesDataSetTableAdapters.BalanceTableAdapter
    Friend WithEvents RechSellBindingSource As BindingSource
    Friend WithEvents RechSellTableAdapter As SalesDataSetTableAdapters.RechSellTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents CredentialsBindingSource As BindingSource
    Friend WithEvents CredentialsTableAdapter As SalesDataSetTableAdapters.CredentialsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
