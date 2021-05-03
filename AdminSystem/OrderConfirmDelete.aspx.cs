using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store primary key value of record to be deleted
    Int32 OrderID;
    //event handler for load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of orders to be deleted from session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the Order Collection
        ClsOrderCollection OrderList = new ClsOrderCollection();
        //finds the record to delete
        OrderList.ThisOrder.Find(OrderID);
        //deletes the record
        OrderList.Delete();
        //Redirects back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void BtnNo_Click(object sender, EventArgs e)
    {
        //Redirects back to the main page
        Response.Redirect("OrderList.aspx");
    }
}