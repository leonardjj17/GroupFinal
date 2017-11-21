<%@ Page Title="Merchandise" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PromoItems.aspx.cs" Inherits="GroupFinal.Views.PromoItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="center">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gear Shenanigans</h1>
    <table style="width:100%;">
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">
                &nbsp;</td>
            <td class="modal-sm" style="width: 276px">
    <img src="../images/shirt.jpg" width="250" height="250"/></td>
            <td style="width: 155px">
                <br />
                <br />
                <br />
                <br />
                <br />
                Size&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSizeShirt1" runat="server">
                    <asp:ListItem> </asp:ListItem>
                    <asp:ListItem>XS</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>L</asp:ListItem>
                    <asp:ListItem>XL</asp:ListItem>
                    <asp:ListItem>XXL</asp:ListItem>
                    <asp:ListItem>XXXL</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                Qty&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlQtyShirt1" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0"> 0</asp:ListItem>
                    <asp:ListItem Value="1"> 1</asp:ListItem>
                    <asp:ListItem Value="2"> 2</asp:ListItem>
                    <asp:ListItem Value="3"> 3</asp:ListItem>
                    <asp:ListItem Value="4"> 4</asp:ListItem>
                    <asp:ListItem Value="5"> 5</asp:ListItem>
                    <asp:ListItem Value="6"> 6</asp:ListItem>
                    <asp:ListItem Value="7"> 7</asp:ListItem>
                    <asp:ListItem Value="8"> 8</asp:ListItem>
                    <asp:ListItem Value="9"> 9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">
                &nbsp;</td>
            <td class="modal-sm" style="width: 276px">
                <img alt="Tshirt2" src="../images/oshea_tshirt1.jpg" style="width: 225px; height: 225px" /></td>
            <td style="width: 155px">
                <br />
                <br />
                <br />
                <br />
                Size&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSizeShirt2" runat="server">
                    <asp:ListItem> </asp:ListItem>
                    <asp:ListItem>XS</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>L</asp:ListItem>
                    <asp:ListItem>XL</asp:ListItem>
                    <asp:ListItem>XXL</asp:ListItem>
                    <asp:ListItem>XXXL</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                Qty&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlQtyShirt2" runat="server" AutoPostBack="True" >
                    <asp:ListItem Value="0"> 0</asp:ListItem>
                    <asp:ListItem Value="1"> 1</asp:ListItem>
                    <asp:ListItem Value="2"> 2</asp:ListItem>
                    <asp:ListItem Value="3"> 3</asp:ListItem>
                    <asp:ListItem Value="4"> 4</asp:ListItem>
                    <asp:ListItem Value="5"> 5</asp:ListItem>
                    <asp:ListItem Value="6"> 6</asp:ListItem>
                    <asp:ListItem Value="7"> 7</asp:ListItem>
                    <asp:ListItem Value="8"> 8</asp:ListItem>
                    <asp:ListItem Value="9"> 9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">
                &nbsp;</td>
            <td class="modal-sm" style="width: 276px">
                <img alt="Tshirt3" src="../images/oshea_img3.jpg" style="width: 225px; height: 225px" /></td>
            <td style="width: 155px">
                <br />
                <br />
                <br />
                <br />
                Size&nbsp; &nbsp;
                <asp:DropDownList ID="ddlSizeShirt3" runat="server">
                    <asp:ListItem> </asp:ListItem>
                    <asp:ListItem>XS</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>L</asp:ListItem>
                    <asp:ListItem>XL</asp:ListItem>
                    <asp:ListItem>XXL</asp:ListItem>
                    <asp:ListItem>XXXL</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                Qty&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlQtyShirt3" runat="server" AutoPostBack="True" >
                    <asp:ListItem Value="0"> 0</asp:ListItem>
                    <asp:ListItem Value="1"> 1</asp:ListItem>
                    <asp:ListItem Value="2"> 2</asp:ListItem>
                    <asp:ListItem Value="3"> 3</asp:ListItem>
                    <asp:ListItem Value="4"> 4</asp:ListItem>
                    <asp:ListItem Value="5"> 5</asp:ListItem>
                    <asp:ListItem Value="6"> 6</asp:ListItem>
                    <asp:ListItem Value="7"> 7</asp:ListItem>
                    <asp:ListItem Value="8"> 8</asp:ListItem>
                    <asp:ListItem Value="9"> 9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">
                &nbsp;</td>
            <td class="modal-sm" style="width: 276px">
                <img alt="Tshirt4" src="../images/oshea_img4.png" style="width: 246px; height: 205px" /></td>
            <td style="width: 155px">
                <br />
                <br />
                <br />
                Size&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlSizeShirt4" runat="server">
                    <asp:ListItem> </asp:ListItem>
                    <asp:ListItem>XS</asp:ListItem>
                    <asp:ListItem>S</asp:ListItem>
                    <asp:ListItem>M</asp:ListItem>
                    <asp:ListItem>L</asp:ListItem>
                    <asp:ListItem>XL</asp:ListItem>
                    <asp:ListItem>XXL</asp:ListItem>
                    <asp:ListItem>XXXL</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                Qty&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlQtyShirt4" runat="server" AutoPostBack="True" >
                    <asp:ListItem Value="0"> 0</asp:ListItem>
                    <asp:ListItem Value="1"> 1</asp:ListItem>
                    <asp:ListItem Value="2"> 2</asp:ListItem>
                    <asp:ListItem Value="3"> 3</asp:ListItem>
                    <asp:ListItem Value="4"> 4</asp:ListItem>
                    <asp:ListItem Value="5"> 5</asp:ListItem>
                    <asp:ListItem Value="6"> 6</asp:ListItem>
                    <asp:ListItem Value="7"> 7</asp:ListItem>
                    <asp:ListItem Value="8"> 8</asp:ListItem>
                    <asp:ListItem Value="9"> 9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 85px">&nbsp;</td>
            <td class="modal-sm" style="width: 276px">&nbsp;</td>
            <td style="width: 155px">
                <asp:Button ID="btnOrder" runat="server" Text="Order Items" OnClick="btnOrder_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    &nbsp;
</asp:Content>
