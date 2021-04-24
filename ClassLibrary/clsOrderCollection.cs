using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsOrderCollection
    {
        List<ClsOrder> mOrderList = new List<ClsOrder>();
        //private data member for ThisOrder
        ClsOrder mthisOrder = new ClsOrder();

        //constructor for the class
        public ClsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);


        }




        //public property for the Order list 
        public List<ClsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;

            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //  ;
            }
        }
        //public property for ThisOrder
        public ClsOrder ThisOrder
        {
            get
            {
                //returns the private data
                return mthisOrder;
            }
            set
            {
                //sets the private data
                mthisOrder = value;
            }

        }
        public int Add()
        {
            //adds the new record to the database based on the values for mThisOrder
            clsDataConnection DB = new clsDataConnection();
            //sets the prarameters for stored procedures
            DB.AddParameter("@orderStatus", mthisOrder.OrderStatus);
            DB.AddParameter("@ShippingAddress", mthisOrder.ShippingAddress);
            DB.AddParameter("@orderDate", mthisOrder.OrderDate);
            DB.AddParameter("@OrderShipped", mthisOrder.OrderShipped);
            DB.AddParameter("@customerID", mthisOrder.CustomerID);
            //executes query returning of the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //Sets the parameter for stored procedure
            DB.AddParameter("@OrderID", mthisOrder.OrderID);
            //executes the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //adds the new record to the database based on the values for mThisOrder
            clsDataConnection DB = new clsDataConnection();
            //sets the prarameters for stored procedures
            DB.AddParameter("@orderID", mthisOrder.OrderID);
            DB.AddParameter("@orderStatus", mthisOrder.OrderStatus);
            DB.AddParameter("@ShippingAddress", mthisOrder.ShippingAddress);
            DB.AddParameter("@orderDate", mthisOrder.OrderDate);
            DB.AddParameter("@OrderShipped", mthisOrder.OrderShipped);
            DB.AddParameter("@customerID", mthisOrder.CustomerID);
            //executes query returning of the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }
        public void ReportByShippingAddress(string ShippingAddress)
        {
            //Filters the record based on full or partial Shipping Address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            //executes the stroed procedure
            DB.Execute("sproc_tblOrder_FilterByShippingAddress");
            //populate the array list with the data table
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array List based on the data table in the parameter DB
            // var for the index
            Int32 Index = 0;
            //var to store the count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the Private Array list
            mOrderList = new List<ClsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                ClsOrder AnOrder = new ClsOrder();
                //reads in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.OrderShipped = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderShipped"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);

                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}
            
        
    

    

            


            

    
    

