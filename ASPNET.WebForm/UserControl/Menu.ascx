<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="ASPNET.WebForm.UserControl.Menu" %>

<nav class="navbar navbar-inverse">
    <div class="container-fluid">
        <div class="navbar-header">
            <a class="navbar-brand" href="/">JustLearn</a>
        </div>
        <ul class="nav navbar-nav">
            <li class="active"><a id="linkRepeaters" href="~/Learn/DataControls/Repeater.aspx" runat="server">Repeater</a></li>
            <li><a id="A1" href="~/Learn/DataControls/DataList.aspx" runat="server">DataList</a></li>
            <li><a id="A2" href="~/Learn/DataControls/GridView.aspx" runat="server">GridView</a></li>
            <li><a id="A3" href="~/Learn/StateManagement/ViewState.aspx" runat="server">ViewState</a></li>
            <li><a id="A4" href="~/Learn/StateManagement/QueryString1.aspx" runat="server">QueryString</a></li>
            <li><a id="A5" href="~/Learn/StateManagement/Cookie.aspx" runat="server">Cookie</a></li>
        </ul>
    </div>
</nav>