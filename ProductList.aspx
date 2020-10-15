<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="IndividualLabAssignment.ProductList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"> 
    <section>
        <div> 
            <hgroup>
                

            </hgroup> 
            <asp:ListView ID="productList" runat="server"
                DataKeyNames="ProductID" GroupItemCount="4"
                ItemType="IndividualLabAssignment.Models.Product"
                SelectMethod="GetProducts"> 
                <EmptyDataTemplate> 
                    <table > 
                        <tr> <td>No data was returned.</td>

                        </tr> 

                    </table> 

                </EmptyDataTemplate> 
                <EmptyItemTemplate> 
                    <td/> 

                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server"> 
                        <td id="itemPlaceholder" runat="server"></td>

                    </tr> 

                </GroupTemplate>
                <ItemTemplate> 
                    <td runat="server"> 
                        <table> 
                            <tr>
                                <td> 
                                    

                                        <img src="Images/<%#:Item.ImagePath%>" 
                                            width="300" height="225" style="border:solid" /> 
                                        

                                </td>
                                <td style="text-indent: 50px">
                                    &nbsp;&nbsp;&nbsp;

                                </td>
                                <td> <a href="ProductDetails.aspx?productID=<%#:Item.ProductID%>"></a>
                                    
                                        <span>
                                            <b>Product Name: </b>
                                            <%#:Item.ProductName%> 

                                        </span>

                                      
                                    <br />
                                    <span> 
                                        <b>Product ID: </b>
                                        <%#: Item.ProductID %>
                                                         
                                    </span>
                                    <br /> 
                                    <span> 
                                        <b>Price: </b>
                                        <%#:String.Format("{0:c}", Item.UnitPrice)%>
                                                         
                                    </span>
                                    <br /> 
                                    
                                    
                                    <span> 
                                        <b>Description: </b>
                                        <%#: Item.Description %>
                                                         
                                    </span>
                                    <br /> 
                                    <br />
                                    <span>
                                        <a href="/AddToCart.aspx?productID=<%#:Item.ProductID %>"> 
                                            <class span ="ProductListItem"> 
                                                <b> Add To Cart<b> 
                                        </a >
                                        <br />
                                    </span >
                                                

                                </td>

                            </tr> 
                            
                            <tr> 
                                

                            </tr> 
                            <tr> 
                                <td>&nbsp;</td>

                            </tr> 

                        </table> 
                        </p> 

                    </td> 
                    <hr />
                </ItemTemplate>
               

            </asp:ListView>

        </div>

    </section>
</asp:Content>