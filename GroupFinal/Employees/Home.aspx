<%@ Page Title="Employee Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GroupFinal.Employees.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><asp:Label ID="lblMessage" runat="server"></asp:Label></h2>
     <h2>
        Welcome,
        <asp:Label ID="lblUserName" runat="server" Text="User"></asp:Label>
    </h2>
    <p>
        <a href ="OrdersList.aspx">Order</a>&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="lnkEmployeeListing" runat="server" Visible="False" OnClick="lnkEmployeeListing_Click" PostBackUrl="~/Employees/EditEmployees.aspx">Employee Listing</asp:LinkButton>
    </p>
        
</asp:Content>
