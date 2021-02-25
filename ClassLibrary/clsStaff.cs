
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

        public string Valid(string name, string jobRole, string email, string dateStarted)
        {
            String error = "";

            DateTime DateTemp;

            if (name.Length == 0)
            {
                //record the error
                error = error + "The name must not be blank : ";
            }
            //if the name is greater than 6 characters
            if (name.Length > 50)
            {
                //record the error
                error = error + "The name must be less than 50 characters : ";
            }

            if (jobRole.Length == 0)
            {
                error = error + "The Job role must not be blank: ";
            }

            if(jobRole.Length > 50)
            {
                error = error + "The job role must be less than 50 characters: ";
            }

            if (email.Length == 0)
            {
                error = error + "The email must not be left blank: ";
            }
            if (email.Length >50)
            {
                error = error + "The email must not be more than 50 characters: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateStarted);
                //checks if the date is earlier than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    //records the error
                    error = error + "The date cannot be in the past : ";

                }
                //checks if the date is after today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the future : ";
                }

            }

            catch
            {
                //records the error
                error = error + "The date was not a valid date : ";
            }
            //returns error message
            return error;
        }

    }
}

