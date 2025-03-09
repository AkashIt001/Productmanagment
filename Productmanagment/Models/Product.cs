namespace Productmanagment.Models
{
    public class Product : Customer
    {

        public int OrderId { get; set; }

        public DateTime OrderDateTime { get; set; }
        public string OrderDetails { get; set; }
        public string OrderStatus { get; set; }
        public decimal Mouse { get; set; }
        public decimal Pen { get; set; }
        public decimal TV { get; set; }
        public decimal Book { get; set; }
        public decimal Mobile { get; set; }


        public int MouseQuantity { get; set; }
        public int PenQuantity { get; set; }
        public int TVQuantity { get; set; }
        public int BookQuantity { get; set; }
        public int MobileQuantity { get; set; }



        public float TTlPrice { get; set; }
        public double DiscountedPrice { get; set; }
        public decimal NetPrice { get; set; }

       
    }
}
