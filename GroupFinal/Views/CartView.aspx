﻿


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Your Current Order</h2>
   
  
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductType" HeaderText="ProductType" SortExpression="ProductType" />
            <asp:BoundField DataField="ProductQty" HeaderText="ProductQty" SortExpression="ProductQty" />
            <asp:BoundField DataField="ProductDetail" HeaderText="ProductDetail" SortExpression="ProductDetail" />
            <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
        </Columns>
    </asp:GridView>
    
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetItems" TypeName="GroupFinal.Classes.Cart">
        <SelectParameters>
            <asp:SessionParameter Name="items" SessionField="items" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <asp:Button ID="continueOrderBtn" class="drinkBtn" runat="server" Text="Continue Ordering" OnClick="continueOrderBtn_Click" Font-Bold="true"/>

    <asp:Button ID="submitOrderBtn" class="submitOrderBtn" runat="server" Text="Submit Order" OnClick="submitOrderBtn_Click" Font-Bold="true"/>
    
   
    
    <hr />

    
</asp:Content>
