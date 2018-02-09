Public Class Home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Dim strPSUPassport As String = Context.User.Identity.Name
        Dim classRole As New clsRole



        'Dim role = classRole.GetRole("noppachart.l")
        'Dim roles = classRole.GetRoles("noppachart.l")

        'Response.Write(role.ID)
        'Response.Write(roles.Item(0).PSUPassport & roles.Item(0).ElectionsID & roles.Item(0).RoleID & roles.Item(0).IsActived)
        'ListBox1.DataSource = roles
        'ListBox1.DataTextField = "ID"
        'ListBox1.DataValueField = "ID"
        'ListBox1.DataBind()

        'Dim classHome As New clsHome

        'If classHome.chkRole(Context.User.Identity.Name) = True Then
        '    For m As Integer = 0 To classHome.GetCheckRole(Context.User.Identity.Name).Length - 1
        '        Response.Write(classHome.GetCheckRole(Context.User.Identity.Name).GetValue(m))

        '    Next



        'Else
        '    Response.Write(classHome.GetCheckRole(Context.User.Identity.Name))

        'End If
        '
        'For x As Integer = 0 To classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows.Count - 1
        'Response.Write(classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows(x).Item("ElectionID") & " " & classRole.GetRole(strPSUPassport).Tables("PSUOVS").Rows(x).Item("RoleID") & " ")
        'Next




    End Sub

End Class