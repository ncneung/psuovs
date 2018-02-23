Imports System
Imports System.Web.UI.WebControls
Public Class ResultElection
    Inherits System.Web.UI.Page
    Dim intElecID As Integer = 1
    'Dim strPSUPassport As String = Context.User.Identity.Name
    Dim strPSUPassport As String = "5735512073"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim classElection As IElectionManagement = New clsElection
        Dim ElectionDetail = classElection.GetElection(intElecID)
        If ElectionDetail.ElectionTypeID = 1 Then
            divResultType1.Visible = True
            CallElecDetail()
            CallResultVoter()
            CallResultVote()

        Else
            divResultType1.Visible = False
            CallElecDetail()
            CallResultVote()
        End If

    End Sub
    Protected Sub CallElecDetail()
        Dim classElection As IElectionManagement = New clsElection
        Dim ElectionDetail = classElection.GetElection(intElecID)

        lbElecText.Text = ElectionDetail.ElectionNameTH & "/" & ElectionDetail.ElectionNameEN

    End Sub
    Protected Sub CallResultVoter()

        Dim classStudent As IStudentOrganizationManagement = New clsStudentOrganization
        Dim StudentDetail = classStudent.countVoter(intElecID)

        lbTotalVoter.Text = StudentDetail.Count
        lbTotalMale.Text = classStudent.countMale(intElecID).Count
        lbTotalFemale.Text = classStudent.countFemale(intElecID).Count
        lbFacTE.Text = classStudent.countFacultyTE(intElecID).Count
        lbFacInter.Text = classStudent.countFacultyInter(intElecID).Count
        lbFacFHT.Text = classStudent.countFacultyFHT(intElecID).Count
        lbFacCOE.Text = classStudent.countFacultyCOE(intElecID).Count
        lbFacCoc.Text = classStudent.countFacultyCOC(intElecID).Count

    End Sub
    Protected Sub CallResultVote()
        Dim classGetBallots As IRegistedManagement = New clsRegisted
        Dim BallotsDetail = classGetBallots.getBallotsForRegisted(intElecID)
        For b As Integer = 0 To BallotsDetail.Count - 1
            '-----------------ทำชื่อบัตรเลือกตั้ง
            Dim lbBallotsName As New Label()
            lbBallotsName.Text = BallotsDetail(b).BallotsNameTH & "/" & BallotsDetail(b).BallotsNameEN
            lbBallotsName.Font.Bold = True
            lbBallotsName.Font.Size = 12
            Dim lbLineBreakBallotsName As New Label()
            lbLineBreakBallotsName.Text = "</br>"
            divResultVote.Controls.Add(lbBallotsName)
            divResultVote.Controls.Add(lbLineBreakBallotsName)


            Dim tableBallots As New Table()
            Dim tableBallotsHRow As New TableRow()
            Dim tableBallotsCellH0 As New TableCell()
            Dim tableBallotsCellH1 As New TableCell()
            Dim tableBallotsCellH2 As New TableCell()
            tableBallots.GridLines = GridLines.Both
            tableBallots.Style.Add("width", "40%")
            tableBallotsCellH0.Text = "Number"
            tableBallotsCellH0.HorizontalAlign = HorizontalAlign.Center
            tableBallotsCellH0.Font.Bold = True
            tableBallotsCellH0.Style.Add("width", "10%")
            tableBallotsCellH1.Text = "Name"
            tableBallotsCellH1.HorizontalAlign = HorizontalAlign.Center
            tableBallotsCellH1.Font.Bold = True
            tableBallotsCellH1.Style.Add("width", "70%")
            tableBallotsCellH2.Text = "Score"
            tableBallotsCellH2.HorizontalAlign = HorizontalAlign.Center
            tableBallotsCellH2.Font.Bold = True
            tableBallotsCellH2.Style.Add("width", "20%")
            tableBallotsHRow.Cells.Add(tableBallotsCellH0)
            tableBallotsHRow.Cells.Add(tableBallotsCellH1)
            tableBallotsHRow.Cells.Add(tableBallotsCellH2)
            tableBallots.Rows.Add(tableBallotsHRow)


            Dim classCandidateDetail As ICandidateManagement = New clsCandidate
            Dim CandidateDetail = classCandidateDetail.getCandidate(BallotsDetail(b).BallotsID)
            For c As Integer = 0 To CandidateDetail.Count - 1

                Dim tableCandidateRow As New TableRow()
                Dim tableCandidateCell0 As New TableCell()
                Dim tableCandidateCell1 As New TableCell()
                Dim tableCandidateCell2 As New TableCell()
                'tableCandidateRow.Width = 100%
                tableCandidateCell0.HorizontalAlign = HorizontalAlign.Center
                tableCandidateCell0.Font.Bold = True
                tableCandidateCell1.Font.Bold = True
                tableCandidateCell2.HorizontalAlign = HorizontalAlign.Center
                tableCandidateCell2.Font.Bold = True
                tableCandidateCell0.Text = CandidateDetail(c).CandidateNumber
                tableCandidateCell1.Text = CandidateDetail(c).NameTH & "/" & CandidateDetail(c).NameEN
                Dim classVoteResult As IResultManagement = New clsResult
                Dim VoteResult = classVoteResult.getResultVote(BallotsDetail(b).BallotsID, CandidateDetail(c).CandidateID)
                If IsNothing(VoteResult) Then
                    tableCandidateCell2.Text = "0"
                Else
                    tableCandidateCell2.Text = VoteResult.Score
                End If
                If CandidateDetail(c).CandidateNumber = 0 Then
                    tableCandidateCell1.ColumnSpan = 2
                    tableCandidateCell1.Font.Bold = True
                Else
                    tableCandidateRow.Cells.Add(tableCandidateCell0)
                End If

                tableCandidateRow.Cells.Add(tableCandidateCell1)
                tableCandidateRow.Cells.Add(tableCandidateCell2)
                tableBallots.Rows.Add(tableCandidateRow)
            Next


            divResultVote.Controls.Add(tableBallots)
            Dim lbLineBreakTable As New Label()
            lbLineBreakTable.Text = "</br>"
            divResultVote.Controls.Add(lbLineBreakTable)


        Next

    End Sub

End Class