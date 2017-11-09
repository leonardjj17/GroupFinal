

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Your Current Order</h2>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
        <Columns>
            <asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" />
            <asp:BoundField DataField="CustomerFirst" HeaderText="CustomerFirst" SortExpression="CustomerFirst" />
            <asp:BoundField DataField="CustomerLast" HeaderText="CustomerLast" SortExpression="CustomerLast" />
            <asp:BoundField DataField="OrderTotal" HeaderText="OrderTotal" SortExpression="OrderTotal" />
            <asp:BoundField DataField="StoreNum" HeaderText="StoreNum" SortExpression="StoreNum" />
            <asp:BoundField DataField="IsFavorite" HeaderText="IsFavorite" SortExpression="IsFavorite" />
            <asp:BoundField DataField="OrderType" HeaderText="OrderType" SortExpression="OrderType" />
            <asp:BoundField DataField="OrderTax" HeaderText="OrderTax" SortExpression="OrderTax" />
            <asp:BoundField DataField="OrderSubTotal" HeaderText="OrderSubTotal" SortExpression="OrderSubTotal" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="CalcTotal" TypeName="GroupFinal.Classes.Cart">
        <SelectParameters>
            <asp:Parameter Name="items" Type="Object" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    <hr />

    
</asp:Content>
