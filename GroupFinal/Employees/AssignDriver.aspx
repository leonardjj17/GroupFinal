<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssignDriver.aspx.cs" Inherits="GroupFinal.Employees.AssignDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Select Driver:</h1>
        <asp:HiddenField id="orderID" runat="server" Value=""/>
        <asp:DropDownList ID="driverList" runat="server">
    </asp:DropDownList>
<asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
</asp:Content>
