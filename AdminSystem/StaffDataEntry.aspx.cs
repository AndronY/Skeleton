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
        //capture the staff id
        string StaffId = txtStaffId.Text;
        //variable to store any data messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
        if (Error == "")
        {
            //capture the name
            AStaff.Name = txtName.Text;
            //capture the job role
            AStaff.JobRole = txtJobRole.Text;
            //capture the email
            AStaff.Email = txtEmail.Text;
            //capture the date started
            AStaff.DateStarted = Convert.ToDateTime(DateStarted);
            //capture the staff id
            AStaff.StaffId = Convert.ToInt32(StaffId);

            //store the staff in the session object
            Session["AStaff"] = AStaff;

            //redirect to the viewer page
            Response.Redirect("StaffViewer.aspx");
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