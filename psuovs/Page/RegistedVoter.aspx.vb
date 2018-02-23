Imports System.Web.UI.WebControls
Public Class RegistedVoterPage
    Inherits System.Web.UI.Page

    '5735512073
    Dim strPSUPassport As String = ""
    Dim intElecID As Integer = 1
    'Dim strUser As String = Context.User.Identity.Name 'รอใช้งาน
    Dim strUser As String = "noppachart.l"





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim ts As IVoterManagement = New clsVoters
        'Dim tsde = ts.GetVoter(tbPassport.Text.ToLower())

        'Dim classtestna As New testna
        'Dim classDetail = classtestna.testGets("5735512073a")
        'If IsNothing(classDetail) Then
        '    lbError.Text = "test"
        'Else

        '    lbError.Text = classDetail.STUD_NAME_THAI

        'End If
        strPSUPassport = tbPassport.Text.ToLower().Trim()
        If Not IsPostBack Then
            tdAllRegisted.Visible = False
        End If
        If strPSUPassport = "" Then

        Else
            CallDataTable()
        End If


    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        strPSUPassport = tbPassport.Text.ToLower()
        'Response.Write(strPSUPassport)
        Dim classVoter As IVoterManagement = New clsVoters
        Dim voterDetail = classVoter.GetVoter(strPSUPassport)

        If IsNothing(voterDetail) Then
            lbError.Text = "NO Data"
            tdAllRegisted.Visible = False
        Else

            'CallDataTable()
            'CallVoterDetail()
            'CallRegisted()
            lbError.Text = ""
            tdAllRegisted.Visible = True

        End If

    End Sub
    Protected Sub CallDataTable()
        CallVoterDetail()
        CallRegisted()
    End Sub
    Protected Sub CallVoterDetail()

        Dim classVoter As IVoterManagement = New clsVoters

        Dim voterDetail = classVoter.GetVoter(strPSUPassport.ToString())

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
        tableVoterDetail.Rows.Add(tempRowVDetailH)

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
        tempCellRowVDetail4.Text = voterDetail.FAC_NAME_THAI

        tempRowVDetail.Cells.Add(tempCellRowVDetail0)
        tempRowVDetail.Cells.Add(tempCellRowVDetail1)
        tempRowVDetail.Cells.Add(tempCellRowVDetail2)
        tempRowVDetail.Cells.Add(tempCellRowVDetail3)
        tempRowVDetail.Cells.Add(tempCellRowVDetail4)
        tableVoterDetail.Rows.Add(tempRowVDetail)




    End Sub


    Protected Sub CallRegisted()

        '-----------------------หัวตาราง
        Dim tempRowRDetailH As New TableRow()
        Dim tempCellRowRDetail0H As New TableCell()
        Dim tempCellRowRDetail1H As New TableCell()
        Dim tempCellRowRDetail2H As New TableCell()
        Dim tempCellRowRDetail3H As New TableCell()

        tempCellRowRDetail0H.Text = "ID"
        tempCellRowRDetail1H.Text = "Ballot(TH)"
        tempCellRowRDetail2H.Text = "Ballot(EN)"
        tempCellRowRDetail3H.Text = "Status"

        tempRowRDetailH.Font.Bold = True

        tempRowRDetailH.Cells.Add(tempCellRowRDetail0H)
        tempRowRDetailH.Cells.Add(tempCellRowRDetail1H)
        tempRowRDetailH.Cells.Add(tempCellRowRDetail2H)
        tempRowRDetailH.Cells.Add(tempCellRowRDetail3H)
        tableRegistedDetail.Rows.Add(tempRowRDetailH)



        '----------------------แถวตาราง


        Dim classRegisted As IRegistedManagement = New clsRegisted


        Dim BallotDetail = classRegisted.getBallotsForRegisted(intElecID)
        Dim classElection As IElectionManagement = New clsElection
        Dim ElectionDetail = classElection.GetElection(intElecID)
        lbHElections.Text = ElectionDetail.ElectionNameEN

        Dim VoterRegisted = classRegisted.getBallotsForVoter(strPSUPassport)
        For m As Integer = 0 To BallotDetail.Count - 1
            Dim tempRowRDetail As New TableRow()
            Dim tempCellRowRDetail0 As New TableCell()
            Dim tempCellRowRDetail1 As New TableCell()
            Dim tempCellRowRDetail2 As New TableCell()
            Dim tempCellRowRDetail3 As New TableCell()
            Dim tempCellRowRDetail4 As New TableCell()

            tempCellRowRDetail0.Text = BallotDetail(m).BallotsID
            tempCellRowRDetail1.Text = BallotDetail(m).BallotsNameTH
            tempCellRowRDetail2.Text = BallotDetail(m).BallotsNameEN

            '------------------------------ทำ CheckBox 
            Dim bBallotID As Boolean = False
            Dim strGet As String = ""
            Dim tempchkbox As New CheckBox()

            Dim templbAutoID As New Label()

            For mv As Integer = 0 To VoterRegisted.Count - 1



                If BallotDetail(m).BallotsID = VoterRegisted(mv).BallotsID Then

                    tempchkbox.ID = "chkbRegisted" & VoterRegisted(mv).AutoID
                    tempchkbox.Checked = True
                    tempchkbox.Text = "Active"
                    tempCellRowRDetail3.Controls.Add(tempchkbox)



                    bBallotID = True

                    Exit For
                Else
                    bBallotID = False
                End If
            Next

            If bBallotID = False Then
                tempchkbox.ID = "chkbRegisted" & BallotDetail(m).BallotsID
                tempchkbox.Checked = False
                tempchkbox.Text = "Not Active"
                tempCellRowRDetail3.Controls.Add(tempchkbox)


            End If
            '----------------------------------- จบการทำ Checkbox



            tempRowRDetail.Cells.Add(tempCellRowRDetail0)
            tempRowRDetail.Cells.Add(tempCellRowRDetail1)
            tempRowRDetail.Cells.Add(tempCellRowRDetail2)
            tempRowRDetail.Cells.Add(tempCellRowRDetail3)
            tableRegistedDetail.Rows.Add(tempRowRDetail)

        Next


