using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name = "xx", int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + ID);
        }
    }
}