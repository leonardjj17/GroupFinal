<%@ Page Title="Order Reciept" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderReciept.aspx.cs" Inherits="GroupFinal.Views.OrderReciept" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<br />
    First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblFirst" runat="server"></asp:Label>
    <br />
    <br />
    Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblLast" runat="server"></asp:Label>
    <br />
    <br />
    Order Total:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblOrderTotal" runat="server"></asp:Label>
    <br />
    <br />
    Store Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblStoreNumber" runat="server"></asp:Label>
    <br />
    <br />
    Favorite:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblIsFavorite" runat="server"></asp:Label>
    <br />
    <br />
    Order Type:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblOrderType" runat="server"></asp:Label>
    <br />
</asp:Content>
