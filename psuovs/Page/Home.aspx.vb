Imports System
Imports System.Web.UI.WebControls
Public Class Home
    Inherits System.Web.UI.Page

    'Dim strPSUPassport As String = Context.User.Identity.Name


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Session("sPSUPassport") = Context.User.Identity.Name
        'Session("sPSUPassport") = "5735512073"
        'Session("sPSUPassport") = "noppachart.l"
        Dim classRoleVote As IRoleManageMent = New clsRole
        If classRoleVote.RoleVote(Session("sPSUPassport")) = True Then
            Dim classElection As IElectionManagement = New clsElection
            Dim detailElection = classElection.GetDetailElectionForVote(Session("sPSUPassport"))
            If detailElection.Count <> 0 Then
                For i As Integer = 0 To detailElection.Count - 1
                    Dim tempBtn As New Button()
                    Dim lineBreak As New Label()
                    tempBtn.ID = "electionID" & detailElection(i).ElectionID
                    tempBtn.Text = detailElection(i).ElectionNameTH & " / " & detailElection(i).ElectionNameEN
                    tempBtn.Style.Add("white-space", "pre-line")
                    tempBtn.Style.Add("width", "400px")
                    tempBtn.Style.Add("text-align", "center")
                    tempBtn.Style.Add("word-wrap", "break-word")
                    tempBtn.ForeColor = Drawing.Color.Blue
                    'tempBtn.PostBackUrl = "~/Page/Vote.aspx"
                    tempBtn.Font.Size = 20
                    tempBtn.Font.Bold = True
                    'If detailElection(i).ElectionStatus.StatusName.ToLower() = "close" Then
                    '    tempBtn.Enabled = False
                    '    tempBtn.Text = "***Close Voted*** " & detailElection(i).ElectionNameTH & " / " & detailElection(i).ElectionNameEN
                    '    tempBtn.ForeColor = Drawing.Color.Red
                    'End If

                    tempBtn.CommandName = "Click"
                    tempBtn.CommandArgument = detailElection(i).ElectionID
                    AddHandler tempBtn.Command, AddressOf clickTempbtn

                    lineBreak.Text = "</br></br>"

                    divElection.Controls.Add(tempBtn)
                    divElection.Controls.Add(lineBreak)
                Next
            Else
                lbErr.Text = "No elections found."
            End If
        Else
            lbErr.Text = "No elections found."
        End If


    End Sub
    Protected Sub clickTempbtn(ByVal sender As Object, ByVal e As CommandEventArgs)
        Select Case e.CommandName
            Case "Click"
                Dim classRegist As IRegistedManagement = New clsRegisted
                Dim classElection As IElectionManagement = New clsElection
                If IsNothing(classRegist.checkRegistTrue(Session("sPSUPassport"), e.CommandArgument)) Then
                    lbErr.Text = "เข้าไม่ได้ เพราะยังไม่ลงทะเบียน"
                Else
                    lbErr.Text = "เข้าได้ลงทะเบียนแล้ว"
                    If classElection.checkElectionStatus(e.CommandArgument).ElectionStatus.StatusName = "Close" Then
                        lbErr.Text = "รอบเลือกตั้งได้ทำการปิดไปแล้ว"
                    ElseIf classElection.checkElectionStatus(e.CommandArgument).ElectionStatus.StatusName = "Pause" Then
                        lbErr.Text = "รอบเลือกตั้งได้ทำหยุด รอการเปิดเลือกตั้งอีกครั้ง"
                    Else
                        Dim classResult As IResultManagement = New clsResult
                        If IsNothing(classResult.checkVoted(Session("sPSUPassport"), e.CommandArgument)) Then
                            Session("sElectionid") = e.CommandArgument
                            lbErr.Text = "เข้าไปโหวตได้"
                            Response.Redirect("~/Page/Vote.aspx")
                        Else
                            lbErr.Text = ">>> You have voted. Don't vote again. <<<"
                        End If

                    End If


                End If
        End Select
    End Sub



End Class