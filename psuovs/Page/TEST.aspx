﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="TEST.aspx.vb" Inherits="PSUOVS.TEST" %>
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
</asp:Content>
