using CoffeeShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        List<ProductViewModel> _products;

        public ProductController()
        {
            _products = new List<ProductViewModel>();
            ProductViewModel productOne = new ProductViewModel()
            {
                Id = 1,
                Name = "Blueberry Muffin",
                Category = "Food",
                Description = "Freshly baked muffin with blueberries and sugar topping.",
                Price = 1.50
            };
            ProductViewModel productTwo = new ProductViewModel()
            {
                Id = 2,
                Name = "Latte",
                Price = 4.50
            };
            ProductViewModel productThree = new ProductViewModel()
            {
                Id = 3,
                Name = "Bagel",
                Price = 2.50
            };
            ProductViewModel productFour = new ProductViewModel()
            {
                Id = 4,
                Name = "Espresso Shot",
                Price = 1.25
            };
            ProductViewModel productFive = new ProductViewModel()
            {
                Id = 5,
                Name = "Hot Coffee",
                Price = 2.75
            };
            ProductViewModel productSix = new ProductViewModel()
            {
                Id = 6,
                Name = "Iced Coffee",
                Price = 2.75
            };
            _products.Add(productOne);
            _products.Add(productTwo);
            _products.Add(productThree);
            _products.Add(productFour);
            _products.Add(productFive);
            _products.Add(productSix);
        }


        // GET: ProductListController
        public ActionResult Index()
        {
            return View(_products);
        }
        
        // GET: ProductListController/Details/5
        public ActionResult Details(int id)
        {
            ProductViewModel product = _products.FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        // GET: ProductListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductListController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductListController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductListController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
