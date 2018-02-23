Imports System.Web.UI.WebControls
Public Class TestAddtable
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'CallTableTest()
        CallTest()

    End Sub
    Protected Sub CallTest()
        Dim tableTest As New Table()
        Dim tableRow As New TableRow()
        Dim tableC0 As New TableCell()
        Dim tableC1 As New TableCell()
        Dim tableC2 As New TableCell()
        tableTest.GridLines = GridLines.Both

        tableC0.Text = "ทดสอบ1"
        tableC1.Text = "ทดสอบ2"

        'Dim tableRow1 As New TableRow()
        'Dim tableRow2 As New TableRow()
        Dim tc1 As New Label()
        Dim tc2 As New Label()
        Dim tc3 As New Label()
        tc1.Text = "ทดสอบข้างใน1"
        tc2.Text = "ทดสอบข้างใน2"
        tc3.Text = "<br/>"
        'tableRow1.Cells.Add(tc1)
        'tableRow2.Cells.Add(tc2)
        tableC2.Controls.Add(tc1)
        tableC2.Controls.Add(tc3)
        tableC2.Controls.Add(tc2)

        tableRow.Cells.Add(tableC0)
        tableRow.Cells.Add(tableC1)
        tableRow.Cells.Add(tableC2)
        tableTest.Rows.Add(tableRow)

        divtest.Controls.Add(tableTest)

    End Sub

    Protected Sub CallTableTest()
        '------------ตารางหลักสร้างแถวไว้รับ
        For x As Integer = 0 To 2


            Dim tableMainRow As New TableRow()
            Dim tableCell As New TableCell()


            Dim classVoter As IVoterManagement = New clsVoters

            Dim voterDetail = classVoter.GetVoter("5735512073")
            Dim table1 As New Table()
            table1.ID = "tableTest" & x
            Dim tempRowVDetailH As New TableRow()
            Dim tempCellRowVDetail0H As New TableCell()
            Dim tempCellRowVDetail1H As New TableCell()
            Dim tempCellRowVDetail2H As New TableCell()
            Dim tempCellRowVDetail3H As New TableCell()
            Dim tempCellRowVDetail4H As New TableCell()

            tempCellRowVDetail0H.Text = "PSUPassport"
            tempCellRowVDetail1H.Text = "Name(TH)"
            tempCellRowVDetail2H.Text = "Name(EN)"
            tempCellRowVDetail3H.Text = "Gender"
            tempCellRowVDetail4H.Text = "Faculty"
            tempRowVDetailH.Font.Bold = True

            tempRowVDetailH.Cells.Add(tempCellRowVDetail0H)
            tempRowVDetailH.Cells.Add(tempCellRowVDetail1H)
            tempRowVDetailH.Cells.Add(tempCellRowVDetail2H)
            tempRowVDetailH.Cells.Add(tempCellRowVDetail3H)
            tempRowVDetailH.Cells.Add(tempCellRowVDetail4H)
            table1.Rows.Add(tempRowVDetailH)

            Dim tempRowVDetail As New TableRow()
            Dim tempCellRowVDetail0 As New TableCell()
            Dim tempCellRowVDetail1 As New TableCell()
            Dim tempCellRowVDetail2 As New TableCell()
            Dim tempCellRowVDetail3 As New TableCell()
            Dim tempCellRowVDetail4 As New TableCell()

            tempCellRowVDetail0.Text = voterDetail.PSUPassport
            tempCellRowVDetail1.Text = voterDetail.STUD_NAME_THAI & "  " & voterDetail.STUD_SNAME_THAI
            tempCellRowVDetail2.Text = voterDetail.STUD_NAME_ENG & "  " & voterDetail.STUD_SNAME_ENG
            tempCellRowVDetail3.Text = voterDetail.SEX_NAME
            'tempCellRowVDetail4.Text = voterDetail.FAC_NAME_THAI

            tempRowVDetail.Cells.Add(tempCellRowVDetail0)
            tempRowVDetail.Cells.Add(tempCellRowVDetail1)
            tempRowVDetail.Cells.Add(tempCellRowVDetail2)
            tempRowVDetail.Cells.Add(tempCellRowVDetail3)
            Dim tempRowVDetail_2 As New TableRow()
            Dim tempCellRowVDetail0_2 As New TableCell()
            Dim tempCellRowVDetail1_2 As New TableCell()
            Dim tempCellRowVDetail2_2 As New TableCell()
            tempCellRowVDetail0_2.Text = "ทดสอบดู1"
            tempCellRowVDetail1_2.Text = "ทดสอบดู2"
            tempCellRowVDetail2_2.Text = "ทดสอบดู3"
            tempRowVDetail_2.Cells.Add(tempCellRowVDetail0_2)
            tempRowVDetail_2.Cells.Add(tempCellRowVDetail1_2)
            tempRowVDetail_2.Cells.Add(tempCellRowVDetail2_2)
            tempCellRowVDetail4.Controls.Add(tempRowVDetail_2)
            tempRowVDetail.Cells.Add(tempCellRowVDetail4)
            'tempRowVDetail.Cells.Add(tempCellRowVDetail4)


            table1.Rows.Add(tempRowVDetail)

            '----------------
            'tableMainRow.Cells.Add(tableCell)
            'tableCell.Controls.Add(table1)

            divtest.Controls.Add(table1)

        Next
    End Sub


End Class