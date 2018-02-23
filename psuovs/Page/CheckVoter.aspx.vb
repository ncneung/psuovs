Imports System
Imports System.Web.UI.WebControls
Public Class CheckVoter
    Inherits System.Web.UI.Page
    Dim intElecID As Integer = 1
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CallElecDetail()
        CallCheckVoter()

    End Sub
    Protected Sub CallElecDetail()
        Dim classElection As IElectionManagement = New clsElection
        Dim ElectionDetail = classElection.GetElection(intElecID)

        lbElecName.Text = ElectionDetail.ElectionNameTH & "/" & ElectionDetail.ElectionNameEN

    End Sub
    Protected Sub CallCheckVoter()
        Dim classCheck As IStudentOrganizationManagement = New clsStudentOrganization
        lbTotalVoter.Text = classCheck.countVoter(intElecID).Count
        lbTotalVoted.Text = classCheck.countVoted(intElecID).Count
        Dim classCountRegist As IRegistedManagement = New clsRegisted
        lbTotalRegisted.Text = classCountRegist.countRegist(intElecID).Count
        lbUpdateTime.Text = "Update : " & Date.Now()
    End Sub
End Class