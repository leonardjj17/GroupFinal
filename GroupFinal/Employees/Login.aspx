<%@ Page Title="Employee Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GroupFinal.Employees.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="eLogin">
    
    <h3>Employee Login</h3>
    
    <table>
        <tr>
            <td class="tLabel" style="width: 7em; text-align: left">Username: </td>
            <td style="width: 280px; padding-bottom: 2px;">
                <asp:TextBox ID="txtUsername" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="tLabel" style="width: 7em; text-align: left">Password: </td>
            <td style="width: 280px">
                <asp:TextBox ID="txtPassword" runat="server" Width="260px" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        
    <tr>
        <td colspan="3" class="eLogButton">
          
                <asp:Button ID="btnLogin"  runat="server" Text="Login" Width="106px" Height="33px" OnClick="btnLogin_Click" />

        </td>

    </tr>
        
        </table>
        </div>
</asp:Content>
