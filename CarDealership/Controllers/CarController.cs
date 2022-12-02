using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dealership.Models;

namespace CarDealership.Controllers
{
    public class CarController : Controller
    {
        [HttpGet("/caritems")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/caritems/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/caritems")]
        public ActionResult Create(string description)
        {
            Item myItem = new Item(description);
            return RedirectToAction("Index");
        }

    }
}