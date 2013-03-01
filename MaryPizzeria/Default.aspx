<%@ Page Title="Home" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" Runat="Server">
    <div id="contentHome">
        <div id="imgContainer">
            <img src="images/pizza1.jpg" />
            <img src="images/pizza2.jpg" />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" >HyperLink</asp:HyperLink>    </div>
</asp:Content>

