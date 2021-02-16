using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the staff id number 
        private Int32 mStaffId;
        //private data member for the staff date started
        private DateTime mDateStarted;
        //private data member for the staff name
        private String mName;
        //private data member for the staff job role
        private String mJobRole;
        //private data member for the staff email
        private String mEmail;
        //private data member for staff exists
        private Boolean mExists;

        //public property for Staff Id
        public Int32 StaffId
        {
            get
            {
                //return private data
                return mStaffId;
            }
            set
            {
                //set private data
                mStaffId = value;
            }
        }
        //public property for Date started
        public DateTime DateStarted
        {
            get
            {
                //return private data
                return mDateStarted;
            }
            set
            {
                //set private data
                mDateStarted = value;
            }

        }
        //public property for Staff Name
        public string Name
        {
            get
            {
                //return private data
                return mName;
            }
            set
            {
                //set private data
                mName = value;
            }

        }
        //public property for Staff Job Role
        public string JobRole
        {
            get
            {
                //return private data
                return mJobRole;
            }
            set
            {
                //set private data
                mJobRole = value;
            }
        }
        //public property for Staff email
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set private data
                mEmail = value;
            }

        }
        //public property for exists
        public bool Exists
        {
            get
            {
                //return private data
                return mExists;
            }

            set
            {
                //set private data
                mExists = value;
            }
        }

        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateStarted = Convert.ToDateTime(DB.DataTable.Rows[0]["DateStarted"]);
                mJobRole = Convert.ToString(DB.DataTable.Rows[0]["JobRole"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mExists = Convert.ToBoolean(DB.DataTable.Rows[0]["Exists"]);
                //return that everything worked
                return true;
            }
            //if no record
            else
            {
                return false;
            }

        
        }

    }
}
