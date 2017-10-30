<%@ Page Title="Employee Listing" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeListing.aspx.cs" Inherits="GroupFinal.Views.EmployeeListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div  class="empListing">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="414px" HorizontalAlign="Center" Width="1188px" AllowSorting="True" DataKeyNames="employeeID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="employeeID" HeaderText="employeeID" InsertVisible="False" ReadOnly="True" SortExpression="employeeID" Visible="False" />
                <asp:BoundField DataField="employeeFirst" HeaderText="First Name" SortExpression="employeeFirst" >
                </asp:BoundField>
                <asp:BoundField DataField="employeeLast" HeaderText="Last Name" SortExpression="employeeLast" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                <FooterStyle HorizontalAlign="Center" />
                <HeaderStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="employeeHireDate" HeaderText="employeeHireDate" SortExpression="employeeHireDate" Visible="False" />
                <asp:BoundField DataField="employeeStatus" HeaderText="Status" SortExpression="employeeStatus" />
                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="storeNum" HeaderText="Store #" SortExpression="storeNum" />
                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" Visible="False" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" Visible="False" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="DarkGreen" BorderStyle="Groove" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" 
            SelectCommand="SELECT * FROM [Employee] WHERE ([Role] NOT LIKE '%' + @Role + '%')"
            
            UpdateCommand="UPDATE [Employee] SET [storeNum] = @storeNum, [employeeFirst] = @employeeFirst, [employeeLast] = @employeeLast, [employeeHireDate] = @employeeHireDate, [employeeStatus] = @employeeStatus, [Role] = @Role, [Login] = @Login, [Password] = @Password WHERE [employeeID] = @original_employeeID AND [storeNum] = @original_storeNum AND [employeeFirst] = @original_employeeFirst AND [employeeLast] = @original_employeeLast AND [employeeHireDate] = @original_employeeHireDate AND [employeeStatus] = @original_employeeStatus AND [Role] = @original_Role AND [Login] = @original_Login AND [Password] = @original_Password" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [Employee] WHERE [employeeID] = @original_employeeID AND [storeNum] = @original_storeNum AND [employeeFirst] = @original_employeeFirst AND [employeeLast] = @original_employeeLast AND [employeeHireDate] = @original_employeeHireDate AND [employeeStatus] = @original_employeeStatus AND [Role] = @original_Role AND [Login] = @original_Login AND [Password] = @original_Password" InsertCommand="INSERT INTO [Employee] ([storeNum], [employeeFirst], [employeeLast], [employeeHireDate], [employeeStatus], [Role], [Login], [Password]) VALUES (@storeNum, @employeeFirst, @employeeLast, @employeeHireDate, @employeeStatus, @Role, @Login, @Password)" OldValuesParameterFormatString="original_{0}">
            <DeleteParameters>
                <asp:Parameter Name="original_employeeID" Type="Int32" />
                <asp:Parameter Name="original_storeNum" Type="String" />
                <asp:Parameter Name="original_employeeFirst" Type="String" />
                <asp:Parameter Name="original_employeeLast" Type="String" />
                <asp:Parameter Name="original_employeeHireDate" Type="DateTime" />
                <asp:Parameter Name="original_employeeStatus" Type="String" />
                <asp:Parameter Name="original_Role" Type="String" />
                <asp:Parameter Name="original_Login" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="storeNum" Type="String" />
                <asp:Parameter Name="employeeFirst" Type="String" />
                <asp:Parameter Name="employeeLast" Type="String" />
                <asp:Parameter Name="employeeHireDate" Type="DateTime" />
                <asp:Parameter Name="employeeStatus" Type="String" />
                <asp:Parameter Name="Role" Type="String" />
                <asp:Parameter Name="Login" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="store manager" Name="Role" QueryStringField="role" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="storeNum" Type="String" />
                <asp:Parameter Name="employeeFirst" Type="String" />
                <asp:Parameter Name="employeeLast" Type="String" />
                <asp:Parameter Name="employeeHireDate" Type="DateTime" />
                <asp:Parameter Name="employeeStatus" Type="String" />
                <asp:Parameter Name="Role" Type="String" />
                <asp:Parameter Name="Login" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="original_employeeID" Type="Int32" />
                <asp:Parameter Name="original_storeNum" Type="String" />
                <asp:Parameter Name="original_employeeFirst" Type="String" />
                <asp:Parameter Name="original_employeeLast" Type="String" />
                <asp:Parameter Name="original_employeeHireDate" Type="DateTime" />
                <asp:Parameter Name="original_employeeStatus" Type="String" />
                <asp:Parameter Name="original_Role" Type="String" />
                <asp:Parameter Name="original_Login" Type="String" />
                <asp:Parameter Name="original_Password" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    
</div>

   
</asp:Content>
