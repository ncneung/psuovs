<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="ResultElection.aspx.vb" Inherits="PSUOVS.ResultElection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <center >
        </br>
        <asp:Label runat="server" ID="lbElecText" Font-Bold="True" Font-Size="Large"></asp:Label></br></br>
       <div runat="server" id="divResultType1">
           <table  cellpadding="0" cellspacing="0" style="width: 35%">
               <tr>
                   <td><asp:Label ID="Label1" runat="server" Text="Total Student" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbTotalVoter" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label2" runat="server" Text="Total Male" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbTotalMale" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label3" runat="server" Text="Total Female" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbTotalFemale" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label4" runat="server" Text="Faculty of Technology and Environment" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbFacTE" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label5" runat="server" Text="Faculty of International Studies" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbFacInter" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label6" runat="server" Text="Faculty of   Hospitality and Tourism" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbFacFHT" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label7" runat="server" Text="Faculty of Engineering" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbFacCOE" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
               <tr>
                   <td><asp:Label ID="Label8" runat="server" Text="College of Computing" Font-Bold="true"></asp:Label></td>
                   <td><asp:Label ID="lbFacCoc" runat="server" ForeColor="Blue"></asp:Label>&nbsp;people</td>
               </tr>
           </table>          
       </div>
        </br>
        <div runat="server" id="divResultVote"  >

        </div>
    </center>
    
</asp:Content>
