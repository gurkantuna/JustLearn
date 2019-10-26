<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="QueryString2.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.QueryString2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bold {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenPlaceTitle" runat="server">QueryString2</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <table class="table">
        <tr>
            <td class="bold">ProductID</td>
            <td>
                <asp:Label Text="" runat="server" ID="labelProductId" /></td>
        </tr>
        <tr>
            <td class="bold">Product Name</td>
            <td>
                <asp:Label Text="" runat="server" ID="labelProductName" /></td>
        </tr>
        <tr>
            <td class="bold">Unit Price</td>
            <td>
                <asp:Label Text="" runat="server" ID="labelUnitPrice" />
            </td>
        </tr>
    </table>    
</asp:Content>
