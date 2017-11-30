<%@ Page Title="Change Your Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="GroupFinal.CustomerPages.PasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Change Your Password</h2>
    <p>
        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Visible="False"></asp:Label>
    </p>
        <table ID="changePass" style="text-align: left">
            <tr>
                <td style="width: 8em">Password:</td>
                <td><asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>New Password:</td>
                <td><asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtNewPassword" CssClass="alert-danger" ErrorMessage="Password must be at least 8 characters long and contain an uppercase letter, a lowercase letter and a number" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>

        <asp:Button ID="btnSubmit" runat="server" Text="Change Password" OnClick="btnSubmit_Click" />

</asp:Content>
