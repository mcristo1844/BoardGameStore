﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BoardGameStore.Models;

namespace BoardGameStore.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products;

        public ProductController()
        {
            _products = new List<Product>();
            _products.Add(new Product
            {
                ID = 1,
                Name = "Agricola",
                Description = "Eurostyle farm building game",
                Price = 49.99m,
                Category = "Worker Placement"
            });
            _products.Add(new Product
            {
                ID = 2,
                Name = "Mysterium",
                Description = "Interpretive card image clue giving game",
                Price = 39.99m,
                Category = "Party"
            });
        }
        public IActionResult Index()
        {
            return View(_products);
        }
    }
}