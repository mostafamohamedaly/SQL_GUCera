<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AvailableCourses.aspx.cs" Inherits="GUCera.AvailableCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Available
            Courses<br />
            <br />
            <asp:Button ID="studenthome" runat="server" OnClick="backhome" Text="Back to Student Homepage" Width="332px" />
            <br />
            <br />
            <asp:Button ID="info" runat="server" OnClick="viewInfo" Text="View Course Information/Enroll" Width="332px"  />
            <br />
            <br />
            Available Courses :<br />
        </div>
    </form>
</body>
</html>
