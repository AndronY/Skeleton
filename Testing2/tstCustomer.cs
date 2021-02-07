using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
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
    }
}
