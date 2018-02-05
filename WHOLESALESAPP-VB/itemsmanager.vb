Public Class itemsmanager
    'UPDATES THE CHANGES MADE INTO DATABASE//////////////////////////////////////
    Public Shared Sub updateitems()
        Dim Itemsadapter As New SalesDataSetTableAdapters.ItemsTableAdapter
        Itemsadapter.Update(MAIN.SalesDataSet.Items)
        MAIN.ItemsTableAdapter.Fill(MAIN.SalesDataSet.Items)
    End Sub
    Public Shared Sub updatereport()
        Dim Reportadapter As New SalesDataSetTableAdapters.ReportTableAdapter
        Reportadapter.Update(MAIN.SalesDataSet.Report)
        MAIN.ReportTableAdapter.Fill(MAIN.SalesDataSet.Report)
    End Sub
    Public Shared Sub updatelogin()
        Dim Loginadapter As New SalesDataSetTableAdapters.CredentialsTableAdapter
        Loginadapter.Update(MAIN.SalesDataSet.Credentials)
    End Sub
    Public Shared Sub updatebalance()
        Dim balanceadapter As New SalesDataSetTableAdapters.BalanceTableAdapter
        balanceadapter.Update(MAIN.SalesDataSet.Balance)
    End Sub
    Public Shared Sub updaterech()
        Dim rechselladapter As New SalesDataSetTableAdapters.RechSellTableAdapter
        rechselladapter.Update(MAIN.SalesDataSet.RechSell)
    End Sub
    '////////////////////////////////////////////////////////////////////////////////


    'THIS WILL ADD THE DESIRED ITEM INTO DATABASE////////////////////////////////////
    Public Shared Sub additem(rbarcode As String, ritem As String, rbuyprice As String, rsellprice As String)

        MAIN.ItemsTableAdapter.Fill(MAIN.SalesDataSet.Items)
        Dim therow As SalesDataSet.ItemsRow
        therow = MAIN.SalesDataSet.Items.NewItemsRow()
        therow.Barcode = rbarcode
        therow.Item = ritem
        therow.Buyprice = rbuyprice
        therow.Sellprice = rsellprice
        therow.ADDED_DATE = Now
        therow.EDIT_DATE = Now
        Try
            MAIN.SalesDataSet.Items.Rows.Add(therow)
        Catch
            MsgBox("BARCODE ALREADY EXIST!")
        End Try
        updateitems()
    End Sub
    '/////////////////////////////////////////////////////////////////////////////////

    'THIS WILL EDIT THE DESIERED ITEM IN THE DATABASE/////////////////////////////////
    Public Shared Sub edititem(rbarcode As String, ritem As String, rbuyprice As String, rsellprice As String, newbarcode As String)
        Dim therow As SalesDataSet.ItemsRow
        therow = MAIN.SalesDataSet.Items.FindByBarcode(rbarcode)
        therow.Barcode = newbarcode
        therow.Item = ritem
        therow.Buyprice = rbuyprice
        therow.Sellprice = rsellprice
        therow.EDIT_DATE = Now
        updateitems()
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////
End Class
