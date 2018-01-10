Public Class Login_Main
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblErrLogin.Text = Session("errLogin")
        Session.Clear()

    End Sub

    Protected Sub LoginButton_Click(sender As Object, e As EventArgs)


    End Sub
End Class