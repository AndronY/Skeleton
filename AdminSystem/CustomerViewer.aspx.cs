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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customer ID for this entry
        Response.Write(ACustomer.ID + "<br />");
        Response.Write(ACustomer.FullName + "<br />");
        Response.Write(ACustomer.Address + "<br />");
        Response.Write(ACustomer.EmailAddress + "<br />");
        Response.Write(ACustomer.DateRegistered + "<br />");
        Response.Write(ACustomer.Above18 + "<br />");
    }
}