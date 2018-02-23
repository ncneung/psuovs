<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="RegistedVoter.aspx.vb" Inherits="PSUOVS.RegistedVoterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br />
    <asp:Label ID="lbText1" runat="server" Text="Registed" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lbText2" runat="server" Text="PSUPassport 5735512073" Font-Bold="True" Font-Size="Medium"></asp:Label>&nbsp;
    <asp:TextBox ID="tbPassport" runat="server" Width="193px"></asp:TextBox>&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Search" ></asp:Button>
    &nbsp;&nbsp;
    <asp:Label ID="lbError" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    
    <br />
    <br />
    <br />
    <td runat="server" id="tdAllRegisted">


    <asp:Label ID="lbHDetail" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Detail"></asp:Label>
    
    
    <asp:Table ID="tableVoterDetail" runat="server"  CellPadding="5" GridLines="Both"></asp:Table>
       
    <br />
    <asp:Label ID="lbHElections" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Elections"></asp:Label>
    
    
    <asp:Table ID="tableRegistedDetail" runat="server"  CellPadding="5" GridLines="Both"></asp:Table>
       
    
    <br />
    <asp:Button ID="btnRegisted" runat="server" Font-Bold="True" Font-Size="Medium" Text="Registed"  />

    &nbsp;
    <asp:Label ID="lbAns" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF"></asp:Label>
    
&nbsp;&nbsp;
    <asp:Label ID="lbAns2" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#0066FF"></asp:Label>
        </td>
    
       
</asp:Content>
