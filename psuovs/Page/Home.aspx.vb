Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim classHome As New clsHome
        If classHome.chkRole(Context.User.Identity.Name) = True Then
            Response.Write(classHome.chkRole(Context.User.Identity.Name))
        Else
            Response.Write(classHome.chkRole(Context.User.Identity.Name))

        End If
    End Sub

End Class