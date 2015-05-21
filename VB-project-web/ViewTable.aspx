<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ViewTable.aspx.vb" Inherits="VB_project_web.ViewTableGeneric" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="tableView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:DetailsView ID="editMajor" runat="server" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="Majors" GridLines="Vertical" Height="50px" Visible="False" Width="125px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        </asp:DetailsView>
        <asp:DetailsView ID="editCourse" runat="server" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="Courses" GridLines="Vertical" Height="50px" Visible="False" Width="125px">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        </asp:DetailsView>
        <asp:SqlDataSource ID="Majors" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Major]" DeleteCommand="DELETE FROM [Major] WHERE [MajorID] = @MajorID" UpdateCommand="UPDATE [Major] SET [Major] = @Major WHERE [MajorID] = @MajorID" InsertCommand="INSERT INTO [Major] ([Major]) VALUES (@Major)">
            <DeleteParameters>
                <asp:Parameter Name="MajorID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Major" Type="String"/>
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Major" Type="String" />
                <asp:Parameter Name="MajorID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="Courses" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Course]" DeleteCommand="DELETE FROM [Course] WHERE [CourseID] = @CourseID" UpdateCommand="UPDATE [Course] SET [CourseName] = @CourseName, [CoursePrereq] = @CoursePrereq, [CourseUnits] = @CourseUnits WHERE [CourseID] = @CourseID" InsertCommand="INSERT INTO [Course] ([CourseName], [CoursePrereq], [CourseUnits]) VALUES (@CourseName, @CoursePrereq, @CourseUnits)">
            <DeleteParameters>
                <asp:Parameter Name="CourseID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="CourseName" Type="String" />
                <asp:Parameter Name="CoursePrereq" Type="Int32" />
                <asp:Parameter Name="CourseUnits" Type="Byte" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="CourseName" Type="String" />
                <asp:Parameter Name="CoursePrereq" Type="Int32" />
                <asp:Parameter Name="CourseUnits" Type="Byte" />
                <asp:Parameter Name="CourseID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="Students" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="Teachers" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT * FROM [Teacher]"></asp:SqlDataSource>
    </div>
    </form>
    <footer>
        <a href="Default.aspx">&lt;-Back</a>
    </footer>
</body>
</html>
