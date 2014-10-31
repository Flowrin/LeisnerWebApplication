<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="LeisnerWebApp.FrontPage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 420px;
            height: 168px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <div>
            <h1>Sign Up</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Child&#39;s Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtChildName" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Email</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style2">Doctor</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDoctor" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style2">Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style2">Child&#39;s Birth Date</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            
        </table>
    
    </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </form>
</body>
</html>
