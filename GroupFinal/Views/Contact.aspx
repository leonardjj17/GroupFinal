<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="GroupFinal.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contact">
        <div class="col-md-6">
    <h2><%: Title %>.</h2>
    <h3>O'Shea Shenanigan's LLC</h3>
    <address>
        900 S. Isle Way <br />
        Dublin, OH  33333<br />
        <abbr title="Phone"> P: </abbr>
        (333) 333-3333
    </address>
            </div>
        <section class="col-md-5">
        
            <address>
                <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@osheas.com</a><br />
                <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@osheas.com</a>
            </address>
        </section>
        </div>
</asp:Content>
