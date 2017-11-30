<%@ Page Title="Sign-on" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="customerLogin.aspx.cs" Inherits="GroupFinal.CustomerPages.customerLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="cLogin">

    <h3>
        Sigh-In To Your Shenanigan&#39;s Account</h3>
    <p>
        <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
    </p>
   <table>
        <tr>
            <td class="tLabel" style="width: 8em">Email: </td>
            <td style="width: 280px; padding-bottom: 2px;">
                <asp:TextBox ID="txtEmail" runat="server" Width="260px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" CssClass="alert-danger" ErrorMessage="Must enter an email address"></asp:RequiredFieldValidator>
            </td>
       </tr>
       <tr>
            <td class="tLabel" style="width: 8em">Password: </td>
            <td style="width: 280px">
                <asp:TextBox ID="txtPassword" runat="server" Width="260px" TextMode="password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="alert-danger" ErrorMessage="Please enter your password"></asp:RequiredFieldValidator>
            </td>
       </tr>
        <tr>
            <td colspan="3" class="cLogButton">
          
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />

            </td>
        </tr>
        
      </table>

    </div>
</asp:Content>
