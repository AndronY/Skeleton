using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.InStock = TestData;
            Assert.AreEqual(AStock.InStock, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateListed = TestData;
            Assert.AreEqual(AStock.DateListed, TestData);
        }
        [TestMethod]
        public void StockQuantityPropertyOk()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 60;
            AStock.StockQuantity = TestData;
            Assert.AreEqual(AStock.StockQuantity, TestData);
        }
        [TestMethod]
        public void StockDescPropertyOk()
        {
            clsStock AStock = new clsStock();
            string TestData = "Wireless Headset Red";
            AStock.ProductDescription = TestData;
            Assert.AreEqual(AStock.ProductDescription, TestData);
        }
        [TestMethod]
        public void StockPricePropertyOk()
        {
            clsStock AStock = new clsStock();
            Decimal TestData = 60;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 6;
            Found = AStock.Find(ProductID);
            if (AStock.ProductID != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductDescriptionFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 5;
            Found = AStock.Find(ProductID);
            if (AStock.ProductDescription != "Microwave 3000")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AStock.Find(ProductID);
            if (AStock.DateListed != Convert.ToDateTime("05/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockQuantityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AStock.Find(ProductID);
            if (AStock.StockQuantity != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 4;
            Found = AStock.Find(ProductID);
            if (AStock.Price != Convert.ToDecimal(1010))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestInStockFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AStock.Find(ProductID);
            if (AStock.InStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
