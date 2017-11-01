<%@ Page Title="Financial Info" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinancialView.aspx.cs" Inherits="GroupFinal.Views.FinancialView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Current Store:
    <asp:Label ID="lblStoreNumber" runat="server"></asp:Label>
    <br />
    Current Balance: <asp:Label ID="lblStoreBalance" runat="server"></asp:Label>
</asp:Content>
