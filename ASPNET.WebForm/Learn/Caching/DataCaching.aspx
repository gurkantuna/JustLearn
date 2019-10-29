<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="DataCaching.aspx.cs" Inherits="ASPNET.WebForm.Learn.Caching.DataCaching" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <asp:GridView ID="gvProducts" runat="server"></asp:GridView>
</asp:Content>
