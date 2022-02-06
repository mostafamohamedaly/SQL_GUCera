<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issueCert.aspx.cs" Inherits="GUCera.issueCert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Issue A Certificate<br />
            <br />
            Student ID<asp:TextBox ID="studentid" runat="server"></asp:TextBox>
            <br />
            Course ID<asp:TextBox ID="courseid" runat="server"></asp:TextBox>
            <br />
            Issue Date
            <asp:TextBox ID="date" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="issue" runat="server" Text="Issue" OnClick="issue_Click" />
            <br />
            <asp:Button ID="backw" runat="server" Text="Back to instructor home" OnClick="backw_Click" />
        </div>
    </form>
</body>
</html>
