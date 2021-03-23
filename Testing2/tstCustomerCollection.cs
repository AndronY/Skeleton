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
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //Test data to assign to property
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
            //create an instance of the class we want to create
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
            //create an instance of the class we want to create
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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ID = 1;
            TestItem.FullName = "Glen Marsh";
            TestItem.Address = "West street";
            TestItem.EmailAddress = "Glen@gmail.com";
            TestItem.DateRegistered = DateTime.Now.Date;
            TestItem.Above18 = true;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.FullName = "James May";
            TestItem.Address = "East Street";
            TestItem.EmailAddress = "James@Gmail.com";
            TestItem.Above18 = true;
            TestItem.DateRegistered = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //modify the test data
            TestItem.FullName = "James Clay";
            TestItem.Address = "West Street";
            TestItem.EmailAddress = "JamC@Gmail.com";
            TestItem.Above18 = false;
            TestItem.DateRegistered = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ID = 1;
            TestItem.FullName = "James May";
            TestItem.Address = "East Street";
            TestItem.EmailAddress = "James@Gmail.com";
            TestItem.Above18 = true;
            TestItem.DateRegistered = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.ID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void RepostByFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a post code that doesnt exist
            FilteredCustomers.ReportByFullName("XXX XXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        
        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a full name that doesnt exist
            FilteredCustomer.ReportByFullName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomer.Count == 2)
            {
                //check that the first record is ID 7
                if (FilteredCustomer.CustomerList[0].ID != 7)
                {
                    OK = false;
                }
                //check that the first record is ID 8
                if (FilteredCustomer.CustomerList[1].ID !=8)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
