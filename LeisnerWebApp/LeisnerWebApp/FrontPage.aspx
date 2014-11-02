<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontPage.aspx.cs" Inherits="LeisnerWebApp.FrontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 420px;
            height: 168px;
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
        }
        .auto-style11 {
            width: 183px;
            text-align: right;
            height: 30px;
        }
        .auto-style14 {
            height: 19px;
        }
        .auto-style16 {
            height: 30px;
        }
        .auto-style17 {
            height: 30px;
            width: 47px;
        }
        .auto-style18 {
            width: 47px;
            text-align: right;
        }
        .auto-style19 {
            text-align: right;
            height: 23px;
        }
        .auto-style21 {
            height: 23px;
        }
        .auto-style22 {
            text-align: right;
            width: 183px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="height: 153px; width: 705px">   
            < href="http://leisner.dk/"><img alt="" class="auto-style2" src="Images/imagegen.jpg" />
           
        </h1>
    
    </div>
        <h2>Login</h2>
        <table class="auto-style5">
            <tr>
                <td class="auto-style3" colspan="2">
                    Log In</td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style11"></td>
                <td class="auto-style17"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
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
                    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
<asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." ValidationGroup="Login1" ToolTip="Password is required." ID="PasswordRequired" BorderStyle="None" Display="Dynamic">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style22"><asp:CheckBox runat="server" Text="Remember me next time." ID="RememberMe" style="text-align: left" Checked="True"></asp:CheckBox>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="2"><asp:Literal runat="server" ID="FailureText"></asp:Literal>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2"><asp:Button runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" ID="LoginButton" Height="26px" style="text-align: right" Width="59px" OnClick="LoginButton_Click"></asp:Button>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19" colspan="2">&nbsp;</td>
                <td class="auto-style21"></td>
            </tr>
            <tr>
                <td class="auto-style22">Dont have an account ?</td>
                <td class="auto-style18">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
