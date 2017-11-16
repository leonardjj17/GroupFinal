<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="GroupFinal.Manager.OrderHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="center">Order History</h1>
        <br />

       <table style="width:100%;">
        <tr>
            <td><h2>Order Date</h2></td>
        </tr>
        <tr>
            <td style="width: 367px">
        <asp:Calendar ID="calOrderDate" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" SelectedDate="11/13/2017 18:53:07" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 367px; height: 39px">&nbsp;</td>
            <td style="height: 39px">&nbsp;</td>
            <td style="height: 39px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 367px; height: 39px"><h2>Store Number</h2></td>
            <td style="height: 39px"></td>
            <td style="height: 39px"></td>
        </tr>
        <tr>
            <td style="width: 367px">
                <asp:DropDownList ID="ddlStore" runat="server" DataSourceID="OSheaStoreNum" DataTextField="storeID" DataValueField="storeID" Width="267px" AutoPostBack="True" OnSelectedIndexChanged="ddlStore_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="OSheaStoreNum" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" SelectCommand="SELECT [storeID] FROM [Store]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
    <p class="center">
        &nbsp;</p>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="orderID" DataSourceID="OsheaDB">
        <AlternatingItemTemplate>
            <span style="">orderID:
            <asp:Label ID="orderIDLabel" runat="server" Text='<%# Eval("orderID") %>' />
            <br />
            customerFirst:
            <asp:Label ID="customerFirstLabel" runat="server" Text='<%# Eval("customerFirst") %>' />
            <br />
            customerLast:
            <asp:Label ID="customerLastLabel" runat="server" Text='<%# Eval("customerLast") %>' />
            <br />
            orderTotal:
            <asp:Label ID="orderTotalLabel" runat="server" Text='<%# Eval("orderTotal") %>' />
            <br />
            storeNum:
            <asp:Label ID="storeNumLabel" runat="server" Text='<%# Eval("storeNum") %>' />
            <br />
            orderType:
            <asp:Label ID="orderTypeLabel" runat="server" Text='<%# Eval("orderType") %>' />
            <br />
            orderDate:
            <asp:Label ID="orderDateLabel" runat="server" Text='<%# Eval("orderDate") %>' />
            <br />
            <br />
            </span>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <span style="">orderID:
            <asp:Label ID="orderIDLabel1" runat="server" Text='<%# Eval("orderID") %>' />
            <br />
            customerFirst:
            <asp:TextBox ID="customerFirstTextBox" runat="server" Text='<%# Bind("customerFirst") %>' />
            <br />
            customerLast:
            <asp:TextBox ID="customerLastTextBox" runat="server" Text='<%# Bind("customerLast") %>' />
            <br />
            orderTotal:
            <asp:TextBox ID="orderTotalTextBox" runat="server" Text='<%# Bind("orderTotal") %>' />
            <br />
            storeNum:
            <asp:TextBox ID="storeNumTextBox" runat="server" Text='<%# Bind("storeNum") %>' />
            <br />
            orderType:
            <asp:TextBox ID="orderTypeTextBox" runat="server" Text='<%# Bind("orderType") %>' />
            <br />
            orderDate:
            <asp:TextBox ID="orderDateTextBox" runat="server" Text='<%# Bind("orderDate") %>' />
            <br />
            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
            <br />
            <br />
            </span>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <span>No data was returned.</span>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <span style="">customerFirst:
            <asp:TextBox ID="customerFirstTextBox" runat="server" Text='<%# Bind("customerFirst") %>' />
            <br />
            customerLast:
            <asp:TextBox ID="customerLastTextBox" runat="server" Text='<%# Bind("customerLast") %>' />
            <br />
            orderTotal:
            <asp:TextBox ID="orderTotalTextBox" runat="server" Text='<%# Bind("orderTotal") %>' />
            <br />
            storeNum:
            <asp:TextBox ID="storeNumTextBox" runat="server" Text='<%# Bind("storeNum") %>' />
            <br />
            orderType:
            <asp:TextBox ID="orderTypeTextBox" runat="server" Text='<%# Bind("orderType") %>' />
            <br />
            orderDate:
            <asp:TextBox ID="orderDateTextBox" runat="server" Text='<%# Bind("orderDate") %>' />
            <br />
            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
            <br />
            <br />
            </span>
        </InsertItemTemplate>
        <ItemTemplate>
            <span style="">orderID:
            <asp:Label ID="orderIDLabel" runat="server" Text='<%# Eval("orderID") %>' />
            <br />
            customerFirst:
            <asp:Label ID="customerFirstLabel" runat="server" Text='<%# Eval("customerFirst") %>' />
            <br />
            customerLast:
            <asp:Label ID="customerLastLabel" runat="server" Text='<%# Eval("customerLast") %>' />
            <br />
            orderTotal:
            <asp:Label ID="orderTotalLabel" runat="server" Text='<%# Eval("orderTotal") %>' />
            <br />
            storeNum:
            <asp:Label ID="storeNumLabel" runat="server" Text='<%# Eval("storeNum") %>' />
            <br />
            orderType:
            <asp:Label ID="orderTypeLabel" runat="server" Text='<%# Eval("orderType") %>' />
            <br />
            orderDate:
            <asp:Label ID="orderDateLabel" runat="server" Text='<%# Eval("orderDate") %>' />
            <br />
            <br />
            </span>
        </ItemTemplate>
        <LayoutTemplate>
            <div id="itemPlaceholderContainer" runat="server" style="">
                <span runat="server" id="itemPlaceholder" />
            </div>
            <div style="">
            </div>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <span style="">orderID:
            <asp:Label ID="orderIDLabel" runat="server" Text='<%# Eval("orderID") %>' />
            <br />
            customerFirst:
            <asp:Label ID="customerFirstLabel" runat="server" Text='<%# Eval("customerFirst") %>' />
            <br />
            customerLast:
            <asp:Label ID="customerLastLabel" runat="server" Text='<%# Eval("customerLast") %>' />
            <br />
            orderTotal:
            <asp:Label ID="orderTotalLabel" runat="server" Text='<%# Eval("orderTotal") %>' />
            <br />
            storeNum:
            <asp:Label ID="storeNumLabel" runat="server" Text='<%# Eval("storeNum") %>' />
            <br />
            orderType:
            <asp:Label ID="orderTypeLabel" runat="server" Text='<%# Eval("orderType") %>' />
            <br />
            orderDate:
            <asp:Label ID="orderDateLabel" runat="server" Text='<%# Eval("orderDate") %>' />
            <br />
            <br />
            </span>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="OsheaDB" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" SelectCommand="SELECT [orderID], [customerFirst], [customerLast], [orderTotal], [storeNum], [orderType], [orderDate] FROM [Orders] WHERE (([storeNum] = @storeNum) AND ([orderDate] = @orderDate))">
        <SelectParameters>
            <asp:ControlParameter ControlID="ddlStore" Name="storeNum" PropertyName="SelectedValue" Type="String" />
            <asp:ControlParameter ControlID="calOrderDate" DbType="Date" Name="orderDate" PropertyName="SelectedDate" />
        </SelectParameters>
    </asp:SqlDataSource>
    <br />

</asp:Content>
