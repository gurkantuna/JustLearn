<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.ViewState" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <p>
        It's working as client side. As you know everything is disappears in the pages normally. You can handle the any value from ViewState because of its an object container. But you can do it only the same page! ViewState can't move to the value next page. 
    </p>
    <div>
        ProductId value :<asp:Label Text="[ProductId]" runat="server" ID="labelProductId" />
    </div>

    <div style="margin: 20px">
        <ul class="list-inline">
            <li></li>
            <li>
                <asp:Button Text='Set to ViewState["ProductId"]' runat="server" ID="btnSetViewState" OnClick="btnSetViewState_Click" />
            </li>
            <li>
                <asp:Button Text='Get from ViewState["ProductId"]' runat="server" ID="btnGetViewState" OnClick="btnGetViewState_Click" />
            </li>
        </ul>
    </div>
</asp:Content>
