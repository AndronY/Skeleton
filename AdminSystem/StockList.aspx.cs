using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        { 
          DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductDescription";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ProductID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if(lstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("StockDataEntry.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ProductID;
        if(lstStockList.SelectedIndex != -1)
        {
            ProductID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ProductID"] = ProductID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByProductDescription(txtFilterProductDescription.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductDescription";
        lstStockList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();
        Stocks.ReportByProductDescription("");
        txtFilterProductDescription.Text = "";
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "ProductID";
        lstStockList.DataTextField = "ProductDescription";
        lstStockList.DataBind();
    }
}