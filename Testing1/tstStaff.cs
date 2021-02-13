using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOkay()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void ExistsPropertyeOkay()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Exists = TestData;
            Assert.AreEqual(AStaff.Exists, TestData);
        }
        [TestMethod]
        public void DateStartedPropertyOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateStarted = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateStarted, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }


        [TestMethod]
        public void NamePropertyOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Full name";
            //assign the data to the property
            AStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }
        
        [TestMethod]
        public void JobRolePropertyOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "A job role";
            //assign the data to the property
            AStaff.JobRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.JobRole, TestData);
        }

        [TestMethod]
        public void EmailPropertyOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "someonesemail@work.com";
            //assign the data to the property
            AStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void FindMethodOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean value to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 IdNumber = 1;
            //Invoke the method
            Found = AStaff.Find(IdNumber);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffNotFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean value to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is okay(Assume it is)
            Boolean Okay = true;
            //Create some test data to use with the method
            Int32 StaffId = 21;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Check the staff Id
            if (AStaff.StaffId != 21)
            {
                Okay = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Okay);

        }
        [TestMethod]
        public void TestDateStartedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean value to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is okay(Assume it is)
            Boolean Okay = true;
            //Create some test data to use with the method
            Int32 StaffId = 21;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Check the staff Id
            if (AStaff.DateStarted != Convert.ToDateTime("16/09/2015"))
            {
                Okay = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Okay);

        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the name
            if (AStaff.Name != "Test Name")
            {
                Okay = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Okay);
        }

        [TestMethod]
        public void TestJobRoleFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the job role
            if (AStaff.JobRole != "Test Job Role")
            {
                Okay = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Okay);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Okay = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the email
            if (AStaff.Email != "Test Email")
            {
                Okay = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Okay);
        }

        [TestMethod]
        public void TestExistsFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check if it exists
            if (AStaff.Exists != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}


