<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.Cookie" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div>
        Name :<asp:Label Text="" runat="server" ID="labelCookie" />
    </div>
    <ul class="list-inline">
        <li>
            <asp:Button runat="server" Text="Set Cookie" CssClass="btn-info" ID="btnSetCookie" OnClick="btnSetCookie_Click" /></li>
        <li>
            <asp:Button runat="server" Text="Get Cookie" CssClass="btn-info" ID="btnGetCookie" OnClick="btnGetCookie_Click" /></li>
    </ul>
</asp:Content>
