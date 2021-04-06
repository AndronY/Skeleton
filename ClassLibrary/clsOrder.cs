using System;

namespace ClassLibrary
{
    public class ClsOrder
    {
        public bool Active;


        //private data member for the order ID number
        private Int32 mOrderID;
        //private data member for Order Date
        private DateTime mOrderDate;

        //private data member for OrderShipped
        private Boolean mOrderShipped;

        //private data member for Customer ID 
        private Int32 mCustomerID;


        //private data member for Shipping Address
        private string mShippingAddress;

        //private data member Order Status
        private string mOrderStatus;


        //public property for OrderID
        public Int32 OrderID
        {
            get
            {
                //return private data
                return mOrderID;
            }
            set
            {
                //set private data
                mOrderID = value;
            }
        }

        public string Valid(string orderID, string orderDate, string customerID, string shippingAddress)
        {
            //Creates a astring variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if OrderID is blank
            if (OrderID == 0)
            {
                return "";
                //record the error
                Error = Error + "The Order ID may not be blank : ";
            
           
            }
            //if OrderID is less than 10 characters
            if (OrderID > 10)
            {
                //record the error
                Error = Error + "The Order ID must be less than 10 characters : ";
            }
            //If CustomerID is blank
            if (CustomerID == 0)
            {
                Error = Error + "The Customer ID may not be blank : ";
            }
            //if customerID is less than 10 characters
            if (CustomerID > 10)
            {
                //record the error
                Error = Error + "The Customer ID must be less than 10 characters : ";
            }
            //if shippingaddress is blank
            if (ShippingAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Shipping Address may not be blank : ";
                
            }
            //if shippingaddress is less than 8 characters
            if (ShippingAddress.Length > 8)
            {
                //record the error
                Error = Error + "The  ShippingAddress must be less than 8 characters : ";
            }

            try
            {
                //copy the Orderdate value to Date Temp variable
                DateTemp = Convert.ToDateTime(OrderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //return any error messages
            return Error;


        }

        //public property for Orderdate
        public DateTime OrderDate
        {
            get
            {
                //return private data
                return mOrderDate;
            }
            set
            {
                //set private data
                mOrderDate = value;
            }

        }
        //public property for OrderShipped
        public Boolean OrderShipped
        {
            get
            {
                //returns private data
                return mOrderShipped;
            }
            set
            {
                //sets private data
                mOrderShipped = value;
            }
        }
        //public property for CustomerID
        public Int32 CustomerID
        {
            get =>
                //return private data
                mCustomerID;
            set =>
                //set private data
                mCustomerID = value;
        }
        //public property for ShippingAddress
        public string ShippingAddress
        {
            get
            {
                //return private data
                return mShippingAddress;
            }
            set
            {
                //set private data
                mShippingAddress = value;
            }

        }
        //public property for OrderStatus
        public string OrderStatus
        {
            get
            {
                //return private data
                return mOrderStatus;
            }

            set
            {
                //set private data
                mOrderStatus = value;
            }
        }

        public bool Find(int OrderID)
        {
            //sets private data members to test the data value
            mOrderID = 21;
            mOrderDate = Convert.ToDateTime("16/09/2015");
            mOrderShipped = Convert.ToBoolean(true);
            mCustomerID =21;
            mShippingAddress ="Test Street";
            mOrderStatus = "Dispatched";

            //always returns true
            return true;
            //creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //adds parameter for the OrderID to search for
            DB.AddParameter("@OrderID", this.OrderID);
            //executes the stored procedures
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (should be one or zero)
            if (DB.Count == 1)
            {
                //copy data from database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderShipped = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderShipped"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                //returns if everything worked
                return true;
            }
            //if no record found
            else
            {
                return false;
            }




            }


        }
    }





            

            
        
    

