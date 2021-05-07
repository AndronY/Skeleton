using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection StockList = new clsStockCollection();
        StockList.ThisStock.Find(ProductID);
        StockList.Delete();
        Response.Redirect("StockList.aspx");
    }
}