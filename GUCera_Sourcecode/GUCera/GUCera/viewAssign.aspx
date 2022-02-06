<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssign.aspx.cs" Inherits="GUCera.viewAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Course ID
        <asp:TextBox ID="courseid" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="vieww" runat="server" Text="view" OnClick="vieww_Click" />
        <br />
        <br />
        <asp:Button ID="back" runat="server" Text="Back to instructor home" OnClick="back_Click" />
        <br />
        
    </form>
</body>
</html>
