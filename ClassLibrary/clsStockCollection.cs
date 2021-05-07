using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {
                //
            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }
        public clsStockCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AStock.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AStock.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                AStock.DateListed = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateListed"]);
                AStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                AStock.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                mStockList.Add(AStock);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("InStock", mThisStock.InStock);
            DB.AddParameter("DateListed", mThisStock.DateListed);
            DB.AddParameter("Price", mThisStock.Price);
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("ProductID", mThisStock.ProductID);
            DB.AddParameter("ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("InStock", mThisStock.InStock);
            DB.AddParameter("StockQuantity", mThisStock.StockQuantity);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("DateListed", mThisStock.DateListed);
            DB.Execute("sproc_tblStock_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.Execute("sproc_tbleStock_Delete");
        }
    }
}