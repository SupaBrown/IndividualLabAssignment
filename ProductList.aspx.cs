using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividualLabAssignment.Models;
using System.Web.ModelBinding;

namespace IndividualLabAssignment
{ 
    public partial class ProductList : System.Web.UI.Page 
    { 
        protected void Page_Load(object sender, EventArgs e)
        { 

        }
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId) 
        { 
            var db = new IndividualLabAssignment.Models.ProductContext();
            IQueryable<Product> query = db.Products; 
            if (categoryId.HasValue && categoryId > 0)
            { 
                query = query.Where(p => p.CategoryID == categoryId); 
            } 
            return query; 
        }
    }
}