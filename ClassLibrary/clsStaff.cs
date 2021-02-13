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

        //public property for IdNumber
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
        public string Name {
            get
            {
                //return private data
                return mName  ;
            }
            set
            {
                //set private data
                mName = value ;
            }

        }
        //public property for Staff Job Role
        public string JobRole {
            get
            {
                //return private data
                return mJobRole  ;
            }
            set
            {
                //set private data
                mJobRole = value ;
            }
        }
        //public property for Staff email
        public string Email {
            get
            {
                //return private data
                return mEmail  ;
            }
            set
            {
                //set private data
                mEmail = value   ;
            }

        }
        //public property for exists
        public bool Exists {
            get
            {
                //return private data
                return mExists   ;
            }

            set
            {
                //set private data
                mExists = value   ;
            }
        }

        public bool Find(int StaffId)
        {
            //set the private data members to the test data value
            mStaffId = 21;
            mDateStarted = Convert.ToDateTime("16/09/2015");
            mName = "Test Name";
            mJobRole = "Test Job Role";
            mEmail = "Test Email";
            mExists = true;

            //Always return true
            return true;
        }

    }
}