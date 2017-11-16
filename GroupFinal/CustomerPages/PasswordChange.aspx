<%@ Page Title="Change Your Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="GroupFinal.CustomerPages.PasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Change Your Password</h2>
    <p>
        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Visible="False"></asp:Label>
    </p>
    <p>

        Old Password: <asp:TextBox ID="txtOldPassword" runat="server"></asp:TextBox>

    </p>
    <p>

        New Password:
        <asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox>

    </p>
    <p>

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Change Password" OnClick="btnSubmit_Click" />

    </p>
</asp:Content>
