<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberShip.aspx.cs" Inherits="ASPNET.WebForm.Learn.MemberShip.MemberShip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:LoginName ID="LoginName1" runat="server" />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <div>
            Welcome to our web site! <a href="Register.aspx">Sign Up</a> | <a href="/">Home</a>
        </div>
    </form>
</body>
</html>
