<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="GroupFinal.CustomerPages.ManageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        Your Account</p>
    <p>
        Email:
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChangeEmail" runat="server" Text="Change" />
    </p>
    <p>
        Change Password:
        <asp:Button ID="btnChangePassword" runat="server" Text="Change" />
    </p>
    <p>
        First Name:
        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
    </p>
    <p>
        Last Name:
        <asp:Label ID="lblLastName" runat="server"></asp:Label>
    </p>
    <p>
        Address:
        <asp:Label ID="lblAddress" runat="server"></asp:Label>
    </p>
    <p>
        City:
        <asp:Label ID="lblCity" runat="server"></asp:Label>
    </p>
    <p>
        State:
        <asp:Label ID="lblState" runat="server"></asp:Label>
    </p>
    <p>
        Zip:
        <asp:Label ID="lblZip" runat="server"></asp:Label>
    </p>
    <p>
        Phone:
        <asp:Label ID="lblPhone" runat="server"></asp:Label>
    </p>

</asp:Content>
