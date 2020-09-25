<%@ Page Title="Product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="IndividualLabAssignment.Product" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align:center">Our Products and Amazing Offers.</h2>
    <hr />
     <div class="row" style="text-align:center">
        <div class="col-md-4" style="text-align:center"> 
            <img src="Images/benzRed.jpg" />
            <p style=" font-size:medium; color:black ">
                Name:Mercedes-Benz CLS<br />
                ID:001<br />
                Cetegory:5<br />
                Unit Price: $21,000.00<br />
                Description:Red<br />
            </p>
        </div>
        <div class="col-md-4" style="text-align:center"> 
            <img src="Images/BMWBlue.jpg" />
            <p style=" font-size:medium; color:black ">
                Name:BMW M4 Coupe<br />
                ID:002<br />
                Cetegory: 2<br />
                Unit Price:$25,000.00<br />
                Description:Blue<br />
            </p>
        </div>
        <div class="col-md-4" style="text-align:center">
            <img src="Images/benzWhite.jpg" />  
            <p style=" font-size:medium; color:black ">
                Name: Mercedes-Benz C-Class<br />
                ID: 003<br />
                Cetegory: 5<br />
                Unit Price: $21,000.00<br />
                Description: White<br />
            </p>
        </div>
        <div class="col-md-4" style="text-align:center">
            <img src="Images/BMWRed.jpg" />
            <p style=" font-size:medium; color:black ">
                Name: BMW 5 Series<br />
                ID: 004<br />
                Cetegory: 5<br />
                Unit Price: $23, 000.00<br />
                Description: Red<br />
            </p>       
        </div>
        
        <div class="col-md-4" style="text-align:center">
            <img src="Images/benzBlue.jpg" />
            <p style="color:black;font-size:medium">
                Name: Mercedez Benz GLS<br />
                ID: 005<br />
                Cetegory: 6<br />
                Unit Price: $25, 000.00<br />
                Description: Blue<br />
            </p>
         </div>
         <div class="col-md-4" style="text-align:center; object-fit: cover">
             <img src="Images/BMWYellow.jpg" />
             <p style="color:black ;font-size:medium">
                Name: BMW M4<br />
                ID: 006<br />
                Cetegory: 2<br />
                Unit Price: $22,000.00<br />
                Description Yellow:<br />
            </p>
         </div>
    </div>
</asp:Content>