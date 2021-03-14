using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassLibrary
{
    public class clsStock
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
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
            mProductID = 21;
            mPrice = 26;
            mProductDescription = "Test Description";
            mStockQuantity = 21;
            mDateAdded = Convert.ToDateTime("30 / 08 / 2022");
            mActive = true;
            return true;
            //throw new NotImplementedException();
        }
    }
}