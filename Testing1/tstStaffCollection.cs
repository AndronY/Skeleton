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
            //test to see if it StaffExists
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
            TestItem.StaffExists = true;
            TestItem.Name = "Test Name";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Test Job Role";
            TestItem.Email = "Test Email";
            TestItem.StaffId = 6;
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
            TestStaff.StaffExists = true;
            TestStaff.Name = "Test Name";
            TestStaff.DateStarted = DateTime.Now.Date;
            TestStaff.JobRole = "Test Job Role";
            TestStaff.Email = "Test Email";
            TestStaff.StaffId = 6;
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
            TestItem.StaffExists = true;
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
        [TestMethod]
        public void AddMethodOkay()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item for the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffExists = true;
            TestItem.StaffId = 8;
            TestItem.Name = "Bob Builder";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Sales Assistant";
            TestItem.Email = "bobbuilder@work.co.uk";
            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //sets the primary key to the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if the values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        
        }
        [TestMethod]
        public void UpdateMethodOkay()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffExists = true;
            TestItem.StaffId = 14;
            TestItem.Name = "Test Staff";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Sales Assistant";
            TestItem.Email = "teststaff@work.co.uk";
            //set thisStaff to test the data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //sets the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test data
            TestItem.StaffExists = false;
            TestItem.StaffId = 16;
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Another Job Role";
            TestItem.Email = "anothertestemail@work.co.uk";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see thisStaff matches the data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOkay()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffExists = true;
            TestItem.StaffId = 19;
            TestItem.Name = "Bob Builder";
            TestItem.DateStarted = DateTime.Now.Date;
            TestItem.JobRole = "Sales Assistant";
            TestItem.Email = "bobbuilder@work.co.uk";
            //set ThisSTaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key to the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByNameMethodOkay()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByName("");
            //test to see if the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a name that doesnt exist
            FilteredStaff.ReportByName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean Okay = true;
            //apply a  post code that doesn't exist
            FilteredStaff.ReportByName("Filter Test");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2) 
            {
                //check that the first record is ID 12
                if (FilteredStaff.StaffList[0].StaffId != 12)
                {
                    Okay = false;
                }
                //check the second record is ID 13
                if (FilteredStaff.StaffList[1].StaffId != 13)
                {
                    Okay = false;
                }
            } 
            else 
            {
                Okay = false;
            }
            //test to see that there are no records
            Assert.IsTrue(Okay);
        }


        }
}
