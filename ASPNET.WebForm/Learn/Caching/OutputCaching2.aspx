<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="OutputCaching2.aspx.cs" Inherits="ASPNET.WebForm.Learn.Caching.OutputCaching2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <asp:Repeater runat="server" ID="rpCategories">
        <ItemTemplate>
            <%# Eval("CategoryName") %>  <a href='GetProducts.aspx?categoryId=<%# Eval("CategoryId") %>' target="_blank">Get Products</a><br />
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
