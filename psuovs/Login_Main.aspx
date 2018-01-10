<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/SitePSUOVS.Master" CodeBehind="Login_Main.aspx.vb" Inherits="PSUOVS.Login_Main" Debug="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>
        
    </h2>

    <div class="container">
    <div class="row">    
        <%--<div class="col-md-12">--%>
        <%--<div class="col-sm-6 col-sm-offset-3 well offset4">--%>
        </br>
        </br>
        <div class="col-sm-4 col-sm-offset-4 well offset3 form-v-middle">
            <section id="loginForm">
                <div class="form-horizontal" >
                    <center>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/PSUPassport-logo.gif" />
                    <h4 style="color:blue">Use PSUPassport account to log in.</h4>
                    <hr />
                        <%--FailureText="รหัสผ่านไม่ถูกต้อง"--%>
                    <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/Page/TEST.aspx"  >
                        <LayoutTemplate>
                            <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                                <tr>
                                    <td>
                                        <table cellpadding="0">
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username</asp:Label>
                                                    &nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Username" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password</asp:Label>
                                                    &nbsp;&nbsp;
                                                </td>
                                                <td>
                                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control" placeholder="Password"></asp:TextBox>
                                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1" ForeColor="Red">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" colspan="2" style="color: Red;">
                                                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False" ></asp:Literal>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right" colspan="2">
                                                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" CssClass="btn btn-default" OnClick="LoginButton_Click"   />
                                                    
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>                                
                            </table>
                        </LayoutTemplate>
                    </asp:Login>    
                   <asp:Label ID="lblErrLogin" runat="server" ForeColor="Red" Font-Size="Medium"></asp:Label>
                    <%-- -------------------------------------------------------------------------------------------%>
                   <%-- <br />
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" ForeColor="Blue" Text="ระบบใช้งานได้ดีกับ"></asp:Label>
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="31px" ImageUrl="~/Image/GoogleChromePortable_128.png" Width="35px" />
&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Google Chrome"></asp:Label>--%>
                        </center>
                    </div>
            </section>
        </div>
        </div>
    </div>

        <%--<div class="col-md-4">
            </br>
            </br>
            </br>
            </br><asp:Label ID="Label3" runat="server" ForeColor="Red" Font-Size="Medium" Text ="***ข้อมูลจะมีการปรับปรุงทุกวัน ณ.เวลา 8.00 น.***"></asp:Label>
            </br>
                </br><asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Medium" PostBackUrl="~/Page/Usermanual.aspx">***คู่มือการใช้งาน***</asp:LinkButton>
             </br></br><asp:HyperLink ID="HyperLink1" Font-Size="Medium" runat="server" NavigateUrl="~/manual/regulation.pdf">***กำหนดเวลาการจ่ายคืนเงินตามสัญญายืมสำรองจ่าย***</asp:HyperLink>
                 </asp:Label>
            </div>--%>

        <%--        <div class="col-md-4">
            <section id="socialLoginForm">
                <uc:openauthproviders runat="server" id="OpenAuthLogin" />
            </section>
        </div>--%>

</asp:Content>
