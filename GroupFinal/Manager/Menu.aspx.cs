using GroupFinal.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupFinal.Manager
{
    public partial class Menu : System.Web.UI.Page
    {
        List<Products> products;
        List<string> categories;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (((Employee)Session["employee"] == null) || (((Employee)Session["employee"]).EmployeeRole != "store manager"))
            {
                Response.Redirect("AdminLogin.aspx");
            }
            products = ProductsDA.GetAllProducts();
            categories = new List<string>();
            foreach (Products product in products)
            {
                if (!categories.Contains(product.ProductType))
                {
                    categories.Add(product.ProductType);
                    ListItem categoryItem = new ListItem();
                    categoryItem.Text = product.ProductType;
                    categoryItem.Value = product.ProductType;
                    dropdownCategory.Items.Add(categoryItem);
                }
            }
        }

        protected void UpdateCategory_Click(object sender, EventArgs e)
        {
            dropdownItems.Items.Clear();
            string category = dropdownCategory.SelectedValue;
            products = ProductsDA.GetAllProducts();
            foreach (Products product in products)
            {
                if (product.ProductType == category)
                {
                    ListItem productItem = new ListItem();
                    productItem.Text = product.ProductDetail;
                    productItem.Value = product.ProductID.ToString();
                    dropdownItems.Items.Add(productItem);
                    ItemTable.Visible = true;
                    PriceTable.Visible = false;
                }
            }
        }

        protected void EditItem_Click(object sender, EventArgs e)
        {
            Products product = ProductsDA.GetProductByID(Convert.ToInt32(dropdownItems.SelectedValue));
            MenuItemName.Text = product.ProductDetail;
            MenuItemID.Text = dropdownItems.SelectedValue;
            Price.Text = product.ProductPrice.ToString();
            PriceTable.Visible = true;
        }

        protected void UpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(Price.Text);
                if (price < 0)
                {
                    InvalidSelectionError();
                }
                else
                {
                    Products product = ProductsDA.GetProductByID(Convert.ToInt32(MenuItemID.Text));
                    product.ProductPrice = price;
                    ProductsDA.UpdateProduct(product);
                    Price.Text = "";
                    MenuItemID.Text = "";
                    MenuItemName.Text = "";
                    PriceTable.Visible = false;
                    ItemTable.Visible = false;
                }
            }
            catch(Exception ex)
            {
                InvalidSelectionError();
            }
        }
        protected void InvalidSelectionError()
        {
            Label error = new Label();
            error.Text = "Invalid price or selection.  Try again";
            Error.Controls.Add(error);
        }
    }
}