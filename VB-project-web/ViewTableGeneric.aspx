<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ViewTableGeneric.aspx.vb" Inherits="VB_project_web.ViewTableGeneric" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableView" runat="server" AutoGenerateColumns="False">
        </asp:GridView>
        <asp:SqlDataSource ID="Majors" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Major]" DeleteCommand="DELETE FROM Major WHERE MajorID=@MajorID"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Courses" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Course]" DeleteCommand="DELETE FROM Course WHERE CourseID=@CourseID"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Students" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Teachers" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Teacher]"></asp:SqlDataSource>
        <asp:Button ID="addBtn" runat="server" Text="Add Entry" Visible="False" />
    </div>
    </form>
</body>
</html>
