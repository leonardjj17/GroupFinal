<%@ Page Title="Unassigned Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdersList.aspx.cs" Inherits="GroupFinal.Employees.OrdersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Order list for store</p>
    <p>
        <asp:Table ID="table" runat="server">
            <asp:TableRow>
                <asp:TableHeaderCell Width="5em">OrderID</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="10em">Customer Name</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="5em">Order</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="6em">Order Type</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="10em">Driver</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="5em">(Re)Assign Driver</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="5em">Delete</asp:TableHeaderCell>
                <asp:TableHeaderCell Width="5em">Complete?</asp:TableHeaderCell>
            </asp:TableRow>
        </asp:Table>
    </p>


</asp:Content>
