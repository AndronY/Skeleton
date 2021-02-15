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
            DB.Execute("sproc_tblCustomers_FilerByID");
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
    }
}
