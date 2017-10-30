<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PizzaView.aspx.cs" Inherits="GroupFinal.Views.PizzaView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="pizzaImage" runat="server" ImageUrl="~/images/blankPizza.png" Width="200px" />
    <asp:RadioButtonList ID="rdoSizeList" runat="server">
        <asp:ListItem>Small (12&quot;)</asp:ListItem>
        <asp:ListItem>Medium (15&quot;)</asp:ListItem>
        <asp:ListItem>Large(18&quot;)</asp:ListItem>
    </asp:RadioButtonList>
</asp:Content>
