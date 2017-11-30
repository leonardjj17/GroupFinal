<%@ Page Title="Sides" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sides.aspx.cs" Inherits="GroupFinal.Views.Sides" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="center">
    <br />

    Select your side:<asp:Panel ID="pnlSides" runat="server" Width="200px">
    </asp:Panel>
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="I Want These Sides!" />
        </div>
</asp:Content>
