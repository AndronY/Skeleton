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
        string DateListed = txtDateListed.Text;

        AStock.ProductDescription = ProductDescription;
        AStock.Price = Convert.ToDecimal(Price);
        AStock.StockQuantity = Convert.ToInt32(StockQuantity);
        AStock.DateListed = Convert.ToDateTime(DateListed);

        Session["AStock"] = AStock;
        Response.Redirect("StockViewer.aspx");


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AStock.Find(ProductID);
        if(Found == true)
        {
            txtProductDescription.Text = AStock.ProductDescription;
            txtPrice.Text = AStock.Price.ToString();
            txtStockQuantity.Text = AStock.StockQuantity.ToString();
            txtDateListed.Text = AStock.DateListed.ToString();
        }
    }
}