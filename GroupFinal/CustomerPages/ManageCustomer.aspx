<%@ Page Title="Your Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageCustomer.aspx.cs" Inherits="GroupFinal.CustomerPages.ManageCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        Your Account
    </p>

    <table class="nav-justified">
        <tr>
            <td style="width: 187px; text-align: left;" aria-live="off">Email:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblEmail" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeEmail" runat="server" Text="Change" OnClick="btnChangeEmail_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">Change Password:</td>
            <td style="width: 187px; text-align: left;">&nbsp;</td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangePassword" runat="server" Text="Change" OnClick="btnChangePassword_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">First Name:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblFirstName" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeFirstName" runat="server" Text="Change" OnClick="btnChangeFirstName_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">Last Name:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblLastName" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeLastName" runat="server" Text="Change" OnClick="btnChangeLastName_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">Address:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblAddress" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeAddress" runat="server" Text="Change" OnClick="btnChangeAddress_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">City:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblCity" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeCity" runat="server" Text="Change" OnClick="btnChangeCity_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">State:
        &nbsp;&nbsp;</td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblState" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeState" runat="server" Text="Change" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">Zip:
            </td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblZip" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangeZip" runat="server" Text="Change" OnClick="btnChangeZip_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 187px; text-align: left;">Phone:</td>
            <td style="width: 187px; text-align: left;">
                <asp:Label ID="lblPhone" runat="server"></asp:Label>
            </td>
            <td style="width: 74px; text-align: left;">
                <asp:Button ID="btnChangePhone" runat="server" Text="Change" OnClick="btnChangePhone_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
