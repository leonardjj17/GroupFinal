<%@ Page Title="Change Your Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="GroupFinal.CustomerPages.PasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Change Your Password</h2>
    <p>
        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Visible="False"></asp:Label>
    </p>
        <asp:Table ID="changePass" runat="server" style="text-align: left">
            <asp:TableRow>
                <asp:TableCell>Password:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtOldPassword" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>New Password:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtNewPassword" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>

        <asp:Button ID="btnSubmit" runat="server" Text="Change Password" OnClick="btnSubmit_Click" />

</asp:Content>
