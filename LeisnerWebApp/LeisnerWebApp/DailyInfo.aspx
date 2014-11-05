<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DailyInfo.aspx.cs" Inherits="LeisnerWebApp.DailyInfo" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 1006px;
            height: 143px;
        }
        .auto-style6 {
            width: 139px;
            height: 47px;
        }
        .auto-style7 {
            height: 47px;
        }
        .auto-style9 {
            width: 1006px;
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color:gray">
    <div style="background-color:gray;">
     <a href="http://leisner.dk/"><img alt="" class="auto-style2" src="Images/logo.png" />  </a>
    </div>
         <h1 style="background-color:#34cbb9; color:white"><span style="margin-left: 280px;font-family: Papyrus"><em>Daily info</em></span></h1>
        <table style="width:88%; height: 471px; background-color:#fff;font-family: Papyrus;  border-bottom-color:gray">
            <tr>
                <td class="auto-style6" style="font-style: italic;font-family: Papyrus; font-weight: 700;">
                    Week</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="dropDownWeek" runat="server" DataSourceID="SqlDataSource1" DataTextField="WeekName" DataValueField="WeekID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT * FROM [Week]"></asp:SqlDataSource>
                </td>
                <td class="auto-style7">
                    </td>
                <td class="auto-style7">
                    </td>
            </tr>
            <tr>
                <td class="auto-style6" style="font-style: italic;font-family: Papyrus; font-weight: 700;">
                    Day</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="dropDownDay" runat="server" DataSourceID="SqlDataSource2" DataTextField="DayName" DataValueField="DayID">
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
                <td class="auto-style9" style="font-style: italic;font-family: Papyrus; font-weight: 700;">
                    Hour</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="dropDownHour" runat="server" DataSourceID="SqlDataSource4" DataTextField="Hour" DataValueField="HourID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [Hour], [HourID] FROM [Time]"></asp:SqlDataSource>
                </td>
                <td class="auto-style7">
                </td>
                <td class="auto-style7">
                    </td>
            </tr>
            <tr>
                <td class="auto-style9"  style="font-style: italic;font-family: Papyrus; font-weight: 700;">
                    Size</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="dropDownSize" runat="server" DataSourceID="SqlDataSource3" DataTextField="Size" DataValueField="PeePeeID">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT * FROM [PeePee]"></asp:SqlDataSource>
                </td>
                <td class="auto-style7">
                    </td>
                <td class="auto-style7">
                    </td>
            </tr>
            <tr>
                <td class="auto-style9" >
                    <asp:Button ID="btnChart" runat="server" OnClick="btnChart_Click" Text="Display Chart"  style="font-style: italic;font-family: Papyrus; font-weight: 700;"/>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit"  style="font-style: italic;font-family: Papyrus; font-weight: 700;" Width="150px" />
                </td>
                <td class="auto-style7">
                    </td>
                <td class="auto-style7">
                    </td>
            </tr>
        </table>
        <p style="background-color:gray; height: 344px;">
            <asp:Chart ID="Stats_Chart" runat="server" DataSourceID="blaaaaaaaa" Visible="False" Width="414px">
                <Series>
                    <asp:Series Name="Series1" XValueMember="DayID" YValueMembers="PeePeeID" YValueType="Int32" XValueType="Int32">
                        <Points>
                <asp:DataPoint AxisLabel="Monday" YValues="" />
                <asp:DataPoint AxisLabel="Tuesday" YValues="" />
                <asp:DataPoint AxisLabel="Wednesday" YValues="" />
                <asp:DataPoint AxisLabel="Thursday" YValues="" />
                <asp:DataPoint AxisLabel="Friday" YValues="" />
                <asp:DataPoint AxisLabel="Saturday" YValues="" />
                <asp:DataPoint AxisLabel="Sunday" YValues="" />
               
            </Points>
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            <asp:SqlDataSource ID="blaaaaaaaa" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [DayID], [PeePeeID] FROM [Common]"></asp:SqlDataSource>
        </p> 
    </form>
</body>
</html>