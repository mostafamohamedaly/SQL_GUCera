<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs" Inherits="GUCera.StudentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             First Name: <asp:TextBox ID="fname" runat="server" style="height: 20px; width: 172px"></asp:TextBox>
            <br />
            <br />
            Last Name:&nbsp; <asp:TextBox ID="lname" runat="server" Height="20px" Width="172px"></asp:TextBox>
            &nbsp;<br />
            <br />
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="email" runat="server" Height="20px" Width="172px"></asp:TextBox>
            <br />
            <br />
            Password:&nbsp;&nbsp; <asp:TextBox ID="pass" runat="server" Height="20px" Width="172px"></asp:TextBox>
            <br />
            <br />
            Gender:
            &nbsp;<asp:TextBox ID="gender" runat="server"></asp:TextBox>
            <br />
            <br />
            Address:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="address" runat="server" Height="20px" Width="172px"></asp:TextBox>
             <br />
             <asp:Button ID="stureg" runat="server" Onclick="stuRegister" Text="Register" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
