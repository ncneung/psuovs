Imports System
Imports System.Web.UI.WebControls
Public Class Vote
    Inherits System.Web.UI.Page
    'Dim intElecID As Integer = 1
    Dim intElecID As Integer
    Dim strPSUPassport As String
    'Dim strPSUPassport As String = "5735512073"
    Dim intCountRadioBtnList As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim classRoleVote As IRoleManageMent = New clsRole
        Dim classElection As IElectionManagement = New clsElection
        Dim detailElection = classElection.GetDetailElectionForVote(Session("sPSUPassport"))
        If classRoleVote.RoleVote(Session("sPSUPassport")) = True And Session("sElectionid") <> "" And detailElection.Count <> 0 Then
            divBtnsummit.Visible = True
            CallTableVote()
        Else
            lbError.Text = "You don't have the right to vote."
            divBtnsummit.Visible = False
        End If

    End Sub
    Protected Sub CallTableVote()
        strPSUPassport = Session("sPSUPassport")
        intElecID = Session("sElectionid")
        'ทำชื่อเลือกตั้ง
        'Dim classRegisted As IRegistedManagement = New clsRegisted
        'Dim elecRegisted = classRegisted.getElectionsForRegisted(strPSUPassport)
        'For a As Integer = 0 To elecRegisted.Count - 1
        Dim classElection As IElectionManagement = New clsElection
        Dim ElectionDetail = classElection.GetElectionForVote(intElecID)

        Dim lbNameElection As New Label()
        Dim lbLineBreakElec As New Label()

        'lbNameElection.ID = "lbNameEle"
        lbLineBreakElec.Text = "</br>"
        If IsNothing(ElectionDetail) Then

        Else
            lbNameElection.Font.Bold = True
            lbNameElection.Font.Size = 20
            lbNameElection.Text = ElectionDetail.ElectionNameTH & "/" & ElectionDetail.ElectionNameEN

        End If

        '--------ทำตาราง
        '----------ทำส่วนเรื่องเลือกตั้ง
        Dim tableVoteElec As New Table()
        Dim tableVoterElecRow As New TableRow()
        Dim tableVoteElecCell0 As New TableCell()


        tableVoteElecCell0.Controls.Add(lbNameElection)
        tableVoteElecCell0.Controls.Add(lbLineBreakElec)
        tableVoterElecRow.Cells.Add(tableVoteElecCell0)
        tableVoteElec.Rows.Add(tableVoterElecRow)

        divElection.Controls.Add(tableVoteElec)

        '--------ทำตาราง ส่วนของ Ballots
        Dim classBallots As IBallotsManagement = New clsBallots
        Dim BallotsDetail = classBallots.GetBallotsForVote(strPSUPassport, ElectionDetail.ElectionID)
        intCountRadioBtnList = BallotsDetail.Count
        For b As Integer = 0 To BallotsDetail.Count - 1
            Dim tableVoteBallot As New Table()
            Dim tableVoteBallotRow As New TableRow()
            Dim tableVoteBallotCell0 As New TableCell()

            Dim tableVoteBallotRow_2 As New TableRow()
            Dim tableVoteBallotCell0_2 As New TableCell()
            '-----------ทำส่วนชื่อบัตรการเลือกตั้ง
            tableVoteBallot.Style.Add("width", "40%")
            'tableVoteBallot.ID = "table" & BallotsDetail(b).BallotsID
            tableVoteBallot.ID = "tableballots" & b
            'tableVoteBallot.GridLines = GridLines.Both
            tableVoteBallot.BorderStyle = BorderStyle.Outset
            tableVoteBallot.CellPadding = 10

            tableVoteBallotCell0.ID = BallotsDetail(b).BallotsID
            tableVoteBallotCell0.Text = BallotsDetail(b).BallotsNameTH
            tableVoteBallotCell0.HorizontalAlign = HorizontalAlign.Center
            tableVoteBallotCell0.Font.Bold = True
            tableVoteBallotCell0.ColumnSpan = 4
            tableVoteBallotRow.Cells.Add(tableVoteBallotCell0)
            tableVoteBallot.Rows.Add(tableVoteBallotRow)
            tableVoteBallotRow.BorderStyle = BorderStyle.Outset
            tableVoteBallotRow.Font.Size = 15


            tableVoteBallotCell0_2.Text = BallotsDetail(b).BallotsNameEN
            tableVoteBallotCell0_2.HorizontalAlign = HorizontalAlign.Center
            tableVoteBallotCell0_2.ColumnSpan = 4
            tableVoteBallotCell0_2.Font.Bold = True
            tableVoteBallotRow_2.Cells.Add(tableVoteBallotCell0_2)
            tableVoteBallot.Rows.Add(tableVoteBallotRow_2)
            tableVoteBallotRow_2.BorderStyle = BorderStyle.Outset
            tableVoteBallotRow_2.Font.Size = 15

            Dim classCandidate As ICandidateManagement = New clsCandidate
            Dim candidateDetail = classCandidate.getCandidate(BallotsDetail(b).BallotsID)


            Dim tableVoteBallotRow_3 As New TableRow()
            Dim tableVoteBallotCell0_3 As New TableCell()
            Dim tableVoteBallotCell1_3 As New TableCell()
            Dim tableVoteBallotCell2_3 As New TableCell()
            Dim tableVoteBallotCell3_3 As New TableCell()

            ''----------ทำ Radio List
            Dim radiolistVote As New RadioButtonList()


            For c As Integer = 0 To candidateDetail.Count - 1
                radiolistVote.ID = "radio" & b
                radiolistVote.Items.Add(New ListItem("", candidateDetail(c).CandidateID))
            Next


            tableVoteBallotCell3_3.HorizontalAlign = HorizontalAlign.Center
            tableVoteBallotCell3_3.VerticalAlign = VerticalAlign.Top
            tableVoteBallotCell3_3.Controls.Add(radiolistVote)
            tableVoteBallotRow_3.Cells.Add(tableVoteBallotCell3_3)

            For c As Integer = 0 To candidateDetail.Count - 1

                Dim lbCanNumber As New Label()
                Dim lbCanNumberLineBreak As New Label()
                Dim lbCanNameTh As New Label()
                Dim lbCanNameThLineBreak As New Label()
                Dim lbCanNameEN As New Label()
                Dim lbCanNameENLineBreak As New Label()

                lbCanNumberLineBreak.Text = "</br>"
                lbCanNumberLineBreak.Font.Size = 13

                lbCanNameThLineBreak.Text = "</br>"
                lbCanNameThLineBreak.Font.Size = 13
                lbCanNameTh.Text = candidateDetail(c).NameTH
                lbCanNameENLineBreak.Text = "</br>"
                lbCanNameENLineBreak.Font.Size = 13
                lbCanNameEN.Text = candidateDetail(c).NameEN

                If candidateDetail(c).CandidateNumber = 0 Then
                    lbCanNumber.Text = "</b>"
                    'lbCanNameTh.Font.Bold = True
                    'lbCanNameEN.Font.Bold = True
                Else
                    lbCanNumber.Text = candidateDetail(c).CandidateNumber
                End If

                tableVoteBallotCell0_3.HorizontalAlign = HorizontalAlign.Center
                tableVoteBallotCell0_3.VerticalAlign = VerticalAlign.Top
                tableVoteBallotCell0_3.Controls.Add(lbCanNumber)
                tableVoteBallotCell0_3.Controls.Add(lbCanNumberLineBreak)
                tableVoteBallotRow_3.Cells.Add(tableVoteBallotCell0_3)

                tableVoteBallotCell1_3.HorizontalAlign = HorizontalAlign.Center
                tableVoteBallotCell1_3.VerticalAlign = VerticalAlign.Top
                tableVoteBallotCell1_3.Controls.Add(lbCanNameTh)
                tableVoteBallotCell1_3.Controls.Add(lbCanNameThLineBreak)
                tableVoteBallotRow_3.Cells.Add(tableVoteBallotCell1_3)

                tableVoteBallotCell2_3.HorizontalAlign = HorizontalAlign.Center
                tableVoteBallotCell2_3.VerticalAlign = VerticalAlign.Top
                tableVoteBallotCell2_3.Controls.Add(lbCanNameEN)
                tableVoteBallotCell2_3.Controls.Add(lbCanNameENLineBreak)
                tableVoteBallotRow_3.Cells.Add(tableVoteBallotCell2_3)


            Next

            tableVoteBallot.Rows.Add(tableVoteBallotRow_3)
            'ทำเว้นบรรทัด
            Dim tableLineBreakRow As New TableRow()
            Dim tableLineBreakCell0 As New TableCell()
            Dim lbLineBreak As New Label()
            divElection.Controls.Add(tableVoteBallot)
            'lbLineBreak.ID = "lbLine"
            lbLineBreak.Text = "<br/>"
            divElection.Controls.Add(lbLineBreak)
        Next
        'Next
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Dim r1 As RadioButtonList = divElection.FindControl("radio0")
        Dim classResult As IResultManagement = New clsResult
        'classResult.updateScore(1, 50)
        If checkRadioList() = True Then
            If IsNothing(classResult.checkVoted(strPSUPassport, intElecID)) Then
                'ถ้าไม่มีแสดงว่า ยังไม่เคยโหวต ก็โหวตได้
                'ทำการเช็คว่ามี Score หรือยัง
                For i As Integer = 0 To intCountRadioBtnList - 1
                    Dim r1 As RadioButtonList = divElection.FindControl("radio" & i)
                    Dim t1 As Table = divElection.FindControl("tableballots" & i)
                    Dim ballotsid As Integer = t1.Rows.Item(0).Cells(0).ID
                    'Response.Write(r1.SelectedValue & " " & ballotsid & "</br>")


                    If IsNothing(classResult.selectScore(ballotsid, r1.SelectedValue)) Then
                        'ถ้าไม่มีก็ insert score และ update voted

                        classResult.insertScore(ballotsid, r1.SelectedValue)
                        classResult.updateVoted(strPSUPassport, ballotsid, intElecID)
                    Else
                        'เช็คว่ามี Record หรือยัง ถ้ายังไม่มี ก็ให้ทำการ update score และ update voted
                        classResult.updateScore(ballotsid, r1.SelectedValue)
                        classResult.updateVoted(strPSUPassport, ballotsid, intElecID)
                    End If
                    lbError.Text = ""
                Next
            Else
                'ถ้ามีแสดงว่าเคยโหวตมาก่อน
                lbError.Text = ">>> You have voted. Don't vote again. <<<"
            End If
        Else
            lbError.Text = ">>>...Please do all votes...<<<"
        End If

    End Sub
    Function checkRadioList() As Boolean

        For i As Integer = 0 To intCountRadioBtnList - 1
            Dim r1 As RadioButtonList = divElection.FindControl("radio" & i)
            Dim t1 As Table = divElection.FindControl("tableballots" & i)
            If r1.SelectedValue = "" Then
                Return False
            Else
                If i = intCountRadioBtnList - 1 Then
                    Return True
                End If
            End If

        Next

    End Function
End Class
