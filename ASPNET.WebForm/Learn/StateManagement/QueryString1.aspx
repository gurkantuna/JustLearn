<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="QueryString1.aspx.cs" Inherits="ASPNET.WebForm.Learn.StateManagement.QueryString1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContenPlaceTitle" runat="server">QueryString1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductId" CssClass="table table-striped">
        <Columns>
            <asp:BoundField DataField="ProductId" HeaderText="Product Id" />
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" DataFormatString="{0:n}" />
            <%--<asp:HyperLinkField NavigateUrl='QueryString2.aspx?productId=<%#Eval("ProductId") %>' Text="Details1" /> You can't use Eval() in this component--%> 
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='QueryString2.aspx?productId=<%#Eval("ProductId") %>'>Details</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
