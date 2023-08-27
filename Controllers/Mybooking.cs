using Microsoft.AspNetCore.Mvc;
using StarSecurityServices.Models;

namespace StarSecurityServices.Controllers
{
    public class Mybooking : Controller
    {
        MyContext myContext;


        public Mybooking(MyContext mycn)
        {
            myContext = mycn;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {

           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Booking u)
        {

            myContext.bookings.Add(u);
            myContext.SaveChanges();
            ViewBag.message = "Data Inserted";

            return View();
        }

    }
}
