<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="CheckVoter.aspx.vb" Inherits="PSUOVS.CheckVoter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        <br />
        <asp:Label runat="server" ID="lbElecName" Font-Bold="True" Font-Size="Large"></asp:Label>
                <br />
        </br>
    <table cellpadding="0" cellspacing="0" style="width: 30%; text-align: center;" >
        <tr>
            <td style="width:50%"><asp:Label runat="server" ID="Label1" Text="Total Voter" Font-Bold="True" Font-Size="Large"></asp:Label></td>
            <td style="width:50%"><asp:Label runat="server" ID="lbTotalVoter" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>&nbsp;people</td>
        </tr>
        <tr>
            <td style="width:50%"><asp:Label runat="server" ID="Label2" Text="Total Registed Voters" Font-Bold="True" Font-Size="Large"></asp:Label></td>
            <td style="width:50%"><asp:Label runat="server" ID="lbTotalRegisted" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>&nbsp;people</td>
        </tr>
        <tr>
            <td style="width:50%"><asp:Label runat="server" ID="Label3" Text="Total Voted" Font-Bold="True" Font-Size="Large"></asp:Label></td>
            <td style="width:50%"><asp:Label runat="server" ID="lbTotalVoted" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>&nbsp;people</td>
        </tr>
    </table>
        </br>
        <asp:Label runat="server" ID="lbUpdateTime" Text=""></asp:Label>
        </center>
</asp:Content>
