Imports System.Environment
Imports WHOLESALESAPP_VB.functions
Imports WHOLESALESAPP_VB.itemsmanager

Public Class MAIN
    Public stat As Integer
    Dim barcode As String
    Dim iname As String
    Dim buyprice As String
    Dim sellprice As String
    Dim adddate As Date
    Dim eddate As Date
    Dim totalprice As Double
    Dim i As Integer = 0

    'LOAD DATABASE ON START
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'SalesDataSet.Credentials' table. You can move, or remove it, as needed.
        Me.CredentialsTableAdapter.Fill(Me.SalesDataSet.Credentials)
        'TODO: This line of code loads data into the 'SalesDataSet.RechSell' table. You can move, or remove it, as needed.
        Me.RechSellTableAdapter.Fill(Me.SalesDataSet.RechSell)
        'TODO: This line of code loads data into the 'SalesDataSet.Balance' table. You can move, or remove it, as needed.
        Me.BalanceTableAdapter.Fill(Me.SalesDataSet.Balance)
        'TODO: This line of code loads data into the 'SalesDataSet.Report' table. You can move, or remove it, as needed.
        Me.ReportTableAdapter.Fill(Me.SalesDataSet.Report)
        'TODO: This line of code loads data into the 'SalesDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.SalesDataSet.Items)
        'checkforupdates()
        updateitems()
        updatereport()
        updatelogin()
        login.ShowDialog()
        PrintDocument1.PrinterSettings.PrinterName = "HP Deskjet 1510 series"
        Timer1.Enabled = True

        Dim touchrow, alfarow As SalesDataSet.BalanceRow
        touchrow = SalesDataSet.Balance.FindByid("touch")
        alfarow = SalesDataSet.Balance.FindByid("alfa")

        lbl_balalfa.Text = alfarow.balancevalue
        lbl_baltouch.Text = touchrow.balancevalue

        lbl_baldatealfa.Text = alfarow.datevalue
        lbl_baldatetouch.Text = touchrow.datevalue

        lbl_balremalfa.Text = DateDiff(DateInterval.Day, Today, alfarow.datevalue)
        lbl_balremtouch.Text = DateDiff(DateInterval.Day, Today, touchrow.datevalue)
    End Sub



    'OPEN DIALOG OF ITEM ADDITION
    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        Dim itemadder As New additempage
        itemadder.ShowDialog()
    End Sub

    'OPEN DIALOG FOR ITEM EDITION
    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditItemToolStripMenuItem.Click
        Dim itemeditor As New edititemapge
        itemeditor.ShowDialog()
    End Sub



    'SEARCH FOR ITEMS TO BE SOLD
    Private Sub btn_sellsearch_Click(sender As Object, e As EventArgs) Handles btn_sellsearch.Click
        Try
            grp_sell.Enabled = False
            barcode = SalesDataSet.Items.FindByBarcode(txt_sellsearch.Text).Barcode
        Catch ex As Exception
            MsgBox("WRONG BARCODE")
            Return
        End Try
        grp_sell.Enabled = True
        Name = SalesDataSet.Items.FindByBarcode(barcode).Item
        buyprice = SalesDataSet.Items.FindByBarcode(barcode).Buyprice
        sellprice = SalesDataSet.Items.FindByBarcode(barcode).Sellprice
        adddate = SalesDataSet.Items.FindByBarcode(barcode).ADDED_DATE
        eddate = SalesDataSet.Items.FindByBarcode(barcode).EDIT_DATE

        txt_sellbarcode.Text = barcode
        txt_sellname.Text = Name
        txt_buyprice.Text = buyprice
        txt_sellprice.Text = sellprice
        txt_selladdate.Text = adddate
        txt_selleditdate.Text = eddate
        txt_totalprice.Text = sellprice
    End Sub

    'THE QUANTITY TO SELL
    Private Sub txt_sellqtt_TextChanged(sender As Object, e As EventArgs) Handles txt_sellqtt.TextChanged
        If Not txt_sellqtt.Text = "" Then
            txt_totalprice.Text = sellprice * txt_sellqtt.Text
        Else
            txt_totalprice.Text = sellprice
        End If
    End Sub

    'PREVENT CHARACTERS OTHER THAN NUMBERS
    Private Sub txt_sellqtt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sellqtt.KeyPress, txt_baladd.KeyPress, txt_balsell.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'SEARCH BY DATE
    Private Sub rdb_bydate_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bydate.CheckedChanged
        grp_bydate.Enabled = True
        grp_bycode.Enabled = False
        btn_repsearch.Enabled = True


    End Sub

    'SEARCH BY BARCODE
    Private Sub rdb_bycode_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_bycode.CheckedChanged
        grp_bydate.Enabled = False
        grp_bycode.Enabled = True
        btn_repsearch.Enabled = True
    End Sub

    'EXECUTE THE SELLING PROCCESS
    Private Sub btn_sellexe_Click(sender As Object, e As EventArgs) Handles btn_sellexe.Click
        If MessageBox.Show("Are you sure you want to sell " + txt_sellqtt.Text + " of " + txt_sellname.Text + " for " + txt_totalprice.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                i = SalesDataSet.Report.Last().paymentid
            Catch


            End Try

            Dim therow As SalesDataSet.ReportRow
            therow = Me.SalesDataSet.Report.NewReportRow()
            therow.paymentid = i + 1
            therow.itemname = txt_sellname.Text
            therow.Barcode = txt_sellbarcode.Text
            therow.soldprice = txt_sellprice.Text
            therow.quanitity = txt_sellqtt.Text
            therow.total_price = txt_totalprice.Text
            therow.dateofpayment = Now
            DataGridView2.Rows.Add(New String() {i + 1, txt_sellbarcode.Text, txt_sellname.Text, txt_sellprice.Text, txt_sellqtt.Text, txt_totalprice.Text, Now})
            SalesDataSet.Report.Rows.Add(therow)
            updatereport()
        Else
            Return
        End If
    End Sub

    'REPORT SEARCHING BY CODE OR BY DATE
    Private Sub btn_repsearch_Click(sender As Object, e As EventArgs) Handles btn_repsearch.Click
        Dim c As Integer = 1
        Dim thedate As Date
        Dim thepayid, repqtt As Integer
        Dim repprice, reptotal As Double
        Dim repbarcode, repname As String

        DataGridView2.Rows.Clear()
        If rdb_bydate.Checked Then
            Dim frmdate, todate, writedate As Date

            DataGridView2.ClearSelection()
            Try
                frmdate = combx_frmday.Text + "/" + combx_frmmon.Text + "/" + txt_frmyear.Text
                todate = combx_today.Text + "/" + combx_tomon.Text + "/" + txt_toyear.Text
            Catch
                Try
                    frmdate = combx_frmmon.Text + "/" + combx_frmday.Text + "/" + txt_frmyear.Text
                    todate = combx_tomon.Text + "/" + combx_today.Text + "/" + txt_toyear.Text
                Catch
                    MsgBox("Invalid Date!")
                    Return
                End Try
            End Try
            While c < SalesDataSet.Report.Count + 1
                thedate = SalesDataSet.Report.FindBypaymentid(c).dateofpayment
                'We need writedate as converted thedate so that the comparison ignore the time in thedate which fixes the single day report
                writedate = FormatDateTime(thedate, DateFormat.ShortDate)

                If writedate >= frmdate And writedate <= todate Then

                    thepayid = SalesDataSet.Report.FindBypaymentid(c).paymentid
                    repbarcode = SalesDataSet.Report.FindBypaymentid(c).Barcode
                    repname = SalesDataSet.Report.FindBypaymentid(c).itemname
                    repprice = SalesDataSet.Report.FindBypaymentid(c).soldprice
                    repqtt = SalesDataSet.Report.FindBypaymentid(c).quanitity
                    reptotal = SalesDataSet.Report.FindBypaymentid(c).total_price

                    DataGridView2.Rows.Add(New String() {thepayid, repbarcode, repname, repprice, repqtt, reptotal, thedate})

                End If
                c = c + 1
            End While



        ElseIf rdb_bycode.Checked Then
            Dim thebarcode As String
            'Counts to see if the barcode has records
            Dim d As Integer = 0
            While c < SalesDataSet.Report.Count + 1
                thebarcode = SalesDataSet.Report.FindBypaymentid(c).Barcode

                If thebarcode = txt_repbarcode.Text Then

                    thepayid = SalesDataSet.Report.FindBypaymentid(c).paymentid
                    repbarcode = SalesDataSet.Report.FindBypaymentid(c).Barcode
                    repname = SalesDataSet.Report.FindBypaymentid(c).itemname
                    repprice = SalesDataSet.Report.FindBypaymentid(c).soldprice
                    repqtt = SalesDataSet.Report.FindBypaymentid(c).quanitity
                    reptotal = SalesDataSet.Report.FindBypaymentid(c).total_price

                    DataGridView2.Rows.Add(New String() {thepayid, repbarcode, repname, repprice, repqtt, reptotal, SalesDataSet.Report.FindBypaymentid(c).dateofpayment})
                    d += 1
                End If
                c = c + 1
            End While
            If d = 0 Then
                MsgBox(txt_repbarcode.Text + " has no records!")
            End If
            d = 0

        End If

    End Sub

    'GIVES TODAY REPORT TO USER
    Private Sub btn_reptoday_Click(sender As Object, e As EventArgs) Handles btn_reptoday.Click
        combx_frmday.Text = Today.Day
        combx_today.Text = Today.Day

        combx_frmmon.Text = MonthName(Today.Month)
        combx_tomon.Text = MonthName(Today.Month)

        txt_frmyear.Text = Today.Year
        txt_toyear.Text = Today.Year

        btn_repsearch.PerformClick()
    End Sub

    'REFRESH ITEMS TABLE ON CLICK
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        refreshall()
    End Sub


    'Enable/Disable Balance Button on text change
    Private Sub txt_balsell_TextChanged(sender As Object, e As EventArgs) Handles txt_balsell.TextChanged
        If Not txt_balsell.Text = "" Then
            btn_balsell.Enabled = True
        Else
            txt_balprice.Text = ""
            btn_balsell.Enabled = False
        End If
        Try
            txt_balprice.Text = getbalprice(txt_balsell.Text)
        Catch

        End Try
    End Sub

    'Enable/Disable Balance Button on check change
    Private Sub rdb_balsell_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_balsellalfa.CheckedChanged, rdb_balselltouch.CheckedChanged
        txt_balsell.Enabled = True
    End Sub

    'Execute balance selling on click
    Private Sub btn_balsell_Click(sender As Object, e As EventArgs) Handles btn_balsell.Click
        Dim therow As SalesDataSet.ReportRow
        Dim balrow As SalesDataSet.BalanceRow

        If rdb_balsellalfa.Checked Then
            balrow = SalesDataSet.Balance.FindByid("alfa")
            If MessageBox.Show("Are you sure you want to sell " + txt_sellqtt.Text + " of " + txt_sellname.Text + " for " + txt_totalprice.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    i = SalesDataSet.Report.Last().paymentid
                Catch
                End Try
                therow = Me.SalesDataSet.Report.NewReportRow()
                therow.paymentid = i + 1
                therow.itemname = "alfa " + txt_balsell.Text + "$"
                therow.Barcode = "alfa " + txt_balsell.Text + "$"
                therow.soldprice = txt_balprice.Text
                therow.quanitity = "1"
                therow.total_price = txt_balprice.Text
                therow.dateofpayment = Now
                'Apply changes to the reports datagridview
                DataGridView2.Rows.Add(New String() {therow.paymentid, therow.itemname, therow.Barcode, therow.soldprice, therow.quanitity, therow.total_price, Now})
                'Apply changes to the balance datagridview
                DataGridView3.Rows.Add(New String() {therow.paymentid, therow.itemname, therow.Barcode, therow.soldprice, Now})
                SalesDataSet.Report.Rows.Add(therow)
                updatereport()
            Else
                Exit Sub
            End If
            balrow.balancevalue = balrow.balancevalue - txt_balsell.Text
            lbl_balalfa.Text = balrow.balancevalue
            updaterech()
        ElseIf rdb_balselltouch.Checked Then
            balrow = SalesDataSet.Balance.FindByid("touch")
            If MessageBox.Show("Are you sure you want to sell " + txt_sellqtt.Text + " of " + txt_sellname.Text + " for " + txt_totalprice.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    i = SalesDataSet.Report.Last().paymentid
                Catch
                End Try
                therow = Me.SalesDataSet.Report.NewReportRow()
                therow.paymentid = i + 1
                therow.itemname = "touch " + txt_balsell.Text + "$"
                therow.Barcode = "touch " + txt_balsell.Text + "$"
                therow.soldprice = txt_balprice.Text
                therow.quanitity = "1"
                therow.total_price = txt_balprice.Text
                therow.dateofpayment = Now
                'Apply changes to the reports datagridview
                DataGridView2.Rows.Add(New String() {therow.paymentid, therow.itemname, therow.Barcode, therow.soldprice, therow.quanitity, therow.total_price, Now})
                'Apply changes to the balance datagridview
                DataGridView3.Rows.Add(New String() {therow.paymentid, therow.itemname, therow.Barcode, therow.soldprice, Now})
                SalesDataSet.Report.Rows.Add(therow)
                updatereport()
            Else
                Exit Sub
            End If
            balrow.balancevalue = balrow.balancevalue - txt_balsell.Text
            lbl_baltouch.Text = balrow.balancevalue
            updaterech()
        End If
    End Sub

    Private Sub txt_baladd_TextChanged(sender As Object, e As EventArgs) Handles txt_baladd.TextChanged
        If txt_baladd.Text <> "" Then
            btn_baladd.Enabled = True
        Else
            btn_baladd.Enabled = False
        End If
    End Sub

    'Enable/Disable Balance Button on check change
    Private Sub rdb_baladdtouch_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_baladdtouch.CheckedChanged, rdb_baladdalfa.CheckedChanged
        txt_baladd.Enabled = True
    End Sub

    'Open balance editor
    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        Dim balanceeditor As New BalanceManager
        balanceeditor.ShowDialog()
    End Sub

    'Refresh the program over time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        RefreshToolStripMenuItem.PerformClick()

    End Sub

    'Open password changer
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        changepasswords.ShowDialog()
    End Sub

    'Page Printing and checking
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentChar As Integer
        Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With


        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer


        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If
    End Sub


End Class
