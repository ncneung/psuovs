<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="Vote.aspx.vb" Inherits="PSUOVS.Vote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center>
        </br>
        <asp:Label runat="server" ID="lbError" Text="" ForeColor="Red" Font-Size="X-Large"></asp:Label>
    <div id="divElection" runat="server">


    </div>

        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="&gt;&gt;&gt;&gt;&gt;&gt;"></asp:Label>

        <asp:Button runat="server" ID ="btnSubmit" Text="Submit" Font-Size="X-Large" ForeColor="Blue" />
        <asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="Red" Text="&lt;&lt;&lt;&lt;&lt;&lt;"></asp:Label></br>
        
      </center>
</asp:Content>
