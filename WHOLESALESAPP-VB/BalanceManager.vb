Imports WHOLESALESAPP_VB.itemsmanager
Imports WHOLESALESAPP_VB.functions
Public Class BalanceManager
    Dim touchbal, alfabal As Double
    Dim touchdate, alfadate As Date

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        Dim touchrow, alfarow As SalesDataSet.BalanceRow
        Dim touchdate, alfadate As Date

        touchrow = MAIN.SalesDataSet.Balance.FindByid("touch")
        alfarow = MAIN.SalesDataSet.Balance.FindByid("alfa")
        touchrow.balancevalue = txt_touchbal.Text
        alfarow.balancevalue = txt_alfabal.Text

        alfadate = combx_alfamon.Text + "/" + combx_alfaday.Text + "/" + txt_alfayear.Text
        touchdate = combx_touchmon.Text + "/" + combx_touchday.Text + "/" + txt_touchyear.Text

        touchrow.datevalue = touchdate
        alfarow.datevalue = alfadate

        refreshall()


    End Sub

    Private Sub BalanceManager_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ballog.Close()
    End Sub

    Private Sub BalanceManager_Load(sender As Object, e As EventArgs) Handles Me.Load

        ballog.ShowDialog()
        If MAIN.stat = 0 Then
            Me.Close()
        End If

        Dim touchrow, alfarow As SalesDataSet.BalanceRow
        touchrow = MAIN.SalesDataSet.Balance.FindByid("touch")
        alfarow = MAIN.SalesDataSet.Balance.FindByid("alfa")
        touchbal = touchrow.balancevalue
        alfabal = alfarow.balancevalue
        txt_touchbal.Text = touchbal
        txt_alfabal.Text = alfabal

        Try
            touchdate = touchrow.datevalue
            alfadate = alfarow.datevalue
            combx_touchday.Text = touchdate.Day
            combx_alfaday.Text = alfadate.Day

            combx_touchmon.Text = MonthName(touchdate.Month)
            combx_alfamon.Text = MonthName(alfadate.Month)

            txt_touchyear.Text = touchdate.Year
            txt_alfayear.Text = alfadate.Year
        Catch

        End Try

    End Sub

End Class