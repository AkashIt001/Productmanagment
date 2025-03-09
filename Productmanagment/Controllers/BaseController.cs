using Microsoft.AspNetCore.Mvc;
using Productmanagment.Models;

namespace Productmanagment.Controllers
{
    public class BaseController : Controller
    {
        public virtual IActionResult AddProduct(Product product)
        {
            return Content("Base method for adding product");
        }
        public virtual IActionResult EditProduct(int id, Product updatedProduct)
        {
            return Content("Base method for editing product");
        }
        public virtual IActionResult DeleteProduct(int id)
        {
            return Content("Base method for deleting product");
        }
    }
}
