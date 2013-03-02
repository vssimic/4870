<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<link href="/MaryPizzeria/style.css" rel="stylesheet" type="text/css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="masterBody">
    <form id="form1" runat="server">
    <div id="loginContainer">
        <div id="divLogin">
            <asp:Login ID="loginControl" runat="server" Height="268px" Width="497px" CssClass="lbl">
        </asp:Login>
        </div>
    </div>
    </form>
</body>
</html>
