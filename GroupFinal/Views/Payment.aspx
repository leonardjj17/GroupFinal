<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="GroupFinal.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlNewCustomer" runat="server" Width="680px">
    </asp:Panel>
    <br />
    <table style="width: 54%">
        <tr>
            <td style="width: 218px" class="text-left">
                <asp:Label ID="lblName" runat="server" Text="Customer Name:"></asp:Label>
            </td>
            <td class="text-left">
                <asp:Label ID="lblCustomerName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 20px; width: 218px" class="text-left">
                <asp:Label ID="Label2" runat="server" Text="Delivery or Carryout:"></asp:Label>
            </td>
            <td style="height: 20px" class="text-left">
                <asp:Label ID="lblOrderType" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 218px" class="text-left">
                <asp:Label ID="Label3" runat="server" Text="Total:"></asp:Label>
            </td>
            <td class="text-left">
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 28px; width: 218px" class="text-left">
                <asp:Label ID="Label4" runat="server" Text="Estimated Time:"></asp:Label>
            </td>
            <td style="height: 28px" class="text-left">
                <asp:Label ID="lblOrderEstimation" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 218px" class="text-left">
                &nbsp;</td>
            <td class="text-left">
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
