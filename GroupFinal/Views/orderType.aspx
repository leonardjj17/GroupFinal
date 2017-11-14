<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="orderType.aspx.cs" Inherits="GroupFinal.Views.orderType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="oType">
        <h1>
            Order Type</h1>
        <p>
            <asp:RadioButton ID="rdoDelivery" runat="server" Text="Delivery" GroupName="rdogrpOrderType" OnCheckedChanged="rdoDelivery_CheckedChanged" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdoCarryOut" runat="server" Text="Carry Out" GroupName="rdogrpOrderType" OnCheckedChanged="rdoCarryOut_CheckedChanged" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Zip Code:   "></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtZip" runat="server" OnTextChanged="txtZip_TextChanged" Height="27px" Width="123px"></asp:TextBox>
        </p>
        <p>
            Choose Store City:&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="OsheaDB" DataTextField="storeCity" DataValueField="storeState" Height="30px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="OsheaDB" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" SelectCommand="SELECT [storeCity], [storeState] FROM [Store]"></asp:SqlDataSource>
        </p>
        <p>
            <asp:Button ID="btnOrderType" runat="server" OnClick="btnOrderType_Click" Text="Start Order" BackColor="#029350" BorderColor="#999999" BorderStyle="Outset" Font-Bold="True" ForeColor="Black" Width="154px" />
        </p>
        </div>
</asp:Content>

