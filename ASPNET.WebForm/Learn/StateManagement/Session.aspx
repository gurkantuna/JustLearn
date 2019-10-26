<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.Session" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenPlaceTitle" runat="server">Session</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <ul class="list-inline">
        <li>Name :<asp:TextBox runat="server" ID="textName" />
            <asp:Button runat="server" Text="Set Session" CssClass="btn-info" ID="btnSetSession" OnClick="btnSetSession_Click" /></li>
        <li>
            <a href="Session2.aspx" class="btn-info">Get Session</a>
        </li>
    </ul>
</asp:Content>
