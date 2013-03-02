<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">
    <div id="contentOrders">
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblFirst" runat="server" Text="First Name: " CssClass="lbl" ></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbFirst" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required!" ControlToValidate="tbFirst" CssClass="err"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblLast" runat="server" Text="Last Name: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbLast" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required!" ControlToValidate="tbLast" CssClass="err"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEmail" runat="server" Text="Email: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required!" ControlToValidate="tbEmail" CssClass="err"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblPhone" runat="server" Text="Phone: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbPhone" runat="server" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required!" ControlToValidate="tbPhone" CssClass="err"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ControlToValidate="tbPhone" ValidationExpression="(\d{3}).(\d{3}).(\d{4})" runat="server" CssClass="err" ErrorMessage="Required format of 111.222.3333"></asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblSize" runat="server" Text="Pizza Size: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlSize" runat="server" OnSelectedIndexChanged="sizeSelected"  AutoPostBack="true">
                            <asp:ListItem Value="Small">Small</asp:ListItem>
                            <asp:ListItem Value="Medium" Selected="True">Medium</asp:ListItem>
                            <asp:ListItem Value="Large">Large</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Quantity" runat="server" Text="Quantity: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbQuantity" runat="server" TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Required!" ControlToValidate="tbQuantity" CssClass="err"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvQuantity" runat="server" ErrorMessage="Must enter a valid Quantity" MinimumValue="1" MaximumValue="99" ControlToValidate="tbQuantity" CssClass="err"></asp:RangeValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblToppings" runat="server" Text="Toppings: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:CheckBoxList ID="lbToppings" runat="server" RepeatColumns="8" CssClass="lbl"></asp:CheckBoxList>
                        <asp:CustomValidator ID="cvToppings" runat="server" ErrorMessage="Must Select atleast one Topping!" OnServerValidate="cvToppings_ServerValidate" CssClass="err" Display="Dynamic"></asp:CustomValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblDelivery" runat="server" Text="Pickup or Delivery: " CssClass="lbl"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButton ID="rbPickup" runat="server" GroupName="Delivery" Checked="true"/>
                        <asp:Label ID="lblrbPickup" runat="server" Text="Pickup" CssClass="lbl"></asp:Label>
                        <asp:RadioButton ID="rbDelivery" runat="server" GroupName="Delivery" />
                        <asp:Label ID="lblrbDelivery" runat="server" Text="Delivery" CssClass="lbl"></asp:Label>            
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="btnOrder" runat="server" Text="Submit Order" OnClick="btnOrder_Click"/>
    </div>
</asp:Content>

