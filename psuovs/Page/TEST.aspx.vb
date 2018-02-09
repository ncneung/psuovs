'Imports PSUOVS.CElectionManagement
Public Class TEST
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim MembershipProvider As PSUPKTProvider.PSUPKTDBProfileProvider
        'MembershipProvider = New PSUPKTProvider.PSUPKTDBProfileProvider()
        'Dim dataLogin As PSUPKTProvider.Model.PSUUserInfo
        'dataLogin = MembershipProvider.GetProfile(User.Identity.Name)

        'Response.Write(dataLogin.CitizenID)

        'Dim sTest As New CElectionManagement
        'Response.Write(sTest.Test)

        Dim classVoter As IRegistedManagement = New clsRegisted
        Dim voterDetail = classVoter.getElectionsForRegisted("5735512073")

        GridView1.DataSource = voterDetail
        GridView1.DataBind()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim classtestna As New testna
        Dim classDetail = classtestna.testGet(TextBox1.Text.ToLower())
        'If IsDBNull(classDetail.FAC_NAME_ENG) Then
        '    lbTest.Text = classDetail.SEX_NAME & classDetail.FAC_NAME_ENG
        'Else
        '    lbTest.Text = "Nothing"
        'End If
        'lbTest.Text = classDetail.SEX_NAME & classDetail.FAC_NAME_ENG
        If IsNothing(classDetail) Then
            lbTest.Text = "NNN"
        Else

            lbTest.Text = classDetail.SEX_NAME & classDetail.FAC_NAME_ENG

        End If
    End Sub
End Class