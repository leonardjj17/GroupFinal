<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="orderType.aspx.cs" Inherits="GroupFinal.Views.orderType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1 class="center">
            Order Type</h1>
        <p class="center">
            <asp:RadioButton ID="rdoDelivery" runat="server" Text="Delivery" GroupName="rdogrpOrderType" OnCheckedChanged="rdoDelivery_CheckedChanged" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdoCarryOut" runat="server" Text="Carry Out" GroupName="rdogrpOrderType" OnCheckedChanged="rdoCarryOut_CheckedChanged" />
        </p>
        <p class="center">
            <asp:Label ID="Label1" runat="server" Text="Zip Code   "></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtZip" runat="server" OnTextChanged="txtZip_TextChanged"></asp:TextBox>
        </p>
        <p class="center">
            Choose Store City:&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="OsheaDB" DataTextField="storeCity" DataValueField="storeState">
            </asp:DropDownList>
            <asp:SqlDataSource ID="OsheaDB" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" SelectCommand="SELECT [storeCity], [storeState] FROM [Store]"></asp:SqlDataSource>
        </p>
        <p class="center">
            <asp:Button ID="btnOrderType" runat="server" OnClick="btnOrderType_Click" Text="Order" />
        </p>
</asp:Content>

