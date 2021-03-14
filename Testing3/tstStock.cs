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
            AStock.Active = TestData;
            Assert.AreEqual(AStock.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOk()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
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
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.ProductID != 21)
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
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.ProductDescription != "Test Description")
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
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.DateAdded != Convert.ToDateTime("30/08/2022"))
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
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.StockQuantity != 21)
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
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.Price != Convert.ToDecimal(26))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 21;
            Found = AStock.Find(ProductID);
            if (AStock.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
