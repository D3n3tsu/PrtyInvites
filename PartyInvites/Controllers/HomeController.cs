using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponce guestResponce)
        {
            if (ModelState.IsValid) { 
            //Todo: Email response to the party organizers
            return View("Thanks", guestResponce);
            }
            else
            {
                //there is validation error
                return View();
            }
        }
    }
}