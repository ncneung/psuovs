Public Class Login_Main
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblErrLogin.Text = Session("errLogin")
        Session.Clear()
    End Sub
End Class