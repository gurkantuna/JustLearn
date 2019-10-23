<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBase.Master" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="ASPNET.WebForm.DataControls.Repeater" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
       Order by Price : 
            <asp:LinkButton Text="Descending" runat="server" ID="LinkButtonDesc" OnClick="LinkButtonDesc_Click" /> &nbsp;<b>|</b>&nbsp;
            <asp:LinkButton Text="Ascending" runat="server" ID="LinkButtonAsc" OnClick="LinkButtonAsc_Click" />
            <asp:HyperLink NavigateUrl="navigateurl" runat="server" ID="HyperLink1" />
            <asp:Repeater runat="server" ID="repeater1" OnItemDataBound="repeater1_ItemDataBound" OnItemCommand="repeater1_ItemCommand" >
                <HeaderTemplate>
                    <table border="1">
                        <thead>
                            <tr>
                                <th>Product Id</th>
                                <th>Product Name</th>
                                <th>Price</th>
                                <th>Price Status</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ProductId") %></td>
                        <td><%#Eval("ProductName") %></td>
                        <td id="cellPrice" runat="server"><%#EvalPrice() %></td>
                        <td id="cellPriceStatus" runat="server"></td>
                        <td>
                            <asp:LinkButton Text="Raise" ID="btnRaise" runat="server" CommandName="Raise" CommandArgument='<%# Eval("ProductId") %>' />
                        </td>   
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr id="rowProduct" runat="server" style="background-color:lightgray">
                        <td><%#Eval("ProductId") %></td>
                        <td><%#Eval("ProductName") %></td>
                        <td id="cellPrice" runat="server"><%#EvalPrice() %></td>
                        <td id="cellPriceStatus" runat="server"></td>
                        <td>
                            <asp:LinkButton Text="Raise" ID="btnRaise" runat="server" CommandName="Raise" CommandArgument='<%# Eval("ProductId") %>' />
                        </td>   
                    </tr>
                </AlternatingItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>                            
                </FooterTemplate>
            </asp:Repeater>
</asp:Content>
