<%@ Page Title="Unassigned Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdersList.aspx.cs" Inherits="GroupFinal.Employees.OrdersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Order list for store</p>
    <p>
        &nbsp;</p>
    <table>
        <tr>
            <th>OrderID</th>
            <th>Customer Name</th>
            <th>Order Total</th>
            <th>Order Type</th>
            <th>Driver</th>
            <th>Delete</th>
        </tr>
        <asp:Panel ID="pnlOrders" runat="server">
        </asp:Panel>
    </table>

</asp:Content>
