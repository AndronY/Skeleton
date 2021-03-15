using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mthisStaff = new clsStaff();


        //public property for the staff list 
        public List<clsStaff> StaffList {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;

            }   
                 }
        public int Count {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
              //  ;
            }
        }
        public clsStaff ThisStaff {
            get
            {
                //return the private staff data
                return mthisStaff;
            }
            set
            {
                //set the private data
                mthisStaff = value;
            }
        }



        //constructor for the class
        public clsStaffCollection()
        {
            // var for the index
            Int32 Index = 0;
            //var to store the count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index<RecordCount)
            {
                //create a blank staff
                clsStaff AStaff = new clsStaff();
                //reads in the fields from the current record
                AStaff.StaffExists = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffExists"]);
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AStaff.DateStarted = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateStarted"]);
                AStaff.JobRole = Convert.ToString(DB.DataTable.Rows[Index]["JobRole"]);
                AStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new recodr to the databse based on the value of mthisStaff, sets the primary key value as
            //the new record
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the procedure
            DB.AddParameter("@Name", mthisStaff.Name);
            DB.AddParameter("@DateStarted", mthisStaff.DateStarted);
            DB.AddParameter("@JobRole", mthisStaff.JobRole);
            DB.AddParameter("@Email", mthisStaff.Email);
            DB.AddParameter("@StaffExists", mthisStaff.StaffExists);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mthisStaff.StaffId);
            DB.AddParameter("@Name", mthisStaff.Name);
            DB.AddParameter("@DateStarted", mthisStaff.DateStarted);
            DB.AddParameter("@JobRole", mthisStaff.JobRole);
            DB.AddParameter("@Email", mthisStaff.Email);
            DB.AddParameter("@StaffExists", mthisStaff.StaffExists);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }
    }
}