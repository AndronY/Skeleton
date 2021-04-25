using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        string ProductID = "500";
        string ProductDescription = "Sample Item";
        string DateAdded = DateTime.Now.Date.ToString();
        string StockQuantity = "875";
        string Price = "8.99";

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
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            string Error = "";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
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
        [TestMethod]
        public void ProdcutDescriptionMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "x";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "xx";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProdcutDescriptionExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ProductDescription = "";
            ProductDescription = ProductDescription.PadRight(400, 'a');
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidDate()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string DateAdded = "no date";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempStockQuantity = int.MinValue;
            string StockQuantity = (TempStockQuantity - 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = int.MinValue.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempStockQuantity = int.MinValue;
            string StockQuantity = (TempStockQuantity + 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempStockQuantity = int.MaxValue;
            string StockQuantity = (TempStockQuantity - 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = int.MaxValue.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempStockQuantity = int.MaxValue;
            string StockQuantity = (TempStockQuantity + 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempStockQuantity = int.MaxValue;
            string StockQuantity = (TempStockQuantity / 2).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityInvalidNumber()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "Not number";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockQuantityNoNumber()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockQuantity = "";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempPrice = int.MinValue;
            string Price = (TempPrice - 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = int.MinValue.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempPrice = int.MinValue;
            string Price = (TempPrice + 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempPrice = int.MaxValue;
            string Price = (TempPrice - 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = int.MaxValue.ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempPrice = int.MaxValue;
            string Price = (TempPrice + 1).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int TempPrice = int.MaxValue;
            string Price = (TempPrice / 2).ToString();
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceNoNumber()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "";
            Error = AStock.Valid(ProductDescription, DateAdded, StockQuantity, Price);
            Assert.AreNotEqual(Error, "");
        }
    }
}
