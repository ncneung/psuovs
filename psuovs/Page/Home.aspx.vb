Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim classHome As New clsHome
        'If classHome.chkRole(Context.User.Identity.Name) = True Then
        '    For m As Integer = 0 To classHome.GetCheckRole(Context.User.Identity.Name).Length - 1
        '        Response.Write(classHome.GetCheckRole(Context.User.Identity.Name).GetValue(m))

        '    Next



        'Else
        '    Response.Write(classHome.GetCheckRole(Context.User.Identity.Name))

        'End If
        Dim strPSUPassport As String = Context.User.Identity.Name
        Dim classRole As New clsRole
        For x As Integer = 0 To classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows.Count - 1
            Response.Write(classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows(x).Item("ElectionID") & " " & classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows(x).Item("RoleID") & " ")
        Next

    End Sub

End Class