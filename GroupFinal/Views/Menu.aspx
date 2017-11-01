<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GroupFinal.Orders.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h1 class ="center">Menu Items</h1>
    <br /><br />
    <h3 class ="center"><img src="../images/pizza.png" height ="250" width="250"/><a href="PizzaView.aspx">Pizza</a></h3><br />
    <h3 class ="center"><a href="Sides.aspx">Sides</a><img src="../images/breadsticks.png" height ="250" width="250"/></h3><br />
    <h3 class ="center"><img src="../images/pepsi.png" height ="250" width="250"/><a href="Drinks.aspx">Drinks</a></h3><br />
    <h3 class ="center"><a href="Specials.aspx">Specials</a><img src="../images/specials.png" height ="250" width="250"/></h3><br />
    <h3 class ="center"><img src="../images/shirt.jpg" height ="250" width="250"/><a href="PromoItems.aspx">Cool Gear</a></h3><br />
</asp:Content>
