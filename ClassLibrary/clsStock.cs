using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassLibrary
{
    public class clsStock
    {
        private Boolean mInStock;
        public bool InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }
        private DateTime mDateListed;
        public DateTime DateListed
        {
            get
            {
                return mDateListed;
            }
            set
            {
                mDateListed = value;
            }
        }
        private Decimal mPrice;
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private Int32 mStockQuantity;
        public Int32 StockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        }
        private string mProductDescription;
        public string ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }
        private Int32 mProductID;
        public Int32 ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        public string Valid(string productDescription,string dateListed,
            string stockQuantity,string price)
        {
            String Error = "";
            DateTime DateTemp;
            if (productDescription.Length == 0)
            {
                Error = Error + "There needs to be a product description: ";
            }
            if (productDescription.Length > 50)
            {
                Error = Error + "The product description needs to be less than 50 characters ";
            }


            if (stockQuantity.Length == 0)
            {
                Error = Error + "Stock Quantity cannot be nothing: ";
            }
            try
            {
                if (Convert.ToInt64(stockQuantity) >= int.MinValue)
                { }
            }
            catch
            {
                Error = Error + "The quantity is not valid: ";
            }

            if (price.Length == Convert.ToDecimal(0))
            {
                Error = Error + "Price cannot be nothing: ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateListed);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "Date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date is not valid: " + dateListed;
            }
            return Error;
        }


        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("spoc_tblStock_FilterByStockID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mDateListed = Convert.ToDateTime(DB.DataTable.Rows[0]["DateListed"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}