using Microsoft.AspNetCore.Mvc;
using StandaloneLessons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandaloneLessons.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository _repository;

        public ProductsController(IRepository repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {
            //return View(new Repository().Products);
            
            return View(_repository.Products);

        }

        public IActionResult Create()
        {
            _repository.AddProduct(new Product { Name = "Apples", Price = 1.50M });

            return RedirectToAction("Index");
        }
    }
}
