<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="VB_project_web._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:100%;">
        <div style="float:left; width:20%;">
            <h1>Editable Tables</h1>
            <h3>Courses</h3>
            <asp:Button id="viewCourse" Text="View Table" OnClick="ViewTable_Click" runat="server" />
            <asp:Button id="editCourse" Text="Edit Courses" OnClick="ViewTable_Click" runat="server" />
            <h3>Major</h3>
            <asp:Button id="viewMajor" Text="View Table" OnClick="ViewTable_Click" runat="server" />
            <asp:Button id="editMajor" Text="Edit Majors" OnClick="ViewTable_Click" runat="server" />
        </div>
        <div style="float:right; width:80%;">
            <h1>Viewable Tables</h1>
            <h3>Teacher</h3>
            <asp:Button id="viewTeacher" Text="View Table" OnClick="ViewTable_Click" runat="server" />
            <h3>Student</h3>
            <asp:Button id="viewStudent" Text="View Table" OnClick="ViewTable_Click" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
