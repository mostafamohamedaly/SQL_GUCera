<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courseContent.aspx.cs" Inherits="GUCera.courseContent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            Update course Content
        </header>
        <div>
            <br />
            
            Course ID
            <asp:TextBox ID="couid" runat="server"></asp:TextBox>
            <br />
            <br />
            Updated Content
            <asp:TextBox ID="conten" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="update" runat="server" OnClick="updatecontentt" Text="Update" />
            <br />
            <asp:Button ID="back" runat="server" Text="Back to instructor home" OnClick="back_Click" />
        </div>
    </form>
</body>
</html>
