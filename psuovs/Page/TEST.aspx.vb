'Imports PSUOVS.CElectionManagement
Public Class TEST
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim MembershipProvider As PSUPKTProvider.PSUPKTDBProfileProvider
        'MembershipProvider = New PSUPKTProvider.PSUPKTDBProfileProvider()
        'Dim dataLogin As PSUPKTProvider.Model.PSUUserInfo
        'dataLogin = MembershipProvider.GetProfile(User.Identity.Name)

        'Response.Write(dataLogin.CitizenID)

        Dim sTest As New CElectionManagement
        Response.Write(sTest.Test)


    End Sub

End Class