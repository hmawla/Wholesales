Public Class additempage
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
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_barcode.Text = "" Then
            MsgBox("Invalid Barcode!")
            Return
        End If
        itemsmanager.additem(txt_barcode.Text, txt_name.Text, txt_buy.Text, txt_sell.Text)
        txt_barcode.Text = ""
        txt_buy.Text = ""
        txt_sell.Text = ""
        txt_name.Text = ""
    End Sub
End Class