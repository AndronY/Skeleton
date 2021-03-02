using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mID;
        private string mFullName;
        private string mAddress;
        private string mEmailAddress;
        private Boolean mAbove18;
        private DateTime mDateRegistered;

        public Int32 ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }

        public bool Above18
        {
            get
            {
                return mAbove18;
            }
            set
            {
                mAbove18 = value;
            }
        }

        public DateTime DateRegistered
        {
            get
            {
                return mDateRegistered;
            }
            set
            {
                mDateRegistered = value;
            }
        }

        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", ID);
            DB.Execute("sproc_tblCustomers_FilterByID");
            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mAbove18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Above18"]);
                mDateRegistered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRegistered"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string fullName, string address, string emailAddress, string dateRegistered)
        {
            String Error = "";
            DateTime DateTemp;

            if (fullName.Length == 0)
            {
                Error = Error + "The full name may not be blank : ";
            }
            if (fullName.Length > 50)
            {
                Error = Error + "The full name must be less than 50 characters : ";
            }

            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters : ";
            }

            if (emailAddress.Length == 0)
            {
                Error = Error + "The email address may not be blank : ";
            }
            if (emailAddress.Length > 50)
            {
                Error = Error + "The  email address must be less than 50 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateRegistered);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            
            return Error;
        }
    }
}
