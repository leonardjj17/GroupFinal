using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GroupFinal.Classes;

namespace GroupFinal.Views
{
    public partial class CartView2 : System.Web.UI.Page
    {
        List<CartItem> cartItems;
        Table shoppingCart = new Table();
        protected void Page_Load(object sender, EventArgs e)
        {
            cartItems = (List<CartItem>)Session["items"];

            //shoppingCart.Width = 1200;
            TableRow headingRow = new TableRow();
            TableCell head1 = new TableCell();
            TableCell head2 = new TableCell();
            TableCell head3 = new TableCell();
            TableCell head4 = new TableCell();


            head1.Text = "Item";
            head2.Text = "Description";
            head3.Text = "Quantity";
            head4.Text = "Price";

            shoppingCart.Rows.Add(headingRow);

            headingRow.Cells.Add(head1);
            headingRow.Cells.Add(head2);
            headingRow.Cells.Add(head3);
            headingRow.Cells.Add(head4);
            


            //head1.Width = 200;
            //head2.Width = 500;
            pnlShoppingCart.Controls.Add(shoppingCart);
            int currentIndex = 0;

            if (cartItems != null)
            {
                foreach (CartItem items in cartItems)
                {


                    TableRow newRow = new TableRow();
                    TableCell newCell1 = new TableCell();
                    TableCell newCell2 = new TableCell();
                    TableCell newCell3 = new TableCell();
                    TableCell newCell4 = new TableCell();
                    //TableCell editRow = new TableCell();
                    TableCell deleteRow = new TableCell();

                    //Button btnEdit = new Button();
                    Button btnDelete = new Button();
                    //btnEdit.Text = "Edit Item";
                    btnDelete.Text = "Delete Item";
                    btnDelete.ID = Convert.ToString(currentIndex);

                    currentIndex++;

                    btnDelete.Click += BtnDelete_Click;

                    //editRow.Controls.Add(btnEdit);
                    deleteRow.Controls.Add(btnDelete);

                    shoppingCart.Rows.Add(newRow);

                    newRow.Cells.Add(newCell1);
                    newRow.Cells.Add(newCell2);
                    newRow.Cells.Add(newCell3);
                    newRow.Cells.Add(newCell4);
                    //newRow.Cells.Add(editRow);
                    newRow.Cells.Add(deleteRow);



                    newCell1.Text = items.ProductType;
                    newCell2.Text = items.ProductDetail;
                    newCell3.Text = items.ProductQty.ToString();
                    newCell4.Text = items.ProductPrice.ToString("c2");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;

            int index = Convert.ToInt16(currentButton.ID);

            cartItems.RemoveAt(index);

            Session["items"] = cartItems;
            shoppingCart.Controls.Clear();

            Page_Load(sender, e);


        }

        protected void btnContinueOrdering_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }
    }
}