<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Basic.jQuery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script>
        function Clock() {
            $.ajax({
                url: "Clock.aspx",
                type: "GET",
                success: function (output) {
                    $("#clock").html(output);
                }
            })
        }

        $(document).ready(function () {
            $("#textProductName").keyup(function () {
                var productName = $(this).val();
                //alert(productName);

                $.ajax({
                    url: "GetByProductName.aspx",
                    type: "POST",
                    data: "productName=" + productName,
                    success: function (output) {
                        $("#tableProducts").html(output);
                    }
                })
            })
        })

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Literal Text="" runat="server" ID="labelClock" /><br />
        <asp:Button Text="Sync" runat="server" ID="btnSyncClock" OnClick="btnSyncClock_Click" />
        <input type="button" name="name" value="Async" onclick="Clock()" />
        <div id="clock">
        </div>

        <table>
            <tr>
                <td>Product Name</td>
                <td>
                    <input type="text" name="name" value="" id="textProductName" /></td>
            </tr>
        </table>


        <div>
            <asp:GridView ID="tableProducts" runat="server" ClientIDMode="Static" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>Product Name</HeaderTemplate>
                        <ItemTemplate>
                            <%#Eval("ProductName") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
