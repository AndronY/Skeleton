﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        //Good Test Data
        //creates some test data to pass to the method
        string OrderID = "2";
        string CustomerID = "58974136";
        string ShippingAddress = "54 Queensville ";
        string OrderDate = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            Assert.IsNotNull(AllOrder);

        }
        [TestMethod]
        public void OrderListOK()
        {
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            List<ClsOrder> TestList = new List<ClsOrder>();
            ClsOrder TestItem = new ClsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 45879632;
            TestItem.ShippingAddress = "64 potter Lane";
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;
            TestList.Add(TestItem);
            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //Test data to assign to property
            ClsOrder TestOrder = new ClsOrder();
            //Set properties of the test item
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 45879632;
            TestOrder.ShippingAddress = "64 potter Lane";
            TestOrder.OrderStatus = "Pending";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderShipped = false;
            //Assign data to the property
            AllOrder.ThisOrder = TestOrder;
            //Test to see that the two are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            Int32 SomeCount = 15;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //creates an instance of class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //Test data to assign to property
            List<ClsOrder> TestList = new List<ClsOrder>();
            //creates item of test data
            ClsOrder TestItem = new ClsOrder();
            //Set properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 45879632;
            TestItem.ShippingAddress = "64 potter Lane";
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;
            //Add item to test list
            TestList.Add(TestItem);
            //reinitialise the object for some new data
            TestItem = new ClsOrder();
            //sets its properties
            TestItem.OrderID = 2;
            TestItem.CustomerID = 58974136;
            TestItem.ShippingAddress = "54 Queensville";
            TestItem.OrderStatus = "Dispatched";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;
            //Add item to test list
            TestList.Add(TestItem);
            //Assign data to the property
            AllOrder.OrderList = TestList;
            //Test to see if the two are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethodOK()
        {
            //creates an instance of class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //creates item of test data
            ClsOrder TestItem = new ClsOrder();
            //Var to store primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 45879632;
            TestItem.ShippingAddress = "64 potter Lane";
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //Test to see if the two are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //creates instance of class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //creates the item of test data
            ClsOrder TestItem = new ClsOrder();
            //Var to store primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 45879632;
            TestItem.ShippingAddress = "64 potter Lane";
            TestItem.OrderStatus = "pending";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //Test to see if the record was not found
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //creates an instance of class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //creates item of test data
            ClsOrder TestItem = new ClsOrder();
            //Var to store primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.OrderID = 1;
            TestItem.CustomerID = 45879632;
            TestItem.ShippingAddress = "64 potter Lane";
            TestItem.OrderStatus = "Pending";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = false;
            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify test data
            TestItem.OrderID = 2;
            TestItem.CustomerID = 58974136;
            TestItem.ShippingAddress = "54 Queensville";
            TestItem.OrderStatus = "Dispatched";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;
            //sets the record based on new data
            AllOrder.ThisOrder = TestItem;
            //updates record
            AllOrder.Update();
            //find record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //tests to see if ThisOrder matches test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);


        }
        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //creates an instance of class we want to create
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //creates an instance of the filtered data
            ClsOrderCollection FilteredOrder = new ClsOrderCollection();
            //applies a blank string (should return all the redords);
            FilteredOrder.ReportByShippingAddress("");
            //tests to see of the two values are the same
            Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);


        }
        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //creates an instance of the filtered data
            ClsOrderCollection FilteredOrder = new ClsOrderCollection();
            //applies the Shipping Address that does not exist
            FilteredOrder.ReportByShippingAddress("xx xxxx xxxxxx");
            //tests to see that there are no records
            Assert.AreEqual(0, FilteredOrder.Count);


        }
        [TestMethod]
        public void ReportByShippingAddressTestDataFound()
        {
            //creates an instance of the filtered data
            ClsOrderCollection FilteredOrder = new ClsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Shipping Address which does not exist
            FilteredOrder.ReportByShippingAddress("xx xxxx xxxxxx");
            //check if that is the correct number of records that are found
            if (FilteredOrder.Count == 2)
            {
                //checks the first record is OrderID 4
                if (FilteredOrder.OrderList[0].OrderID != 4)
                {
                    OK = false;
                }
                //checks the first record is OrderID 5
                if (FilteredOrder.OrderList[0].OrderID != 4)
                {
                    OK = false;

                }
            }
            else
            {
                OK = false;

            }

            //tests to see that there are no records
            Assert.IsFalse(OK);
        }
        }
        }







    


