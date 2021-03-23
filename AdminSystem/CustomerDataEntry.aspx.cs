using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the ID to be processed
        ID = Convert.ToInt32(Session["ID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(ID);
        //display the data for this record
        txtCustomerID.Text = Customers.ThisCustomer.ID.ToString();
        txtFullName.Text = Customers.ThisCustomer.FullName;
        txtAddress.Text = Customers.ThisCustomer.Address;
        txtEmailAddress.Text = Customers.ThisCustomer.EmailAddress;
        chkAbove18.Checked = Customers.ThisCustomer.Above18;
        txtDateRegistered.Text = Customers.ThisCustomer.DateRegistered.ToString();
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
            //capture the ID
            ACustomer.ID = ID;
            //capture the full name
            ACustomer.FullName = FullName;
            //capture the address
            ACustomer.Address = Address;
            //capture the email address
            ACustomer.EmailAddress = EmailAddress;
            //capture date registered
            ACustomer.DateRegistered = Convert.ToDateTime(DateRegistered);
            //capture above18
            ACustomer.Above18 = chkAbove18.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. ID = -1 then add the data
            if (ID == -1)
            {
                //set the ThisCustomer propertry
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(ID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
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

    protected void btnCustomerList_Click(object sender, EventArgs e)
    {
        //redirect back to the listpage
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}