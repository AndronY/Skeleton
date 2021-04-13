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

        //public bool Active { get; set; }
        //public DateTime DateAdded { get; set; }
        //public int StockQuantity { get; set; }
        //public string ProductDescription { get; set; }
        //public decimal Price { get; set; }


        public bool Find(int ProductID)
        {
            //mProductID = 21;
            //mPrice = 26;
            //mProductDescription = "Test Description";
            //mStockQuantity = 21;
            //mDateAdded = Convert.ToDateTime("30 / 08 / 2022");
            //mActive = true;
            //return true;
            //throw new NotImplementedException();
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("spoc_tbleAddress_FilterByStockID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mDateListed = Convert.ToDateTime(DB.DataTable.Rows[0]["DateListed"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                return true;
                //throw new NotImplementedException();
            }
            else
            {
                return false;
            }
        }
    }
}