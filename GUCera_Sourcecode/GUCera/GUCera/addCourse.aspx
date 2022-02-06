<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCourse.aspx.cs" Inherits="GUCera.addCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A</title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>Add Course</h1></header>
         <div>   
             
             Creadit Hours
             <asp:TextBox ID="creditHours" runat="server"></asp:TextBox>
             <br />
             Name
             <asp:TextBox ID="Name" runat="server"></asp:TextBox>
             <br />
             Price
             <asp:TextBox ID="price" runat="server"></asp:TextBox>
             
             <br />
             <br />
             <asp:Button ID="Add" runat="server" Text="Add" OnClick="Add_Click" />
             
             <br />
             <asp:Button ID="back" runat="server" Text="Back to instructor home" OnClick="back_Click" />
             
         </div>
    </form>
</body>
</html>
