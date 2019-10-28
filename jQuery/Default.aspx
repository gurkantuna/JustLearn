<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jQuery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script>
        function WriteClock() {
            $.ajax({
                url: "Clock.aspx",
                type: "GET",
                success: function (saat) {
                    $('#clock').html(saat);
                }
            });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal Text="" runat="server" ID="labelClock" />
        </div>
        <div id="clock"></div>
        <asp:Button Text="PostBack" runat="server" OnClick="btnClock_Click" ID="btnClock" />
        <a href="#" onclick="WriteClock()">Dont PostBack</a>
    </form>
</body>
</html>
