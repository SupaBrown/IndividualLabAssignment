using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using IndividualLabAssignment.Logic;
using System.Data.SqlClient;
using System.Data;

namespace IndividualLabAssignment
{
    public partial class AddToCart : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Supa\Desktop\sem1-2020-21\EC1\IndividualLabAssignment\App_Data\aspnet-IndividualLabAssignment-20201002094444.mdf;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string rawId = Request.QueryString["ProductID"];

            SqlCommand cmd = new SqlCommand("select * from OrderDetails where ProductID = '" + rawId + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);

            int i = ds1.Tables[0].Rows.Count;

            if (i > 0)
            {

                Response.Write("<script>alert('Check us back for this vehicle within a few days')</script>");
                Response.Redirect("ProductAlreadyRented.aspx?");
            }
            else
            {
                //ProductID doesn't exist.



                int productId;
                if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
                {
                    using (ShoppingCartActions usersShoppingCart = new
                    ShoppingCartActions())
                    {
                        usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                    }
                }
                else
                {
                    Debug.Fail("ERROR : We should never get to AddToCart.aspx without a ProductId.");
                    throw new Exception("ERROR : It is illegal to load AddToCart.aspx without setting a ProductId.");
                }
                Response.Redirect("ShoppingCart.aspx");
            }

        }
    }
}