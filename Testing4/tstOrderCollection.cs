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
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "Test street";
            TestItem.OrderStatus = "Dispatched";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.OrderShipped = true;
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
            TestOrder.CustomerID = 1;
            TestOrder.ShippingAddress = "Test street";
            TestOrder.OrderStatus = "Dispatched";
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.OrderShipped = true;
            //Assign data to the property
            AllOrder.ThisOrder = TestOrder;
            //Test to see that the two are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

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
            TestItem.CustomerID = 1;
            TestItem.ShippingAddress = "Test street";
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
    }
}

