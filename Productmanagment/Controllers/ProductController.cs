using Microsoft.AspNetCore.Mvc;
using Productmanagment.Models;

namespace Productmanagment.Controllers
{
    public class ProductController : BaseController
    {
        private List<Product> msd = new List<Product>();
        public override IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                msd.Add(product);  
                return RedirectToAction("Index");  
            }

            return View("Index", msd);  
        }
        public override IActionResult EditProduct(int id, Product updatedProduct)
        {
            var product = msd.FirstOrDefault(p => p.OrderId == id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Address = updatedProduct.Address;
                product.PhoneNumber = updatedProduct.PhoneNumber;
                product.OrderDetails = updatedProduct.OrderDetails;
                product.OrderStatus = updatedProduct.OrderStatus;
                product.Mouse = updatedProduct.Mouse;
                product.Pen = updatedProduct.Pen;
                product.TV = updatedProduct.TV;
                product.Book = updatedProduct.Book;
                product.Mobile = updatedProduct.Mobile;
                product.MouseQuantity = updatedProduct.MouseQuantity;
                product.PenQuantity = updatedProduct.PenQuantity;
                product.TVQuantity = updatedProduct.TVQuantity;
                product.BookQuantity = updatedProduct.BookQuantity;
                product.MobileQuantity = updatedProduct.MobileQuantity;
                product.OrderDateTime = updatedProduct.OrderDateTime;

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        // Override the DeleteProduct 
        public override IActionResult DeleteProduct(int id)
        {
            var product = msd.FirstOrDefault(p => p.OrderId == id);
            if (product != null)
            {
                // Remove the product from the list
                msd.Remove(product);  
                return RedirectToAction("Index"); 
            }

            return NotFound();
        }

        
        public IActionResult Index()
        {
            return View(msd);  
        }
    }

}
