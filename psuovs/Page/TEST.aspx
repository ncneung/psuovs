<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="TEST.aspx.vb" Inherits="PSUOVS.TEST" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" UseSubmitBehavior="False" />
    <br />
    <br />
    <br />
    <asp:Label ID="lbTest" runat="server"></asp:Label>
    <br />
    
   
    <asp:Table ID="tableRegistedDetail" runat="server"  CellPadding="5" GridLines="Both" ViewStateMode="Enabled"  >
      
    </asp:Table>

       
    
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
     <br />
     <br />
     <asp:CheckBox ID="CheckBox1" runat="server" />
     <br />
     <br />
     <br />
     <asp:CheckBoxList ID="CheckBoxList1" runat="server">
     </asp:CheckBoxList>
     <br />
     <asp:RadioButton ID="RadioButton1" runat="server" />
     <br />
     <asp:RadioButtonList ID="RadioButtonList2" runat="server">
     </asp:RadioButtonList>
     <br />
     <br />
     <asp:RadioButtonList ID="RadioButtonList1" runat="server">
     </asp:RadioButtonList>
     <br />
     <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <asp:Label runat="server" ID="lb1" Text = '<%#Eval("BallotsID")%>'> </asp:Label>            <asp:Button ID="Button2" runat="server" Text="Button" />
         </ItemTemplate>
     </asp:Repeater>
    
</asp:Content>