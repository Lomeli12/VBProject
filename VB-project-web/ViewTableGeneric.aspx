<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ViewTableGeneric.aspx.vb" Inherits="VB_project_web.ViewTableGeneric" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableView" runat="server" AutoGenerateColumns="False" DataSourceID="Major">
        </asp:GridView>
        <asp:SqlDataSource ID="Majors" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Major]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Courses" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Course]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Students" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Teachers" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Teacher]"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
