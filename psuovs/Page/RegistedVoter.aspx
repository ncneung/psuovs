<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="RegistedVoter.aspx.vb" Inherits="PSUOVS.RegistedVoter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="lbText1" runat="server" Text="Registed" Font-Bold="True" Font-Size="Large" ForeColor="Blue"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lbText2" runat="server" Text="PSUPassport 5735512073"></asp:Label>&nbsp;
    <asp:TextBox ID="tbPassport" runat="server" Width="193px"></asp:TextBox>&nbsp;
    <asp:Button ID="btnSearch" runat="server" Text="Search" ></asp:Button>
    &nbsp;&nbsp;
    <asp:Label ID="lbError" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <br />
    
    
    <asp:Table ID="tableRegistedDetail" runat="server"  CellPadding="5" GridLines="Both"></asp:Table>
       
</asp:Content>
