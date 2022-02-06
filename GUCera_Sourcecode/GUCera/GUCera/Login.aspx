<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User ID<br />
            <asp:TextBox ID="userID" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="loginButton" runat="server" OnClick="login" Text="Login" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Registerinst" runat="server"  OnClick="studentRegister" Text="Register as Student" Width="231px" />
            <br />
            <asp:Button ID="Registerstu" runat="server"  OnClick="instructorRegister" Text="Register as Instructor" Width="231px" />
        </div>
    </form>
</body>
</html>
