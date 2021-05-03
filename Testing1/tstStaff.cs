

using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        //Good test data
        //create some test data to pass the test
        string Name = "Test Name";
        string JobRole = "Test Job Role";
        string Email = "Test Email";
        string DateStarted = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOkay()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void StaffExistsPropertyeOkay()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.StaffExists = TestData;
            Assert.AreEqual(AStaff.StaffExists, TestData);
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
            Int32 StaffId = 1;
            //Invoke the method
            Found = AStaff.Find(StaffId);
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
            Int32 StaffId = 7;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Check the staff Id
            if (AStaff.StaffId != 7)
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
            Int32 StaffId = 6;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Check the staff Id
            if (AStaff.DateStarted != Convert.ToDateTime("25/02/2021"))
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
            Int32 StaffId = 6;
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
            Int32 StaffId = 6;
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
            Int32 StaffId = 6;
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
        public void TestStaffExistsFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 7;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check if it StaffExists
            if (AStaff.StaffExists != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOkay()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see if the results are correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            //create a string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Name = "";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be okay
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be okay
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be okay
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(500, 'a');//this should also be okay
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateStartedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-50);
            //convert the date from date to a string
            string DateStarted = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateStartedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-10).AddDays(-1);
            //convert the date variable to a string variable
            string DateStarted = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateStartedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddYears(-10);
            //convert the date variable to a string variable
            string DateStarted = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateStartedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(-11);
            //convert the date variable to a string variable
            string DateStarted = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateStartedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateStarted = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateStartedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store error message
            String Error = "";
            //Add detail to string
            string DateStarted = "This is not the date";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //Test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string JobRole = "";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobRole = "a";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void JobRoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobRole = "aa";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobRole = "";
            JobRole = JobRole.PadRight(49, 's');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobRole = "";
            JobRole = JobRole.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string JobRole = "";
            JobRole = JobRole.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JobRoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string JobRole = "";
            JobRole = JobRole.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            Email = Email.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(Name, JobRole, Email, DateStarted);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }

}
