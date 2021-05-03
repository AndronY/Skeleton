using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    

    public int OrderShipped { get; private set; }

    //variable to store primary key with page level scope
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }
    void DisplayOrder()
    {
        //create an instance of the Order collection
        ClsOrderCollection OrderCollection = new ClsOrderCollection();
        //find the record to update
        OrderCollection.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderCollection.ThisOrder.OrderID.ToString();
        txtOrderDate.Text = OrderCollection.ThisOrder.OrderDate.ToString();
        txtCustomerID.Text = OrderCollection.ThisOrder.CustomerID.ToString();
        txtShippingAddress.Text = OrderCollection.ThisOrder.ShippingAddress;



    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //creates a new instance of ClsOrder
        ClsOrder AnOrder = new ClsOrder();
        //capture the OrderID
        String OrderID = txtOrderID.Text;
        //capture the OrderDate
        string OrderDate = txtOrderDate.Text;
        //capture the CustomerID
        String CustomerID = txtCustomerID.Text;

        //capture the ShippingAddress
        string ShippingAddress = txtShippingAddress.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
        if (Error == "")
        {
            //capture the OrderID
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            //capture OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture the CustomerID
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //capture ShippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //capture Order Shipped
            AnOrder.OrderShipped  = chkOrderShipped.Checked;
            //creates new instance of OrderCollection
            ClsOrderCollection OrderList = new ClsOrderCollection();

            //If this is a new record i.e OrderShipped = -1 the add the data
           if ( OrderShipped  == -1) 
              {

            //Sets the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //adds new record
            OrderList.Add();
       }
        //Otherwise it must be an update
       else
        {
                //find record to update
                OrderList.ThisOrder.Find(OrderShipped);
                //Sets the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //updates the record
                OrderList.Update();
        }
            //redirects back to listpage
            Response.Redirect("OrderList.aspx");



        }
        else
        {
            //display the error message
            lblError.Text = Error;

        }

    }




    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //creates a new instance of ClsOrder
        ClsOrder AnOrder = new ClsOrder();
        //Variable to store primary key
        Int32 OrderID;
        //variable to store result of find operation
        Boolean Found = false;
        //primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display values of properties in the form
            txtOrderID.Text = AnOrder.OrderID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress;
            txtOrderStatus.Text = AnOrder.OrderStatus;


        }
    }

    






    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}


    

