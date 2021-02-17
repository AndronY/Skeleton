using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);


        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void OrderShippedPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.OrderShipped = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderShipped, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void ShippingAddressPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            String TestData = "54 Queensville";
            //assign the data to the property
            AnOrder.ShippingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingAddress, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //create some test data to assign to the property
            String TestData = "Dispatched";
            //assign the data to the property
            AnOrder.OrderStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);




        }
    }
}


