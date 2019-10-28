<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ASPNET.WebForm.Learn.MemberShip.Manuel.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContenPlaceTitle" runat="server">
    Register
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <table class="table-bordered">
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox runat="server" ID="textUserName" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textUserName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox runat="server" ID="textPassword" TextMode="Password" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textPassword"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Password (Again)</td>
            <td>
                <asp:TextBox runat="server" ID="textPasswordAgain" TextMode="Password" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textPasswordAgain"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" CssClass="text-danger" ControlToCompare="textPassword" ControlToValidate="textPasswordAgain"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td>
                <asp:TextBox runat="server" ID="textEmail" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textEmail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="textEmail" CssClass="text-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Question</td>
            <td>
                <asp:TextBox runat="server" ID="textQuestion" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textQuestion"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Answer</td>
            <td>
                <asp:TextBox runat="server" ID="textAnswer" /></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" CssClass="text-danger" ControlToValidate="textAnswer"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Button runat="server" CssClass="btn-default" Text="Sign Up" ID="btnRegister" OnClick="btnRegister_Click" /></td>
        </tr>
    </table>
</asp:Content>
