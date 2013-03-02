<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Toppings.aspx.cs" Inherits="Admin_Toppings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div id="contentToppings">
        <div id="toppingsGridView">
            <asp:GridView ID="gvToppings" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="toppingId" DataSourceID="edsToppings" ForeColor="Black" GridLines="Horizontal" AllowPaging="True" Height="20px" PageSize="20">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="toppingId" HeaderText="toppingId" ReadOnly="True" SortExpression="toppingId" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="active" HeaderText="active" SortExpression="active" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
        <div id="toppingFormContainer">
            <div id="toppingForm">
                <asp:TextBox ID="tbToppingName" runat="server"></asp:TextBox>
                <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
                <asp:RequiredFieldValidator ID="rfvToppingName" runat="server" ErrorMessage="Cannot be empty!" CssClass="err" ControlToValidate="tbToppingName"></asp:RequiredFieldValidator>
            </div>
        </div>
        <asp:EntityDataSource ID="edsToppings" runat="server" ConnectionString="name=MaryPizzaEntities" DefaultContainerName="MaryPizzaEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Toppings">
        </asp:EntityDataSource>
    </div>
</asp:Content>

