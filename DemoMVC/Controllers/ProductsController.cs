using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ProductsController : Controller
    {
        public String Get(int id)
        {
            return $"Product with ID {id}";
        }

        public String Create([FromQuery]int id, [FromQuery]string name, [FromForm] Product product)
        {
            return $"Product with ID {id} :: Name{name}\n{product.Id} :: {product.Name}";
        }
    }
}