#Region "ตารางเก่าเก็บไว้เผื่อใช้"
        'For x As Integer = 0 To ElectionDetail.Count - 1
        '    'For Each x In ElectionDetail
        '    Dim tempRowElec As New TableRow()
        '    Dim tempCellElec0 As New TableCell()
        '    tempCellElec0.Text = ElectionDetail(x).ElectionNameTH & "  /  " & ElectionDetail(x).ElectionNameEN
        '    tempCellElec0.ColumnSpan = 3
        '    tempCellElec0.Font.Bold = True

        '    tempRowElec.Cells.Add(tempCellElec0)
        '    tableRegistedDetail.Rows.Add(tempRowElec)

        '    'Dim classRegisted As IRegistedManagement = New clsRegisted
        '    Dim intElectionID As Integer = ElectionDetail(x).ElectionID
        '    Dim BallotDetail = classRegisted.getBallotsForRegisted(intElectionID)

        '    Dim VoterRegisted = classRegisted.getBallotsForVoter(tbPassport.Text.ToLower())

        '    For m As Integer = 0 To BallotDetail.Count - 1

        '        Dim tempRowH As New TableRow()
        '        Dim tempCell0H As New TableCell()
        '        Dim tempCell1H As New TableCell()
        '        Dim tempCell2H As New TableCell()
        '        Dim tempCell3H As New TableCell()



        '        tempCell0H.Text = BallotDetail(m).BallotsNameTH
        '        tempCell1H.Text = BallotDetail(m).BallotsNameEN

        '        '------------------------------ทำ CheckBox 
        '        Dim bBallotID As Boolean = False
        '        Dim tempchkbox As New CheckBox()
        '        For mv As Integer = 0 To VoterRegisted.Count - 1



        '            If BallotDetail(m).BallotsID = VoterRegisted(mv).BallotsID Then

        '                tempchkbox.ID = "chkbRegisted" & VoterRegisted(mv).AutoID
        '                tempchkbox.Checked = True
        '                tempchkbox.Text = "chkbRegisted" & VoterRegisted(mv).AutoID
        '                tempCell2H.Controls.Add(tempchkbox)

        '                bBallotID = True

        '                Exit For
        '            Else
        '                bBallotID = False
        '            End If
        '        Next

        '        If bBallotID = False Then
        '            tempchkbox.ID = "chkbRegisted" & BallotDetail(m).BallotsID
        '            tempchkbox.Checked = False
        '            tempchkbox.Text = "chkbRegisted" & BallotDetail(m).BallotsID
        '            tempCell2H.Controls.Add(tempchkbox)
        '        End If
        '        '----------------------------------- จบการทำ Checkbox

        '        'Dim tempButton As New Button()
        '        'tempButton.ID = ""


        '        tempRowH.Cells.Add(tempCell0H)
        '        tempRowH.Cells.Add(tempCell1H)
        '        tempRowH.Cells.Add(tempCell2H)
        '        tableRegistedDetail.Rows.Add(tempRowH)
        '    Next
        'Next
#End Region
    End Sub

    Protected Sub btnRegisted_Click(sender As Object, e As EventArgs) Handles btnRegisted.Click
        'CallDataTable()
        Dim classRegist As IRegistedManagement = New clsRegisted
        If tableRegistedDetail.Rows.Count <> 0 Then

            If IsNothing(classRegist.selectRegistedVoter(strPSUPassport, intElecID)) Then

                classRegist.insertRegistedVoter(strPSUPassport, intElecID, True, Date.Now, strUser)
                lbAns2.Text = "Registed Success"

            Else
                lbAns2.Text = "You have already Registered"
            End If



            For x As Integer = 1 To tableRegistedDetail.Rows.Count - 1
                'For x As Integer = 1 To 1
                Dim cchkbox As CheckBox = tableRegistedDetail.Rows.Item(x).Cells(3).Controls(0)
                If IsNothing(classRegist.selectMatchVoterBallots(strPSUPassport, tableRegistedDetail.Rows.Item(x).Cells(0).Text, intElecID)) Then
                    'ไม่มีในฐาน
                    If cchkbox.Checked Then
                        'insert
                        classRegist.insertMatchVoterBallots(strPSUPassport, tableRegistedDetail.Rows.Item(x).Cells(0).Text, intElecID)
                    Else
                        'ไม่ต้องทำไร
                    End If
                Else
                    'มีในฐาน
                    If cchkbox.Checked Then
                        'ไม่ต้องทำไร
                    Else
                        'delete
                        classRegist.deleteMatchVoterBallots(strPSUPassport, tableRegistedDetail.Rows.Item(x).Cells(0).Text, intElecID)
                    End If
                End If



            Next
            tableRegistedDetail.Rows.Clear()
            tableVoterDetail.Rows.Clear()
            CallDataTable()
            lbAns.Text = "Active Success"
        Else
            lbAns.Text = "Active Fail"
        End If


    End Sub


End Class