<%@ Page Title="Employee Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GroupFinal.Employees.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
     <p>
        Welcome,
        <asp:Label ID="lblUserName" runat="server" Text="User"></asp:Label>
    </p>
    <p>
        <a href ="OrdersList.aspx">Order</a>&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lnkEmployeeListing" runat="server" Visible="False">Employee Listing</asp:LinkButton>
    </p>
        </div>
</asp:Content>
