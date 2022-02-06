<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gradeView.aspx.cs" Inherits="GUCera.gradeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 200px;
            left: 166px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 57px;
            left: 17px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 57px;
            left: 245px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 127px;
            left: 14px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 85px;
            left: 13px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 86px;
            left: 228px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 151px;
            left: 12px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style2" Text="Assignment Number"></asp:Label>
        </div>
        <asp:Button ID="vieww" runat="server" CssClass="auto-style1" OnClick="View_Click" Text="View" />
        <asp:Label ID="Label2" runat="server" CssClass="auto-style3" Text="Assignment Type"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style4" Text="CourseID"></asp:Label>
        <asp:TextBox ID="assignNum" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="assignType" runat="server" CssClass="auto-style6"></asp:TextBox>
        <asp:TextBox ID="coursID" runat="server" CssClass="auto-style7"></asp:TextBox>
    </form>
</body>
</html>
