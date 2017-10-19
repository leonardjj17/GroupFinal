<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GroupFinal.Employees.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <h1>Login</h1>
    <hr />
    <table style="width: 100%">
        <tr>
            <td style="width: 123px">Username</td>
            <td style="width: 286px">
                <asp:TextBox ID="txtUsername" runat="server" Width="230px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 123px">Password</td>
            <td style="width: 286px">
                <asp:TextBox ID="txtPassword" runat="server" Width="230px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
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
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="106px" Height="29px" OnClick="btnLogin_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
