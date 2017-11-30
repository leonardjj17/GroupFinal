<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="GroupFinal.Employees.CreateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Fill out the form for your new employee</h2>
    <p>
        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Visible="False"></asp:Label>
    </p>

    <div class="container">
        <div class="row">
            <div class="col-sm">
                First Name:        
            </div>
            <div class="col-sm">
                <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFirst" CssClass="alert-danger" ErrorMessage="*Must enter a first name!"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-sm">
                Last Name:        
            </div>
            <div class="col-sm">
                <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLast" CssClass="alert-danger" ErrorMessage="*Must enter a last name!"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-sm">
                Status:        
            </div>
            <div class="col-sm">
                <asp:DropDownList ID="cmboStatus" runat="server">
                    <asp:ListItem>Part-Time</asp:ListItem>
                    <asp:ListItem>Full-Time</asp:ListItem>
                    <asp:ListItem>Store Manager</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-sm">
                Job:        
            </div>
            <div class="col-sm">
                <asp:DropDownList ID="cmboJob" runat="server">
                    <asp:ListItem Value="DeliveryDriver">Delivery Driver</asp:ListItem>
                    <asp:ListItem>Server</asp:ListItem>
                    <asp:ListItem>Bartender</asp:ListItem>
                    <asp:ListItem>Cook</asp:ListItem>
                    <asp:ListItem Value="StoreManager">Store Manager</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="col-sm">
                Login:        
            </div>
            <div class="col-sm">
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Must enter a login username!" ControlToValidate="txtLogin" CssClass="alert-danger"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-sm">
                Password:
            </div>
            <div class="col-sm">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ToolTip="Password must contain at least 1 Uppercase, 1 lowercase,  1 numeric digit, and be at least 8 characters long"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="alert-danger" Display="Dynamic" ErrorMessage="*Must enter a password!"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <br />
&nbsp;<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
</div>
</asp:Content>
