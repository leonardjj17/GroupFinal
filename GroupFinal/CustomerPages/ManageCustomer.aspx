<%@ Page Title="Your Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="GroupFinal.CustomerPages.ManageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        Your Account</p>
    <p>
        Email:
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChangeEmail" runat="server" Text="Change" OnClick="btnChangeEmail_Click" />
    </p>
    <p>
        Change Password:
        <asp:Button ID="btnChangePassword" runat="server" Text="Change" OnClick="btnChangePassword_Click" />
    </p>
    <p>
        First Name:
        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangeFirstName" runat="server" Text="Change" OnClick="btnChangeFirstName_Click" />
    </p>
    <p>
        Last Name:
        <asp:Label ID="lblLastName" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangeLastName" runat="server" Text="Change" OnClick="btnChangeLastName_Click" />
    </p>
    <p>
        Address:
        <asp:Label ID="lblAddress" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangeAddress" runat="server" Text="Change" OnClick="btnChangeAddress_Click" />
    </p>
    <p>
        City:
        <asp:Label ID="lblCity" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangeCity" runat="server" Text="Change" OnClick="btnChangeCity_Click" />
    </p>
    <p>
        State:
        <asp:Label ID="lblState" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangeState" runat="server" Text="Change" />
    </p>
    <p>
        Zip:
        <asp:Label ID="lblZip" runat="server"></asp:Label>
        <asp:Button ID="btnChangeZip" runat="server" Text="Change" OnClick="btnChangeZip_Click" />
    </p>
    <p>
        Phone:
        <asp:Label ID="lblPhone" runat="server"></asp:Label>
    &nbsp;<asp:Button ID="btnChangePhone" runat="server" Text="Change" OnClick="btnChangePhone_Click" />
    </p>
    
</asp:Content>
