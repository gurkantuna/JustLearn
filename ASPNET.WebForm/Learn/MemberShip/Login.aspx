﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPNET.WebForm.Learn.MemberShip.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="Register.aspx">Register</a>
        <a href="/">Home</a>
        <div>
            <asp:Login ID="Login1" runat="server"></asp:Login>
        </div>
    </form>
</body>
</html>
