<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="GroupFinal.Employees.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
 
        <h1>Welcome, <asp:Label ID="lblName" runat="server" Text="User"></asp:Label></h1>
        <a href="OrdersList.aspx">Orders</a>

</asp:Content>

