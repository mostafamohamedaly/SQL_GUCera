<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeAssign.aspx.cs" Inherits="GUCera.gradeAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body><form id="form1" runat="server">
        Grade Assignment<br />
        <br />
        student ID<asp:TextBox ID="stuid" runat="server"></asp:TextBox>
        <br />
        course ID<asp:TextBox ID="couid" runat="server"></asp:TextBox>
        <br />
        Assignment Number<asp:TextBox ID="an" runat="server"></asp:TextBox>
        <br />
        Type<asp:TextBox ID="typ" runat="server"></asp:TextBox>
        <br />
        Grade<asp:TextBox ID="grad" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="change" runat="server" Text="Change" OnClick="change_Click" />
        <br />
        <asp:Button ID="back" runat="server" Text="Back to instructor home" OnClick="back_Click" />
    </form>
</body>
</html>
