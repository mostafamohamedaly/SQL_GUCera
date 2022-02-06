<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="GUCera.InstructorHome" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body style="background-color: white; height: 288px; width: 605px; margin-right: 275px;">
    <header>
  <h1 style="color: black;width: 1479px"><b>&nbsp;Instructor Home Page</b></h1>
</header>
    <form id="form1" runat="server">
        <div style="width: 1208px"> 
            
            <asp:Button ID="addcourse" runat="server" OnClick="addCourse" Text="Add Course" Height="102px" Width="402px" BackColor="#339966" />
            
            <asp:Button ID="viewwassign" runat="server" OnClick="viewAssign" Text="View Students' Assignments" Height="102px" Width="402px" BackColor="#339966" Font-Bold="true" />
            
            <asp:Button ID="courseeContent" runat="server" OnClick="courseContent" Text="Update Course Content" Height="102px" Width="402px" BackColor="#339966" Font-Bold="true"/>
            
            <asp:Button ID="gradeeAssign" runat="server" OnClick="gradeAssign" Text="Grade Assignment" Height="102px" Width="402px" BackColor="#339966" Font-Bold="true"/>
            
            <asp:Button ID="viewwFeed" runat="server" OnClick="viewFeed" Text="View Feedback" Height="102px" Width="402px" BackColor="#339966" Font-Bold="true" />
        
            <asp:Button ID="issueeCert" runat="server" OnClick="issueCert" Text="Issue Certificate" Height="102px" Width="402px" BackColor="#339966" Font-Bold="true" Font-Names="Raleway" />
            <br />
            <br />
            Add Phone number
            <asp:TextBox ID="phonenumber" runat="server"></asp:TextBox>
    &nbsp;<asp:Button ID="addMn" runat="server" OnClick="AddMobile" Text="Add" />
        </div>
    </form>
</body>
</html>
