<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="RoleManager.aspx.cs" Inherits="ASPNET.WebForm.Learn.MemberShip.Manuel.RoleManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
    RoleManager
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <table>
        <tr>
            <td>Rol Name</td>
            <td>
                <asp:TextBox runat="server" ID="textRoleName" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button Text="Add" runat="server" ID="btnAddRole" OnClick="btnAddRole_Click" /></td>
        </tr>
    </table>
</asp:Content>
