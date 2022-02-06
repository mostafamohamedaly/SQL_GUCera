<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewFeed.aspx.cs" Inherits="GUCera.viewFeed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Feedbacks<br />
            <br />
            course ID<asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="open" runat="server" Text="Open" OnClick="open_Click" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" Text="Back to instructor home" OnClick="back_Click" />
        </div>
    </form>
</body>
</html>
