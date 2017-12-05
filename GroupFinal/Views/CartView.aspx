<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Your Current Order<br />
    <asp:Panel ID="pnlShoppingCart" runat="server">
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
    </asp:Panel>
    <br />
    <asp:Button ID="btnContinueOrdering" runat="server" OnClick="btnContinueOrdering_Click" Text="Continue Ordering" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnPayment" runat="server" OnClick="btnPayment_Click" Text="Lets Pay" />
</asp:Content>
