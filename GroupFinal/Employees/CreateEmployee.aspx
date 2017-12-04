<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="GroupFinal.Employees.CreateEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Fill out the form for your new employee</h2>
    <p>
        <asp:Label ID="lblError" runat="server" CssClass="alert-danger" Visible="False"></asp:Label>
    </p>

    <div class="container">
        <div class="row">
            <div class="col-sm">
                <table style="text-align: left">
                    <tr>
                        <td style="width: 8em">First Name:</td>
                        <td style="width: 178px">
                            <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFirst" CssClass="alert-danger" ErrorMessage="*Must enter a first name!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Last Name:        
                        </td>
                        <td style="width: 178px">
                            <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLast" CssClass="alert-danger" ErrorMessage="*Must enter a last name!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Status:        
                        </td>
                        <td style="width: 178px">
                            <asp:DropDownList ID="cmboStatus" runat="server">
                                <asp:ListItem>Part-Time</asp:ListItem>
                                <asp:ListItem>Full-Time</asp:ListItem>
                                <asp:ListItem>Store Manager</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Job:        
                        </td>
                        <td style="width: 178px">
                            <asp:DropDownList ID="cmboJob" runat="server">
                                <asp:ListItem Value="DeliveryDriver">Delivery Driver</asp:ListItem>
                                <asp:ListItem>Server</asp:ListItem>
                                <asp:ListItem>Bartender</asp:ListItem>
                                <asp:ListItem>Cook</asp:ListItem>
                                <asp:ListItem Value="StoreManager">Store Manager</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td></td>
                    </tr>
                    <tr>
                        <td>Login:        
                        </td>
                        <td style="width: 178px">
                            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Must enter a login username!" ControlToValidate="txtLogin" CssClass="alert-danger"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Password:
                        </td>
                        <td style="width: 178px">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" CssClass="alert-danger" Display="Dynamic" ErrorMessage="*Must enter a password!"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password must be at least 8 characters long and contain an uppercase letter, a lowercase letter and a number" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$" CssClass="alert-danger" Display="Dynamic"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="row">
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </div>
</asp:Content>
