﻿using System;
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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture customer ID
        ACustomer.ID = int.Parse(txtCustomerID.Text);
        //capture customer full name
        ACustomer.FullName = txtFullName.Text;
        //capture customer address
        ACustomer.Address = txtAddress.Text;
        //capture customer email address
        ACustomer.EmailAddress = txtEmailAddress.Text;
        //capture customer date registered
        ACustomer.DateRegistered = DateTime.Parse(txtDateRegistered.Text);
        //capture customer above18
        ACustomer.Above18 = chkAbove18.Checked;
        //store the ID in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}