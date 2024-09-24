using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webkobejp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult ShopDetail()
        {
            return View();
        }
        public ActionResult cart()
        {
            return View();
        }
        public ActionResult chackout()
        {
            return View();

        }
        public ActionResult testimonial()
        {
            return View();

        }
        public ActionResult Error()
        {
            return View();

        }
        public ActionResult Contact()
        {
            return View();
        }
      
    }
}