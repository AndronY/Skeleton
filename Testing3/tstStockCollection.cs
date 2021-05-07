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

    }
}
