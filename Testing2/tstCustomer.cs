using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string FullName = "John Green";
        string Address = "Little Street";
        string EmailAddress = "john@gmail.com";
        string DateRegistered = DateTime.Now.Date.ToString();
        

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.ID = TestData;
            Assert.AreEqual(ACustomer.ID, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "John Green";
            ACustomer.FullName = TestData;
            Assert.AreEqual(ACustomer.FullName, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Some Street, Leicester, LE2 8FE";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "JohnGreen@gmail.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void Above18PropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Above18 = TestData;
            Assert.AreEqual(ACustomer.Above18, TestData);
        }

        [TestMethod]
        public void DateRegisteredPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateRegistered = TestData;
            Assert.AreEqual(ACustomer.DateRegistered, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.ID !=4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.FullName != "John Green")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.Address != "Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.EmailAddress != "John@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRegisteredFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.DateRegistered != Convert.ToDateTime("16/9/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAbove18Found()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ID = 4;
            Found = ACustomer.Find(ID);
            if (ACustomer.Above18 != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(FullName,Address,EmailAddress,DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "a";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "aa";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(49, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(51, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(500, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(25, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "a";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "aa";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(500, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "a";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "aa";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(49, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(51, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(500, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(25, 'a');
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateRegistered = TestDate.ToString();
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRegisteredInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string DateRegistered = "this is not a date";
            Error = ACustomer.Valid(FullName, Address, EmailAddress, DateRegistered);
            Assert.AreNotEqual(Error, "");
        }

    }
}
