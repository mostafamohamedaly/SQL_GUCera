﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instructorRegister.aspx.cs" Inherits="GUCera.instructorRegister" %>

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
            <br />
            <asp:Button ID="insRegister" runat="server" Text="Register" OnClick="instRegister" />
        </div>
    </form>
</body>
</html>
