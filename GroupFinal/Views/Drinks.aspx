<%@ Page Title="Drinks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Drinks.aspx.cs" Inherits="GroupFinal.Views.Drinks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    Select your Size<asp:Panel ID="pnlSize" runat="server" Width="300px">
        <asp:RadioButton ID="rdoSmall" runat="server" GroupName="drinkSize" Text="Small (12oz)" />
        <br />
        <asp:RadioButton ID="rdoMedium" runat="server" GroupName="drinkSize" Text="Medium (24oz)" />
        <br />
        <asp:RadioButton ID="rdoLarge" runat="server" GroupName="drinkSize" Text="Large (48oz)" />
    </asp:Panel>
    <br />
    Select your beverage<asp:Panel ID="pnlDrink" runat="server" Width="300px">

    </asp:Panel>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Add to Order" />
    <br />
</asp:Content>
