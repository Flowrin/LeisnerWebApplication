<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DailyInfo.aspx.cs" Inherits="LeisnerWebApp.DailyInfo" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 139px;
        }
        .auto-style2 {
            width: 139px;
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style4 {
            width: 139px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
            width: 139px;
            height: 59px;
        }
        .auto-style7 {
            height: 59px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%; height: 112px;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    Week</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="WeekName" DataValueField="WeekID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT * FROM [Week]"></asp:SqlDataSource>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    Day</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="DropDownDay" runat="server" DataSourceID="SqlDataSource2" DataTextField="DayName" DataValueField="DayID">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT * FROM [Day]"></asp:SqlDataSource>
                </td>
                <td class="auto-style7">
                    </td>
                <td class="auto-style7">
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Hour</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TxtHour" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3">
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Size</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownSize" runat="server" DataSourceID="SqlDataSource3" DataTextField="Size" DataValueField="PeePeeID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT * FROM [PeePee]"></asp:SqlDataSource>
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnChart" runat="server" OnClick="btnChart_Click" Text="Display Chart" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
