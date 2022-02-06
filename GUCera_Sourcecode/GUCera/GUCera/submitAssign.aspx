<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="submitAssign.aspx.cs" Inherits="GUCera.submitAssign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 353px; top: 59px; position: absolute" Text="Course ID"></asp:Label>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 59px; position: absolute" Text="Please enter the assignment type"></asp:Label>
        <asp:TextBox ID="asstype" runat="server" style="z-index: 1; left: 13px; top: 87px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 8px; top: 118px; position: absolute" Text="Please enter the assignment number"></asp:Label>
        <asp:TextBox ID="assnum" runat="server" style="z-index: 1; left: 15px; top: 143px; position: absolute"></asp:TextBox>
        <asp:Button ID="submit" runat="server" style="z-index: 1; left: 13px; top: 197px; position: absolute" Text="Submit" OnClick="Submit_Click" />
        <asp:TextBox ID="courseID" runat="server" style="z-index: 1; left: 349px; top: 84px; position: absolute; height: 17px"></asp:TextBox>
    </form>
</body>
</html>
