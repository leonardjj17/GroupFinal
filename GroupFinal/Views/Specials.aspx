<%@ Page Title="Specials" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Specials.aspx.cs" Inherits="GroupFinal.Views.Specials" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Specials</h1>
    <p>&nbsp;</p>
    <p>
        <asp:RadioButton ID="rdoLGFamPk" runat="server" Text="Large Family Pack $29.99" Font-Bold="True" Font-Size="Large" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A large pepperoni pizza, a large supreme pizza, an order of breadsticks, and a liter of Pepsi</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="rdoFamPk" runat="server" Text="Family Pack $19.99" Font-Bold="True" Font-Size="Large" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A large pepperoni pizza, an order of breadsticks, and a liter of Pepsi&nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:RadioButton ID="rdoIndivPk" runat="server"  Text="Individual Pack $9.99" Font-Bold="True" Font-Size="Large" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; A medium pizza and a 20 oz Pepsi&nbsp;</p>
    <p>
        
        <asp:Button ID="btnSpecOrder" runat="server" Text="Order" OnClick="btnSpecOrder_Click" />
        
    </p>

</asp:Content>
