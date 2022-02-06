<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewEnrollCourse.aspx.cs" Inherits="GUCera.ViewEnrollCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 0px">
            <br />
            View Course Information/Enroll<br />
            <br />
            <asp:Button ID="backavc" runat="server" OnClick="Backtocourses" Text="Back to Available Courses" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Course ID:"></asp:Label>
            <asp:TextBox ID="cid" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="view" runat="server" OnClick="viewInfo" Text="View Information" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Instructor ID:"></asp:Label>
            <br />
            <asp:TextBox ID="iid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="en" runat="server" OnClick="enrl"  Text="Enroll" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
