Imports WHOLESALESAPP_VB.functions

Public Class edititemapge
    Dim barcode, oldbarcode, iname, buyprice, sellprice As String
    Private Sub txt_oldbarcode_TextChanged(sender As Object, e As EventArgs) Handles txt_oldbarcode.TextChanged, txt_name.TextChanged, txt_sell.TextChanged, txt_buy.TextChanged, txt_oldbarcode.TextChanged
        btn_edit.Enabled = True
    End Sub

    Private Sub txt_buy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_buy.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_sell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sell.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Try
            barcode = MAIN.SalesDataSet.Items.FindByBarcode(txt_barcode.Text).Barcode
        Catch
        End Try



        If checkbarcode(txt_barcode.Text) = 1 Then
            oldbarcode = MAIN.SalesDataSet.Items.FindByBarcode(txt_barcode.Text).Barcode
            iname = MAIN.SalesDataSet.Items.FindByBarcode(txt_barcode.Text).Item
            buyprice = MAIN.SalesDataSet.Items.FindByBarcode(txt_barcode.Text).Buyprice
            sellprice = MAIN.SalesDataSet.Items.FindByBarcode(txt_barcode.Text).Sellprice


            lbl_barcode.Enabled = True
            lbl_buy.Enabled = True
            lbl_sell.Enabled = True
            lbl_name.Enabled = True

            txt_oldbarcode.Enabled = True
            txt_oldbarcode.Text = barcode

            txt_buy.Enabled = True
            txt_buy.Text = buyprice

            txt_name.Enabled = True
            txt_name.Text = iname

            txt_sell.Enabled = True
            txt_sell.Text = sellprice

            btn_edit.Enabled = False

        Else

            lbl_barcode.Enabled = False
            lbl_buy.Enabled = False
            lbl_sell.Enabled = False
            lbl_name.Enabled = False

            txt_oldbarcode.Enabled = False
            txt_buy.Enabled = False
            txt_name.Enabled = False
            txt_sell.Enabled = False

            MsgBox("WRONG BARCODE!")
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        itemsmanager.edititem(barcode, txt_name.Text, txt_buy.Text, txt_sell.Text, txt_oldbarcode.Text)
        barcode = txt_oldbarcode.Text
        btn_edit.Enabled = False
    End Sub
End Class