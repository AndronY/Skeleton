using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOkay()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOkay()
        {
            //Create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Exists = true;
            TestItem.Name = "Test Name";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Test Job Role";
            TestItem.Email = "Test Email";
            TestItem.StaffId = 7;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }


        [TestMethod]
        public void ThisStaffPropertyOkay()
        {
            //Create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties to test the object
            TestStaff.Exists = true;
            TestStaff.Name = "Test Name";
            TestStaff.DateStarted = DateTime.Now.Date;
            TestStaff.JobRole = "Test Job Role";
            TestStaff.Email = "Test Email";
            TestStaff.StaffId = 7;
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaff;
            //Test to see if the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOkay()
        {
            //Create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the class
            //create an item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Exists = true;
            TestItem.Name = "Another Name";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Another Test Job Role";
            TestItem.Email = "AnotherEmail@work.com";
            TestItem.StaffId = 8;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }


        }
}
