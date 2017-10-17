<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Employees_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
        <h1>Login</h1>
    <table style="width: 100%">
        <tr>
            <td style="width: 123px">Username</td>
            <td style="width: 286px">
                <asp:TextBox ID="txtUsername" runat="server" Width="230px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Username" ErrorMessage="Username is required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 123px">Password</td>
            <td style="width: 286px">
                <asp:TextBox ID="txtPassword" runat="server" Width="230px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 286px">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 123px">&nbsp;</td>
            <td style="width: 286px">
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="106px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <p>
    </p>
</asp:Content>

