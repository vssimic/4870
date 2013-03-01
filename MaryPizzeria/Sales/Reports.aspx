<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reports.aspx.cs" Inherits="Sales_Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <form runat="server">
        <div>
            <div id="calendars" style="float: left">
                <asp:Label ID="lblCalendarStart" runat="server" Text="Start Date: "></asp:Label>
                <asp:Calendar ID="calendarStart" runat="server"></asp:Calendar>
                <asp:Label ID="lblCalendarEnd" runat="server" Text="End Date: "></asp:Label>
                <asp:Calendar ID="calendarEnd" runat="server"></asp:Calendar>
                <asp:Button ID="btnGetReport" runat="server" Text="Submit" />
            </div>
            <div style="">
                something
            </div>
        </div>


    </form>

</asp:Content>

