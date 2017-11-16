<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="generalChange.aspx.cs" Inherits="GroupFinal.CustomerPages.generalChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Change your profile</h2>
    <p>
        <asp:Label ID="lblError" runat="server" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;<asp:Label ID="lblChanging" runat="server"></asp:Label>
        :&nbsp;<asp:TextBox ID="txtChangedValue" runat="server" CssClass="form control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must have a value(click back to home if you want to leave unchanged)" ControlToValidate="txtChangedValue" CssClass="alert-danger" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="validatorEmail" runat="server" ControlToValidate="txtChangedValue" CssClass="alert-danger" Display="Dynamic" Enabled="False" ErrorMessage="Must enter a valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RegularExpressionValidator ID="validatorPhone" runat="server" ControlToValidate="txtChangedValue" CssClass="alert-danger" Display="Dynamic" ErrorMessage="Must enter a valid phone number" Enabled="False"></asp:RegularExpressionValidator>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save" CssClass="btn btn-success"/>
        <br />
    </p>
    
</asp:Content>
