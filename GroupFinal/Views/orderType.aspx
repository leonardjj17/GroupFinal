<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="orderType.aspx.cs" Inherits="GroupFinal.Views.orderType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            max-width: 500px;
            max-height: 300px;
        }
        .center{
            text-align: center;
        }
        img{
            clear: both;
        }
    </style>
</head>
<body>
    <header><img alt="Titlebar" class="center" src="../images/main_title1.png" width ="500px"/></header>
    <form id="form1" runat="server">

        <h2 class ="center">
            Order Type</h2>
        <p class="center">
            <asp:RadioButton ID="rdoDelivery" runat="server" Text="Delivery" GroupName="rdogrpOrderType" OnCheckedChanged="rdoDelivery_CheckedChanged" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdoCarryOut" runat="server" Text="Carry Out" GroupName="rdogrpOrderType" OnCheckedChanged="rdoCarryOut_CheckedChanged" />
        </p>
        <p class="center">
            <asp:Label ID="Label1" runat="server" Text="Zip Code   "></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtZip" runat="server" OnTextChanged="txtZip_TextChanged"></asp:TextBox>
        </p>
        <p class="center">
            <asp:Button ID="btnOrderType" runat="server" OnClick="btnOrderType_Click" Text="Order" />
        </p>
    </form>
</body>
</html>
