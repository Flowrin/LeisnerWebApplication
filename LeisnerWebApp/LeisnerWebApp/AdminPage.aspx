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
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            text-align: left;
            width: 144px;
            height: 37px;
        }
        .auto-style6 {
            width: 90px;
            height: 37px;
        }
        .auto-style7 {
            height: 37px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color:gray">
    <div style="background-color:gray;">
    
        <table style="width:100%;background-color:#fff;">
            <tr>
                <td>
    
        <asp:ListView style="background-color:#fff;font-family: Papyrus;  border-bottom-color:gray" ID="listViewPerson" runat="server" DataSourceID="SqlDataSourcePersonList" DataKeyNames="Name" >
            <AlternatingItemTemplate>
                <tr style="background-color:#fff;font-family: Papyrus;  border-bottom-color:gray">
                    
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
                <table id="Table2" runat="server" style="font-family: Papyrus">
                    <tr id="Tr1" runat="server">
                        <td id="Td1" runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr id="Tr2" runat="server" style="background-color:#DCDCDC;color: #000000;">
                                    <th  id="Th1" runat="server">Email</th>
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
                        <asp:Label ID="EmailLabel" runat="server" style="font-family: Papyrus" Text='<%# Eval("Email") %>' />
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
        <table style="width:100%;background-color:#fff;font-family: Papyrus;  border-bottom-color:gray"">
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button12" runat="server" OnClick="Button12_Click1" Text="Create new user" style="font-style: italic;font-family: Papyrus; font-weight: 700" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="UpdateUser" runat="server" style="margin-left: 0px;font-style: italic;font-family: Papyrus; font-weight: 700" Text="Update user" OnClick="UpdateUser_Click"  />
                </td>
                <td>
                    <asp:Button ID="DeleteUser" runat="server"  OnClick="DeleteUser_Click1" style="margin-bottom: 1px;font-style: italic;font-family: Papyrus; font-weight: 700" Text="Delete user"  />
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
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Week"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlWeek" runat="server" DataSourceID="SqlDataSourceWeeks" DataTextField="WeekName" DataValueField="WeekName">
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">
                    <asp:SqlDataSource ID="SqlDataSourceWeeks" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [WeekName] FROM [Week]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr style="background-color:#34cbb9">
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="DisplayChart" runat="server" OnClick="DisplayChart_Click" Text="Display Chart" style="font-style: italic;font-family: Papyrus; font-weight: 700" />
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
     <p style="background-color:gray; height: 344px;">
            <table style="width:100%; background-color:white; font-style: italic;font-family: Papyrus; margin-top: 26px;">
                <tr>
                    <td><strong>Day</strong></td>
                    <td style="color:#34cbb9; font-weight: 700;">Monday</td>
                    <td style="color:#34cbb9; font-weight: 700;">Tuesday</td>
                    <td style="color:#34cbb9; font-weight: 700;">Wednesday</td>
                    <td style="color:#34cbb9; font-weight: 700;">Thursd<strong>a</strong>y</td>
                    <td style="color:#34cbb9; font-weight: 700;">Friday</td>
                    <td style="color:#34cbb9; font-weight: 700;">Saturday</td>
                    <td style="color:#34cbb9; font-weight: 700;">Sunday</td>
                </tr>
                <tr>
                    <td><strong>Points</strong></td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblMonday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblTuesday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblWednesday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblThursday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblFriday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblSaturday" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label style="color:#000; font-weight: 700;" ID="lblSunday" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><strong>Hours</strong></td>
                    <td>
                        <asp:Label ID="lblMondayH" runat="server" style="font-weight: 700; color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblTuesdayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblWednesdayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblThurdayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblFridayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSaturdayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblSundayH" runat="server" style="font-weight: 700;color:#34cbb9"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="8" class="auto-style4"></td>
                </tr>
            </table>
               
            </p>
    </form>
</body>
</html>
