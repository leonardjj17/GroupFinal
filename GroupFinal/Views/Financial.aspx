<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Financial.aspx.cs" Inherits="GroupFinal.Views.Financial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Current Store:
    <asp:Label ID="lblStoreNumber" runat="server"></asp:Label>
    <br />
    Current Balance: <asp:Label ID="lblStoreBalance" runat="server"></asp:Label>
</asp:Content>
