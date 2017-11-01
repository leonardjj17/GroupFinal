<%@ Page Title="Pizza" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PizzaView.aspx.cs" Inherits="GroupFinal.Views.PizzaView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="pizzaImage" runat="server" ImageUrl="~/images/blankPizza.png" Width="200px" />
    &nbsp;&nbsp;&nbsp;
    <br />
    Select your Size<asp:Panel ID="pnlSize" runat="server" Width="200px">
        <asp:RadioButton ID="rdoSmall" runat="server" GroupName="pizzaSize" Text="Small (12&quot;)" />
        <br />
        <asp:RadioButton ID="rdoMedium" runat="server" GroupName="pizzaSize" Text="Medium (15&quot;)" />
        <br />
        <asp:RadioButton ID="rdoLarge" runat="server" GroupName="pizzaSize" Text="Large (18&quot;)" />
    </asp:Panel>
    <br />
    Select your Crust<br />
    <asp:RadioButtonList ID="rdoCrustList" runat="server" DataSourceID="SqlDataSource3" DataTextField="productDetail" DataValueField="productDetail">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644ConnectionString %>" SelectCommand="SELECT [productDetail] FROM [Products] WHERE ([productType] = @productType)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="crust" Name="productType" QueryStringField="crust" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    <br />
    Select your Sauce
    <br />
    <asp:RadioButtonList ID="rdoSauceList" runat="server" 
        DataSourceID="SqlDataSource2" DataTextField="productDetail" 
        DataValueField="productDetail">
    </asp:RadioButtonList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:OsheaDB2644ConnectionString %>" 
        SelectCommand="SELECT [productDetail] FROM [Products] WHERE ([productType] = @productType)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="sauce" Name="productType" 
                QueryStringField="sauce" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    Select your Cheese<br />
    <asp:Panel ID="pnlCheese" runat="server" Width="200px">
        <asp:RadioButton ID="rdoNone" runat="server" GroupName="grpCheese"  Text="None" />
        <br />
        <asp:RadioButton ID="rdoRegular" runat="server" GroupName="grpCheese" Text="Regular Mozzerella" />
        <br />
    </asp:Panel>
    <br />
    <br />
    Select your toppings<asp:CheckBoxList ID="chkToppingsList" runat="server" DataSourceID="SqlDataSource1" DataTextField="productDetail" DataValueField="productDetail">
    </asp:CheckBoxList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644ConnectionString %>" SelectCommand="SELECT [productDetail] FROM [Products] WHERE ([productType] = @productType)">
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="ingredients" Name="productType" QueryStringField="ingredients" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />
    Can we tempt you?<br />
    <asp:Panel ID="pnlExtras" runat="server" Width="200px">
        <asp:CheckBox ID="chkExtraSauce" runat="server" Text="Extra Sauce" />
        <br />
        <asp:CheckBox ID="chkExtraCheese" runat="server" Text="Extra Cheese" />
    </asp:Panel>
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Make this Pizza" />
    <br />
&nbsp;
</asp:Content>
