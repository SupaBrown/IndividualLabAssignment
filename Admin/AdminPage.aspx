<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="IndividualLabAssignment.Admin.AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      
    <h1>Administration</h1>
   <hr />
   <h3>Add Product:</h3>
    <div class="container body-content">
   <table>
      <tr>
         <td>
            <asp:Label ID="LabelAddCategory"
               runat="server">Category:</asp:Label>
         </td>
         <td>
            <asp:DropDownList ID="DropDownAddCategory" runat="server"
               ItemType="IndividualLabAssignment.Models.Category"
               SelectMethod="GetCategories" DataTextField="CategoryName"
               DataValueField="CategoryID" >
            </asp:DropDownList>
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelAddName"
               runat="server">Name:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="AddProductName" runat="server"></asp:TextBox>
           
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelAddDescription"
               runat="server">Description:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="AddProductDescription"
               runat="server"></asp:TextBox>
            
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelAddPrice"
               runat="server">Price:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="AddProductPrice" runat="server"></asp:TextBox>
           
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelAddImageFile" runat="server">Image
               File:
            </asp:Label>
         </td>
         <td>
            <asp:FileUpload ID="ProductImage" runat="server" />
           
         </td>
      </tr>
   </table>
   <p></p>
   <p></p>
   <asp:Button ID="AddProductButton" runat="server" Text="Add Product"
      OnClick="AddProductButton_Click" CausesValidation="true" formnovalidate="true"/>
   <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
   <p></p>
    <br />
    </div>
        
    
    <h3>Update Product:</h3>
    <table>
       <tr>
         <td>
            <asp:Label ID="LabelUpdateProduct"
               runat="server">Product:</asp:Label>
         </td>
         <td>
            <asp:DropDownList ID="DropDownList2" runat="server"
               ItemType="IndividualLabAssignment.Models.Product"
               SelectMethod="GetProducts" AppendDataBoundItems="true"
               DataTextField="ProductName" DataValueField="ProductID" >
            </asp:DropDownList>
         </td>
      </tr>

      <tr>
         <td>
            <asp:Label ID="LabelUpdateCategory"
               runat="server">Category:</asp:Label>
         </td>
         <td>
            <asp:DropDownList ID="DropDownList1" runat="server"
               ItemType="IndividualLabAssignment.Models.Category"
               SelectMethod="GetCategories" DataTextField="CategoryName"
               DataValueField="CategoryID" >
            </asp:DropDownList>
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelUpdateName"
               runat="server">Name:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="UpdateProductName" runat="server"></asp:TextBox>
           
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelUpdateDescription"
               runat="server">Description:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="UpdateProductDescription"
               runat="server"></asp:TextBox>
            
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelUpdatePrice"
               runat="server">Price:</asp:Label>
         </td>
         <td>
            <asp:TextBox ID="UpdateProductPrice" runat="server"></asp:TextBox>
            
         </td>
      </tr>
      <tr>
         <td>
            <asp:Label ID="LabelUpdateImageFile" runat="server">Image
               File:
            </asp:Label>
         </td>
         <td>
            <asp:FileUpload ID="UpdateProductImage" runat="server" />
         </td>
      </tr>
   </table>

    <p></p>
   <p></p>
   <asp:Button ID="UpdateProductButton" runat="server" Text="Update Product"
      OnClick="UpdateProductButton_Click" />
   <asp:Label ID="LabelUpdateStatus" runat="server" Text=""></asp:Label>
   <p></p>

    <br />

   <h3>Remove Product:</h3>
   <table>
      <tr>
         <td>
            <asp:Label ID="LabelRemoveProduct"
               runat="server">Product:</asp:Label>
         </td>
         <td>
            <asp:DropDownList ID="DropDownRemoveProduct" runat="server"
               ItemType="IndividualLabAssignment.Models.Product"
               SelectMethod="GetProducts" AppendDataBoundItems="true"
               DataTextField="ProductName" DataValueField="ProductID" >
            </asp:DropDownList>
         </td>
      </tr>
   </table>
   <p></p>
   <asp:Button ID="RemoveProductButton" runat="server" Text="Remove Product"
      OnClick="RemoveProductButton_Click" CausesValidation="false"/>
   <asp:Label ID="LabelRemoveStatus" runat="server" Text=""></asp:Label>
</asp:Content>
