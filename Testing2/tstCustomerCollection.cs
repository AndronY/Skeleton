using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.ID = 1;
            TestItem.FullName = "John Green";
            TestItem.Address = "Test street";
            TestItem.EmailAddress = "John@gmail.com";
            TestItem.DateRegistered = DateTime.Now.Date;
            TestItem.Above18 = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data to assign to property
            clsCustomer TestCustomer = new clsCustomer();
            //Set properties of the test item
            TestCustomer.ID = 1;
            TestCustomer.FullName = "John Green";
            TestCustomer.Address = "Test street";
            TestCustomer.EmailAddress = "John@gmail.com";
            TestCustomer.DateRegistered = DateTime.Now.Date;
            TestCustomer.Above18 = true;
            //Assign data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //Test to see that the two are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data to assign to property
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //Set properties
            TestItem.ID = 1;
            TestItem.FullName = "John Green";
            TestItem.Address = "Test street";
            TestItem.EmailAddress = "John@gmail.com";
            TestItem.DateRegistered = DateTime.Now.Date;
            TestItem.Above18 = true;
            TestList.Add(TestItem);
            //Add item to test list
            TestList.Add(TestItem);
            //Assign data to the property
            AllCustomers.CustomerList = TestList;
            //Test to see if the two are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
    }
}
