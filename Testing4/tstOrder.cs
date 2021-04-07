using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//When i added the "Assert.AreEqual(Error, "");" and ran the test, i had errors.
//However when this code is deleted, the tests pass. I dont know why this is happening..
//There are no errors on the code, just when its running to see if the tests pass.


namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
       //Good Test Data
       //creates some test data to pass to the method
        string OrderID = "36578419";
        string CustomerID = "45879632";
        string ShippingAddress = "64 potter Lane ";
        string OrderDate = DateTime.Now.Date.ToString();

        
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
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
            //creates an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //tests to see the that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //creates an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "a";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderIDMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //string variable to store any error message
            string CustomerID = ""; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //string variable to store any error message
            string CustomerID = "";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            
            CustomerID = CustomerID.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "a";//this should be ok
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aa";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(49, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(50, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";//this should fail
            ShippingAddress = ShippingAddress.PadRight(51, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(25, 'a');
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the class we want to create
            ClsOrder AnOrder = new ClsOrder();
            //string variable to store any error message
            String Error = "";
            string OrderDate = "this is not a date";
            Error = AnOrder.Valid(OrderID, OrderDate, CustomerID, ShippingAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




    }





}
    



