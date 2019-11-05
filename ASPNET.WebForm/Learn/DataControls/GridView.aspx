<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="ASPNET.WebForm.DataControls.GridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductId" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" AllowSorting="True" EmptyDataText="No Data" PageSize="20" OnRowCommand="GridView1_RowCommand" OnSorting="GridView1_Sorting" CssClass="table table-striped">
        <Columns>
            <asp:BoundField HeaderText="Product Name" DataField="ProductName" SortExpression="ProductName" />
            <asp:BoundField HeaderText="Unit Price" DataField="UnitPrice" ApplyFormatInEditMode="true" DataFormatString="{0:n}" SortExpression="UnitPrice" />
            <asp:TemplateField HeaderText="Category" SortExpression="CategoryId">
                <ItemTemplate>
                    <%# Eval("Category.CategoryName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>Raise Price</HeaderTemplate>
                <ItemTemplate>
                    <asp:ImageButton ImageUrl="~/Images/raise.png" runat="server" CommandName="Raise" CommandArgument='<%#Eval("ProductId") %>' />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" EditImageUrl="~/Images/edit.png" CancelImageUrl="~/Images/cancel.png" UpdateImageUrl="~/Images/save.png" DeleteImageUrl="~/Images/delete.png" ButtonType="Image" />
        </Columns>
    </asp:GridView>
</asp:Content>
