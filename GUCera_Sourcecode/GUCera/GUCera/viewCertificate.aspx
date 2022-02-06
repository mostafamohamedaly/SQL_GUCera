<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewCertificate.aspx.cs" Inherits="GUCera.viewCertificate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 155px;
            left: 34px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 79px;
            left: 7px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="viewww" runat="server" CssClass="auto-style1" OnClick="Vieww_Click" Text="View" />
        Please Enter Your CourseID<asp:TextBox ID="courseeID" runat="server" CssClass="auto-style2"></asp:TextBox>
    </form>
</body>
</html>
