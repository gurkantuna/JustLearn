<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPNET.WebForm.Learn.MemberShip.Manuel.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <asp:Label runat="server" Text="" CssClass="alert-success" Visible="false" ID="labelMessage"></asp:Label>
    <asp:Login runat="server" DestinationPageUrl="~/Learn/MemberShip/MemberShip.aspx"></asp:Login>

    <table class="table-bordered">
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox runat="server" ID="textUserName" /></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox runat="server" ID="textPassword" TextMode="Password" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button Text="Log In" runat="server" ID="btnLogIn" OnClick="btnLogIn_Click" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Literal Text="" runat="server" ID="labelUserName" /></td>
        </tr>
    </table>
</asp:Content>
