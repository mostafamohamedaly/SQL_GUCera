<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eval.aspx.cs" Inherits="GUCera.eval" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="send" runat="server" OnClick="Send_Click" style="z-index: 1; left: 6px; top: 236px; position: absolute" Text="Send" />
        <asp:TextBox ID="comment" runat="server" style="z-index: 1; left: 4px; top: 172px; position: absolute; height: 40px; width: 415px"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 7px; top: 143px; position: absolute; height: 31px; width: 328px" Text="Leave a comment"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 9px; top: 74px; position: absolute" Text="CourseID"></asp:Label>
        <asp:TextBox ID="courID" runat="server" style="z-index: 1; left: 5px; top: 108px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
