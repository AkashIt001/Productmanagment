using System.Diagnostics;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Productmanagment.Models;

namespace Productmanagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private object msd;

        public int TTlPrice { get; private set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private double CalculateDiscountPrice(double ttlPrice, double discountPercentage)
        {
            double discountAmount = (ttlPrice * discountPercentage) / 100;
            double discountedPrice = ttlPrice - discountAmount;

            return discountedPrice;
        }

        public IActionResult Index(float v)
        {

            List<Product> msd = new List<Product>();

            msd.Add(new Product()
            {
                CustomerId = 1,
                Name = "Kamal",
                Address ="Dhaka",
                PhoneNumber = "01796854485",
                OrderId = 1512,
                Mouse = 500,
                Pen = 50,
                TV =5000,
                Book = 500,
                Mobile = 8000,
                MouseQuantity = 2,   
                PenQuantity = 3,
                TVQuantity = 1,
                BookQuantity = 5,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now,
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            } );
            msd.Add(new Product()
            {
                CustomerId = 2,
                Name = "Rana",
                Address = "Chittagong",
                PhoneNumber = "0176584554",
                OrderId = 2141,
                Mouse = 700,
                Pen = 45,
                TV = 12000,
                Book = 1200,
                Mobile = 9000,
                MouseQuantity = 2,   
                PenQuantity = 3,
                TVQuantity = 1,
                BookQuantity = 5,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now,
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            }
            );
            msd.Add(new Product()
            {
                CustomerId = 3,
                Name = "Hamid",
                Address = "Rangpur",
                PhoneNumber = "017234567890",
                OrderId = 3215,
                Mouse = 485,
                Pen = 124,
                TV = 22000,
                Book = 956,
                Mobile = 15585,
                MouseQuantity = 2,
                PenQuantity = 3,
                TVQuantity = 1,
                BookQuantity = 5,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now,
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            });
            msd.Add(new Product()
            {
                CustomerId = 10,
                Name = "Hamid",
                Address = "Rangpur",
                PhoneNumber = "017234567890",
                OrderId = 3215,
                Mouse = 485,
                Pen = 124,
                TV = 22000,
                Book = 956,
                Mobile = 15585,
                MouseQuantity = 2,
                PenQuantity = 3,
                TVQuantity = 1,
                BookQuantity = 5,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now,
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            });
            msd.Add(new Product()
            {
                CustomerId = 4,
                Name = "Sara",
                Address = "Dhaka",
                PhoneNumber = "018234567890",
                OrderId = 3216,
                Mouse = 450,
                Pen = 150,
                TV = 25000,
                Book = 800,
                Mobile = 15000,
                MouseQuantity = 1,
                PenQuantity = 2,
                TVQuantity = 2,
                BookQuantity = 3,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now.AddMinutes(-30),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Shipped"
            });
            msd.Add(new Product()
            {
                CustomerId = 5,
                Name = "Ali",
                Address = "Chittagong",
                PhoneNumber = "017334567890",
                OrderId = 3217,
                Mouse = 500,
                Pen = 120,
                TV = 30000,
                Book = 900,
                Mobile = 16000,
                MouseQuantity = 3,
                PenQuantity = 4,
                TVQuantity = 1,
                BookQuantity = 2,
                MobileQuantity = 2,
                OrderDateTime = DateTime.Now.AddHours(-1),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Delivered"
            });
            msd.Add(new Product()
            {
                CustomerId = 6,
                Name = "Ravi",
                Address = "Sylhet",
                PhoneNumber = "016234567890",
                OrderId = 3218,
                Mouse = 480,
                Pen = 130,
                TV = 21000,
                Book = 950,
                Mobile = 15800,
                MouseQuantity = 2,
                PenQuantity = 5,
                TVQuantity = 1,
                BookQuantity = 3,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now.AddDays(-1),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            });
            msd.Add(new Product()
            {
                CustomerId = 7,
                Name = "Nina",
                Address = "Barisal",
                PhoneNumber = "01774567890",
                OrderId = 3219,
                Mouse = 495,
                Pen = 140,
                TV = 23000,
                Book = 980,
                Mobile = 16500,
                MouseQuantity = 4,
                PenQuantity = 3,
                TVQuantity = 2,
                BookQuantity = 2,
                MobileQuantity = 1,
                OrderDateTime = DateTime.Now.AddDays(-2),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Shipped"
            });
            msd.Add(new Product()
            {
                CustomerId = 8,
                Name = "John",
                Address = "Mymensingh",
                PhoneNumber = "01844567890",
                OrderId = 3220,
                Mouse = 510,
                Pen = 110,
                TV = 24000,
                Book = 910,
                Mobile = 17000,
                MouseQuantity = 1,
                PenQuantity = 4,
                TVQuantity = 3,
                BookQuantity = 5,
                MobileQuantity = 2,
                OrderDateTime = DateTime.Now.AddDays(-3),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Delivered"
            });
            msd.Add(new Product()
            {
                CustomerId = 9,
                Name = "Kamal",
                Address = "Rajshahi",
                PhoneNumber = "0175567890",
                OrderId = 3221,
                Mouse = 460,
                Pen = 160,
                TV = 22000,
                Book = 920,
                Mobile = 15050,
                MouseQuantity = 3,
                PenQuantity = 6,
                TVQuantity = 1,
                BookQuantity = 4,
                MobileQuantity = 2,
                OrderDateTime = DateTime.Now.AddDays(-4),
                OrderDetails = "Mouse, Pen, TV, Book, Mobile",
                OrderStatus = "Pending"
            });
            foreach (var Product in msd)
            {

                Product.TTlPrice = (float)(Product.Mouse * Product.MouseQuantity
                                      + Product.Pen * Product.PenQuantity
                                      + Product.TV * Product.TVQuantity
                                      + Product.Book * Product.BookQuantity
                                      + Product.Mobile * Product.MobileQuantity);

                double discountPercentage = 5;
                Product.DiscountedPrice = CalculateDiscountPrice(Product.TTlPrice, discountPercentage);
                float s1 = (float)(Product.TTlPrice - Product.DiscountedPrice);
                Product.NetPrice = (decimal)s1;
            }
            msd = msd.OrderByDescending(s => s.TTlPrice).ToList();

            ////Remove Methode 
            //msd.RemoveAll (s => s.TTlPrice == 1);
            //msd.RemoveAt(dst.Count - 1);
            //msd.RemoveAt((int)dst.Count - 1);
            ////Update Methode 
            //var updatedst = Product.Find(static msd => msd.Name == "Lima");


            //Delete Method

            //Add/Insert Method 

            //String method

            //Method Overloading 
            //Method Overriting  Apply Another Contoller

            //Array


            return View(msd);
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
