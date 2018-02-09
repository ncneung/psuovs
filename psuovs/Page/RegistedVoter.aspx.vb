Public Class RegistedVoter
    Inherits System.Web.UI.Page
    'Dim strPSUPassport As String = Context.User.Identity.Name
    Dim strPSUPassport As String = "5735512073"

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

    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'If classVoter.GetVoter(strPSUPassport).checkVoter = True Then
        '    lbPSUPassport.Text = voterDetail.PSUPassport
        '    lbNameTH.Text = voterDetail.NameTH
        '    lbSNameTH.Text = voterDetail.SNameTH
        '    lbNameEN.Text = voterDetail.NameEN
        '    lbSNameEn.Text = voterDetail.SNameEN
        '    lbFac.Text = voterDetail.FacNameTH
        '    lbGender.Text = voterDetail.Genger
        '    tableVoterDetail.Visible = True
        '    lbError.Text = ""
        'Else
        '    tableVoterDetail.Visible = False
        '    lbError.Text = "No Data"
        'End If
        'If classVoter.GetVoter(tbPassport.Text.ToLower()).checkVoter = True Then
        Dim classVoter As IVoterManagement = New clsVoters
        Dim voterDetail = classVoter.GetVoter(tbPassport.Text.ToLower())

        If IsNothing(voterDetail) Then
            lbError.Text = "NO Data"
        Else

            CallDataTable()
            lbError.Text = ""
        End If

    End Sub
    Protected Sub CallDataTable()
        CallVoterDetail()
        CallRegisted()
    End Sub
    Protected Sub CallVoterDetail()

        Dim classVoter As IVoterManagement = New clsVoters

        Dim voterDetail = classVoter.GetVoter(tbPassport.Text.ToLower())
        Dim tempRowVDetail As New TableRow()
        Dim tempCellRowVDetail0 As New TableCell()
        tempCellRowVDetail0.Text = "<b>PSUPassport : </b>" & voterDetail.PSUPassport & "<b>  Name(TH) : </b>" & voterDetail.STUD_NAME_THAI & "  " & voterDetail.STUD_SNAME_THAI & "<b>  Name(EN) : </b>" & voterDetail.STUD_NAME_ENG & "  " & voterDetail.STUD_SNAME_ENG
        'tempCellRowVDetail0.Text = "<b>PSUPassport : </b>" & voterDetail.PSUPassport
        tempCellRowVDetail0.ColumnSpan = 3
        tempRowVDetail.Cells.Add(tempCellRowVDetail0)
        tableRegistedDetail.Rows.Add(tempRowVDetail)

        Dim tempRowVDetail_2 As New TableRow()
        Dim tempCellRowVDetail0_2 As New TableCell()
        Dim tempCellRowVDetail1_2 As New TableCell()
        Dim tempCellRowVDetail2_2 As New TableCell()
        tempCellRowVDetail0_2.Text = "<b>Gender : </b>" & voterDetail.SEX_NAME & "<b>   Faculty : </b>" & voterDetail.FAC_NAME_THAI
        tempCellRowVDetail0_2.ColumnSpan = 3
        tempRowVDetail_2.Cells.Add(tempCellRowVDetail0_2)
        tableRegistedDetail.Rows.Add(tempRowVDetail_2)

    End Sub


    Protected Sub CallRegisted()



        Dim classRegisted As IRegistedManagement = New clsRegisted
        Dim ElectionDetail = classRegisted.getElectionsForRegisted(tbPassport.Text.ToLower())


        For x As Integer = 0 To ElectionDetail.Count - 1
            'For Each x In ElectionDetail
            Dim tempRowElec As New TableRow()
            Dim tempCellElec0 As New TableCell()
            tempCellElec0.Text = ElectionDetail(x).ElectionNameTH & "  /  " & ElectionDetail(x).ElectionNameEN
            tempCellElec0.ColumnSpan = 3
            tempCellElec0.Font.Bold = True

            tempRowElec.Cells.Add(tempCellElec0)
            tableRegistedDetail.Rows.Add(tempRowElec)

            'Dim classRegisted As IRegistedManagement = New clsRegisted
            Dim intElectionID As Integer = ElectionDetail(x).ElectionID
            Dim BallotDetail = classRegisted.getBallotsForRegisted(intElectionID)

            For m As Integer = 0 To BallotDetail.Count - 1

                Dim tempRowH As New TableRow()
                Dim tempCell0H As New TableCell()
                Dim tempCell1H As New TableCell()
                Dim tempCell2H As New TableCell()
                Dim tempCell3H As New TableCell()
                Dim tempCell4H As New TableCell()
                tempCell0H.Text = BallotDetail(m).BallotsNameTH
                tempCell1H.Text = BallotDetail(m).BallotsNameEN
                tempCell2H.Text = "ช่อง2"
                tempRowH.Cells.Add(tempCell0H)
                tempRowH.Cells.Add(tempCell1H)
                tempRowH.Cells.Add(tempCell2H)
                tableRegistedDetail.Rows.Add(tempRowH)
            Next
        Next






    End Sub
End Class