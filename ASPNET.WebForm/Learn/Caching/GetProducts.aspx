<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="GetProducts.aspx.cs" Inherits="ASPNET.WebForm.Learn.Caching.GetProducts" %>

<%@ OutputCache Duration="3600" VaryByParam="CategoryId" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <asp:Repeater runat="server" ID="rpProducts">
        <ItemTemplate>
            <%# Eval("ProductName") %>
            <br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
