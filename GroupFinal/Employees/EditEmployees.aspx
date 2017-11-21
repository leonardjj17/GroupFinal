<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployees.aspx.cs" Inherits="GroupFinal.Employees.EditEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Edit Your Employees</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="employeeID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="employeeID" HeaderText="employeeID" InsertVisible="False" ReadOnly="True" SortExpression="employeeID" />
            <asp:BoundField DataField="employeeFirst" HeaderText="employeeFirst" SortExpression="employeeFirst" />
            <asp:BoundField DataField="employeeLast" HeaderText="employeeLast" SortExpression="employeeLast" />
            <asp:BoundField DataField="employeeHireDate" HeaderText="employeeHireDate" SortExpression="employeeHireDate" />
            <asp:BoundField DataField="employeeStatus" HeaderText="employeeStatus" SortExpression="employeeStatus" />
            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
            <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="storeNum" HeaderText="storeNum" SortExpression="storeNum" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" DeleteCommand="DELETE FROM [Employee] WHERE [employeeID] = @original_employeeID AND [storeNum] = @original_storeNum AND [employeeFirst] = @original_employeeFirst AND [employeeLast] = @original_employeeLast AND [employeeHireDate] = @original_employeeHireDate AND [employeeStatus] = @original_employeeStatus AND [Role] = @original_Role AND [Login] = @original_Login AND [Password] = @original_Password" InsertCommand="INSERT INTO [Employee] ([storeNum], [employeeFirst], [employeeLast], [employeeHireDate], [employeeStatus], [Role], [Login], [Password]) VALUES (@storeNum, @employeeFirst, @employeeLast, @employeeHireDate, @employeeStatus, @Role, @Login, @Password)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Employee] WHERE ([storeNum] = @storeNum) ORDER BY [Role], [employeeLast], [employeeFirst]" UpdateCommand="UPDATE [Employee] SET [storeNum] = @storeNum, [employeeFirst] = @employeeFirst, [employeeLast] = @employeeLast, [employeeHireDate] = @employeeHireDate, [employeeStatus] = @employeeStatus, [Role] = @Role, [Login] = @Login, [Password] = @Password WHERE [employeeID] = @original_employeeID AND [storeNum] = @original_storeNum AND [employeeFirst] = @original_employeeFirst AND [employeeLast] = @original_employeeLast AND [employeeHireDate] = @original_employeeHireDate AND [employeeStatus] = @original_employeeStatus AND [Role] = @original_Role AND [Login] = @original_Login AND [Password] = @original_Password">
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
            <asp:SessionParameter Name="storeNum" SessionField="storeNum" Type="String" />
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
</p>
</asp:Content>
