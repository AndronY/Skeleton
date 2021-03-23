using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;

            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
              //  
            }
        }

        //public property for ThisAddress
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the daabase based on the values of mThisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Above18", mThisCustomer.Above18);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            //execute the quary returning the primary key value
            return DB.Execute("sproc_tblCustomers_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ID", mThisCustomer.ID);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Above18", mThisCustomer.Above18);
            DB.AddParameter("@DateRegistered", mThisCustomer.DateRegistered);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ID", mThisCustomer.ID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on a full or partial full name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FullName parameter to the database
            DB.AddParameter("@Fullname", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
                ACustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                ACustomer.DateRegistered = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateRegistered"]);
                ACustomer.Above18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Above18"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point to the next record
                Index++;
            }
        }
    }
}