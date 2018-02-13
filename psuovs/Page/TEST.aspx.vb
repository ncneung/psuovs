Imports System.Web.UI.WebControls
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

        'Dim classVoter As IRegistedManagement = New clsRegisted
        'Dim voterDetail = classVoter.getElectionsForRegisted("5735512073")

        'GridView1.DataSource = voterDetail
        'GridView1.DataBind()
        'If Not IsPostBack Then
        '    tableRegistedDetail = testtable()



        'End If
        'Button1.Attributes.Add("onclick", "return false")


    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim classtestna As New testna
        Dim classDetail = classtestna.testGet("5735512073")
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
    Function testtable() As Table
        Dim classVoter As IVoterManagement = New clsVoters

        Dim voterDetail = classVoter.GetVoter("5735512073")

        Dim tempRowVDetailH As New TableRow()
        Dim tempCellRowVDetail0H As New TableCell()
        Dim tempCellRowVDetail1H As New TableCell()
        Dim tempCellRowVDetail2H As New TableCell()
        Dim tempCellRowVDetail3H As New TableCell()
        Dim tempCellRowVDetail4H As New TableCell()

        tempCellRowVDetail0H.Text = "PSUPassport"
        tempCellRowVDetail1H.Text = "Name(TH)"
        tempCellRowVDetail2H.Text = "Name(EN)"
        tempCellRowVDetail3H.Text = "Gender"
        tempCellRowVDetail4H.Text = "Faculty"
        tempRowVDetailH.Font.Bold = True

        tempRowVDetailH.Cells.Add(tempCellRowVDetail0H)
        tempRowVDetailH.Cells.Add(tempCellRowVDetail1H)
        tempRowVDetailH.Cells.Add(tempCellRowVDetail2H)
        tempRowVDetailH.Cells.Add(tempCellRowVDetail3H)
        tempRowVDetailH.Cells.Add(tempCellRowVDetail4H)
        tableRegistedDetail.Rows.Add(tempRowVDetailH)

        Dim tempRowVDetail As New TableRow()
        Dim tempCellRowVDetail0 As New TableCell()
        Dim tempCellRowVDetail1 As New TableCell()
        Dim tempCellRowVDetail2 As New TableCell()
        Dim tempCellRowVDetail3 As New TableCell()
        Dim tempCellRowVDetail4 As New TableCell()

        tempCellRowVDetail0.Text = voterDetail.PSUPassport
        tempCellRowVDetail1.Text = voterDetail.STUD_NAME_THAI & "  " & voterDetail.STUD_SNAME_THAI
        tempCellRowVDetail2.Text = voterDetail.STUD_NAME_ENG & "  " & voterDetail.STUD_SNAME_ENG
        tempCellRowVDetail3.Text = voterDetail.SEX_NAME
        tempCellRowVDetail4.Text = voterDetail.FAC_NAME_THAI

        tempRowVDetail.Cells.Add(tempCellRowVDetail0)
        tempRowVDetail.Cells.Add(tempCellRowVDetail1)
        tempRowVDetail.Cells.Add(tempCellRowVDetail2)
        tempRowVDetail.Cells.Add(tempCellRowVDetail3)
        tempRowVDetail.Cells.Add(tempCellRowVDetail4)
        tableRegistedDetail.Rows.Add(tempRowVDetail)
        Return tableRegistedDetail
    End Function

    Private Sub tableRegistedDetail_Load(sender As Object, e As EventArgs) Handles tableRegistedDetail.Load
        tableRegistedDetail = testtable()
    End Sub
End Class