using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayStocks();
            }
        }

    }
    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ThisStock.Find(ProductID);

        txtProductID.Text = Stocks.ThisStock.ProductID.ToString();
        txtProductDescription.Text = Stocks.ThisStock.ProductDescription;
        txtPrice.Text = Stocks.ThisStock.Price.ToString();
        txtStockQuantity.Text = Stocks.ThisStock.StockQuantity.ToString();
        chkInStock.Checked = Stocks.ThisStock.InStock;
        txtDateListed.Text = Stocks.ThisStock.DateListed.ToString();
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        string ProductDescription = txtProductDescription.Text;
        string Price = txtPrice.Text;
        string StockQuantity = txtStockQuantity.Text;
        string DateListed = txtDateListed.Text;
        string Error = "";
        Error = AStock.Valid(ProductDescription, DateListed, StockQuantity, Price);
        if (Error == "")
        {
            AStock.ProductDescription = ProductDescription;
            AStock.Price = Convert.ToDecimal(Price);
            AStock.StockQuantity = Convert.ToInt32(StockQuantity);
            AStock.DateListed = Convert.ToDateTime(DateListed);

            AStock.InStock = chkInStock.Checked;
            clsStockCollection StockList = new clsStockCollection();
            if(ProductID == -1)
            {
                StockList.ThisStock = AStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(ProductID);
                StockList.ThisStock = AStock;
                StockList.Update();
            }
            //StockList.ThisStock = AStock;
            //StockList.Add();

            ////Session["AStock"] = AStock;
            ////Response.Write("StockViewer.aspx");
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();
        Int32 ProductID;
        Boolean Found = false;
        try
        {
            ProductID = Convert.ToInt32(txtProductID.Text);
            Found = AStock.Find(ProductID);
            if (Found == true)
            {
                txtProductDescription.Text = AStock.ProductDescription;
                txtPrice.Text = AStock.Price.ToString();
                txtStockQuantity.Text = AStock.StockQuantity.ToString();
                txtDateListed.Text = AStock.DateListed.ToString();
            }
        }
        catch
        {

        }
    }
}