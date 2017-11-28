﻿


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Your Current Order</h2>
   
  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Qty" HeaderText="Qty" SortExpression="Qty" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="SubTotal" HeaderText="SubTotal" ReadOnly="True" SortExpression="SubTotal" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
            <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
            <asp:BoundField DataField="ProductType" HeaderText="ProductType" SortExpression="ProductType" />
            <asp:BoundField DataField="ProductQty" HeaderText="ProductQty" SortExpression="ProductQty" />
            <asp:BoundField DataField="ProductCost" HeaderText="ProductCost" SortExpression="ProductCost" />
            <asp:BoundField DataField="ProductDetail" HeaderText="ProductDetail" SortExpression="ProductDetail" />
        </Columns>
    </asp:GridView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetItems" TypeName="GroupFinal.Classes.Cart">
        <SelectParameters>
            <asp:SessionParameter Name="cartItems" SessionField="cart" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:Button ID="continueOrderBtn" class="drinkBtn" runat="server" Text="Continue Ordering" OnClick="continueOrderBtn_Click" Font-Bold="true"/>
    
   
    
    <hr />

    
</asp:Content>
