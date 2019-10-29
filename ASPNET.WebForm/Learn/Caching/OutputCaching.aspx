<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="OutputCaching.aspx.cs" Inherits="ASPNET.WebForm.Learn.Caching.OutputCaching" %>

<%@ OutputCache Duration="5" VaryByParam="none" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    You will seeing be the same result from the cache until 5 second. You have to reload the page 5 second interval to see the difference.
    <br />
    <asp:Literal Text="" runat="server" ID="labelDateTime" /><br />
    <a href="OutputCaching2.aspx">Output Caching2</a>

</asp:Content>
