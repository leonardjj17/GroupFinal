


<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="GroupFinal.Views.CartView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h2>Your Current Order</h2>
    
   <%-- <% foreach (CartItem items in theCart)
        { %>--%>
    <table>
        <thead>
            <tr>
                <th>
                    Qty
                </th>
                <th>
                    Description
                </th>
                <th>
                    Price
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td> 
                  <%--<%@ items.Qty;%> --%>
                </td>
            </tr>
            <tr>
               <%-- <%@ items.Description; %>--%>
            </tr>
        </tbody>
    </table>
   <%-- <% } %>--%>
       <br />
            <asp:Button runat="server" ID="btnUpdateCart" Text="Update Cart" OnClick="btnUpdateCart_Click"  Font-Bold="true"/>
        
    
    <asp:Button ID="continueOrderBtn" class="drinkBtn" runat="server" Text="Continue Ordering" OnClick="continueOrderBtn_Click" Font-Bold="true"/>
    
   
    
    <hr />
       

    
</asp:Content>
