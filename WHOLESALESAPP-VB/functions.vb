Imports System.Environment
Imports System.IO
Public Class functions

    Public Shared TextToPrint As String = ""

    Public Shared Sub PrintHeader()

        TextToPrint = ""

        'send Business Name
        Dim StringToPrint As String = "PC-Helpers"
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        'send address name
        StringToPrint = "1501 Borj El Barajneh"
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        ' send city, state, zip
        StringToPrint = "Beirut, MountLiban, 1501"
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

        ' send phone number
        StringToPrint = "961-01-455424"
        LineLen = StringToPrint.Length
        Dim spcLen4 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4 & StringToPrint & Environment.NewLine

        'send website
        StringToPrint = "pc-helpers.com"
        LineLen = StringToPrint.Length
        Dim spcLen4b As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen4b & StringToPrint & Environment.NewLine

    End Sub

    Public Shared Sub ItemsToBePrinted()
        Dim numofitems As Integer = 3
        Dim i As Integer = 0
        Dim StringsToPrint(numofitems) As String

        While i < numofitems
            StringsToPrint(i) = "    " & (i + 1) & " The Item" & (i + 1) & " " & "999.99" & "  " & "99" & "  " & "999.99"
            i += 1
        End While
        Dim LineLen As String = StringsToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((30 - LineLen)))


        TextToPrint &= "    Description" & Environment.NewLine
        TextToPrint &= "    " & "#" & " Name      " & "U.Price" & " " & "Qty" & " " & "T.Price" & Environment.NewLine
        i = 0
        While i < numofitems
            TextToPrint &= StringsToPrint(i) & Environment.NewLine
            i += 1
        End While

    End Sub

    Public Shared Sub printFooter()
        TextToPrint &= Environment.NewLine & Environment.NewLine
        Dim globalLengt As Integer = 0

        'SubTotal Amount
        Dim StringToPrint As String = "Sub Total   " & FormatCurrency("3.99", , , TriState.True, TriState.True)  'Change here to subtotal
        Dim LineLen As String = StringToPrint.Length
        globalLengt = StringToPrint.Length
        Dim spcLen5 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen5 & StringToPrint & Environment.NewLine

        'Tax Amount
        StringToPrint = "Tax         " & FormatCurrency("0.05", , , TriState.True, TriState.True) 'Change to tax amount
        LineLen = globalLengt
        Dim spcLen6 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Tax         $0.00" Then
            TextToPrint &= spcLen6 & StringToPrint & Environment.NewLine
        End If

        'Total Amount
        StringToPrint = "Total       " & "$4.04"
        LineLen = globalLengt
        Dim spcLen8 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= spcLen8 & StringToPrint & Environment.NewLine & Environment.NewLine

        'Cash Entered Amount
        StringToPrint = "Cash        " & FormatCurrency("5.00", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen9 As New String(" "c, Math.Round((26 - LineLen)))
        If Not StringToPrint = "Cash        $0.00" Then
            TextToPrint &= spcLen9 & StringToPrint & Environment.NewLine
        End If

        'Change Amount
        StringToPrint = "Change      " & FormatCurrency("0.96", , , TriState.True, TriState.True)
        LineLen = globalLengt
        Dim spcLen10 As New String(" "c, Math.Round((26 - LineLen)))
        TextToPrint &= Environment.NewLine & spcLen10 & StringToPrint & Environment.NewLine
    End Sub

    Public Shared Sub start_print()
        PrintHeader()
        ItemsToBePrinted()
        printFooter()
        Dim printControl = New Printing.StandardPrintController
        MAIN.PrintDocument1.PrintController = printControl
        Try
            MAIN.PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'CHECKS IF THE BARCODE EXISTS IN THE DATABASE//////////////////////////////////////////////
    Public Shared Function checkbarcode(barcode As String)
        Try
            barcode = MAIN.SalesDataSet.Items.FindByBarcode(barcode).Barcode
            Return 1
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function getpass(row As String)
        Dim therow As SalesDataSet.CredentialsRow
        therow = MAIN.SalesDataSet.Credentials.FindBytype(row)
        Return therow.pass
    End Function

    Public Shared Sub setpass(row As String, pass As String)
        Dim therow As SalesDataSet.CredentialsRow
        therow = MAIN.SalesDataSet.Credentials.FindBytype(row)
        therow.pass = pass
    End Sub


    Public Shared Function getbalprice(thenum As Integer)
        Dim dol1, dol2, dol3, dol4, dol5, dol6, dol7, dol8, dol9, dol10, rnum As Integer
        rnum = 0
        If MAIN.rdb_balsellalfa.Checked Then
            dol1 = MAIN.SalesDataSet.RechSell.FindBypid(1).alfa
            dol2 = MAIN.SalesDataSet.RechSell.FindBypid(2).alfa
            dol3 = MAIN.SalesDataSet.RechSell.FindBypid(3).alfa
            dol4 = MAIN.SalesDataSet.RechSell.FindBypid(4).alfa
            dol5 = MAIN.SalesDataSet.RechSell.FindBypid(5).alfa
            dol6 = MAIN.SalesDataSet.RechSell.FindBypid(6).alfa
            dol7 = MAIN.SalesDataSet.RechSell.FindBypid(7).alfa
            dol8 = MAIN.SalesDataSet.RechSell.FindBypid(8).alfa
            dol9 = MAIN.SalesDataSet.RechSell.FindBypid(9).alfa
            dol10 = MAIN.SalesDataSet.RechSell.FindBypid(10).alfa

            Select Case thenum
                Case 1
                    Return dol1
                Case 2
                    Return dol2
                Case 3
                    Return dol3
                Case 4
                    Return dol4
                Case 5
                    Return dol5
                Case 6
                    Return dol6
                Case 7
                    Return dol7
                Case 8
                    Return dol8
                Case 9
                    Return dol9
                Case 10
                    Return dol10
                Case Else
                    While thenum > 10
                        rnum = rnum + dol10
                        thenum = thenum - 10
                    End While
                    rnum = rnum + getbalprice(thenum)
                    Return rnum
            End Select

        ElseIf MAIN.rdb_balselltouch.Checked Then
            dol1 = MAIN.SalesDataSet.RechSell.FindBypid(1).touch
            dol2 = MAIN.SalesDataSet.RechSell.FindBypid(2).touch
            dol3 = MAIN.SalesDataSet.RechSell.FindBypid(3).touch
            dol4 = MAIN.SalesDataSet.RechSell.FindBypid(4).touch
            dol5 = MAIN.SalesDataSet.RechSell.FindBypid(5).touch
            dol6 = MAIN.SalesDataSet.RechSell.FindBypid(6).touch
            dol7 = MAIN.SalesDataSet.RechSell.FindBypid(7).touch
            dol8 = MAIN.SalesDataSet.RechSell.FindBypid(8).touch
            dol9 = MAIN.SalesDataSet.RechSell.FindBypid(9).touch
            dol10 = MAIN.SalesDataSet.RechSell.FindBypid(10).touch

            Select Case thenum
                Case 1
                    Return dol1
                Case 2
                    Return dol2
                Case 3
                    Return dol3
                Case 4
                    Return dol4
                Case 5
                    Return dol5
                Case 6
                    Return dol6
                Case 7
                    Return dol7
                Case 8
                    Return dol8
                Case 9
                    Return dol9
                Case 10
                    Return dol10
                Case Else
                    While thenum > 10
                        rnum = rnum + dol10
                        thenum = thenum - 10
                    End While
                    rnum = rnum + getbalprice(thenum)
                    Return rnum
            End Select

        End If
        Return 0
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////

    'Checks If Updates are available///////////////////////////////////////////////////////////
    Public Shared Sub checkforupdates()
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Dim enddate As Date
        If Not System.IO.File.Exists(appData + "\data") Then
            System.IO.File.WriteAllText(appData + "\data", "0")
        End If
        If Not System.IO.File.Exists(appData + "\date") Then
            System.IO.File.WriteAllText(appData + "\date", Today)
        End If
        enddate = File.ReadAllText(appData + "\date")
        If Today > enddate.AddDays(5) Or System.IO.File.ReadAllText(appData + "\data") = "2" Then
            MsgBox("Programs is unstable and needs update, please refer to the owner for more information")
            System.IO.File.WriteAllText(appData + "\data", "2")
            MAIN.Close()
        End If
    End Sub
    '//////////////////////////////////////////////////////////////////////////////////////////

    Public Shared Sub refreshall()
        itemsmanager.updateitems()
        itemsmanager.updatereport()
        itemsmanager.updatelogin()
        itemsmanager.updatebalance()
        itemsmanager.updaterech()
        Dim touchrow, alfarow As SalesDataSet.BalanceRow
        touchrow = MAIN.SalesDataSet.Balance.FindByid("touch")
        alfarow = MAIN.SalesDataSet.Balance.FindByid("alfa")

        MAIN.lbl_balalfa.Text = alfarow.balancevalue
        MAIN.lbl_baltouch.Text = touchrow.balancevalue

        MAIN.lbl_baldatealfa.Text = alfarow.datevalue
        MAIN.lbl_baldatetouch.Text = touchrow.datevalue

        MAIN.lbl_balremalfa.Text = DateDiff(DateInterval.Day, Today, alfarow.datevalue)
        MAIN.lbl_balremtouch.Text = DateDiff(DateInterval.Day, Today, touchrow.datevalue)

    End Sub

End Class
