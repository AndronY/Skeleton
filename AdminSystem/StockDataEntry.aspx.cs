using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        string ProductDescription = txtProductDescription.Text;
        string Price = txtPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string DateAdded = txtDateListed.Text;

        AStock.ProductDescription = ProductDescription;
        AStock.Price = Convert.ToDecimal(Price);
        AStock.StockQuantity = Convert.ToInt32(StockQuantity);
        AStock.DateAdded = Convert.ToDateTime(DateAdded);

        Session["AStock"] = AStock;
        Response.Redirect("StockViewer.aspx");


    }
}