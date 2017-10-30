<%@ Page Title="Employee Listing" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeListing.aspx.cs" Inherits="GroupFinal.Views.EmployeeListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  class="empListing">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="414px" HorizontalAlign="Center" Width="1188px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="employeeFirst" HeaderText="employeeFirst" SortExpression="employeeFirst" />
                <asp:BoundField DataField="employeeLast" HeaderText="employeeLast" SortExpression="employeeLast" />
                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="employeeStatus" HeaderText="employeeStatus" SortExpression="employeeStatus" />
                <asp:BoundField DataField="storeNum" HeaderText="storeNum" SortExpression="storeNum" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" BorderStyle="Groove" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644ConnectionString %>" SelectCommand="SELECT [employeeFirst], [employeeLast], [Role], [employeeStatus], [storeNum] FROM [Employee] WHERE ([Role] NOT LIKE '%' + @Role + '%')">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="store manager" Name="Role" QueryStringField="role" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    
</div>

   
</asp:Content>
