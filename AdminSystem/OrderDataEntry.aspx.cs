using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store primary key with page level scope
    Int32 OrderID;


    protected void Page_Load(object sender, EventArgs e)
    {



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

            //capture OrderDate
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            //capture ShippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //capture the OrderID
            AnOrder.OrderID = Convert.ToInt32(OrderID);
            //capture the CustomerID
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            //creates new instance of OrderCollection
            ClsOrderCollection OrderList = new ClsOrderCollection();
            //Sets the ThisOrder property
            OrderList.ThisOrder = AnOrder;
            //adds new record
            OrderList.Add();
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


    

