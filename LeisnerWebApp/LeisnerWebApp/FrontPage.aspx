<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontPage.aspx.cs" Inherits="LeisnerWebApp.FrontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
    
        .auto-style2 {
            width: 1006px;
            height: 144px;
            background-color:gray;
        }
        .auto-style3 {
            text-align: center;
            height: 19px;
            
        }
        .auto-style5 {
        }
        .auto-style9 {
            text-align: center;
        }
        .auto-style10 {
            text-align: right;
            height: 30px;
        }
        .auto-style14 {
            height: 19px;
        }
        .auto-style16 {
            height: 30px;
        }
        .auto-style18 {
            width: 47px;
            text-align: right;
        }
        .auto-style22 {
            text-align: right;
            width: 183px;
        }
        .auto-style23 {
            text-align: right;
            width: 183px;
            height: 17px;
        }
        .auto-style24 {
            width: 47px;
            text-align: right;
            height: 17px;
        }
        .auto-style25 {
            height: 17px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color:gray">
    <div style="background-color:gray">
    
        
            <a href="http://leisner.dk/"><img alt="" class="auto-style2" src="Images/logo.png" /> </a>
            
       
    
    </div>
        <h1 style="background-color:#34cbb9; color:white"><strong style="margin-left: 280px;font-family: Papyrus"><em>Log in</em></strong></h1>
        <table class="auto-style5"; style="background-color:#fff;font-family: Papyrus; height: 290px; border-bottom-color:gray" >
            <tr>
                <td class="auto-style3" colspan="2" style="font-family: Papyrus; font-size: 18px; text-decoration: underline;">
                   <strong><em>Log In</em></strong> </td>
                <th style =" font-size:14px;" class="auto-style14"></th>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label1" runat="server" Text="Email:" style="font-weight: 700; font-style: italic;font-family: Papyrus"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Email is required." ValidationGroup="Login1" ToolTip="Email is required." ID="EmailRequired" BorderStyle="None" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label2" runat="server" Text="Password:" style="font-weight: 700; font-style: italic;font-family: Papyrus"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." ValidationGroup="Login1" ToolTip="Password is required." ID="PasswordRequired" BorderStyle="None" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22"><asp:CheckBox runat="server" Text="Remember me next time." ID="RememberMe" style="text-align: left; font-style: italic;font-family: Papyrus" Checked="True" ></asp:CheckBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2"><asp:Button runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" ID="LoginButton" Height="34px" style="text-align: right; font-weight: 700; font-style: italic;font-family: Papyrus; margin-left: 165px;" Width="151px" OnClick="LoginButton_Click"></asp:Button>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">&nbsp;</td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style23"><span style="font-style: italic; font-family: Papyrus;">Don&#39;t have an account ?</span></td>
                <td class="auto-style24">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" style="font-weight: 700; font-style: italic;font-family: Papyrus; margin-left: 46px;" />
                </td>
                <td class="auto-style25"></td>            
            </tr>
        </table>
    </form>
   
    <p style="background-color:gray; height: 102px;">
        </p>
    
   
</body>
</html>