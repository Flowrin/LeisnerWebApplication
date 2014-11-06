<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCreateUser.aspx.cs" Inherits="LeisnerWebApp.AdminCreateUser" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 420px;
            height: 168px;
        }
        .auto-style2 {
            font-weight: normal;
            width: 1006px;
            height: 105px;
        }
        .auto-style14 {
            font-weight: normal;
            width: 1006px;
            height: 35px;
        }
        .auto-style15 {
            font-weight: normal;
            height: 35px;
        }
        .auto-style16 {
            height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
            <div style="background-color:gray">
                  <a href="http://leisner.dk/"><img alt="" class="auto-style2" src="Images/logo.png" /> </a>

            <h1 style="background-color:#34cbb9; color:white"><strong style="margin-left: 280px;font-family: Papyrus"><em>Sign Up</em></strong></h1>
        <table class="auto-style1" style="background-color:#fff">
            <tr>
                <td class="auto-style15"style="font-weight: 700; font-style: italic;font-family: Papyrus">Name</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Child&#39;s Name</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtChildName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Password</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Confirm Password</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Email</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Doctor</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtDoctor" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            
            <tr>
                <td class="auto-style14" style="font-weight: 700; font-style: italic;font-family: Papyrus">Address</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            
            <tr>
                <td class="auto-style14"style="font-weight: 700; font-style: italic;font-family: Papyrus">Child&#39;s Birth Date</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style16"></td>
            </tr>
            
            <tr>
                <td class="auto-style14"style="font-weight: 700; font-style: italic;font-family: Papyrus">
                    <asp:Label ID="Label1" runat="server" Text="User Type"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:DropDownList ID="ddlType" runat="server" >
                        <asp:ListItem Value="0">Select a user Type</asp:ListItem>
                        <asp:ListItem Value="1">Admin</asp:ListItem>
                        <asp:ListItem Value="0">User</asp:ListItem>
                        <asp:ListItem Value="1">Employee</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style16">&nbsp;</td>
            </tr>
            
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style15">
        <asp:Button ID="Button1" runat="server" Text="Submit" style="font-weight: 700; font-style: italic;font-family: Papyrus; " Width="111px" OnClick="Button1_Click1"/> 
                </td>
                <td class="auto-style16"></td>
            </tr>
            
        </table>
    
    </div>
    </form>
     <p style="background-color:gray; height: 101px;">
        </p>
</body>
</html>