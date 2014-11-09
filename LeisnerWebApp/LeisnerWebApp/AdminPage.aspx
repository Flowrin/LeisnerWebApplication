<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="LeisnerWebApp.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 90px;
        }
        .auto-style3 {
            text-align: left;
            width: 144px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
    
        <asp:ListView  ID="listViewPerson" runat="server" DataSourceID="SqlDataSourcePersonList" DataKeyNames="Name"  >
            <AlternatingItemTemplate>
                <tr style="background-color:#FFF8DC;">
                    
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ChildsNameLabel" runat="server" Text='<%# Eval("ChildsName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateOfBirthLabel" runat="server" Text='<%# Eval("DateOfBirth") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DoctorLabel" runat="server" Text='<%# Eval("Doctor") %>' />
                    </td>
                     <td>
                        <asp:LinkButton ID="lnkSelect" Text="Select" CommandName="Select" runat="server" />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color:#008A8C;color: #FFFFFF;">
                    
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ChildsNameTextBox" runat="server" Text='<%# Bind("ChildsName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DateOfBirthTextBox" runat="server" Text='<%# Bind("DateOfBirth") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DoctorTextBox" runat="server" Text='<%# Bind("Doctor") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table id="Table1" runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                    </td>
                    <td>
                        <asp:TextBox ID="EmailTextBox" runat="server" Text='<%# Bind("Email") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ChildsNameTextBox" runat="server" Text='<%# Bind("ChildsName") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DateOfBirthTextBox" runat="server" Text='<%# Bind("DateOfBirth") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="DoctorTextBox" runat="server" Text='<%# Bind("Doctor") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color:#DCDCDC;color: #000000;">
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ChildsNameLabel" runat="server" Text='<%# Eval("ChildsName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateOfBirthLabel" runat="server" Text='<%# Eval("DateOfBirth") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DoctorLabel" runat="server" Text='<%# Eval("Doctor") %>' />
                    </td>
                      <td>
                        <asp:LinkButton ID="lnkSelect" Text="Select" CommandName="Select" runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table id="Table2" runat="server">
                    <tr id="Tr1" runat="server">
                        <td id="Td1" runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr id="Tr2" runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th id="Th1" runat="server">Email</th>
                                    <th id="Th2" runat="server">Name</th>
                                    <th id="Th3" runat="server">Address</th>
                                    <th id="Th4" runat="server">ChildsName</th>
                                    <th id="Th5" runat="server">DateOfBirth</th>
                                    <th id="Th6" runat="server">Doctor</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr id="Tr3" runat="server">
                        <td id="Td2" runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;"></td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                    <td>
                        <asp:Label ID="EmailLabel" runat="server" Text='<%# Eval("Email") %>' />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AddressLabel" runat="server" Text='<%# Eval("Address") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ChildsNameLabel" runat="server" Text='<%# Eval("ChildsName") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateOfBirthLabel" runat="server" Text='<%# Eval("DateOfBirth") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DoctorLabel" runat="server" Text='<%# Eval("Doctor") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSourcePersonList" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [Email], [Name], [Address], [ChildsName], [DateOfBirth], [Doctor] FROM [Person] ORDER BY [ChildsName], [Name], [Email]"></asp:SqlDataSource>
    
                </td>
            </tr>
        </table>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click1" Text="Create new user" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="UpdateUser" runat="server" style="margin-left: 0px" Text="Update user" OnClick="UpdateUser_Click" />
                </td>
                <td>
                    <asp:Button ID="DeleteUser" runat="server" style="margin-bottom: 1px" Text="Delete user" OnClick="DeleteUser_Click1" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Label ID="Label1" runat="server" style="text-align: center" Text="View Statistics"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Week"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:DropDownList ID="ddlWeek" runat="server" DataSourceID="SqlDataSourceWeeks" DataTextField="WeekName" DataValueField="WeekName">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:SqlDataSource ID="SqlDataSourceWeeks" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [WeekName] FROM [Week]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="DisplayChart" runat="server" OnClick="DisplayChart_Click" Text="Display Chart" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Chart ID="chartStats" runat="server" Height="326px" Width="655px">
            <Series>
                <asp:Series Name="Series1" ChartType="Line">
                </asp:Series>
            </Series>
           
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Days" TitleAlignment="Center"></AxisX>
                    <AxisY Title="Urine Ammount" TitleAlignment="Center"></AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
      
            <table style="width:100%;">
                <tr>
                    <td>Day</td>
                    <td>Monday</td>
                    <td>Tuesday</td>
                    <td>Wednesday</td>
                    <td>Thursday</td>
                    <td>Friday</td>
                    <td>Saturday</td>
                    <td>Sunday</td>
                </tr>
                <tr>
                    <td>Points</td>
                    <td>
                        <asp:Label ID="lblMonday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTuesday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblWednesday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblThursday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblFriday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSaturday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSunday" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Hours</td>
                    <td>
                        <asp:Label ID="lblMondayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTuesdayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblWednesdayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblThurdayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblFridayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSaturdayH" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSundayH" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="8">Points are calculated with formula (Times your kid peed during the night )*(Size of pee value)<br />
                        Extra small - 1<br />
                        Small - 2<br />
                        Medium - 3<br />
                        Large - 4<br />
                        Extra Large - 5</td>
                </tr>
            </table>
    </form>
</body>
</html>
