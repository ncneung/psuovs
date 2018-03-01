Imports System
Imports System.Web.UI.WebControls
Public Class MainCheckVoter
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        Dim classRole As IRoleManageMent = New clsRole
        If (classRole.CheckRole(Session("sPSUPassport"), "it") IsNot Nothing) _
            Or (classRole.CheckRole(Session("sPSUPassport"), "president") IsNot Nothing) _
            Or (classRole.CheckRole(Session("sPSUPassport"), "staff") IsNot Nothing) Then

            Dim classElection As IRoleManageMent = New clsRole
            Dim detailElection = classElection.RoleGetElection(Session("sPSUPassport"))
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

                tempBtn.CommandName = "Click"
                tempBtn.CommandArgument = detailElection(i).ElectionID
                AddHandler tempBtn.Command, AddressOf clickTempbtn

                lineBreak.Text = "</br></br>"

                divElection.Controls.Add(tempBtn)
                divElection.Controls.Add(lineBreak)
            Next
        Else
            lbErr.Text = "คุณไม่มีสิทธิ์ กรุณาติดต่อผู้ดูแลระบบ"
        End If
    End Sub
    Protected Sub clickTempbtn(ByVal sender As Object, ByVal e As CommandEventArgs)
        Select Case e.CommandName
            Case "Click"

                Response.Redirect("~/Page/CheckVoter.aspx")

        End Select
    End Sub

End Class