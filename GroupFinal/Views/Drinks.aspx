<%@ Page Title="Drinks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Drinks.aspx.cs" Inherits="GroupFinal.Views.Drinks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="center">
    <br />
    <p style="font-weight: 700; font-size: 1.3em;">Select your Size</p>
        <asp:Panel ID="pnlSize" style="margin: 0 auto; text-align: left;" runat="server" Width="300px">
        <asp:RadioButton ID="rdoSmall" runat="server" GroupName="drinkSize" Text="  Small  (12oz)  " />
        <br />
        <asp:RadioButton ID="rdoMedium" runat="server" GroupName="drinkSize" Text="  Medium  (24oz)  " Checked="True" />
        <br />
        <asp:RadioButton ID="rdoLarge" runat="server" GroupName="drinkSize" Text="  Large  (48oz)  " />
    </asp:Panel>
    <br />
    <p style="font-weight: 700; font-size: 1.3em;">Select your beverage</p>
        <asp:Panel ID="pnlDrink" style="margin: 0 auto; text-align: left;" runat="server" Width="300px">

    </asp:Panel>
    
    <br />
    <asp:Button ID="btnSubmit" style="margin-bottom: 20px; font-weight: 800; font-size: 1.2em;" runat="server" OnClick="btnSubmit_Click" Text="Add to Order" />
    <br />
        </div>
</asp:Content>
