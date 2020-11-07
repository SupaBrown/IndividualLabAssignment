﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IndividualLabAssignment.Models;
using IndividualLabAssignment.Logic;
using System.Data.SqlClient;
using System.Data;

namespace IndividualLabAssignment.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "add")
            {
                LabelAddStatus.Text = "Product added!";
            }

            if (productAction == "update")
            {
                LabelUpdateStatus.Text = "Product updated!";
            }


            if (productAction == "remove")
            {
                LabelRemoveStatus.Text = "Product removed!";
            }
        }
        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/");
            String path1 = "Images";
            if (ProductImage.HasFile)
            {
                String fileExtension =
                System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    // C: \Users\User1\source\repos\Milestone2\Milestone2\Images\
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + "/" + ProductImage.FileName);
                    // Save to Images/Thumbs folder.
                    // ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }



                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(AddProductName.Text, AddProductDescription.Text,
                AddProductPrice.Text, DropDownAddCategory.SelectedValue,
                path1 + "/" + ProductImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0,
                    Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new product to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }
        public IQueryable GetCategories()
        {
            var _db = new IndividualLabAssignment.Models.ProductContext();
            IQueryable query = _db.Categories;
            return query;
        }
        public IQueryable GetProducts()
        {
            var _db = new IndividualLabAssignment.Models.ProductContext();
            IQueryable query = _db.Products;
            _db.SaveChanges();
            return query;
        }
        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new IndividualLabAssignment.Models.ProductContext())
            {
                int productId = Convert.ToInt16(DropDownRemoveProduct.SelectedValue);
                var myItem = (from c in _db.Products
                              where c.ProductID == productId
                              select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Products.Remove(myItem);
                    _db.SaveChanges();
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0,
                    Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }


        protected void UpdateProductButton_Click(object sender, EventArgs e)
        {

            using (var _db = new IndividualLabAssignment.Models.ProductContext())
            {
                int productId = Convert.ToInt16(DropDownList2.SelectedValue);
                var myItem = (from c in _db.Products
                              where c.ProductID == productId
                              select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Products.Remove(myItem);
                    _db.SaveChanges();
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0,
                    Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    //Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }

            Boolean fileOK = false;
            String path = Server.MapPath("~/Images/");
            String path1 = "Images";
            if (UpdateProductImage.HasFile)
            {
                String fileExtension =
                System.IO.Path.GetExtension(UpdateProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }
            if (fileOK)
            {
                try
                {
                    // C: \Users\User1\source\repos\Milestone2\Milestone2\Images\
                    // Save to Images folder.
                    UpdateProductImage.PostedFile.SaveAs(path + "/" + UpdateProductImage.FileName);
                    // Save to Images/Thumbs folder.
                    // ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }



                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(UpdateProductName.Text, UpdateProductDescription.Text,
                UpdateProductPrice.Text, DropDownList1.SelectedValue,
                path1 + "/" + UpdateProductImage.FileName);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0,
                    Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=update");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new product to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }
    }
}