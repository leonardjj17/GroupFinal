<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="GroupFinal.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table ID="LoginEntry" runat="server">
        <asp:TableRow>
            <asp:TableCell Width="8em" HorizontalAlign="Left">
                <asp:Label ID="Label1" runat="server" Text="Store Number:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtStoreNumber" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Store Number is Required" ControlToValidate="txtStoreNumber" Display="Dynamic" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Left">
                <asp:Label ID="Label2" runat="server" Text="Admin Login:"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtAdminLogin" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminLogin" Display="Dynamic" ErrorMessage="Login Username is Required" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell HorizontalAlign="Left">
                <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Left">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Password is Required" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>&nbsp;</asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click1" Text="Login" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
