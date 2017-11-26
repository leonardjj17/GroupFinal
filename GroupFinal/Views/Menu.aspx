<%@ Page Title="Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="GroupFinal.Orders.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div  class ="center">

   <h1>Menu Items</h1>
    <br /><br />
    <p><a href="PizzaView.aspx">  Pizza   <img src="../images/pizza.png" height ="250" width="250"/></a></p><br />
    <p><a href="Sides.aspx">  Sides  <img src="../images/breadsticks.png" height ="250" width="250"/></a></p><br />
    <p><a href="Drinks.aspx">  Drinks  <img src="../images/pepsi.png" height ="250" width="250"/></a></p><br />
    <p><a href="Specials.aspx">  Specials  <img src="../images/specials.png" height ="250" width="250"/></a></p><br />
    <p><a href="PromoItems.aspx">  Cool Gear  <img src="../images/shirt.jpg" height ="250" width="250"/></a></p><br />
</div>
</asp:Content>
