<%@ Page Title="Inventory" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="GroupFinal.Views.Inventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Select a Ingredient from our inventory to see more<br />
    <br />
    <br />
    Item Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblIngredientName" runat="server"></asp:Label>
&nbsp;
    <br />
    Item Cost:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblItemCost" runat="server"></asp:Label>
    <br />
    Item Menu Price:&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblMenuPrice" runat="server"></asp:Label>
&nbsp;&nbsp;
    <br />
    Quantitiy:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lblQuantity" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;<asp:ListBox ID="lstIngredients" runat="server" Height="150px" Width="244px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
&nbsp;<asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" />
&nbsp; 
</asp:Content>
