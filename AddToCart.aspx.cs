using IndividualLabAssignment.Logic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndividualLabAssignment
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductId"];
            int productId;
            if(!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {
                using(ShoppingCartActions usersShoppingCart= new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR : We should never get to AddToCart.aspx without a Product ID");
                throw new Exception("Error: It is illegal to load AddtoCart without setting a Product ID");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}