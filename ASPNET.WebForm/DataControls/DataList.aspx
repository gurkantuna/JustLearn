<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="ASPNET.WebForm.DataControls.DataList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Button Text="Edit 3.Row" runat="server" OnClick="Unnamed1_Click" />
    <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" OnEditCommand="DataList1_EditCommand" OnUpdateCommand="DataList1_UpdateCommand" OnDeleteCommand="DataList1_DeleteCommand" OnCancelCommand="DataList1_CancelCommand">
        <ItemTemplate>
            <%# Eval("ProductName") %>
            <%# Eval("UnitPrice") %>
            <asp:LinkButton ID="linkEdit" Text="Edit" runat="server" CommandName="Edit" CommandArgument='<%# Eval("ProductId") %>' />
            <asp:LinkButton Text="Delete" ID="linkDelete" runat="server" CommandName="Delete" CommandArgument='<%# Eval("ProductId") %>' />
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="textProductName" runat="server" Text='<%# Eval("ProductName") %>' />
            <asp:TextBox ID="textUnitPrice" runat="server" Text='<%# Eval("UnitPrice") %>' />
            <asp:LinkButton Text="Save" ID="linkSave" runat="server" CommandName="Update" CommandArgument='<%# Eval("ProductId") %>' />
            <asp:LinkButton Text="Cancel" ID="linkCancel" runat="server" CommandName="Cancel" />
        </EditItemTemplate>
    </asp:DataList>
</asp:Content>
