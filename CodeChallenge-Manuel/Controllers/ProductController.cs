using CodeChallenge_Manuel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge_Manuel.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> Products { get; set; }

        //private productService {get; set;}
        
        //public ProductController(serviceProduct service)
        //{
        //    productService = serviceProduct;
        //}

        // TODO: Create a constructor and inject the service

        // GET: ProductsController - Get All Products
        public ActionResult Index()
        {
            if (Products.Count == 0) return NotFound();

            return Ok(new JsonResult(Products));
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            Product product = Products[id];

            if (product == null) return NotFound();

            return Ok(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create(Product product)
        {
            if (product != null)
            {
                Products.Add(product);
            }
            
            return Ok(product);
        }


        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            Products.RemoveAt(id);
            return Ok();
        }
    }
}
