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
        clsStaff AStaff = new clsStaff();
        AStaff.Name = txtName.Text;
        AStaff.JobRole = txtJobRole.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.DateStarted = DateTime.Parse(txtStartDate.Text);
        AStaff.StaffId = Int32.Parse(txtStaffId.Text);
        Session["AStaff"] = AStaff;


        Response.Redirect("StaffViewer.aspx");
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