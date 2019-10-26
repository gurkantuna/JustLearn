<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Session2.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.Session2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenPlaceTitle" runat="server">Session2</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div>
        Name: <asp:Label Text="" runat="server" ID="labelSessionValue" />
    </div>
</asp:Content>
