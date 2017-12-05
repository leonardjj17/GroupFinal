<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="center">
    <h3>Your Current Order</h3>
    <asp:Panel ID="pnlShoppingCart" runat="server">
      
        &nbsp;&nbsp;
    </asp:Panel>
    <br />
        <asp:Button ID="btnPayment" runat="server" OnClick="btnPayment_Click" Text="Lets Pay" />&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnContinueOrdering" runat="server" OnClick="btnContinueOrdering_Click" Text="Continue Ordering" />

    
        </div>
</asp:Content>
