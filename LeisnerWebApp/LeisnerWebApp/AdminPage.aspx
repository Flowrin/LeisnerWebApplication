<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="LeisnerWebApp.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSourcePersonList">
        </asp:ListView>
        <asp:SqlDataSource ID="SqlDataSourcePersonList" runat="server" ConnectionString="<%$ ConnectionStrings:EJL12_DBConnectionString %>" SelectCommand="SELECT [Email], [Name], [Address], [ChildsName], [DateOfBirth], [Doctor] FROM [Person] ORDER BY [ChildsName], [Name], [Email]"></asp:SqlDataSource>
    
    </div>
        <asp:Button ID="btnShowInfo" runat="server" Text="Show " />
    </form>
</body>
</html>
