<%@ Page Title="Employee List" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditEmployees.aspx.cs" Inherits="GroupFinal.Employees.EditEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    Edit Your Employees</p>
    <div style="width:90%;overflow:auto">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="employeeID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" >
                <ControlStyle CssClass="nonwhite" />
                </asp:CommandField>
                <asp:BoundField DataField="employeeID" HeaderText="employeeID" InsertVisible="False" ReadOnly="True" SortExpression="employeeID" />
                <asp:BoundField DataField="storeNum" HeaderText="storeNum" SortExpression="storeNum"/>
                <asp:BoundField DataField="employeeFirst" HeaderText="employeeFirst" SortExpression="employeeFirst"/>
                <asp:BoundField DataField="employeeLast" HeaderText="employeeLast" SortExpression="employeeLast" />
                <asp:BoundField DataField="employeeStatus" HeaderText="employeeStatus" SortExpression="employeeStatus" />
                <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                <asp:BoundField DataField="Login" HeaderText="Login" SortExpression="Login" />
            </Columns>
            <EmptyDataTemplate>
                &nbsp;
            </EmptyDataTemplate>
            <HeaderStyle BackColor="#029350" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OsheaDB2644 %>" DeleteCommand="DELETE FROM [Employee] WHERE [employeeID] = @employeeID" InsertCommand="INSERT INTO [Employee] ([storeNum], [employeeFirst], [employeeLast], [employeeStatus], [Role], [Login], [Password]) VALUES (@storeNum, @employeeFirst, @employeeLast, @employeeStatus, @Role, @Login, @Password)" SelectCommand="SELECT [employeeID], [storeNum], [employeeFirst], [employeeLast], [employeeStatus], [Role], [Login], [Password] FROM [Employee] WHERE ([storeNum] = @storeNum) ORDER BY [employeeLast], [employeeFirst]" UpdateCommand="UPDATE [Employee] SET [storeNum] = @storeNum, [employeeFirst] = @employeeFirst, [employeeLast] = @employeeLast, [employeeStatus] = @employeeStatus, [Role] = @Role, [Login] = @Login, [Password] = @Password WHERE [employeeID] = @employeeID">
            <DeleteParameters>
                <asp:Parameter Name="employeeID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="storeNum" Type="String" />
                <asp:Parameter Name="employeeFirst" Type="String" />
                <asp:Parameter Name="employeeLast" Type="String" />
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
                <asp:Parameter Name="employeeStatus" Type="String" />
                <asp:Parameter Name="Role" Type="String" />
                <asp:Parameter Name="Login" Type="String" />
                <asp:Parameter Name="Password" Type="String" />
                <asp:Parameter Name="employeeID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        </div>

</asp:Content>
