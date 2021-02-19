using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates a new instance of ClsOrder
        ClsOrder AnOrder = new ClsOrder();
        //gets the data from session object
        AnOrder = (ClsOrder)Session["AnOrder"];
        //displays the Order ID for this entry
        Response.Write(AnOrder.OrderID + "<br />");
        Response.Write(AnOrder.OrderDate + "<br />");
        Response.Write(AnOrder.OrderShipped + "<br />");
        Response.Write(AnOrder.CustomerID + "<br />");
        Response.Write(AnOrder.ShippingAddress + "<br />");
        Response.Write(AnOrder.OrderStatus + "<br />");

    }
}