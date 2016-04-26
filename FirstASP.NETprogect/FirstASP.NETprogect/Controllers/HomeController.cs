using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstASP.NETprogect.Models;

namespace FirstASP.NETprogect.Controllers
{

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 10 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
            {
                // Нужно отправить данные нового гостя no электронной почте 
                // организатору вечеринки.
                return View("Thanks", guest);
            }
            else
                // Обнаружена ошибка проверки достоверности
                return View();

        }
    }
}
