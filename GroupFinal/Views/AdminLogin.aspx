<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="GroupFinal.Views.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Store Number:"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtStoreNumber" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Store Number is Required" ControlToValidate="txtStoreNumber" Display="Dynamic"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Employee ID: "></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmployeeID" Display="Dynamic" ErrorMessage="Employee ID is Required"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Password: "></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
    <br />
    <br />
    <br />
    <input id="btnLogin" type="submit" value="Login" /><br />
    <br />
</asp:Content>
