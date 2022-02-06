<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GUCera.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin<br />
            --------<br />
            <asp:Button ID="viewAllCourses" runat="server" Text="View All Courses" Height="85px" Width="212px" OnClick="viewAllCourses_Click" />
            <asp:Button ID="viewNonAccpetedCourses" runat="server" Text="View Not Accepted Courses" Height="85px" Width="212px" OnClick="viewNonAccpetedCourses_Click" />
            <br />
            <br />
            Accepting Courses:&nbsp;&nbsp;&nbsp;&nbsp; <br />
            ----------------------&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
            <br />
&nbsp;Course ID :<br />
            <asp:TextBox ID="CourseId" runat="server" Height="16px" Width="156px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="acc" runat="server" Text="Accept" OnClick="AcceptCourse" />
            <br />
            <br />
            Create Promocode:<br />
            ----------------------<br />
            <br />
            Code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Issue Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Expiry Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Discount:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:TextBox ID="codee" runat="server" Height="16px" Width="141px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="issdate" runat="server" Height="16px" Width="142px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="exdate" runat="server" Height="16px" Width="140px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="discountt" runat="server" Height="16px" Width="136px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="promo" runat="server" Text="Create" OnClick="Create_Promocode" />
            <br />
            <br />
            Issue Promocode:<br />
            --------------------<br />
            <br />
            Student ID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PromoCode:<br />
            <asp:TextBox ID="studentid" runat="server" Height="16px" Width="140px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="codeee" runat="server" Height="16px" Width="146px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="issuepromo" runat="server" Text="Issue" OnClick="issuepromo_Click" />
            <br />
            <br />
            Add Phone Number:<br />
            -----------------------<br />
            <br />
&nbsp;<asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="addMn" runat="server" OnClick="AddMobile" Text="Add" />
        </div>
    </form>
</body>
</html>
