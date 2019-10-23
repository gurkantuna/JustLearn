<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="GridView.aspx.cs" Inherits="ASPNET.WebForm.DataControls.GridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductId" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField HeaderText="Product Name" DataField="ProductName" />
            <asp:BoundField HeaderText="Unit Price" DataField="UnitPrice" ApplyFormatInEditMode="true" DataFormatString="{0:n}" />
            <asp:CommandField ShowEditButton="true" ShowDeleteButton="true" EditImageUrl="~/Images/edit.png" CancelImageUrl="~/Images/cancel.png" UpdateImageUrl="~/Images/save.png" DeleteImageUrl="~/Images/delete.png" ButtonType="Image" />
        </Columns>
    </asp:GridView>
</asp:Content>
