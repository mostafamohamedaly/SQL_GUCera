<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="direction: ltr">
            &nbsp; 
            <br />
            STUDENT HOMEPAGE<br />
            <br />
            <asp:Button ID="viewProf" runat="server" OnClick="viewProfile" Text="View profile details" Height="37px" Width="253px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="viewAssin" runat="server" OnClick="ViewAssi" Text="View Assignment Content" Height="37px" Width="198px" />
            &nbsp;<asp:Button ID="feedback" runat="server" OnClick="Feedback_Click" Text="Add Feedback" Height="37px" Width="176px"/>
            <br />
            <br />
            <asp:Button ID="viewcourses" runat="server" OnClick="viewAvailableCourses" Text="View available courses " Height="37px" Width="253px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="submit" runat="server" OnClick="Submit_Click" Text="Submit Assignment" Height="37px" Width="198px"/>
            &nbsp;<asp:Button ID="certif" runat="server" OnClick="Certificate_Click" Text="View Certificates" Height="37px" Width="175px"/>
            <br />
            <br />
            <asp:Button ID="viewPromo" runat="server" OnClick="ViewPromocodes" Text="View my promocodes" Height="37px" Width="253px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="grade" runat="server" OnClick="Grade_Click" Text="View Grades" Height="37px" Width="198px"/>
            <br />
            <br />
            Add Phone number
            <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="addMn" runat="server" OnClick="AddMobile" Text="Add" />
            <br />
            <br />
            <br />
            Add Credit Card:<br />
            <br />
            Credit Card Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="ccn" runat="server"></asp:TextBox>
            <br />
            Cardholder Name&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            Expiry Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; <asp:TextBox ID="edate" runat="server"></asp:TextBox>
            <br />
            (mm/dd/yyyy)<br />
            <br />
            CVV&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="cvv" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addccard" runat="server" OnClick="addCreditCard" Text="Add Credit Card" Width="368px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
