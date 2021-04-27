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
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }
    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        //find the record to update
        StaffCollection.ThisStaff.Find(StaffId);
        //display the data for this record
        txtStaffId.Text = StaffCollection.ThisStaff.StaffId.ToString();
        txtName.Text = StaffCollection.ThisStaff.Name;
        txtStartDate.Text = StaffCollection.ThisStaff.DateStarted.ToString();
        txtJobRole.Text = StaffCollection.ThisStaff.JobRole;
        txtEmail.Text = StaffCollection.ThisStaff.Email;
        chkStaffStaffExists.Checked = StaffCollection.ThisStaff.StaffExists;
    }

    protected void btnOkay_Click(object sender, EventArgs e)
    {
        //Create new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the name
         string Name = txtName.Text;
        //capture the job role
        string JobRole = txtJobRole.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the date started
        string DateStarted = txtStartDate.Text;
        //variable to store any data messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
        if (Error == "")
        {
           
            //capture the name
            AStaff.Name = Name;
            //capture the job role
            AStaff.JobRole = JobRole;
            //capture the email
            AStaff.Email = Email;
            //capture the date started
            AStaff.DateStarted = Convert.ToDateTime(DateStarted);
            //capture the staff id
            AStaff.StaffId = StaffId;
            //capture if it exists
            AStaff.StaffExists = chkStaffStaffExists.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record i.e. StaffId = -1 add data
            if (StaffId == -1)
            {
                //set ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();

            }

            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the StaffId property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }

            //redirect to the viewer page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the new staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //Get primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the staff in the form
            txtStaffId.Text = AStaff.StaffId.ToString();
            txtName.Text = AStaff.Name;
            txtStartDate.Text = AStaff.DateStarted.ToString();
            txtJobRole.Text = AStaff.JobRole;
            txtEmail.Text = AStaff.Email;

        }
       
    }
}