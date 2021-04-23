using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;




public partial class _1_List : System.Web.UI.Page
{

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }
    }

    void DisplayOrder()
    {


        //create an instance of the Order Collection
        ClsOrderCollection Orders = new ClsOrderCollection();
        //set the data source to the list of Orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderStatus";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    //event handler for add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //stores -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirects to data entry page
        Response.Redirect("AnOrder.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Var stores primary key value of record to be edited
        Int32 OrderID;
        //if a record has been selected from list
        if (lstOrderList.SelectedIndex != -1) 
        {
            //gets primary key value of record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //stores data in session object
            Session["orderID"] = OrderID;
            //redirect to edit page
            Response.Redirect("AnOrder.aspx");
        }    
        else//if no record has been selected
        {
            //display the error message
            lblError.Text = "Please select a record to delete from the list";

        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Var stores primary key value of record to be delete
        Int32 OrderID;

        //if a record has been selected from list
        if (lstOrderList.SelectedIndex != -1) 
        {
            //gets primary key value of record to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);

            //stores data in session object
            Session["orderID"] = OrderID;

            //redirect to delete page
            Response.Redirect("AnOrder.aspx");


        }



        else//if no record has been selected
        {
            //display the error message
            lblError.Text = "Please select a record to delete from the list";
        }


    
    }




    

    }




       


    

