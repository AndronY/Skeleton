using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            Assert.IsNotNull(AllStocks);
        }
        [TestMethod]
        public void StockListOk()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.ProductDescription = "Phone 7";
            TestItem.DateListed = DateTime.Now.Date;
            TestItem.StockQuantity = 50;
            TestItem.Price = 799;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.StockList, TestList);
        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.InStock = true;
            TestStock.ProductID = 1;
            TestStock.ProductDescription = "Phone 7";
            TestStock.DateListed = DateTime.Now.Date;
            TestStock.StockQuantity = 50;
            TestStock.Price = 799;
            AllStocks.ThisStock = TestStock;
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.ProductDescription = "Phone 7";
            TestItem.DateListed = DateTime.Now.Date;
            TestItem.StockQuantity = 50;
            TestItem.Price = 799;
            TestList.Add(TestItem);
            AllStocks.StockList = TestList;
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.ProductDescription = "Test Product";
            TestItem.Price = 1.99M;
            TestItem.StockQuantity = 1;
            TestItem.DateListed = DateTime.Now.Date;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.ProductDescription = "Sample Item";
            TestItem.StockQuantity = 4;
            TestItem.Price = 4.99M;
            TestItem.DateListed = DateTime.Now.Date;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;


            TestItem.InStock = false;
            TestItem.ProductDescription = "Sample Item2";
            TestItem.StockQuantity = 5;
            TestItem.Price = 5.00M;
            TestItem.DateListed = DateTime.Now.Date;

            AllStocks.ThisStock = TestItem;
            AllStocks.Update();
            AllStocks.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.InStock = true;
            TestItem.ProductID = 1;
            TestItem.ProductDescription = "Test Product";
            TestItem.Price = 1.99M;
            TestItem.StockQuantity = 1;
            TestItem.DateListed = DateTime.Now.Date;
            AllStocks.ThisStock = TestItem;
            PrimaryKey = AllStocks.Add();
            TestItem.ProductID = PrimaryKey;
            AllStocks.ThisStock.Find(PrimaryKey);
            AllStocks.Delete();
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByProductDescriptionMethoOK()
        {
            clsStockCollection AllStocks = new clsStockCollection();
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductDescription("");
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByProductDescriptionNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            FilteredStocks.ReportByProductDescription("... ...");
            Assert.AreEqual(0, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByProductDescriptionTestDataFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            Boolean OK = true;
            FilteredStocks.ReportByProductDescription("PearGX");
            if(FilteredStocks.Count == 2)
            {
                if(FilteredStocks.StockList[0].ProductID != 8)
                {
                    OK = false;
                }
                if(FilteredStocks.StockList[1].ProductID != 18)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
