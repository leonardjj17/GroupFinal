<%@ Page Title="Sides" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sides.aspx.cs" Inherits="GroupFinal.Views.Sides" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="center">
    <br />

    <p style="margin: 0 auto">Select your side:</p>
            <asp:Panel ID="pnlSides" style="margin: 0 auto" runat="server" Width="200px">
    </asp:Panel>
    <br />
    <asp:Button  style="margin: 0 auto" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="I Want These Sides!" />
        </div>
</asp:Content>
