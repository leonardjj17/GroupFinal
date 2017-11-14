<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="customerLogin.aspx.cs" Inherits="GroupFinal.CustomerPages.customerLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Sigh-In To Your Shenanigan&#39;s Account</p>
    <p>
        <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
    </p>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" CssClass="alert-danger" ErrorMessage="Must enter an email address"></asp:RequiredFieldValidator>
    </p>
    <br />
    Password:
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="alert-danger" ErrorMessage="Please enter your password"></asp:RequiredFieldValidator>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
</asp:Content>
