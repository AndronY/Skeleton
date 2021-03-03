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

    }
}
