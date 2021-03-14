using MG_LAB2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_LAB2.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository productRepository;

        public IActionResult Index()
        {
            return View();
        }
    }
}
