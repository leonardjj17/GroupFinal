<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignDriver.aspx.cs" Inherits="GroupFinal.Employees.AssignDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Select Driver:</h1>
        <form action="OrdersList.aspx" method="post">
            <asp:Panel ID="pnlStoreID" runat="server"></asp:Panel>
            <select name="driver">
            <asp:Panel ID="pnlDrivers" runat="server">
            </asp:Panel>
            </select> 
        </form>
</asp:Content>
