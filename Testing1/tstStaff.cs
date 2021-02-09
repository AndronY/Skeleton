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
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
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
            AStaff.IdNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.IdNumber, TestData);
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
    }

}


