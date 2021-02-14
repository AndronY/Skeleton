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
}