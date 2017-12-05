<%@ Page Title="Pizza" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PizzaView.aspx.cs" Inherits="GroupFinal.Views.PizzaView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-4">
        <br />

    <asp:Image ID="pizzaImage" runat="server" ImageUrl="~/images/pizza.png" Width="300px" Height="200px" />
    &nbsp;&nbsp;&nbsp;
    <br />
        <div class="col1">
    Select your Size<asp:Panel ID="pnlSize" runat="server" Width="300px">
        <asp:RadioButton ID="rdoSmall" runat="server" GroupName="pizzaSize" Text="Small (12&quot;) $8.99" />
        <br />
        <asp:RadioButton ID="rdoMedium" runat="server" GroupName="pizzaSize" Text="Medium (15&quot;) $11.99" Checked="True" />
        <br />
        <asp:RadioButton ID="rdoLarge" runat="server" GroupName="pizzaSize" Text="Large (18&quot;) $14.99" />
    </asp:Panel>
    <br />
    Select your Crust<br />
    <asp:Panel ID="pnlCrusts" runat="server" Width="200px">
    </asp:Panel>
    <br />
    </div>
  
             </div>
    <div class="col-md-4">
        <div class="col2">
    Select your Sauce
    <br />
    <asp:Panel ID="pnlSauce" runat="server" Width="200px">
    </asp:Panel>
    <br />
   
    Select your Cheese<br />
    <asp:Panel ID="pnlCheese" runat="server" Width="200px">
        <asp:RadioButton ID="rdoNone" runat="server" GroupName="grpCheese"  Text="None" />
        <br />
        <asp:RadioButton ID="rdoRegular" runat="server" GroupName="grpCheese" Text="Regular Mozzerella" Checked="True" />
        <br />
    </asp:Panel>
        <br />
            </div>
            </div>
    <div class="col-md-4">
        <div class="col2">
        Select your topping $0.75 each<br />
    <asp:Panel ID="pnlToppings" runat="server" Width="200px">
    </asp:Panel>
    <br />
    <br />
    
    Can we tempt you?<br />
    <asp:Panel ID="pnlExtras" runat="server" Width="200px">
        <asp:CheckBox ID="chkExtraSauce" runat="server" Text="Extra Sauce" />
        <br />
        <asp:CheckBox ID="chkExtraCheese" runat="server" Text="Extra Cheese" />
    </asp:Panel>
         </div>
        </div>
    <br />
    <br />
    <br />
  
    <asp:Button ID="btnSubmit" class="makePizzaBtn" runat="server" OnClick="btnSubmit_Click" Text="Make this Pizza" Font-Bold="True" />
    
    <br />
       
&nbsp;
</asp:Content>
