

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Your Current Order</h2>
    
    
    
    
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
            <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
            <asp:BoundField DataField="ProductType" HeaderText="ProductType" SortExpression="ProductType" />
            <asp:BoundField DataField="ProductQty" HeaderText="ProductQty" SortExpression="ProductQty" />
            <asp:BoundField DataField="ProductCost" HeaderText="ProductCost" SortExpression="ProductCost" />
            <asp:BoundField DataField="ProductDetail" HeaderText="ProductDetail" SortExpression="ProductDetail" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="AddItemsToCart" TypeName="GroupFinal.Classes.Cart">
        <SelectParameters>
            <asp:Parameter Name="myPizza" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    
    
    
    
    <hr />

    
</asp:Content>
