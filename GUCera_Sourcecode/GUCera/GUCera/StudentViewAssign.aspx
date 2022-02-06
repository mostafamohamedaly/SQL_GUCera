<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentViewAssign.aspx.cs" Inherits="GUCera.StudentViewAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Course ID<asp:TextBox ID="viewassi" runat="server"></asp:TextBox>
            <asp:Button ID="showassign" runat="server" OnClick="Show_Click" Text="Show" />

        </div>
    </form>
</body>
</html>
