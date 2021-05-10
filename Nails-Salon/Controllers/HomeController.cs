using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nails_Salon.Models;
using Nails_Salon.Models.Context;
using Nails_Salon.Models.ViewModels;

namespace Nails_Salon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext db;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            db = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult ServicesAndPrices()
        {
            return View();
        }

        public IActionResult ClientsCard()
        {
            return View();
        }

        public IActionResult Social()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Products()
        {
            var products = db.Products.ToList();
            
            return View(products);
            // return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Products(int prodCount, string address, int productId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var productName = db.Products.FirstOrDefault(w => w.Id == productId).Name;
            var purchase = new Purchase
            {
                Address = address,
                Qy = prodCount,
                ProductId = productId,
                PurchaseDate = DateTime.UtcNow,
                UserId = Guid.Parse(userId),
                ProductName = productName
            };
            db.Purchases.Add(purchase);
            db.SaveChanges();
            
            return RedirectToAction("ClientsCard");
        }

        [Authorize]
        [HttpGet]
        public IActionResult PurchasesList()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var purchasesList = db.Purchases.Where(w => w.UserId == Guid.Parse(userId)).ToList();
            
            TempData["Products"] = db.Products.ToList();
            return View(purchasesList);
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeletePurchase(string prodId)
        {
            db.Purchases.Remove(db.Purchases.FirstOrDefault(w => w.Id == Convert.ToInt32(prodId))!);
            db.SaveChanges();
            
            return RedirectToAction("PurchasesList");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}