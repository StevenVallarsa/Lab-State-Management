using Lab_State_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_State_Management.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login(User u)
        {
            if(u.UserName == null || u.UserName =="")
            {
                Session["Error"] = "A User Name must be entered. Please try again.";
                return RedirectToAction("Index");
            }
            else
            {
                Session["Error"] = "";
                Session["User"] = u;
            }
            return View();
        }
    }
}