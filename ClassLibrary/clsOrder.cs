namespace ClassLibrary
{
    public class ClsOrder
    {
        public bool Active { get; set; }
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public bool OrderShipped { get; set; }
        public int CustomerID { get; set; }
        public string ShippingAddress { get; set; }
        public string OrderStatus { get; set; }


    }
}