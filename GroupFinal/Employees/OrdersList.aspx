<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrdersList.aspx.cs" Inherits="GroupFinal.Employees.OrderList" %>
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
            <th>Action</th>
        </tr>
        <asp:Panel ID="pnlOrders" runat="server">
        </asp:Panel>
    </table>

</asp:Content>
