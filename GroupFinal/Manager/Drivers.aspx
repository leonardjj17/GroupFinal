﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="GroupFinal.Manager.Drivers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    display how many orders are assigned to each driver, but only if the order is not yet complete

    <asp:Table runat="server" ID="Count">
        <asp:TableRow >
            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
            <asp:TableHeaderCell>Assigned Delivery Count</asp:TableHeaderCell>
        </asp:TableRow>


    </asp:Table>
</asp:Content>
