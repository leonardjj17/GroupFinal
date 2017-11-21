<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GroupFinal.Manager.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    allow editing the price of menu items
    
    <asp:Table ID="CategoryTable" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="">Select Category</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="dropdownCategory" runat="server"></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="UpdateCategory" runat="server" Text="Select" OnClick="UpdateCategory_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="ItemTable" runat="server" Visible="false">
        <asp:TableRow>
            <asp:TableCell>
                 <asp:Label ID="Label2" runat="server" Text="">Select Menu Item</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="dropdownItems" runat="server"></asp:DropDownList>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="EditItem" runat="server" Text="Edit Menu Item" OnClick="EditItem_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Table ID="PriceTable" runat="server" Visible="false">
        <asp:TableRow>
            <asp:TableCell>
                Menu Item:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="MenuItemName" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Item ID:
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="MenuItemID" runat="server" Text=""></asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label4" runat="server" Text="Label">Enter New Price</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="Price" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="UpdatePrice" runat="server" Text="Save Change" OnClick="UpdatePrice_Click" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:Panel ID="Error" runat="server"></asp:Panel>
</asp:Content>
