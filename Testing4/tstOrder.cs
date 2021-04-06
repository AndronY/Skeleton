using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
       
        
        string OrderID = "36578419";
        string CustomerID = "45879632";
        string ShippingAddress = "64 potter Lane ";
        string OrderDate = DateTime.Now.Date.ToString();

        
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

            [TestMethod]
        public void FindMethodOkay()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //Boolean value to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 OrderID = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestOrderIDNotFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //Boolean value to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is okay(Assume it is)
            Boolean Okay = true;
            //Create some test data to use with the method
            Int32 OrderID = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the Order ID
            if (AnOrder.OrderID != 21)
            {
                Okay = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Okay);

        }
        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //Boolean value to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is okay(Assume it is)
            Boolean Okay = true;
            //Create some test data to use with the method
            Int32 OrderID = 21;
            //Invoke the method
            Found = AnOrder.Find(OrderID);
            //Check the Order Date
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                Okay = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Okay);

        }

        [TestMethod]
        public void TestOrderShippedFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check if it exists
            if (AnOrder.OrderShipped != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Customer ID
            if (AnOrder.CustomerID != 21)
            {
                Okay = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Okay);
        }

        [TestMethod]
        public void TestShippingAddressFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Shipping Address
            if (AnOrder.ShippingAddress != "Test Shipping Address")
            {
                Okay = false;
            }
            
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Status
            if (AnOrder.OrderStatus != "Test Order Status")
            {
                Okay = false;
            }
        }
        
            
            [TestMethod]
        public void ValidMethodOK()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(49);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(50);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(51);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(500);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderID = "";
            OrderID = OrderID.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIDMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(49);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(50);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(51);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ShippingAddressMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(51);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500);
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateRegistered = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            ClsOrder AnOrder = new ClsOrder();
            String Error = "";
            string OrderDate = "this is not a date";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            Assert.AreNotEqual(Error, "");
        }




    }





}
    



