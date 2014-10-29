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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%; height: 112px;">
            <tr>
                <td class="auto-style4">Week</td>
                <td class="auto-style5">Day</td>
                <td class="auto-style5">Hour</td>
                <td class="auto-style5">Size</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownWeek" runat="server" DataSourceID="SqlDataSource1" DataTextField="WeekName" DataValueField="WeekName">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [WeekName] FROM [Week]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownDay" runat="server" DataSourceID="SqlDataSource2" DataTextField="DayName" DataValueField="DayName">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [DayName] FROM [Day]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:TextBox ID="TxtHour" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownSize" runat="server" DataSourceID="SqlDataSource3" DataTextField="Size" DataValueField="Size">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [Size] FROM [PeePee]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnChart" runat="server" OnClick="btnChart_Click" Text="Display Chart" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Weekly chart:</td>
                <td class="auto-style3">
                    <asp:Chart ID="Chart1" runat="server" Visible="False" >
                        <series>
                            <asp:Series ChartType="Line" Name="Series1" YValuesPerPoint="2">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                                <AxisX2 IntervalType="Days">
                                </AxisX2>
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                </td>
                <td class="auto-style3">
                </td>
                <td class="auto-style3">
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
