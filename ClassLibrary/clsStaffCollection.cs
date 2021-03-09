using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

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
        public clsStaff ThisStaff { get; set; }



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
                AStaff.Exists = Convert.ToBoolean(DB.DataTable.Rows[Index]["Exists"]);
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


    }
}