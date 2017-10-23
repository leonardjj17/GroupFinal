<%@ Page Title="Employee Listing" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeListing.aspx.cs" Inherits="GroupFinal.Views.EmployeeListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2><%: Title %> </h2>
         <table style="width:99%;">
         
         <tr>
                <td>employee name</td>
             <td>role</td>
             <td>
                 <asp:Button ID="btnEditEmp" runat="server" Text="Edit" Width="86px" />
                 <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="103px" />
                
             </td>
          
         </tr>
        
         </table>
    

   
</asp:Content>
