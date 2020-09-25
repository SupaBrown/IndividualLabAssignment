<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="IndividualLabAssignment.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div class="row""><img src="Images/contactus.jpg"/></div>
    <address>
        45 East Avenue<br />
        Kingston 10 <br />St. Andrew<br />
        Jamaica<br />
        <abbr title="Phone">Tel#:</abbr>
        (876)878-8383 or<br /> 
        (876)998-3361
    </address>

    <address>
        <strong>Website:</strong>   <a href="bscarrental.com">bscarrental.com</a><br />
        <strong>Facebook:</strong> <a href="bscarrental/facebook.com">facebook.com</a><br />
        <strong>email:</strong> <a href="bscarrental@gmail.com">bscarrental@gmail.com</a>
    </address>
</asp:Content>
