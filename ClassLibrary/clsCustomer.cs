using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public bool Above18 { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
