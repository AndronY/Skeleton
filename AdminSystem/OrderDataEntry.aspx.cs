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

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //creates a new instance of ClsOrder
        ClsOrder AnOrder = new ClsOrder();
        //captures the OrderID
        AnOrder.OrderID = int.Parse(txtOrderID.Text);
        //captures the Order Date
        AnOrder.OrderDate = DateTime.Parse(txtOrderDate.Text);
        //captures the Order Shipped
        AnOrder.OrderShipped = chkOrderShipped.Checked;
        //captures the CustomerID
        AnOrder.CustomerID = int.Parse(txtCustomerID.Text);
        //captures the Shipping Address
        AnOrder.ShippingAddress = txtShippingAddress.Text;
        //captures the Order Status
        AnOrder.OrderStatus = txtOrderStatus.Text;
       //stores the address in the session object
       Session["AnOrder"] = AnOrder;
        //Navigates to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

   

    }
