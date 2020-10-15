<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="IndividualLabAssignment.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id ="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1>Shopping Cart</h1>
    </div>
    <asp:GridView ID="CartList" runat="server" IDrunatAutoGenerateColumns="False" ShowFooter="True" 
        GridLines="Vertical" CellPadding="4"  ItemType="IndividualLabAssignment.Models.CartItem" SelectMethod="GetShoppingCartItems"
        CssClass="table table-striped table-bordered" >

    <Columns>
        <asp:BoundField DataField="ProductID" HeaderText="CAR-ID" SortExpression="ProductID"/>
        <asp:BoundField DataField="Product.ProductName" HeaderText="CAR-NAME"/>
        <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price-(each)" DataFormatString="{0:c}"/>
        <asp:TemplateField HeaderText="Number OF DAYS">
            <ItemTemplate>
                <asp:TextBox ID="numberDays" Width="40" runat="server" Text="<%#: Item.Quantity %>" > </asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Rental Total">
            <ItemTemplate>
                <%#:String.Format("{0:c}", (( Convert.ToDouble(Item.Quantity)) *
                    Convert.ToDouble(Item.Product.UnitPrice)))%>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Remove Item">
            <ItemTemplate>
                <asp:CheckBox ID="remove" runat="server" ></asp:CheckBox>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns> 
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: "></asp:Label> 
            <asp:Label ID="Total" runat="server" EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table>
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
            </td>
            <td>
                <!--Checkout Placeholder-->
            </td>
        </tr>
    </table>

</asp:Content>
