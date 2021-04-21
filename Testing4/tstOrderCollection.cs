using System;
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
        string OrderID = "1";
        string CustomerID = "45879632";
        string ShippingAddress = "64 potter Lane ";
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
            Int32 SomeCount = 5;
            AllOrder.Count = SomeCount;
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClsOrderCollection AllOrder = new ClsOrderCollection();
            //Test data to assign to property
            List<ClsOrder> TestList = new List<ClsOrder>();
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
            ClsOrderCollection AllOrder = new ClsOrderCollection();
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




        }
    }






    


