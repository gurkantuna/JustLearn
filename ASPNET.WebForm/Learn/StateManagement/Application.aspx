<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.Application" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
   You have to enter to above address from a different browser or wait 1 minute to see difference.
    <table>
        <tr>
            <td>Online Visitors</td>
            <td>
                <asp:Label Text="" runat="server" ID="labelOnlineVisitors" /></td>
        </tr>
        <tr>
            <td>Total Visitors</td>
            <td>
                <asp:Label Text="" runat="server" ID="labelTotalVisitors" />
            </td>
        </tr>
    </table>
</asp:Content>
