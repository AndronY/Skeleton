using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff ID to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff list
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to delete 
        StaffList.ThisStaff.Find(StaffId);
        //delete the record 
        StaffList.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}