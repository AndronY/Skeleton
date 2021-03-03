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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the full name
        string FullName = txtFullName.Text;
        //capture the address
        string Address = txtAddress.Text;
        //capture the email address
        string EmailAddress = txtEmailAddress.Text;
        //capture the date registered
        string DateRegistered = txtDateRegistered.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
        if (Error == "")
        {
            //capture customer full name
            ACustomer.FullName = FullName;
            //capture customer address
            ACustomer.Address = Address;
            //capture customer email address
            ACustomer.EmailAddress = EmailAddress;
            //capture customer date registered
            ACustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
            //store the ID in the session object
            Session["ACustomer"] = ACustomer;
            //navigate to the viewer page
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 ID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        ID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(ID);
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = ACustomer.Address;
            txtDateRegistered.Text = Convert.ToString(ACustomer.DateRegistered);
            txtEmailAddress.Text = ACustomer.EmailAddress;
            txtFullName.Text = ACustomer.FullName;
        }
    }
}